namespace ProIsa
{
    partial class FrmVendedor
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
            this.lvlLegajo = new System.Windows.Forms.Label();
            this.lvlDocumento = new System.Windows.Forms.Label();
            this.lvlApellido = new System.Windows.Forms.Label();
            this.lvlNombre = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxVendedor = new System.Windows.Forms.GroupBox();
            this.gbxVendedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvlLegajo
            // 
            this.lvlLegajo.AutoSize = true;
            this.lvlLegajo.Location = new System.Drawing.Point(26, 151);
            this.lvlLegajo.Name = "lvlLegajo";
            this.lvlLegajo.Size = new System.Drawing.Size(39, 13);
            this.lvlLegajo.TabIndex = 23;
            this.lvlLegajo.Text = "Legajo";
            // 
            // lvlDocumento
            // 
            this.lvlDocumento.AutoSize = true;
            this.lvlDocumento.Location = new System.Drawing.Point(26, 116);
            this.lvlDocumento.Name = "lvlDocumento";
            this.lvlDocumento.Size = new System.Drawing.Size(62, 13);
            this.lvlDocumento.TabIndex = 22;
            this.lvlDocumento.Text = "Documento";
            // 
            // lvlApellido
            // 
            this.lvlApellido.AutoSize = true;
            this.lvlApellido.Location = new System.Drawing.Point(26, 83);
            this.lvlApellido.Name = "lvlApellido";
            this.lvlApellido.Size = new System.Drawing.Size(54, 13);
            this.lvlApellido.TabIndex = 20;
            this.lvlApellido.Text = "Apellido/s";
            // 
            // lvlNombre
            // 
            this.lvlNombre.AutoSize = true;
            this.lvlNombre.Location = new System.Drawing.Point(26, 51);
            this.lvlNombre.Name = "lvlNombre";
            this.lvlNombre.Size = new System.Drawing.Size(44, 13);
            this.lvlNombre.TabIndex = 19;
            this.lvlNombre.Text = "Nombre";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(150, 151);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(171, 20);
            this.txtLegajo.TabIndex = 18;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(150, 116);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(171, 20);
            this.txtDocumento.TabIndex = 17;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(150, 80);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(171, 20);
            this.txtApellido.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(150, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(171, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.Location = new System.Drawing.Point(41, 223);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 41);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.Location = new System.Drawing.Point(185, 223);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 41);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbxVendedor
            // 
            this.gbxVendedor.Controls.Add(this.btnCancelar);
            this.gbxVendedor.Controls.Add(this.btnGuardar);
            this.gbxVendedor.Controls.Add(this.txtLegajo);
            this.gbxVendedor.Controls.Add(this.lvlLegajo);
            this.gbxVendedor.Controls.Add(this.lvlNombre);
            this.gbxVendedor.Controls.Add(this.lvlDocumento);
            this.gbxVendedor.Controls.Add(this.txtDocumento);
            this.gbxVendedor.Controls.Add(this.txtNombre);
            this.gbxVendedor.Controls.Add(this.lvlApellido);
            this.gbxVendedor.Controls.Add(this.txtApellido);
            this.gbxVendedor.Location = new System.Drawing.Point(48, 26);
            this.gbxVendedor.Name = "gbxVendedor";
            this.gbxVendedor.Size = new System.Drawing.Size(336, 309);
            this.gbxVendedor.TabIndex = 24;
            this.gbxVendedor.TabStop = false;
            this.gbxVendedor.Text = "Datos Vendedor";
            // 
            // FrmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(439, 373);
            this.Controls.Add(this.gbxVendedor);
            this.Name = "FrmVendedor";
            this.Text = "FrmVendedor";
            this.Load += new System.EventHandler(this.FrmVendedor_Load);
            this.gbxVendedor.ResumeLayout(false);
            this.gbxVendedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lvlLegajo;
        private System.Windows.Forms.Label lvlDocumento;
        private System.Windows.Forms.Label lvlApellido;
        private System.Windows.Forms.Label lvlNombre;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbxVendedor;
    }
}