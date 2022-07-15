

namespace PobreTITO
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        public static CargarReclamo cr = new CargarReclamo();
        public static Menu menu = new Menu();
        public static GestorPobreTITO gpt = new GestorPobreTITO();
        public static IniciarSesion ini = new IniciarSesion();
        public static Registro reg = new Registro();
        public static ValidarPersona vp = new ValidarPersona();
        

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            ApplicationConfiguration.Initialize();
            Application.Run(menu);
        }
    }
}