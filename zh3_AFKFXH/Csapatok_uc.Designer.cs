namespace zh3_AFKFXH
{
    partial class Csapatok_uc
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
            listBox3 = new ListBox();
            listBox2 = new ListBox();
            CsapatokListBox = new ListBox();
            CsapatokTextBox = new TextBox();
            SuspendLayout();
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(547, 43);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(159, 484);
            listBox3.TabIndex = 5;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(354, 43);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(159, 484);
            listBox2.TabIndex = 4;
            // 
            // CsapatokListBox
            // 
            CsapatokListBox.FormattingEnabled = true;
            CsapatokListBox.ItemHeight = 15;
            CsapatokListBox.Location = new Point(177, 43);
            CsapatokListBox.Name = "CsapatokListBox";
            CsapatokListBox.Size = new Size(159, 484);
            CsapatokListBox.TabIndex = 3;
            // 
            // CsapatokTextBox
            // 
            CsapatokTextBox.Location = new Point(177, 3);
            CsapatokTextBox.Name = "CsapatokTextBox";
            CsapatokTextBox.Size = new Size(159, 23);
            CsapatokTextBox.TabIndex = 6;
            // 
            // Csapatok_uc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CsapatokTextBox);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(CsapatokListBox);
            Name = "Csapatok_uc";
            Size = new Size(725, 570);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox3;
        private ListBox listBox2;
        private ListBox CsapatokListBox;
        private TextBox CsapatokTextBox;
    }
}
