namespace WindowsFormsApp1
{
    partial class GAMEOPTIONS
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GAMEOPTIONS));
            this.BTNFORMULARIO = new System.Windows.Forms.Button();
            this.BTNLISTA = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNFORMULARIO
            // 
            this.BTNFORMULARIO.Location = new System.Drawing.Point(12, 12);
            this.BTNFORMULARIO.Name = "BTNFORMULARIO";
            this.BTNFORMULARIO.Size = new System.Drawing.Size(126, 41);
            this.BTNFORMULARIO.TabIndex = 0;
            this.BTNFORMULARIO.Text = "JUGAR CON EL FORMULARIO";
            this.BTNFORMULARIO.UseVisualStyleBackColor = true;
            this.BTNFORMULARIO.Click += new System.EventHandler(this.BTNFORMULARIO_Click);
            // 
            // BTNLISTA
            // 
            this.BTNLISTA.Location = new System.Drawing.Point(162, 12);
            this.BTNLISTA.Name = "BTNLISTA";
            this.BTNLISTA.Size = new System.Drawing.Size(126, 41);
            this.BTNLISTA.TabIndex = 1;
            this.BTNLISTA.Text = "JUGAR CON LA LISTA";
            this.BTNLISTA.UseVisualStyleBackColor = false;
            this.BTNLISTA.Click += new System.EventHandler(this.BTNLISTA_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(311, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 41);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "SALIR";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // GAMEOPTIONS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 70);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.BTNLISTA);
            this.Controls.Add(this.BTNFORMULARIO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GAMEOPTIONS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ELEGIR JUEGO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNFORMULARIO;
        private System.Windows.Forms.Button BTNLISTA;
        private System.Windows.Forms.Button btnExit;
    }
}

