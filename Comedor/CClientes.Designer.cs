namespace Comedor
{
    partial class CClientes
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
            this.SuspendLayout();
            // 
            // BSelecionar
            // 
            this.BSelecionar.Location = new System.Drawing.Point(12, 382);
            this.BSelecionar.Size = new System.Drawing.Size(100, 26);
            // 
            // BImprimir
            // 
            this.BImprimir.Location = new System.Drawing.Point(128, 382);
            this.BImprimir.Size = new System.Drawing.Size(100, 26);
            // 
            // BBuscar
            // 
            this.BBuscar.Location = new System.Drawing.Point(473, 12);
            this.BBuscar.TabIndex = 0;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(41, 16);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 12);
            this.textBox1.Size = new System.Drawing.Size(359, 22);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(481, 380);
            this.Salir.TabIndex = 3;
            // 
            // CClientes
            // 
            this.AcceptButton = this.BBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 423);
            this.Name = "CClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Clientes";
            this.Load += new System.EventHandler(this.CClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}