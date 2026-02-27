using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAFora
{
   
        partial class Login
        {
            public Login()
            {
                InitializeComponent();
            }
        async void OnCadastrarClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("CadastroUsuario");

        }
      
    }
    

}
