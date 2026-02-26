using MundoAFora.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MundoAFora.Services
{
    public class AuthService
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://localhost:7177/"; 

        public AuthService(HttpClient httpClient)
        {
            _httpClient =  new HttpClient();
        }

        public async Task<ResponseLoginDTO> LoginAsync(RequestLoginDTO dadosUsuario) 
        {
            var response = await _httpClient.PostAsJsonAsync($"{BaseUrl}api/Usuarios/Login", dadosUsuario);   

            if (response.IsSuccessStatusCode)
            {
                var result = await  response.Content.ReadFromJsonAsync<ResponseLoginDTO>();
                
                return new ResponseLoginDTO { 
                    Sucesso = true, 
                    Mensagem = " Login realizado com sucesso"
                };
            }

            return new ResponseLoginDTO { 
                Sucesso = false, 
                Mensagem = " Login falhou. Tente novamente"
            };



        }

        public async Task<ResponseCadastroDTO> CadastrarAsync(RequestCadastroDTO dadosUsuario)
        {
            var response = await _httpClient.PostAsJsonAsync(
                $"{BaseUrl}api/Usuarios/cadastrar",
                dadosUsuario
            );

            var content = await response.Content.ReadAsStringAsync();

            Debug.WriteLine($"Status: {response.StatusCode}");
            Debug.WriteLine($"Resposta da API: {content}");

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<ResponseCadastroDTO>();
                return result;
            }

            return new ResponseCadastroDTO
            {
                Erro = true,
                Mensagem = content // 👈 agora você vê o erro real
            };
        }
    }
}
