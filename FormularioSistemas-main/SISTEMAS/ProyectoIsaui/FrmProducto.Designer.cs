namespace ProyectoIsaui
{
    partial class FrmProducto
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
            this.GbProducto = new System.Windows.Forms.GroupBox();
            this.lblstock = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodBarra = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.GbProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbProducto
            // 
            this.GbProducto.BackColor = System.Drawing.Color.NavajoWhite;
            this.GbProducto.Controls.Add(this.lblstock);
            this.GbProducto.Controls.Add(this.txtstock);
            this.GbProducto.Controls.Add(this.label1);
            this.GbProducto.Controls.Add(this.txtCodBarra);
            this.GbProducto.Controls.Add(this.btncancelar);
            this.GbProducto.Controls.Add(this.btnguardar);
            this.GbProducto.Controls.Add(this.txtprecio);
            this.GbProducto.Controls.Add(this.lblprecio);
            this.GbProducto.Controls.Add(this.txtNombre);
            this.GbProducto.Controls.Add(this.LblNombre);
            this.GbProducto.Controls.Add(this.txtCodProducto);
            this.GbProducto.Location = new System.Drawing.Point(45, 33);
            this.GbProducto.Margin = new System.Windows.Forms.Padding(4);
            this.GbProducto.Name = "GbProducto";
            this.GbProducto.Padding = new System.Windows.Forms.Padding(4);
            this.GbProducto.Size = new System.Drawing.Size(574, 503);
            this.GbProducto.TabIndex = 0;
            this.GbProducto.TabStop = false;
            this.GbProducto.Text = "Nuevo Producto";
            this.GbProducto.Enter += new System.EventHandler(this.GbProducto_Enter);
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.Location = new System.Drawing.Point(88, 306);
            this.lblstock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(44, 17);
            this.lblstock.TabIndex = 9;
            this.lblstock.Text = "Stock";
            this.lblstock.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(91, 327);
            this.txtstock.Margin = new System.Windows.Forms.Padding(4);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(393, 25);
            this.txtstock.TabIndex = 8;
            this.txtstock.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(414, 108);
            this.txtCodProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(70, 25);
            this.txtCodProducto.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo de Barra";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCodBarra
            // 
            this.txtCodBarra.Location = new System.Drawing.Point(91, 252);
            this.txtCodBarra.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodBarra.Name = "txtCodBarra";
            this.txtCodBarra.Size = new System.Drawing.Size(393, 25);
            this.txtCodBarra.TabIndex = 4;
            this.txtCodBarra.TextChanged += new System.EventHandler(this.txtCodBarra_TextChanged);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btncancelar.Location = new System.Drawing.Point(316, 400);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(115, 49);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnguardar.Location = new System.Drawing.Point(135, 400);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(117, 49);
            this.btnguardar.TabIndex = 4;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(91, 181);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(393, 25);
            this.txtprecio.TabIndex = 3;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(88, 160);
            this.lblprecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(48, 17);
            this.lblprecio.TabIndex = 2;
            this.lblprecio.Text = "Precio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(91, 108);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(393, 25);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(88, 87);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(61, 17);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(683, 561);
            this.Controls.Add(this.GbProducto);
            this.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmProducto";
            this.Text = "Formulario de Producto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            this.GbProducto.ResumeLayout(false);
            this.GbProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbProducto;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodBarra;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label lblstock;
        private System.Windows.Forms.TextBox txtstock;
    }
}