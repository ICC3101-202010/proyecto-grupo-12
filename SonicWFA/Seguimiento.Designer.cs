namespace SonicWFA
{
    partial class Seguimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seguimiento));
            this.label1 = new System.Windows.Forms.Label();
            this.btnFlecha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnFlecha)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(250)))), ((int)(((byte)(171)))));
            this.label1.Location = new System.Drawing.Point(165, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(669, 238);
            this.label1.TabIndex = 91;
            this.label1.Text = "FALTA";
            // 
            // btnFlecha
            // 
            this.btnFlecha.Image = ((System.Drawing.Image)(resources.GetObject("btnFlecha.Image")));
            this.btnFlecha.Location = new System.Drawing.Point(915, 12);
            this.btnFlecha.Name = "btnFlecha";
            this.btnFlecha.Size = new System.Drawing.Size(44, 25);
            this.btnFlecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFlecha.TabIndex = 90;
            this.btnFlecha.TabStop = false;
            this.btnFlecha.Click += new System.EventHandler(this.btnFlecha_Click);
            // 
            // Seguimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(971, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFlecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Seguimiento";
            this.Text = "Seguimiento";
            ((System.ComponentModel.ISupportInitialize)(this.btnFlecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnFlecha;
        private System.Windows.Forms.Label label1;
    }
}