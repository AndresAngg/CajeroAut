namespace ATM_Proof
{
    partial class formINICIAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formINICIAL));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.textCUENTA = new System.Windows.Forms.TextBox();
            this.textPIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLOGIN = new System.Windows.Forms.Button();
            this.botonCERRAR = new System.Windows.Forms.PictureBox();
            this.botonMIN = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCERRAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMIN)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 290);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(196, 240);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(290, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(680, 290);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 331;
            this.lineShape2.X2 = 620;
            this.lineShape2.Y1 = 169;
            this.lineShape2.Y2 = 169;
            // 
            // lineShape1
            // 
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 330;
            this.lineShape1.X2 = 619;
            this.lineShape1.Y1 = 108;
            this.lineShape1.Y2 = 108;
            this.lineShape1.Click += new System.EventHandler(this.lineShape1_Click);
            // 
            // textCUENTA
            // 
            this.textCUENTA.BackColor = System.Drawing.Color.Lavender;
            this.textCUENTA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCUENTA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCUENTA.ForeColor = System.Drawing.Color.Blue;
            this.textCUENTA.Location = new System.Drawing.Point(330, 80);
            this.textCUENTA.Name = "textCUENTA";
            this.textCUENTA.Size = new System.Drawing.Size(225, 20);
            this.textCUENTA.TabIndex = 1;
            this.textCUENTA.Text = "Últimos 4 dígitos de tarjeta";
            this.textCUENTA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textCUENTA.Enter += new System.EventHandler(this.textCUENTA_Enter);
            this.textCUENTA.Leave += new System.EventHandler(this.textCUENTA_Leave);
            // 
            // textPIN
            // 
            this.textPIN.BackColor = System.Drawing.Color.Lavender;
            this.textPIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPIN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPIN.ForeColor = System.Drawing.Color.Blue;
            this.textPIN.Location = new System.Drawing.Point(330, 141);
            this.textPIN.Name = "textPIN";
            this.textPIN.Size = new System.Drawing.Size(90, 20);
            this.textPIN.TabIndex = 2;
            this.textPIN.Text = "PIN";
            this.textPIN.TextChanged += new System.EventHandler(this.textPIN_TextChanged);
            this.textPIN.Enter += new System.EventHandler(this.textPIN_Enter);
            this.textPIN.Leave += new System.EventHandler(this.textPIN_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(434, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "INGRESO";
            // 
            // buttonLOGIN
            // 
            this.buttonLOGIN.FlatAppearance.BorderSize = 0;
            this.buttonLOGIN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.buttonLOGIN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLOGIN.ForeColor = System.Drawing.Color.Blue;
            this.buttonLOGIN.Location = new System.Drawing.Point(410, 240);
            this.buttonLOGIN.Name = "buttonLOGIN";
            this.buttonLOGIN.Size = new System.Drawing.Size(168, 28);
            this.buttonLOGIN.TabIndex = 0;
            this.buttonLOGIN.Text = "ACCEDER";
            this.buttonLOGIN.UseVisualStyleBackColor = true;
            this.buttonLOGIN.Click += new System.EventHandler(this.buttonLOGIN_Click);
            this.buttonLOGIN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonLOGIN_MouseDown);
            // 
            // botonCERRAR
            // 
            this.botonCERRAR.Image = ((System.Drawing.Image)(resources.GetObject("botonCERRAR.Image")));
            this.botonCERRAR.Location = new System.Drawing.Point(644, 6);
            this.botonCERRAR.Name = "botonCERRAR";
            this.botonCERRAR.Size = new System.Drawing.Size(24, 23);
            this.botonCERRAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botonCERRAR.TabIndex = 7;
            this.botonCERRAR.TabStop = false;
            this.botonCERRAR.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // botonMIN
            // 
            this.botonMIN.Image = ((System.Drawing.Image)(resources.GetObject("botonMIN.Image")));
            this.botonMIN.Location = new System.Drawing.Point(611, 6);
            this.botonMIN.Name = "botonMIN";
            this.botonMIN.Size = new System.Drawing.Size(27, 23);
            this.botonMIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botonMIN.TabIndex = 6;
            this.botonMIN.TabStop = false;
            this.botonMIN.Click += new System.EventHandler(this.botonMIN_Click);
            // 
            // formINICIAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(680, 290);
            this.Controls.Add(this.botonCERRAR);
            this.Controls.Add(this.botonMIN);
            this.Controls.Add(this.buttonLOGIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPIN);
            this.Controls.Add(this.textCUENTA);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formINICIAL";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INGRESO";
            this.Load += new System.EventHandler(this.formINICIAL_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formINICIAL_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonCERRAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonMIN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox textPIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLOGIN;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox botonMIN;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.TextBox textCUENTA;
        public System.Windows.Forms.PictureBox botonCERRAR;
    }
}