namespace MenuPrincipal
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
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
            label1.Location = new Point(69, 26);
            label1.Name = "label1";
            label1.Size = new Size(270, 47);
            label1.TabIndex = 0;
            label1.Text = "Menu Principal";
            // 
            // button1
            // 
            button1.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(200, 143, 130);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(74, 107);
            button1.Name = "button1";
            button1.Size = new Size(265, 50);
            button1.TabIndex = 1;
            button1.Text = "Novo Agendamento";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(200, 143, 130);
            button2.Location = new Point(74, 180);
            button2.Name = "button2";
            button2.Size = new Size(265, 50);
            button2.TabIndex = 2;
            button2.Text = "Pedidos Atuais";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(200, 143, 130);
            button3.Location = new Point(74, 252);
            button3.Name = "button3";
            button3.Size = new Size(265, 50);
            button3.TabIndex = 3;
            button3.Text = "Histórico de Pedidos";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(200, 143, 130);
            button4.Location = new Point(74, 325);
            button4.Name = "button4";
            button4.Size = new Size(265, 50);
            button4.TabIndex = 4;
            button4.Text = "Sair";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(246, 233, 229);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(56, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(412, 407);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(277, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(524, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
