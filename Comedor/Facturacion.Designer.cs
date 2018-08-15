namespace Comedor
{
    partial class Facturacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Cliente = new MiLibreria.ErrortxtBox();
            this.Atiende = new MiLibreria.ErrortxtBox();
            this.BCodigo = new MiLibreria.ErrortxtBox();
            this.TPrecio = new MiLibreria.ErrortxtBox();
            this.TCantidad = new MiLibreria.ErrortxtBox();
            this.TDescripcion = new MiLibreria.ErrortxtBox();
            this.SCodigo = new MiLibreria.ErrortxtBox();
            this.BAgregar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.BCliente = new System.Windows.Forms.Button();
            this.BProducto = new System.Windows.Forms.Button();
            this.BNuevo = new System.Windows.Forms.Button();
            this.BFacturar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TTotal = new MiLibreria.ErrortxtBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(721, 418);
            // 
            // Cliente
            // 
            this.Cliente.Location = new System.Drawing.Point(128, 120);
            this.Cliente.Name = "Cliente";
            this.Cliente.Numeros = false;
            this.Cliente.Size = new System.Drawing.Size(202, 20);
            this.Cliente.TabIndex = 1;
            this.Cliente.Vacio = true;
            // 
            // Atiende
            // 
            this.Atiende.Enabled = false;
            this.Atiende.Location = new System.Drawing.Point(128, 68);
            this.Atiende.Name = "Atiende";
            this.Atiende.Numeros = false;
            this.Atiende.Size = new System.Drawing.Size(100, 20);
            this.Atiende.TabIndex = 2;
            this.Atiende.Vacio = false;
            // 
            // BCodigo
            // 
            this.BCodigo.Location = new System.Drawing.Point(128, 94);
            this.BCodigo.Name = "BCodigo";
            this.BCodigo.Numeros = true;
            this.BCodigo.Size = new System.Drawing.Size(100, 20);
            this.BCodigo.TabIndex = 3;
            this.BCodigo.Vacio = true;
            // 
            // TPrecio
            // 
            this.TPrecio.Location = new System.Drawing.Point(444, 169);
            this.TPrecio.Name = "TPrecio";
            this.TPrecio.Numeros = false;
            this.TPrecio.Size = new System.Drawing.Size(100, 20);
            this.TPrecio.TabIndex = 4;
            this.TPrecio.Vacio = true;
            // 
            // TCantidad
            // 
            this.TCantidad.Location = new System.Drawing.Point(336, 169);
            this.TCantidad.Name = "TCantidad";
            this.TCantidad.Numeros = false;
            this.TCantidad.Size = new System.Drawing.Size(100, 20);
            this.TCantidad.TabIndex = 5;
            this.TCantidad.Vacio = true;
            // 
            // TDescripcion
            // 
            this.TDescripcion.Location = new System.Drawing.Point(128, 169);
            this.TDescripcion.Name = "TDescripcion";
            this.TDescripcion.Numeros = false;
            this.TDescripcion.Size = new System.Drawing.Size(202, 20);
            this.TDescripcion.TabIndex = 6;
            this.TDescripcion.Vacio = true;
            // 
            // SCodigo
            // 
            this.SCodigo.Location = new System.Drawing.Point(22, 169);
            this.SCodigo.Name = "SCodigo";
            this.SCodigo.Numeros = false;
            this.SCodigo.Size = new System.Drawing.Size(100, 20);
            this.SCodigo.TabIndex = 7;
            this.SCodigo.Vacio = true;
            // 
            // BAgregar
            // 
            this.BAgregar.Location = new System.Drawing.Point(689, 141);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(107, 23);
            this.BAgregar.TabIndex = 8;
            this.BAgregar.Text = "Agregar";
            this.BAgregar.UseVisualStyleBackColor = true;
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(689, 178);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(107, 23);
            this.Eliminar.TabIndex = 9;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // BCliente
            // 
            this.BCliente.Location = new System.Drawing.Point(689, 215);
            this.BCliente.Name = "BCliente";
            this.BCliente.Size = new System.Drawing.Size(107, 23);
            this.BCliente.TabIndex = 10;
            this.BCliente.Text = "Cliente";
            this.BCliente.UseVisualStyleBackColor = true;
            // 
            // BProducto
            // 
            this.BProducto.Location = new System.Drawing.Point(689, 252);
            this.BProducto.Name = "BProducto";
            this.BProducto.Size = new System.Drawing.Size(107, 23);
            this.BProducto.TabIndex = 11;
            this.BProducto.Text = "Producto";
            this.BProducto.UseVisualStyleBackColor = true;
            // 
            // BNuevo
            // 
            this.BNuevo.Location = new System.Drawing.Point(689, 289);
            this.BNuevo.Name = "BNuevo";
            this.BNuevo.Size = new System.Drawing.Size(107, 23);
            this.BNuevo.TabIndex = 12;
            this.BNuevo.Text = "Nuevo";
            this.BNuevo.UseVisualStyleBackColor = true;
            // 
            // BFacturar
            // 
            this.BFacturar.Location = new System.Drawing.Point(689, 326);
            this.BFacturar.Name = "BFacturar";
            this.BFacturar.Size = new System.Drawing.Size(107, 23);
            this.BFacturar.TabIndex = 13;
            this.BFacturar.Text = "Facturar";
            this.BFacturar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Le Atendió";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Precio";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Descripción";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Código";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(359, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cantidad";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Código Articulo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Precio,
            this.Cantidad,
            this.Importe});
            this.dataGridView1.Location = new System.Drawing.Point(12, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(671, 266);
            this.dataGridView1.TabIndex = 21;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(234, 94);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 23);
            this.button7.TabIndex = 22;
            this.button7.Text = "Buscar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(522, 464);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Total";
            // 
            // TTotal
            // 
            this.TTotal.Enabled = false;
            this.TTotal.Location = new System.Drawing.Point(583, 464);
            this.TTotal.Name = "TTotal";
            this.TTotal.Numeros = false;
            this.TTotal.Size = new System.Drawing.Size(100, 20);
            this.TTotal.TabIndex = 24;
            this.TTotal.Vacio = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Comedor.Properties.Resources.Facturar;
            this.pictureBox1.Location = new System.Drawing.Point(463, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Codigo
            // 
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle1;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Codigo.Width = 60;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descripcion.Width = 375;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 90;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 60;
            // 
            // Importe
            // 
            this.Importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 488);
            this.Controls.Add(this.TTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BFacturar);
            this.Controls.Add(this.BNuevo);
            this.Controls.Add(this.BProducto);
            this.Controls.Add(this.BCliente);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.BAgregar);
            this.Controls.Add(this.SCodigo);
            this.Controls.Add(this.TDescripcion);
            this.Controls.Add(this.TCantidad);
            this.Controls.Add(this.TPrecio);
            this.Controls.Add(this.BCodigo);
            this.Controls.Add(this.Atiende);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Facturacion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.Salir, 0);
            this.Controls.SetChildIndex(this.Cliente, 0);
            this.Controls.SetChildIndex(this.Atiende, 0);
            this.Controls.SetChildIndex(this.BCodigo, 0);
            this.Controls.SetChildIndex(this.TPrecio, 0);
            this.Controls.SetChildIndex(this.TCantidad, 0);
            this.Controls.SetChildIndex(this.TDescripcion, 0);
            this.Controls.SetChildIndex(this.SCodigo, 0);
            this.Controls.SetChildIndex(this.BAgregar, 0);
            this.Controls.SetChildIndex(this.Eliminar, 0);
            this.Controls.SetChildIndex(this.BCliente, 0);
            this.Controls.SetChildIndex(this.BProducto, 0);
            this.Controls.SetChildIndex(this.BNuevo, 0);
            this.Controls.SetChildIndex(this.BFacturar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.button7, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.TTotal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MiLibreria.ErrortxtBox Cliente;
        private MiLibreria.ErrortxtBox Atiende;
        private MiLibreria.ErrortxtBox BCodigo;
        private MiLibreria.ErrortxtBox TPrecio;
        private MiLibreria.ErrortxtBox TCantidad;
        private MiLibreria.ErrortxtBox TDescripcion;
        private MiLibreria.ErrortxtBox SCodigo;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button BCliente;
        private System.Windows.Forms.Button BProducto;
        private System.Windows.Forms.Button BNuevo;
        private System.Windows.Forms.Button BFacturar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label8;
        private MiLibreria.ErrortxtBox TTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    }
}