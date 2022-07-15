namespace PobreTITO
{
    partial class Registro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreYapellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtFechaDeNacimiento = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombreDeUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txtContraRepetida = new System.Windows.Forms.TextBox();
            this.ocultarContraseña = new System.Windows.Forms.PictureBox();
            this.verContraseña = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocultarContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre y Apellido";
            // 
            // txtNombreYapellido
            // 
            this.txtNombreYapellido.Location = new System.Drawing.Point(308, 73);
            this.txtNombreYapellido.Name = "txtNombreYapellido";
            this.txtNombreYapellido.Size = new System.Drawing.Size(175, 27);
            this.txtNombreYapellido.TabIndex = 1;
            this.txtNombreYapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreYapellido_KeyPress);
            this.txtNombreYapellido.Leave += new System.EventHandler(this.txtNombreYapellido_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha De Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre De Usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Contraseña";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(305, 28);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(178, 27);
            this.txtDni.TabIndex = 0;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            this.txtDni.Leave += new System.EventHandler(this.txtDni_Leave);
            // 
            // txtFechaDeNacimiento
            // 
            this.txtFechaDeNacimiento.Location = new System.Drawing.Point(308, 127);
            this.txtFechaDeNacimiento.Name = "txtFechaDeNacimiento";
            this.txtFechaDeNacimiento.Size = new System.Drawing.Size(175, 27);
            this.txtFechaDeNacimiento.TabIndex = 2;
            this.txtFechaDeNacimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFechaDeNacimiento_KeyPress);
            this.txtFechaDeNacimiento.Leave += new System.EventHandler(this.txtFechaDeNacimiento_Leave);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(308, 177);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(175, 27);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(308, 231);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(175, 27);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtNombreDeUsuario
            // 
            this.txtNombreDeUsuario.Location = new System.Drawing.Point(308, 286);
            this.txtNombreDeUsuario.Name = "txtNombreDeUsuario";
            this.txtNombreDeUsuario.Size = new System.Drawing.Size(175, 27);
            this.txtNombreDeUsuario.TabIndex = 5;
            this.txtNombreDeUsuario.Leave += new System.EventHandler(this.txtNombreDeUsuario_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(308, 335);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(175, 27);
            this.txtContraseña.TabIndex = 6;
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(250, 436);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(158, 55);
            this.btnRegistrarse.TabIndex = 14;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Repetir Contraseña";
            // 
            // txtContraRepetida
            // 
            this.txtContraRepetida.Location = new System.Drawing.Point(308, 386);
            this.txtContraRepetida.Name = "txtContraRepetida";
            this.txtContraRepetida.Size = new System.Drawing.Size(175, 27);
            this.txtContraRepetida.TabIndex = 7;
            this.txtContraRepetida.Leave += new System.EventHandler(this.txtContraRepetida_Leave);
            // 
            // ocultarContraseña
            // 
            this.ocultarContraseña.Image = ((System.Drawing.Image)(resources.GetObject("ocultarContraseña.Image")));
            this.ocultarContraseña.Location = new System.Drawing.Point(489, 335);
            this.ocultarContraseña.Name = "ocultarContraseña";
            this.ocultarContraseña.Size = new System.Drawing.Size(25, 27);
            this.ocultarContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ocultarContraseña.TabIndex = 18;
            this.ocultarContraseña.TabStop = false;
            this.ocultarContraseña.Click += new System.EventHandler(this.ocultarContraseña_Click);
            // 
            // verContraseña
            // 
            this.verContraseña.Image = ((System.Drawing.Image)(resources.GetObject("verContraseña.Image")));
            this.verContraseña.Location = new System.Drawing.Point(489, 335);
            this.verContraseña.Name = "verContraseña";
            this.verContraseña.Size = new System.Drawing.Size(27, 27);
            this.verContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.verContraseña.TabIndex = 19;
            this.verContraseña.TabStop = false;
            this.verContraseña.Click += new System.EventHandler(this.verContraseña_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 503);
            this.Controls.Add(this.verContraseña);
            this.Controls.Add(this.ocultarContraseña);
            this.Controls.Add(this.txtContraRepetida);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNombreDeUsuario);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtFechaDeNacimiento);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreYapellido);
            this.Controls.Add(this.label2);
            this.Name = "Registro";
            this.Text = "Registro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registro_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocultarContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private TextBox txtNombreYapellido;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtDni;
        private TextBox txtFechaDeNacimiento;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtNombreDeUsuario;
        private TextBox txtContraseña;
        private Button btnRegistrarse;
        private ErrorProvider errorProv;
        private TextBox txtContraRepetida;
        private Label label8;
        private PictureBox ocultarContraseña;
        private PictureBox verContraseña;
    }
}