namespace SonicWFA
{
    partial class Favoritos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Favoritos));
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFlecha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnFlecha)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 21;
            this.listBox2.Location = new System.Drawing.Point(396, 76);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(355, 361);
            this.listBox2.TabIndex = 102;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(17, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(355, 361);
            this.listBox1.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 100;
            this.label3.Text = "Videos Guardados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 21);
            this.label2.TabIndex = 99;
            this.label2.Text = "Canciones Guardadas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 98;
            this.label1.Text = "Favoritos";
            // 
            // btnFlecha
            // 
            this.btnFlecha.Image = ((System.Drawing.Image)(resources.GetObject("btnFlecha.Image")));
            this.btnFlecha.Location = new System.Drawing.Point(732, 12);
            this.btnFlecha.Name = "btnFlecha";
            this.btnFlecha.Size = new System.Drawing.Size(44, 25);
            this.btnFlecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFlecha.TabIndex = 97;
            this.btnFlecha.TabStop = false;
            this.btnFlecha.Click += new System.EventHandler(this.btnFlecha_Click);
            // 
            // Favoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(788, 466);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFlecha);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(250)))), ((int)(((byte)(171)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Favoritos";
            this.Text = "Favoritos";
            ((System.ComponentModel.ISupportInitialize)(this.btnFlecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnFlecha;
    }
}