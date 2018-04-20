namespace Vista2 {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.contenedorDatos1 = new Componentes.ContenedorDatos();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.contenedorDatos2 = new Componentes.ContenedorDatos();
            this.contenedorDatos3 = new Componentes.ContenedorDatos();
            this.SuspendLayout();
            // 
            // contenedorDatos1
            // 
            this.contenedorDatos1.Location = new System.Drawing.Point(13, 13);
            this.contenedorDatos1.Name = "contenedorDatos1";
            this.contenedorDatos1.Size = new System.Drawing.Size(430, 529);
            this.contenedorDatos1.TabIndex = 0;
            // 
            // contenedorDatos2
            // 
            this.contenedorDatos2.Location = new System.Drawing.Point(449, 13);
            this.contenedorDatos2.Name = "contenedorDatos2";
            this.contenedorDatos2.Size = new System.Drawing.Size(430, 529);
            this.contenedorDatos2.TabIndex = 1;
            // 
            // contenedorDatos3
            // 
            this.contenedorDatos3.Location = new System.Drawing.Point(885, 13);
            this.contenedorDatos3.Name = "contenedorDatos3";
            this.contenedorDatos3.Size = new System.Drawing.Size(430, 529);
            this.contenedorDatos3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1327, 554);
            this.Controls.Add(this.contenedorDatos3);
            this.Controls.Add(this.contenedorDatos2);
            this.Controls.Add(this.contenedorDatos1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Vista";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.ContenedorDatos contenedorDatos1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Componentes.ContenedorDatos contenedorDatos2;
        private Componentes.ContenedorDatos contenedorDatos3;
    }
}

