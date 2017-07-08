namespace traduccion1
{
    partial class Form1
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
            this.lblpruba = new System.Windows.Forms.Label();
            this.btnespanol = new System.Windows.Forms.Button();
            this.btningles = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblpruba
            // 
            this.lblpruba.AutoSize = true;
            this.lblpruba.Location = new System.Drawing.Point(113, 76);
            this.lblpruba.Name = "lblpruba";
            this.lblpruba.Size = new System.Drawing.Size(41, 13);
            this.lblpruba.TabIndex = 0;
            this.lblpruba.Text = "Prueba";
            // 
            // btnespanol
            // 
            this.btnespanol.Location = new System.Drawing.Point(13, 212);
            this.btnespanol.Name = "btnespanol";
            this.btnespanol.Size = new System.Drawing.Size(75, 23);
            this.btnespanol.TabIndex = 1;
            this.btnespanol.Text = "Español";
            this.btnespanol.UseVisualStyleBackColor = true;
            this.btnespanol.Click += new System.EventHandler(this.btnespanol_Click);
            // 
            // btningles
            // 
            this.btningles.Location = new System.Drawing.Point(107, 212);
            this.btningles.Name = "btningles";
            this.btningles.Size = new System.Drawing.Size(75, 23);
            this.btningles.TabIndex = 2;
            this.btningles.Text = "English";
            this.btningles.UseVisualStyleBackColor = true;
            this.btningles.Click += new System.EventHandler(this.btningles_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(197, 212);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 3;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btningles);
            this.Controls.Add(this.btnespanol);
            this.Controls.Add(this.lblpruba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpruba;
        private System.Windows.Forms.Button btnespanol;
        private System.Windows.Forms.Button btningles;
        private System.Windows.Forms.Button btncerrar;
    }
}

