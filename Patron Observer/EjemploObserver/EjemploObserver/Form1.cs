using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploObserver
{
    public partial class Form1 : Form
    {
        public void Notificar(string s)
        {
            this.listNotificaciones.Items.Add(s);
        }

        private List<ISujetoCanal> _canales;
        private List<IObserverUsuario> _usuarios;

        private ISujetoCanal _canal;
        private IObserverUsuario _usuario;


        public Form1()
        {
            InitializeComponent();

            _canales = new List<ISujetoCanal>();
            _usuarios = new List<IObserverUsuario>();
            simularDatos();
        }

        private void simularDatos()
        {
            _canales.Add(new Canal("Pablo Pioli",5));
            _canales.Add(new Canal("Bettatech", 113));
            _usuarios.Add(new Usuario("Juanse", "Pulidori"));
            _usuarios.Add(new Usuario("Tomás", "Eschoyez"));
            _usuarios.Add(new Usuario("Matías", "Rodriguez"));
            _usuarios.Add(new Usuario("Matías", "Morero"));
            _usuarios.Add(new Usuario("Guillermo", "Bellido"));

            mostrarCanales();
            mostrarUsuarios();
        }

        private void mostrarCanales()
        {
            this.listCanales.DataSource = null;
            this.listCanales.DataSource = _canales;
        }
        private void mostrarUsuarios()
        {
            this.listUsuarios.DataSource = null;
            this.listUsuarios.DataSource = _usuarios;
        }
        private void listCanales_SelectedIndexChanged(object sender, EventArgs e)
        {
            _canal = (ISujetoCanal)((ListBox)sender).SelectedItem;
        }

        private void listUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            _usuario = (IObserverUsuario)((ListBox)sender).SelectedItem;
        }

        private void btnSuscribir_Click_1(object sender, EventArgs e)
        {
            if (_canal != null && _usuario != null)
            {
                try
                {
                    _canal.Agregar(_usuario);
                    MessageBox.Show("Suscripción correcta");
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar canal y usuario");
            }
        }

        private void btnDesuscribir_Click_1(object sender, EventArgs e)
        {
            if (_canal != null && _usuario != null)
            {
                try
                {
                    _canal.Quitar(_usuario);
                    MessageBox.Show("Desuscripción correcta");
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar canal y usuario");
            }
        }
        private void listCanales_DoubleClick(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            ((Canal)_canal).CantVideos++;
            mostrarCanales();
        }
    }
}