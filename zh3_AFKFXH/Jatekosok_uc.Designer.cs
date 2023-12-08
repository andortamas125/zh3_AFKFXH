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
            JatekosokTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            születésidátumTextBox = new TextBox();
            posztTextBox = new TextBox();
            mezTextBox = new TextBox();
            SuspendLayout();
            // 
            // JatekosokListBox
            // 
            JatekosokListBox.FormattingEnabled = true;
            JatekosokListBox.ItemHeight = 15;
            JatekosokListBox.Location = new Point(240, 44);
            JatekosokListBox.Name = "JatekosokListBox";
            JatekosokListBox.Size = new Size(159, 484);
            JatekosokListBox.TabIndex = 0;
            JatekosokListBox.SelectedIndexChanged += JatekosokListBox_SelectedIndexChanged;
            // 
            // JatekosokTextBox
            // 
            JatekosokTextBox.Location = new Point(240, 15);
            JatekosokTextBox.Name = "JatekosokTextBox";
            JatekosokTextBox.Size = new Size(159, 23);
            JatekosokTextBox.TabIndex = 3;
            JatekosokTextBox.TextChanged += JatekosokTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(441, 44);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 4;
            label1.Text = "Születési dátum:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(441, 122);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "Poszt:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(441, 199);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 6;
            label3.Text = "Mezszám:";
            // 
            // születésidátumTextBox
            // 
            születésidátumTextBox.Location = new Point(441, 62);
            születésidátumTextBox.Name = "születésidátumTextBox";
            születésidátumTextBox.Size = new Size(100, 23);
            születésidátumTextBox.TabIndex = 7;
            // 
            // posztTextBox
            // 
            posztTextBox.Location = new Point(441, 140);
            posztTextBox.Name = "posztTextBox";
            posztTextBox.Size = new Size(100, 23);
            posztTextBox.TabIndex = 8;
            // 
            // mezTextBox
            // 
            mezTextBox.Location = new Point(441, 226);
            mezTextBox.Name = "mezTextBox";
            mezTextBox.Size = new Size(100, 23);
            mezTextBox.TabIndex = 9;
            // 
            // Jatekosok_uc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mezTextBox);
            Controls.Add(posztTextBox);
            Controls.Add(születésidátumTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(JatekosokTextBox);
            Controls.Add(JatekosokListBox);
            Name = "Jatekosok_uc";
            Size = new Size(750, 592);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox JatekosokListBox;
        private TextBox JatekosokTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox születésidátumTextBox;
        private TextBox posztTextBox;
        private TextBox mezTextBox;
    }
}
