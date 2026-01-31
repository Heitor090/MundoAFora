using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAFora
{
    partial class CadastroUsuario
    {
        public CadastroUsuario()
        { 
            InitializeComponent();
        }
        async void OnCadastrarClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("PerfilUsuario");

        }

    }
}
