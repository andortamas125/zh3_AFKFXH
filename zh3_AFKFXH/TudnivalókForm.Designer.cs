namespace zh3_AFKFXH
{
    partial class TudnivalókForm
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
            label1 = new Label();
            label2 = new Label();
            TörténeteTextBox = new RichTextBox();
            MirőlTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 16);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Története:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 160);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Miről szól:";
            // 
            // TörténeteTextBox
            // 
            TörténeteTextBox.Location = new Point(36, 34);
            TörténeteTextBox.Name = "TörténeteTextBox";
            TörténeteTextBox.Size = new Size(255, 96);
            TörténeteTextBox.TabIndex = 2;
            TörténeteTextBox.Text = "";
            // 
            // MirőlTextBox
            // 
            MirőlTextBox.Location = new Point(36, 187);
            MirőlTextBox.Name = "MirőlTextBox";
            MirőlTextBox.Size = new Size(255, 96);
            MirőlTextBox.TabIndex = 3;
            MirőlTextBox.Text = "";
            // 
            // TudnivalókForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MirőlTextBox);
            Controls.Add(TörténeteTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TudnivalókForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox TörténeteTextBox;
        private RichTextBox MirőlTextBox;
    }
}