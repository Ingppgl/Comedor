namespace Comedor
{
    partial class MProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CCodigo = new MiLibreria.ErrortxtBox();
            this.CDescrip = new MiLibreria.ErrortxtBox();
            this.CPrec = new MiLibreria.ErrortxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.Provider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio";
            // 
            // CCodigo
            // 
            this.CCodigo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCodigo.Location = new System.Drawing.Point(137, 106);
            this.CCodigo.Name = "CCodigo";
            this.CCodigo.Numeros = true;
            this.CCodigo.Size = new System.Drawing.Size(189, 22);
            this.CCodigo.TabIndex = 11;
            this.CCodigo.Vacio = true;
            this.CCodigo.TextChanged += new System.EventHandler(this.CCodigo_TextChanged);
            // 
            // CDescrip
            // 
            this.CDescrip.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDescrip.Location = new System.Drawing.Point(137, 153);
            this.CDescrip.Name = "CDescrip";
            this.CDescrip.Numeros = false;
            this.CDescrip.Size = new System.Drawing.Size(189, 22);
            this.CDescrip.TabIndex = 12;
            this.CDescrip.Vacio = true;
            this.CDescrip.TextChanged += new System.EventHandler(this.CDescrip_TextChanged);
            // 
            // CPrec
            // 
            this.CPrec.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPrec.Location = new System.Drawing.Point(137, 199);
            this.CPrec.Name = "CPrec";
            this.CPrec.Numeros = false;
            this.CPrec.Size = new System.Drawing.Size(189, 22);
            this.CPrec.TabIndex = 13;
            this.CPrec.Vacio = true;
            this.CPrec.TextChanged += new System.EventHandler(this.CPrec_TextChanged);
            // 
            // MProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 423);
            this.Controls.Add(this.CPrec);
            this.Controls.Add(this.CDescrip);
            this.Controls.Add(this.CCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MProducto";
            this.Controls.SetChildIndex(this.Salir, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.CCodigo, 0);
            this.Controls.SetChildIndex(this.CDescrip, 0);
            this.Controls.SetChildIndex(this.CPrec, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Provider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MiLibreria.ErrortxtBox CCodigo;
        private MiLibreria.ErrortxtBox CDescrip;
        private MiLibreria.ErrortxtBox CPrec;
    }
}