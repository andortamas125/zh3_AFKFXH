namespace zh3_AFKFXH
{
    partial class Stadionok_uc
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
            StadionokListBox = new ListBox();
            StadionokTextBox = new TextBox();
            SuspendLayout();
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(524, 58);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(159, 484);
            listBox3.TabIndex = 5;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(331, 58);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(159, 484);
            listBox2.TabIndex = 4;
            // 
            // StadionokListBox
            // 
            StadionokListBox.FormattingEnabled = true;
            StadionokListBox.ItemHeight = 15;
            StadionokListBox.Location = new Point(154, 58);
            StadionokListBox.Name = "StadionokListBox";
            StadionokListBox.Size = new Size(159, 484);
            StadionokListBox.TabIndex = 3;
            // 
            // StadionokTextBox
            // 
            StadionokTextBox.Location = new Point(154, 29);
            StadionokTextBox.Name = "StadionokTextBox";
            StadionokTextBox.Size = new Size(159, 23);
            StadionokTextBox.TabIndex = 6;
            // 
            // Stadionok_uc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StadionokTextBox);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(StadionokListBox);
            Name = "Stadionok_uc";
            Size = new Size(718, 597);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox3;
        private ListBox listBox2;
        private ListBox StadionokListBox;
        private TextBox StadionokTextBox;
    }
}
