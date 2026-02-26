using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MundoAFora
{
    partial class PerfilUsuario
    {

        public PerfilUsuario()
        {
            InitializeComponent();
        }

        async void OnSalvarClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Login");
        }
        async void OnDescartarClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("CadastroUsuario");
        }
        async void OnSairClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///MainPage");
        }
    }
}