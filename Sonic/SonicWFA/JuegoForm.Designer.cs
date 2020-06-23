namespace SonicWFA
{
    partial class JuegoForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JuegoForm));
            this.pbRayo = new System.Windows.Forms.PictureBox();
            this.pbEdificio = new System.Windows.Forms.PictureBox();
            this.pbTierra = new System.Windows.Forms.PictureBox();
            this.pbNave = new System.Windows.Forms.PictureBox();
            this.TiempoJuego = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lPuntos = new System.Windows.Forms.Label();
            this.pBarra = new System.Windows.Forms.Panel();
            this.btnSalida = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRayo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdificio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTierra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRayo
            // 
            this.pbRayo.Image = ((System.Drawing.Image)(resources.GetObject("pbRayo.Image")));
            this.pbRayo.Location = new System.Drawing.Point(295, 95);
            this.pbRayo.Name = "pbRayo";
            this.pbRayo.Size = new System.Drawing.Size(52, 213);
            this.pbRayo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRayo.TabIndex = 4;
            this.pbRayo.TabStop = false;
            // 
            // pbEdificio
            // 
            this.pbEdificio.Image = ((System.Drawing.Image)(resources.GetObject("pbEdificio.Image")));
            this.pbEdificio.Location = new System.Drawing.Point(449, 508);
            this.pbEdificio.Name = "pbEdificio";
            this.pbEdificio.Size = new System.Drawing.Size(76, 174);
            this.pbEdificio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEdificio.TabIndex = 3;
            this.pbEdificio.TabStop = false;
            // 
            // pbTierra
            // 
            this.pbTierra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(250)))), ((int)(((byte)(171)))));
            this.pbTierra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbTierra.Location = new System.Drawing.Point(0, 681);
            this.pbTierra.Name = "pbTierra";
            this.pbTierra.Size = new System.Drawing.Size(621, 72);
            this.pbTierra.TabIndex = 2;
            this.pbTierra.TabStop = false;
            // 
            // pbNave
            // 
            this.pbNave.Image = global::SonicWFA.Properties.Resources.LogoMakr_1QFic3__1_;
            this.pbNave.Location = new System.Drawing.Point(89, 348);
            this.pbNave.Name = "pbNave";
            this.pbNave.Size = new System.Drawing.Size(100, 46);
            this.pbNave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNave.TabIndex = 0;
            this.pbNave.TabStop = false;
            // 
            // TiempoJuego
            // 
            this.TiempoJuego.Enabled = true;
            this.TiempoJuego.Interval = 20;
            this.TiempoJuego.Tick += new System.EventHandler(this.TiempoJuegoEvento);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(627, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lPuntos
            // 
            this.lPuntos.AutoSize = true;
            this.lPuntos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(250)))), ((int)(((byte)(171)))));
            this.lPuntos.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lPuntos.ForeColor = System.Drawing.Color.Black;
            this.lPuntos.Location = new System.Drawing.Point(12, 701);
            this.lPuntos.Name = "lPuntos";
            this.lPuntos.Size = new System.Drawing.Size(122, 33);
            this.lPuntos.TabIndex = 7;
            this.lPuntos.Text = "PUNTOS:";
            // 
            // pBarra
            // 
            this.pBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(250)))), ((int)(((byte)(171)))));
            this.pBarra.Controls.Add(this.btnSalida);
            this.pBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBarra.Location = new System.Drawing.Point(0, 0);
            this.pBarra.Name = "pBarra";
            this.pBarra.Size = new System.Drawing.Size(621, 43);
            this.pBarra.TabIndex = 8;
            this.pBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBarra_MouseDown);
            // 
            // btnSalida
            // 
            this.btnSalida.Image = ((System.Drawing.Image)(resources.GetObject("btnSalida.Image")));
            this.btnSalida.Location = new System.Drawing.Point(585, 6);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(29, 29);
            this.btnSalida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalida.TabIndex = 0;
            this.btnSalida.TabStop = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // JuegoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(621, 753);
            this.Controls.Add(this.pBarra);
            this.Controls.Add(this.lPuntos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbRayo);
            this.Controls.Add(this.pbEdificio);
            this.Controls.Add(this.pbTierra);
            this.Controls.Add(this.pbNave);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "JuegoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JuegoForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JuegoKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.JuegoKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbRayo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdificio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTierra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNave;
        private System.Windows.Forms.PictureBox pbTierra;
        private System.Windows.Forms.PictureBox pbEdificio;
        private System.Windows.Forms.PictureBox pbRayo;
        private System.Windows.Forms.Timer TiempoJuego;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lPuntos;
        private System.Windows.Forms.Panel pBarra;
        private System.Windows.Forms.PictureBox btnSalida;
    }
}