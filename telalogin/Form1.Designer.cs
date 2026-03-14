namespace telalogin
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            imageList1 = new ImageList(components);
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 26.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(200, 143, 130);
            label1.Location = new Point(83, 44);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(336, 47);
            label1.TabIndex = 0;
            label1.Text = "Realize o seu login:";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(246, 233, 229);
            label3.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(200, 143, 130);
            label3.Location = new Point(68, 122);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(246, 233, 229);
            label4.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(200, 143, 130);
            label4.Location = new Point(68, 227);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 3;
            label4.Text = "Senha:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(68, 152);
            textBox1.Margin = new Padding(6, 5, 6, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(379, 34);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Location = new Point(68, 257);
            textBox2.Margin = new Padding(6, 5, 6, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(379, 34);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(200, 143, 130);
            button1.Location = new Point(68, 350);
            button1.Name = "button1";
            button1.Size = new Size(379, 35);
            button1.TabIndex = 6;
            button1.Text = "Acessar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Snow;
            button2.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(200, 143, 130);
            button2.Location = new Point(68, 410);
            button2.Name = "button2";
            button2.Size = new Size(379, 38);
            button2.TabIndex = 7;
            button2.Text = "Esqueci minha senha";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(246, 233, 229);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-36, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 657);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Snow;
            label5.Font = new Font("Leelawadee UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(171, 136, 149);
            label5.Location = new Point(509, 349);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 37);
            label5.TabIndex = 8;
            label5.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(491, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(886, 472);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private ImageList imageList1;
        private Label label5;
        private PictureBox pictureBox1;
    }
}
