namespace MundoAFora
{
    public partial class MainPage : ContentPage
    {
        public MainPage() {InitializeComponent(); }

      

        async void OnPerfilClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("PerfilUsuario");
        }
        async void OnEntrarClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Login");
        }
        async void OnCadastrarClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("CadastroUsuario");
        }


    }
}


