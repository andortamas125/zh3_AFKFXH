namespace zh3_AFKFXH
{
    partial class Csapat_uc
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
            CsapatListBox = new ListBox();
            CsapatTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            alakulásTextBox = new TextBox();
            edzőTextBox = new TextBox();
            SuspendLayout();
            // 
            // CsapatListBox
            // 
            CsapatListBox.FormattingEnabled = true;
            CsapatListBox.ItemHeight = 15;
            CsapatListBox.Location = new Point(154, 58);
            CsapatListBox.Name = "CsapatListBox";
            CsapatListBox.Size = new Size(159, 484);
            CsapatListBox.TabIndex = 3;
            CsapatListBox.SelectedIndexChanged += StadionokListBox_SelectedIndexChanged;
            // 
            // CsapatTextBox
            // 
            CsapatTextBox.Location = new Point(154, 29);
            CsapatTextBox.Name = "CsapatTextBox";
            CsapatTextBox.Size = new Size(159, 23);
            CsapatTextBox.TabIndex = 6;
            CsapatTextBox.TextChanged += StadionokTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(365, 85);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 7;
            label1.Text = "Alakulás éve:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(365, 215);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 8;
            label2.Text = "Edző neve:";
            // 
            // alakulásTextBox
            // 
            alakulásTextBox.Location = new Point(365, 103);
            alakulásTextBox.Name = "alakulásTextBox";
            alakulásTextBox.Size = new Size(100, 23);
            alakulásTextBox.TabIndex = 9;
            // 
            // edzőTextBox
            // 
            edzőTextBox.Location = new Point(365, 242);
            edzőTextBox.Name = "edzőTextBox";
            edzőTextBox.Size = new Size(100, 23);
            edzőTextBox.TabIndex = 10;
            // 
            // Stadionok_uc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(edzőTextBox);
            Controls.Add(alakulásTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CsapatTextBox);
            Controls.Add(CsapatListBox);
            Name = "Stadionok_uc";
            Size = new Size(718, 597);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox CsapatListBox;
        private TextBox CsapatTextBox;
        private Label label1;
        private Label label2;
        private TextBox alakulásTextBox;
        private TextBox edzőTextBox;
    }
}
