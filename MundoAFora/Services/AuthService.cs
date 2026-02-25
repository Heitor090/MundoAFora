using MundoAFora.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MundoAFora.Services
{
    public class AuthService
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://localhost:7177/api/auth"; 

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
            var response = await _httpClient.PostAsJsonAsync($"{BaseUrl}api/Usuarios/Cadastrar", dadosUsuario);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<ResponseCadastroDTO>();
                return new ResponseCadastroDTO
                {
                    Sucesso = true,
                    Mensagem = "Cadastro realizado com sucesso"
                };
            }
            return new ResponseCadastroDTO
            {
                Sucesso = false,
                Mensagem = "Cadastro falhou. Tente novamente"
            };
        }
    }
}
