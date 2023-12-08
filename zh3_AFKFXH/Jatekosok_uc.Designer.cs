namespace zh3_AFKFXH
{
    partial class Jatekosok_uc
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
            JatekosokListBox = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            JatekosokTextBox = new TextBox();
            SuspendLayout();
            // 
            // JatekosokListBox
            // 
            JatekosokListBox.FormattingEnabled = true;
            JatekosokListBox.ItemHeight = 15;
            JatekosokListBox.Location = new Point(165, 51);
            JatekosokListBox.Name = "JatekosokListBox";
            JatekosokListBox.Size = new Size(159, 484);
            JatekosokListBox.TabIndex = 0;
            JatekosokListBox.SelectedIndexChanged += JatekosokListBox_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(342, 51);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(159, 484);
            listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(535, 51);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(159, 484);
            listBox3.TabIndex = 2;
            // 
            // JatekosokTextBox
            // 
            JatekosokTextBox.Location = new Point(165, 22);
            JatekosokTextBox.Name = "JatekosokTextBox";
            JatekosokTextBox.Size = new Size(159, 23);
            JatekosokTextBox.TabIndex = 3;
            JatekosokTextBox.TextChanged += JatekosokTextBox_TextChanged;
            // 
            // Jatekosok_uc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(JatekosokTextBox);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(JatekosokListBox);
            Name = "Jatekosok_uc";
            Size = new Size(750, 592);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox JatekosokListBox;
        private ListBox listBox2;
        private ListBox listBox3;
        private TextBox JatekosokTextBox;
    }
}
