namespace PobreTITO
{
    partial class CargarReclamo
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
            this.btnCargar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cboSubIncidente = new System.Windows.Forms.ComboBox();
            this.cboIncidente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(310, 376);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(121, 31);
            this.btnCargar.TabIndex = 18;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(272, 189);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(274, 151);
            this.txtDescripcion.TabIndex = 15;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(272, 138);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(274, 27);
            this.txtDireccion.TabIndex = 14;
            this.txtDireccion.Leave += new System.EventHandler(this.txtDireccion_Leave);
            // 
            // cboSubIncidente
            // 
            this.cboSubIncidente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubIncidente.FormattingEnabled = true;
            this.cboSubIncidente.Location = new System.Drawing.Point(272, 87);
            this.cboSubIncidente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSubIncidente.Name = "cboSubIncidente";
            this.cboSubIncidente.Size = new System.Drawing.Size(274, 28);
            this.cboSubIncidente.TabIndex = 13;
            // 
            // cboIncidente
            // 
            this.cboIncidente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIncidente.FormattingEnabled = true;
            this.cboIncidente.Location = new System.Drawing.Point(272, 38);
            this.cboIncidente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboIncidente.Name = "cboIncidente";
            this.cboIncidente.Size = new System.Drawing.Size(274, 28);
            this.cboIncidente.TabIndex = 12;
            this.cboIncidente.SelectedIndexChanged += new System.EventHandler(this.cboIncidente_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Subincidente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Incidente";
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // CargarReclamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.cboSubIncidente);
            this.Controls.Add(this.cboIncidente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CargarReclamo";
            this.Text = "CargarReclamo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CargarReclamo_FormClosed);
            this.Load += new System.EventHandler(this.CargarReclamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCargar;
        private Label label4;
        private Label label3;
        private TextBox txtDescripcion;
        private TextBox txtDireccion;
        private ComboBox cboSubIncidente;
        private ComboBox cboIncidente;
        private Label label2;
        private Label label1;
        private ErrorProvider errorProv;
    }
}