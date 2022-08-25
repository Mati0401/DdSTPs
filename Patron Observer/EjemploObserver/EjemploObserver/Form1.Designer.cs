namespace EjemploObserver
{
    partial class Form1
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
            this.listCanales = new System.Windows.Forms.ListBox();
            this.listUsuarios = new System.Windows.Forms.ListBox();
            this.listNotificaciones = new System.Windows.Forms.ListBox();
            this.btnSuscribir = new System.Windows.Forms.Button();
            this.btnDesuscribir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listCanales
            // 
            this.listCanales.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listCanales.FormattingEnabled = true;
            this.listCanales.ItemHeight = 23;
            this.listCanales.Location = new System.Drawing.Point(12, 52);
            this.listCanales.Name = "listCanales";
            this.listCanales.Size = new System.Drawing.Size(295, 556);
            this.listCanales.TabIndex = 0;
            this.listCanales.SelectedIndexChanged += new System.EventHandler(this.listCanales_SelectedIndexChanged);
            this.listCanales.DoubleClick += new System.EventHandler(this.listCanales_DoubleClick);
            // 
            // listUsuarios
            // 
            this.listUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listUsuarios.FormattingEnabled = true;
            this.listUsuarios.ItemHeight = 23;
            this.listUsuarios.Location = new System.Drawing.Point(328, 52);
            this.listUsuarios.Name = "listUsuarios";
            this.listUsuarios.Size = new System.Drawing.Size(295, 556);
            this.listUsuarios.TabIndex = 1;
            this.listUsuarios.SelectedIndexChanged += new System.EventHandler(this.listUsuarios_SelectedIndexChanged);
            // 
            // listNotificaciones
            // 
            this.listNotificaciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listNotificaciones.FormattingEnabled = true;
            this.listNotificaciones.ItemHeight = 23;
            this.listNotificaciones.Location = new System.Drawing.Point(647, 52);
            this.listNotificaciones.Name = "listNotificaciones";
            this.listNotificaciones.Size = new System.Drawing.Size(712, 464);
            this.listNotificaciones.TabIndex = 2;
            // 
            // btnSuscribir
            // 
            this.btnSuscribir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuscribir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuscribir.Location = new System.Drawing.Point(1090, 544);
            this.btnSuscribir.Name = "btnSuscribir";
            this.btnSuscribir.Size = new System.Drawing.Size(154, 51);
            this.btnSuscribir.TabIndex = 3;
            this.btnSuscribir.Text = "Suscribir";
            this.btnSuscribir.UseVisualStyleBackColor = false;
            this.btnSuscribir.Click += new System.EventHandler(this.btnSuscribir_Click_1);
            // 
            // btnDesuscribir
            // 
            this.btnDesuscribir.BackColor = System.Drawing.Color.White;
            this.btnDesuscribir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDesuscribir.Location = new System.Drawing.Point(756, 544);
            this.btnDesuscribir.Name = "btnDesuscribir";
            this.btnDesuscribir.Size = new System.Drawing.Size(154, 51);
            this.btnDesuscribir.TabIndex = 4;
            this.btnDesuscribir.Text = "Desuscribir";
            this.btnDesuscribir.UseVisualStyleBackColor = false;
            this.btnDesuscribir.Click += new System.EventHandler(this.btnDesuscribir_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "CANALES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(328, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 43);
            this.label2.TabIndex = 6;
            this.label2.Text = "USUARIOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(647, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 43);
            this.label3.TabIndex = 7;
            this.label3.Text = "NOTIFICACIONES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1371, 634);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDesuscribir);
            this.Controls.Add(this.btnSuscribir);
            this.Controls.Add(this.listNotificaciones);
            this.Controls.Add(this.listUsuarios);
            this.Controls.Add(this.listCanales);
            this.Name = "Form1";
            this.Text = "Observer Ejemplo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listCanales;
        private ListBox listUsuarios;
        private ListBox listNotificaciones;
        private Button btnSuscribir;
        private Button btnDesuscribir;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}