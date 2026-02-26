namespace MundoAFora
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //Registering the route for the Login page
            Routing.RegisterRoute(nameof(Login), typeof(Login));
            Routing.RegisterRoute(nameof(CadastroUsuario), typeof(CadastroUsuario));
            Routing.RegisterRoute(nameof(PerfilUsuario), typeof(PerfilUsuario));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        }
    }
}
