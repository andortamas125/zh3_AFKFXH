namespace zh3_AFKFXH
{
    partial class Excel_uc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            excelButton = new Button();
            diagramButton = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // excelButton
            // 
            excelButton.Location = new Point(127, 261);
            excelButton.Name = "excelButton";
            excelButton.Size = new Size(90, 69);
            excelButton.TabIndex = 0;
            excelButton.Text = "Excelbe írás!";
            excelButton.UseVisualStyleBackColor = true;
            excelButton.Click += excelButton_Click;
            // 
            // diagramButton
            // 
            diagramButton.Location = new Point(501, 261);
            diagramButton.Name = "diagramButton";
            diagramButton.Size = new Size(90, 69);
            diagramButton.TabIndex = 1;
            diagramButton.Text = "Diagram készítés!";
            diagramButton.UseVisualStyleBackColor = true;
            diagramButton.Click += diagramButton_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(219, 94);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(287, 96);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // Excel_uc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(richTextBox1);
            Controls.Add(diagramButton);
            Controls.Add(excelButton);
            Name = "Excel_uc";
            Size = new Size(725, 570);
            ResumeLayout(false);
        }

        #endregion

        private Button excelButton;
        private Button diagramButton;
        private RichTextBox richTextBox1;
    }
}
