

namespace Devoluciones_E_commerce

{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new InicioUsuario());
        }

    }
}