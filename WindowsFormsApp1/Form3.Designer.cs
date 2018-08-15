namespace WindowsFormsApp1
{
    partial class GAMELISTA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GAMELISTA));
            this.btnTraslateAllFromOrigin = new System.Windows.Forms.Button();
            this.btnTraslateSelectToOrigin = new System.Windows.Forms.Button();
            this.btnTraslateSelectFromOrigin = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listViewOrigin = new System.Windows.Forms.ListView();
            this.listViewDestiny = new System.Windows.Forms.ListView();
            this.btnDeleteSelect = new System.Windows.Forms.Button();
            this.btnAddValue = new System.Windows.Forms.Button();
            this.txtAddValueToOrigin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTraslateAllFromOrigin
            // 
            this.btnTraslateAllFromOrigin.Location = new System.Drawing.Point(263, 58);
            this.btnTraslateAllFromOrigin.Name = "btnTraslateAllFromOrigin";
            this.btnTraslateAllFromOrigin.Size = new System.Drawing.Size(35, 23);
            this.btnTraslateAllFromOrigin.TabIndex = 0;
            this.btnTraslateAllFromOrigin.Text = ">>";
            this.btnTraslateAllFromOrigin.UseVisualStyleBackColor = true;
            this.btnTraslateAllFromOrigin.Click += new System.EventHandler(this.btnTraslateAllFromOrigin_Click);
            // 
            // btnTraslateSelectToOrigin
            // 
            this.btnTraslateSelectToOrigin.Location = new System.Drawing.Point(179, 58);
            this.btnTraslateSelectToOrigin.Name = "btnTraslateSelectToOrigin";
            this.btnTraslateSelectToOrigin.Size = new System.Drawing.Size(37, 23);
            this.btnTraslateSelectToOrigin.TabIndex = 1;
            this.btnTraslateSelectToOrigin.Text = "<";
            this.btnTraslateSelectToOrigin.UseVisualStyleBackColor = true;
            this.btnTraslateSelectToOrigin.Click += new System.EventHandler(this.btnTraslateSelectToOrigin_Click);
            // 
            // btnTraslateSelectFromOrigin
            // 
            this.btnTraslateSelectFromOrigin.Location = new System.Drawing.Point(222, 58);
            this.btnTraslateSelectFromOrigin.Name = "btnTraslateSelectFromOrigin";
            this.btnTraslateSelectFromOrigin.Size = new System.Drawing.Size(35, 23);
            this.btnTraslateSelectFromOrigin.TabIndex = 2;
            this.btnTraslateSelectFromOrigin.Text = ">";
            this.btnTraslateSelectFromOrigin.UseVisualStyleBackColor = true;
            this.btnTraslateSelectFromOrigin.Click += new System.EventHandler(this.btnTraslateSelectFromOrigin_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(373, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 32);
            this.button4.TabIndex = 3;
            this.button4.Text = "VOLVER";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listViewOrigin
            // 
            this.listViewOrigin.Location = new System.Drawing.Point(13, 13);
            this.listViewOrigin.Name = "listViewOrigin";
            this.listViewOrigin.Size = new System.Drawing.Size(160, 235);
            this.listViewOrigin.TabIndex = 4;
            this.listViewOrigin.UseCompatibleStateImageBehavior = false;
            // 
            // listViewDestiny
            // 
            this.listViewDestiny.Location = new System.Drawing.Point(304, 13);
            this.listViewDestiny.Name = "listViewDestiny";
            this.listViewDestiny.Size = new System.Drawing.Size(161, 235);
            this.listViewDestiny.TabIndex = 5;
            this.listViewDestiny.UseCompatibleStateImageBehavior = false;
            // 
            // btnDeleteSelect
            // 
            this.btnDeleteSelect.Location = new System.Drawing.Point(222, 87);
            this.btnDeleteSelect.Name = "btnDeleteSelect";
            this.btnDeleteSelect.Size = new System.Drawing.Size(35, 23);
            this.btnDeleteSelect.TabIndex = 6;
            this.btnDeleteSelect.Text = "...";
            this.btnDeleteSelect.UseVisualStyleBackColor = true;
            this.btnDeleteSelect.Click += new System.EventHandler(this.btnDeleteSelect_Click);
            // 
            // btnAddValue
            // 
            this.btnAddValue.Location = new System.Drawing.Point(13, 309);
            this.btnAddValue.Name = "btnAddValue";
            this.btnAddValue.Size = new System.Drawing.Size(92, 32);
            this.btnAddValue.TabIndex = 7;
            this.btnAddValue.Text = "AGREGAR";
            this.btnAddValue.UseVisualStyleBackColor = true;
            this.btnAddValue.Click += new System.EventHandler(this.btnAddValue_Click);
            // 
            // txtAddValueToOrigin
            // 
            this.txtAddValueToOrigin.Location = new System.Drawing.Point(13, 267);
            this.txtAddValueToOrigin.Name = "txtAddValueToOrigin";
            this.txtAddValueToOrigin.Size = new System.Drawing.Size(160, 20);
            this.txtAddValueToOrigin.TabIndex = 8;
            this.txtAddValueToOrigin.TextChanged += new System.EventHandler(this.txtAddValueToOrigin_TextChanged);
            this.txtAddValueToOrigin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddValueToOrigin_KeyPress);
            // 
            // GAMELISTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 353);
            this.Controls.Add(this.txtAddValueToOrigin);
            this.Controls.Add(this.btnAddValue);
            this.Controls.Add(this.btnDeleteSelect);
            this.Controls.Add(this.listViewDestiny);
            this.Controls.Add(this.listViewOrigin);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnTraslateSelectFromOrigin);
            this.Controls.Add(this.btnTraslateSelectToOrigin);
            this.Controls.Add(this.btnTraslateAllFromOrigin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GAMELISTA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTraslateAllFromOrigin;
        private System.Windows.Forms.Button btnTraslateSelectToOrigin;
        private System.Windows.Forms.Button btnTraslateSelectFromOrigin;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listViewOrigin;
        private System.Windows.Forms.ListView listViewDestiny;
        private System.Windows.Forms.Button btnDeleteSelect;
        private System.Windows.Forms.Button btnAddValue;
        private System.Windows.Forms.TextBox txtAddValueToOrigin;
    }
}