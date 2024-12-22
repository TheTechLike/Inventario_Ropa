using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Inventario_Base.Datos
{
    internal class DLogin
    {
        private static readonly HttpClient client = new HttpClient();
        private string conect = Conexion.conectionstring;

        private string encriptar(string password)
        {
            // Clave secreta para firmar el JWT. **¡Nunca la hardcodees en producción!**
            // Debe almacenarse en una variable de entorno o configuración segura.
            string secretKey = "150103TheLikeR@paInventarioBase5678!!ClaveKyyy";

            // Crea una clave simétrica a partir de la clave secreta
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));

            // Define las credenciales de firma utilizando el algoritmo HMAC SHA-256
            var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Crea dos descriptores de token, uno con expiración y otro sin ella
            var tokenDescriptorL = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("data", password) }),
                Expires = DateTime.UtcNow.AddMinutes(20), // Expira en 20 minutos
                SigningCredentials = signingCredentials
            };


            // Genera el token JWT según el valor de Login
            var tokenHandler = new JwtSecurityTokenHandler();
            var securityToken = tokenHandler.CreateToken( tokenDescriptorL);

            // Obtiene el JWT como una cadena
            var encryptedToken = tokenHandler.WriteToken(securityToken);

            // Imprime el token en la consola (solo para depuración)
            Console.WriteLine("Token Encriptado:");
            Console.WriteLine(encryptedToken);

            // Lee los claims del token (solo para demostración)
            var claims = tokenHandler.ReadJwtToken(encryptedToken).Claims;
            foreach (var claim in claims)
            {
                Console.WriteLine($"{claim.Type}: {claim.Value}");
            }

            return encryptedToken;
        }
        public async Task<string> GetLogin(MLogin parameters)
        {
            // Encriptar la contraseña antes de enviar
            parameters.Password = encriptar(parameters.Password);

            // Serializar los parámetros a JSON
            string jsonBody = JsonSerializer.Serialize(parameters);
            StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            // Enviar la solicitud POST
            HttpResponseMessage response = await client.PostAsync(conect + "Usuario/login", content);

            // Validar si la respuesta es exitosa
            if (response.IsSuccessStatusCode)
            {
                // Leer el contenido de la respuesta
                string responseContent = await response.Content.ReadAsStringAsync();

                // Deserializar la respuesta para obtener el campo "user"
                var responseObject = JsonSerializer.Deserialize<Dictionary<string, object>>(responseContent);
                if (responseObject != null && responseObject.ContainsKey("user"))
                {
                    // Devolver el valor del campo "user"
                    return responseObject["user"]?.ToString() ?? "0";
                }

                return "0";
            }
            return "0";
        }


    }
}
