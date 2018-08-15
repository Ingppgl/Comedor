namespace Comedor
{
    partial class MCliente
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CCodigoC = new MiLibreria.ErrortxtBox();
            this.CNombreC = new MiLibreria.ErrortxtBox();
            this.CApell = new MiLibreria.ErrortxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.Provider)).BeginInit();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(379, 376);
            this.Salir.Size = new System.Drawing.Size(91, 28);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código";
            // 
            // CCodigoC
            // 
            this.CCodigoC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCodigoC.Location = new System.Drawing.Point(134, 104);
            this.CCodigoC.Name = "CCodigoC";
            this.CCodigoC.Numeros = true;
            this.CCodigoC.Size = new System.Drawing.Size(189, 22);
            this.CCodigoC.TabIndex = 17;
            this.CCodigoC.Vacio = true;
            this.CCodigoC.TextChanged += new System.EventHandler(this.CCodigoC_TextChanged);
            // 
            // CNombreC
            // 
            this.CNombreC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNombreC.Location = new System.Drawing.Point(134, 152);
            this.CNombreC.Name = "CNombreC";
            this.CNombreC.Numeros = false;
            this.CNombreC.Size = new System.Drawing.Size(189, 22);
            this.CNombreC.TabIndex = 18;
            this.CNombreC.Vacio = true;
            this.CNombreC.TextChanged += new System.EventHandler(this.CNombreC_TextChanged);
            // 
            // CApell
            // 
            this.CApell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CApell.Location = new System.Drawing.Point(134, 198);
            this.CApell.Name = "CApell";
            this.CApell.Numeros = false;
            this.CApell.Size = new System.Drawing.Size(189, 22);
            this.CApell.TabIndex = 19;
            this.CApell.Vacio = true;
            this.CApell.TextChanged += new System.EventHandler(this.CApell_TextChanged);
            // 
            // MCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 416);
            this.Controls.Add(this.CApell);
            this.Controls.Add(this.CNombreC);
            this.Controls.Add(this.CCodigoC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCliente";
            this.Controls.SetChildIndex(this.Salir, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.CCodigoC, 0);
            this.Controls.SetChildIndex(this.CNombreC, 0);
            this.Controls.SetChildIndex(this.CApell, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Provider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MiLibreria.ErrortxtBox CCodigoC;
        private MiLibreria.ErrortxtBox CNombreC;
        private MiLibreria.ErrortxtBox CApell;
    }
}