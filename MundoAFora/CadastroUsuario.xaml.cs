using MundoAFora.Services;
using MundoAFora.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAFora
{
    partial class CadastroUsuario
    {
        private readonly AuthService _authService;
        public CadastroUsuario()
        { 
            InitializeComponent();
        }
        async void OnCadastrarClicked(object sender, EventArgs e)
        {
            string nome = Nome.Text;
            string cpf = CPF.Text;
            DateTime dataNascimento = DataNascimento.Date;
            string email = Email.Text;
            string senha = Senha.Text;
            string  confirmasenha = ConfirmaSenha.Text;

            if (confirmasenha != senha)
            {
               await DisplayAlert("Atenção", "As senhas não conferem", "OK");
            }

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) || 
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha) || 
                string.IsNullOrEmpty(confirmasenha))
            {
                await DisplayAlert("Erro", "Por favor, preencha todos os campos.", "OK");
                return;
            }
            RequestCadastroDTO dadosUsuario = new RequestCadastroDTO
            {
                Email = email,
                Senha = senha,
                CPF = cpf,
                DataNascimento = dataNascimento,
                NomeCompleto = nome

            };

            ResponseCadastroDTO respostaCadastro = await _authService.CadastrarAsync(dadosUsuario);

            if (respostaCadastro.Sucesso)
            {
                await Shell.Current.GoToAsync("PerfilUsuario");
                return;
            }
            await DisplayAlert("Erro de login", "Verifique seus dados novamente", "Tentar Novamente");



            //await Shell.Current.GoToAsync("CadastarUsuario");
        }

    }

    }

