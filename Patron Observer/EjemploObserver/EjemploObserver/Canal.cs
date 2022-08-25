using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploObserver
{
    public class Canal : ISujetoCanal
    {
        private List<IObserverUsuario> _usuarios;

        int _cantVideos;
        public Canal(string nombre, int cantVideos)
        {

            _usuarios = new List<IObserverUsuario>();
            Nombre = nombre;
            _cantVideos = cantVideos;
        }

        public string Nombre { get; set; }

        public int CantVideos
        {
            get
            {
                return _cantVideos;
            }
            set
            {
                _cantVideos = value;
                this.Notificar();
            }
        }

        public override string ToString()
        {
            return $"{Nombre} ({_cantVideos})";
        }


        public void Agregar(IObserverUsuario usuario)
        {
            if (!_usuarios.Contains(usuario))
            {
                _usuarios.Add(usuario);
            }
            else
            {
                throw new Exception($"Ya existe una suscripción para {((Usuario)usuario)}");
            }
        }

        public void Notificar()
        {
            foreach (var usuario in _usuarios)
            {
                usuario.Actualizar(this);
            }

            Form1 formulario = (Form1)Application.OpenForms[0];

            if (_usuarios.Count == 0)
            {
                formulario.Notificar($"No hay suscripciones");
            }

            formulario.Notificar($"--------------------------------------------------------------------------------------------------------------------");
        }

        public void Quitar(IObserverUsuario usuario)
        {
            if (_usuarios.Contains(usuario))
            {
                _usuarios.Remove(usuario);
            }
            else
            {
                throw new Exception($"No existe una suscripción para {((Usuario)usuario)}");
            }
        }
    }
}
