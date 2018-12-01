namespace WindowsFormsApp1
{
    partial class AyudaForm
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
            this.labelMiNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMiNombre
            // 
            this.labelMiNombre.Location = new System.Drawing.Point(68, 23);
            this.labelMiNombre.Name = "labelMiNombre";
            this.labelMiNombre.Size = new System.Drawing.Size(340, 23);
            this.labelMiNombre.TabIndex = 0;
            this.labelMiNombre.Text = "Jorge Arroyo Tercero";
            this.labelMiNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(68, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Atajos de teclado:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(93, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ctrl + Shift + Derecha: Mover derecha";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(68, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cuando hay zoom en una foto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(93, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ctrl + Shift + Izquierda: Mover izquierda";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(93, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ctrl + Shift + Arriba: Mover arriba";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(93, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(340, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ctrl + Shift + Abajo: Mover hacia abajo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AyudaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 243);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMiNombre);
            this.Name = "AyudaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AyudaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMiNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}