using MundoAFora.DTO;
using MundoAFora.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAFora
{

    partial class Login
    {
        private readonly AuthService _authService;
        public Login()
        {
            InitializeComponent();
        }

        public Login(AuthService authService)
        {
            InitializeComponent();
            _authService = authService;
        }
            async void OnCadastrarClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("CadastroUsuario");

        }
            async void OnLoginClicked(object sender, EventArgs e)
            {
              DisplayLoding();

                string email = Email.Text;
                string senha = Senha.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                await DisplayAlert("Erro", "Por favor, preencha todos os campos.", "OK");
                DisplayLoding();
                return;
            }

            RequestLoginDTO dadosUsuario = new RequestLoginDTO
            {
                Email = email,
                Senha = senha
            };

            ResponseLoginDTO respostaLogin = await _authService.LoginAsync(dadosUsuario);

            if (respostaLogin.Sucesso)
            {
                DisplayLoding();
                await Shell.Current.GoToAsync("CadastroUsuario");
                return;
            }
                await DisplayAlert("Erro de login", "Verifique seus dados novamente", "Tentar Novamente");
                DisplayLoding();
        }
        public void DisplayLoding()
        {
            btnEntrar.IsVisible = !btnEntrar.IsVisible;
            loading.IsVisible = !loading.IsVisible;
        }


    }
    

}
