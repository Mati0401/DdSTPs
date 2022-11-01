namespace Devoluciones_E_commerce
{
    partial class FormTicket
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
            this.txtIdReclamo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaDeApertura = new System.Windows.Forms.TextBox();
            this.txtFechaDeCierre = new System.Windows.Forms.TextBox();
            this.txtEstadoDelTicket = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFechaDeUltimaActualizacion = new System.Windows.Forms.TextBox();
            this.btnActualizarEstado = new System.Windows.Forms.Button();
            this.txtDescripcionDelCierre = new System.Windows.Forms.TextBox();
            this.lblDescripcionDelCierre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIdReclamo
            // 
            this.txtIdReclamo.Location = new System.Drawing.Point(124, 77);
            this.txtIdReclamo.Name = "txtIdReclamo";
            this.txtIdReclamo.ReadOnly = true;
            this.txtIdReclamo.Size = new System.Drawing.Size(123, 23);
            this.txtIdReclamo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Reclamo";
            // 
            // txtFechaDeApertura
            // 
            this.txtFechaDeApertura.Location = new System.Drawing.Point(124, 123);
            this.txtFechaDeApertura.Name = "txtFechaDeApertura";
            this.txtFechaDeApertura.ReadOnly = true;
            this.txtFechaDeApertura.Size = new System.Drawing.Size(123, 23);
            this.txtFechaDeApertura.TabIndex = 2;
            // 
            // txtFechaDeCierre
            // 
            this.txtFechaDeCierre.Location = new System.Drawing.Point(124, 168);
            this.txtFechaDeCierre.Name = "txtFechaDeCierre";
            this.txtFechaDeCierre.ReadOnly = true;
            this.txtFechaDeCierre.Size = new System.Drawing.Size(123, 23);
            this.txtFechaDeCierre.TabIndex = 3;
            // 
            // txtEstadoDelTicket
            // 
            this.txtEstadoDelTicket.Location = new System.Drawing.Point(124, 212);
            this.txtEstadoDelTicket.Name = "txtEstadoDelTicket";
            this.txtEstadoDelTicket.ReadOnly = true;
            this.txtEstadoDelTicket.Size = new System.Drawing.Size(123, 23);
            this.txtEstadoDelTicket.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha de apertura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de cierre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(146, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "TICKET DE DEVOLUCIÓN";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(232, 265);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Última actualización";
            // 
            // txtFechaDeUltimaActualizacion
            // 
            this.txtFechaDeUltimaActualizacion.Location = new System.Drawing.Point(382, 212);
            this.txtFechaDeUltimaActualizacion.Name = "txtFechaDeUltimaActualizacion";
            this.txtFechaDeUltimaActualizacion.ReadOnly = true;
            this.txtFechaDeUltimaActualizacion.Size = new System.Drawing.Size(123, 23);
            this.txtFechaDeUltimaActualizacion.TabIndex = 11;
            // 
            // btnActualizarEstado
            // 
            this.btnActualizarEstado.Location = new System.Drawing.Point(382, 241);
            this.btnActualizarEstado.Name = "btnActualizarEstado";
            this.btnActualizarEstado.Size = new System.Drawing.Size(123, 23);
            this.btnActualizarEstado.TabIndex = 12;
            this.btnActualizarEstado.Text = "Actualizar Estado";
            this.btnActualizarEstado.UseVisualStyleBackColor = true;
            this.btnActualizarEstado.Click += new System.EventHandler(this.btnActualizarEstado_Click);
            // 
            // txtDescripcionDelCierre
            // 
            this.txtDescripcionDelCierre.Location = new System.Drawing.Point(305, 101);
            this.txtDescripcionDelCierre.Multiline = true;
            this.txtDescripcionDelCierre.Name = "txtDescripcionDelCierre";
            this.txtDescripcionDelCierre.ReadOnly = true;
            this.txtDescripcionDelCierre.Size = new System.Drawing.Size(200, 90);
            this.txtDescripcionDelCierre.TabIndex = 13;
            // 
            // lblDescripcionDelCierre
            // 
            this.lblDescripcionDelCierre.AutoSize = true;
            this.lblDescripcionDelCierre.Location = new System.Drawing.Point(305, 80);
            this.lblDescripcionDelCierre.Name = "lblDescripcionDelCierre";
            this.lblDescripcionDelCierre.Size = new System.Drawing.Size(120, 15);
            this.lblDescripcionDelCierre.TabIndex = 14;
            this.lblDescripcionDelCierre.Text = "Descripción del cierre";
            // 
            // FormTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(550, 300);
            this.Controls.Add(this.lblDescripcionDelCierre);
            this.Controls.Add(this.txtDescripcionDelCierre);
            this.Controls.Add(this.btnActualizarEstado);
            this.Controls.Add(this.txtFechaDeUltimaActualizacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEstadoDelTicket);
            this.Controls.Add(this.txtFechaDeCierre);
            this.Controls.Add(this.txtFechaDeApertura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdReclamo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.FormTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCerrar;
        private Label label6;
        private Button btnActualizarEstado;
        private Label lblDescripcionDelCierre;
        public TextBox txtEstadoDelTicket;
        public TextBox txtFechaDeApertura;
        public TextBox txtIdReclamo;
        public TextBox txtFechaDeCierre;
        public TextBox txtFechaDeUltimaActualizacion;
        public TextBox txtDescripcionDelCierre;
    }
}