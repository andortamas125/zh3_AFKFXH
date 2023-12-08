namespace zh3_AFKFXH
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
            JátékosokButton = new Button();
            CsapatokButton = new Button();
            ExcelButton = new Button();
            TudnivalókButton = new Button();
            DataGridViewButton = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // JátékosokButton
            // 
            JátékosokButton.Location = new Point(23, 62);
            JátékosokButton.Name = "JátékosokButton";
            JátékosokButton.Size = new Size(75, 23);
            JátékosokButton.TabIndex = 0;
            JátékosokButton.Text = "Játékosok";
            JátékosokButton.UseVisualStyleBackColor = true;
            JátékosokButton.Click += JátékosokButton_Click;
            // 
            // CsapatokButton
            // 
            CsapatokButton.Location = new Point(23, 91);
            CsapatokButton.Name = "CsapatokButton";
            CsapatokButton.Size = new Size(75, 23);
            CsapatokButton.TabIndex = 1;
            CsapatokButton.Text = "Csapatok";
            CsapatokButton.UseVisualStyleBackColor = true;
            CsapatokButton.Click += CsapatokButton_Click;
            // 
            // ExcelButton
            // 
            ExcelButton.Location = new Point(23, 120);
            ExcelButton.Name = "ExcelButton";
            ExcelButton.Size = new Size(75, 39);
            ExcelButton.TabIndex = 2;
            ExcelButton.Text = "Excel készítés";
            ExcelButton.UseVisualStyleBackColor = true;
            ExcelButton.Click += ExcelButton_Click;
            // 
            // TudnivalókButton
            // 
            TudnivalókButton.Location = new Point(23, 236);
            TudnivalókButton.Name = "TudnivalókButton";
            TudnivalókButton.Size = new Size(75, 23);
            TudnivalókButton.TabIndex = 3;
            TudnivalókButton.Text = "Tudnivalók";
            TudnivalókButton.UseVisualStyleBackColor = true;
            TudnivalókButton.Click += TudnivalókButton_Click;
            // 
            // DataGridViewButton
            // 
            DataGridViewButton.Location = new Point(23, 265);
            DataGridViewButton.Name = "DataGridViewButton";
            DataGridViewButton.Size = new Size(75, 23);
            DataGridViewButton.TabIndex = 4;
            DataGridViewButton.Text = "DataGridView";
            DataGridViewButton.UseVisualStyleBackColor = true;
            DataGridViewButton.Click += DataGridViewButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 44);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 5;
            label1.Text = "UserControllok:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 218);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Formok:";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(906, 523);
            panel1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 523);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DataGridViewButton);
            Controls.Add(TudnivalókButton);
            Controls.Add(ExcelButton);
            Controls.Add(CsapatokButton);
            Controls.Add(JátékosokButton);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button JátékosokButton;
        private Button CsapatokButton;
        private Button ExcelButton;
        private Button TudnivalókButton;
        private Button DataGridViewButton;
        private Label label1;
        private Label label2;
        private Panel panel1;
    }
}