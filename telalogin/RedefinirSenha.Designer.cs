namespace telalogin
{
    partial class RedefinirSenha
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
            lbFechar = new Label();
            SuspendLayout();
            // 
            // lbFechar
            // 
            lbFechar.AutoSize = true;
            lbFechar.ForeColor = Color.FromArgb(200, 143, 130);
            lbFechar.Location = new Point(465, 22);
            lbFechar.Name = "lbFechar";
            lbFechar.Size = new Size(14, 15);
            lbFechar.TabIndex = 10;
            lbFechar.Text = "X";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 411);
            Controls.Add(lbFechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbFechar;
    }
}