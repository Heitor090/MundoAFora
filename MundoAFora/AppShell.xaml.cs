namespace MundoAFora
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //Registering the route for the Login page
            Routing.RegisterRoute(nameof(Login), typeof(Login));
        }
    }
}
