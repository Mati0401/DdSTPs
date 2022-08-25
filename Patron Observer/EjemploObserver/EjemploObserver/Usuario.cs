using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploObserver
{
    public class Usuario : IObserverUsuario
    {
        public Usuario(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }


        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }

        public void Actualizar(Canal canal)
        {
            Form1 formulario = (Form1)Application.OpenForms[0];
            formulario.Notificar($"El usuario {this} recibió la notificación de que {canal} subió un nuevo video.");
        }
    }
}
