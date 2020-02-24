namespace EcuacionCuadratica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textEcuacion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.raiz1 = new System.Windows.Forms.Label();
            this.raiz2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(146, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 169);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(12, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese la Ecuacion cuadratica de la forma Ax2+Bx+C=R";
            // 
            // textEcuacion
            // 
            this.textEcuacion.Location = new System.Drawing.Point(360, 208);
            this.textEcuacion.Name = "textEcuacion";
            this.textEcuacion.Size = new System.Drawing.Size(227, 20);
            this.textEcuacion.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.button1.Location = new System.Drawing.Point(211, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular las raices";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // raiz1
            // 
            this.raiz1.AutoSize = true;
            this.raiz1.Location = new System.Drawing.Point(54, 292);
            this.raiz1.Name = "raiz1";
            this.raiz1.Size = new System.Drawing.Size(26, 13);
            this.raiz1.TabIndex = 4;
            this.raiz1.Text = "X1: ";
            // 
            // raiz2
            // 
            this.raiz2.AutoSize = true;
            this.raiz2.Location = new System.Drawing.Point(328, 292);
            this.raiz2.Name = "raiz2";
            this.raiz2.Size = new System.Drawing.Size(26, 13);
            this.raiz2.TabIndex = 5;
            this.raiz2.Text = "X2: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 341);
            this.Controls.Add(this.raiz2);
            this.Controls.Add(this.raiz1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textEcuacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEcuacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label raiz1;
        private System.Windows.Forms.Label raiz2;
    }
}

