namespace AUTOFELIZ
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
            this.arbol = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.barra = new System.Windows.Forms.StatusStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // arbol
            // 
            this.arbol.Location = new System.Drawing.Point(26, 29);
            this.arbol.Name = "arbol";
            this.arbol.Size = new System.Drawing.Size(445, 449);
            this.arbol.TabIndex = 0;
            this.arbol.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.arbol_NodeMouseClick);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(497, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRECIO REPUESTO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.Black;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(694, 29);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(179, 31);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // barra
            // 
            this.barra.Location = new System.Drawing.Point(0, 504);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(904, 22);
            this.barra.TabIndex = 4;
            this.barra.Text = "statusStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(497, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(376, 397);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 526);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arbol);
            this.Name = "Form1";
            this.Text = "AUTO FELIZ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView arbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.StatusStrip barra;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

