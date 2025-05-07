namespace bilgi_yarısması
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            btnA = new Button();
            btnc = new Button();
            btnB = new Button();
            btnd = new Button();
            btnsonraki = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblsoruno = new Label();
            lblyanlıs = new Label();
            lbldogru = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.IndianRed;
            richTextBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            richTextBox1.ForeColor = SystemColors.InactiveBorder;
            richTextBox1.Location = new Point(-1, 26);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(385, 106);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnA
            // 
            btnA.BackColor = Color.Gold;
            btnA.Location = new Point(-1, 148);
            btnA.Name = "btnA";
            btnA.Size = new Size(143, 76);
            btnA.TabIndex = 1;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += btnA_Click;
            // 
            // btnc
            // 
            btnc.BackColor = Color.Gold;
            btnc.Location = new Point(-1, 249);
            btnc.Name = "btnc";
            btnc.Size = new Size(143, 72);
            btnc.TabIndex = 2;
            btnc.Text = "C";
            btnc.UseVisualStyleBackColor = false;
            btnc.Click += btnc_Click;
            // 
            // btnB
            // 
            btnB.BackColor = Color.Gold;
            btnB.Location = new Point(194, 148);
            btnB.Name = "btnB";
            btnB.Size = new Size(146, 76);
            btnB.TabIndex = 2;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = false;
            btnB.Click += btnB_Click;
            // 
            // btnd
            // 
            btnd.BackColor = Color.Gold;
            btnd.Location = new Point(194, 249);
            btnd.Name = "btnd";
            btnd.Size = new Size(146, 72);
            btnd.TabIndex = 3;
            btnd.Text = "D";
            btnd.UseVisualStyleBackColor = false;
            btnd.Click += btnd_Click;
            // 
            // btnsonraki
            // 
            btnsonraki.BackColor = Color.White;
            btnsonraki.Location = new Point(409, 164);
            btnsonraki.Name = "btnsonraki";
            btnsonraki.Size = new Size(148, 60);
            btnsonraki.TabIndex = 3;
            btnsonraki.Text = "Sonraki";
            btnsonraki.UseVisualStyleBackColor = false;
            btnsonraki.Click += btnsonraki_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(409, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 38);
            label1.TabIndex = 4;
            label1.Text = "Soru No :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(434, 55);
            label2.Name = "label2";
            label2.Size = new Size(100, 38);
            label2.TabIndex = 5;
            label2.Text = "Yanlış :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(426, 104);
            label3.Name = "label3";
            label3.Size = new Size(109, 38);
            label3.TabIndex = 6;
            label3.Text = "Doğru :";
            // 
            // lblsoruno
            // 
            lblsoruno.AutoSize = true;
            lblsoruno.Font = new Font("Segoe UI", 16.2F);
            lblsoruno.ForeColor = SystemColors.ButtonFace;
            lblsoruno.Location = new Point(538, 9);
            lblsoruno.Name = "lblsoruno";
            lblsoruno.Size = new Size(32, 38);
            lblsoruno.TabIndex = 7;
            lblsoruno.Text = "0";
            // 
            // lblyanlıs
            // 
            lblyanlıs.AutoSize = true;
            lblyanlıs.Font = new Font("Segoe UI", 16.2F);
            lblyanlıs.ForeColor = SystemColors.ButtonFace;
            lblyanlıs.Location = new Point(538, 55);
            lblyanlıs.Name = "lblyanlıs";
            lblyanlıs.Size = new Size(32, 38);
            lblyanlıs.TabIndex = 8;
            lblyanlıs.Text = "0";
            // 
            // lbldogru
            // 
            lbldogru.AutoSize = true;
            lbldogru.Font = new Font("Segoe UI", 16.2F);
            lbldogru.ForeColor = SystemColors.ButtonFace;
            lbldogru.Location = new Point(538, 104);
            lbldogru.Name = "lbldogru";
            lbldogru.Size = new Size(32, 38);
            lbldogru.TabIndex = 9;
            lbldogru.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(386, 249);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(538, 249);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 126);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 382);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 12;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 382);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 13;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(689, 390);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbldogru);
            Controls.Add(lblyanlıs);
            Controls.Add(lblsoruno);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnsonraki);
            Controls.Add(btnd);
            Controls.Add(btnB);
            Controls.Add(btnc);
            Controls.Add(btnA);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnA;
        private Button btnc;
        private Button btnB;
        private Button btnd;
        private Button btnsonraki;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblsoruno;
        private Label lblyanlıs;
        private Label lbldogru;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
    }
}
