namespace PobreTITO
{
    partial class IniciarSesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreDeUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnIngresar = new System.Windows.Forms.Button();
            this.ocultarContraseña = new System.Windows.Forms.PictureBox();
            this.verContraseña = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocultarContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre De Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // txtNombreDeUsuario
            // 
            this.txtNombreDeUsuario.Location = new System.Drawing.Point(261, 124);
            this.txtNombreDeUsuario.Name = "txtNombreDeUsuario";
            this.txtNombreDeUsuario.Size = new System.Drawing.Size(187, 27);
            this.txtNombreDeUsuario.TabIndex = 2;
            this.txtNombreDeUsuario.Leave += new System.EventHandler(this.txtNombreDeUsuario_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(261, 175);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(187, 27);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(217, 264);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(138, 49);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // ocultarContraseña
            // 
            this.ocultarContraseña.Image = ((System.Drawing.Image)(resources.GetObject("ocultarContraseña.Image")));
            this.ocultarContraseña.Location = new System.Drawing.Point(472, 175);
            this.ocultarContraseña.Name = "ocultarContraseña";
            this.ocultarContraseña.Size = new System.Drawing.Size(25, 27);
            this.ocultarContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ocultarContraseña.TabIndex = 19;
            this.ocultarContraseña.TabStop = false;
            this.ocultarContraseña.Click += new System.EventHandler(this.ocultarContraseña_Click);
            // 
            // verContraseña
            // 
            this.verContraseña.Image = ((System.Drawing.Image)(resources.GetObject("verContraseña.Image")));
            this.verContraseña.Location = new System.Drawing.Point(472, 175);
            this.verContraseña.Name = "verContraseña";
            this.verContraseña.Size = new System.Drawing.Size(27, 27);
            this.verContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.verContraseña.TabIndex = 20;
            this.verContraseña.TabStop = false;
            this.verContraseña.Click += new System.EventHandler(this.verContraseña_Click);
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 360);
            this.Controls.Add(this.verContraseña);
            this.Controls.Add(this.ocultarContraseña);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNombreDeUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IniciarSesion";
            this.Text = "IniciarSesion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IniciarSesion_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocultarContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombreDeUsuario;
        private TextBox txtContraseña;
        private ErrorProvider errorProv;
        private Button btnIngresar;
        private PictureBox ocultarContraseña;
        private PictureBox verContraseña;
    }
}