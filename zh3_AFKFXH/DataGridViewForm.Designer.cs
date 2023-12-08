namespace zh3_AFKFXH
{
    partial class DataGridViewForm
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            mérkőzésBindingSource = new BindingSource(components);
            napBindingSource = new BindingSource(components);
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            listBox2 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            FelvételButton = new Button();
            label4 = new Label();
            nézőTextBox = new TextBox();
            eredményTextBox = new TextBox();
            label5 = new Label();
            errorProvider1 = new ErrorProvider(components);
            csapat1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            csapat2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nezoszamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bevételDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eredmenyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            napDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mérkőzésBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)napBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { csapat1DataGridViewTextBoxColumn, csapat2DataGridViewTextBoxColumn, nezoszamDataGridViewTextBoxColumn, bevételDataGridViewTextBoxColumn, eredmenyDataGridViewTextBoxColumn, napDataGridViewTextBoxColumn });
            dataGridView1.DataSource = mérkőzésBindingSource;
            dataGridView1.Location = new Point(287, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(501, 379);
            dataGridView1.TabIndex = 0;
            // 
            // mérkőzésBindingSource
            // 
            mérkőzésBindingSource.DataSource = typeof(Mérkőzés);
            // 
            // napBindingSource
            // 
            napBindingSource.DataSource = typeof(Models.Nap);
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 30);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(118, 379);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 415);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 415);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(118, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(146, 30);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(118, 379);
            listBox2.TabIndex = 3;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 5;
            label1.Text = "1. csapat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 12);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 6;
            label2.Text = "2. csapat";
            // 
            // FelvételButton
            // 
            FelvételButton.Location = new Point(287, 417);
            FelvételButton.Name = "FelvételButton";
            FelvételButton.Size = new Size(49, 28);
            FelvételButton.TabIndex = 9;
            FelvételButton.Text = "+";
            FelvételButton.UseVisualStyleBackColor = true;
            FelvételButton.Click += FelvételButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(618, 417);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 10;
            label4.Text = "Nézőszám:";
            // 
            // nézőTextBox
            // 
            nézőTextBox.Location = new Point(688, 415);
            nézőTextBox.Name = "nézőTextBox";
            nézőTextBox.Size = new Size(100, 23);
            nézőTextBox.TabIndex = 11;
            // 
            // eredményTextBox
            // 
            eredményTextBox.Location = new Point(512, 414);
            eredményTextBox.Name = "eredményTextBox";
            eredményTextBox.Size = new Size(100, 23);
            eredményTextBox.TabIndex = 13;
            eredményTextBox.Validating += eredményTextBox_Validating;
            eredményTextBox.Validated += eredményTextBox_Validated;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(443, 415);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 12;
            label5.Text = "Eredmény:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // csapat1DataGridViewTextBoxColumn
            // 
            csapat1DataGridViewTextBoxColumn.DataPropertyName = "Csapat1";
            csapat1DataGridViewTextBoxColumn.HeaderText = "Csapat1";
            csapat1DataGridViewTextBoxColumn.Name = "csapat1DataGridViewTextBoxColumn";
            // 
            // csapat2DataGridViewTextBoxColumn
            // 
            csapat2DataGridViewTextBoxColumn.DataPropertyName = "Csapat2";
            csapat2DataGridViewTextBoxColumn.HeaderText = "Csapat2";
            csapat2DataGridViewTextBoxColumn.Name = "csapat2DataGridViewTextBoxColumn";
            // 
            // nezoszamDataGridViewTextBoxColumn
            // 
            nezoszamDataGridViewTextBoxColumn.DataPropertyName = "Nezoszam";
            nezoszamDataGridViewTextBoxColumn.HeaderText = "Nezoszam";
            nezoszamDataGridViewTextBoxColumn.Name = "nezoszamDataGridViewTextBoxColumn";
            // 
            // bevételDataGridViewTextBoxColumn
            // 
            bevételDataGridViewTextBoxColumn.DataPropertyName = "Bevétel";
            bevételDataGridViewTextBoxColumn.HeaderText = "Bevétel";
            bevételDataGridViewTextBoxColumn.Name = "bevételDataGridViewTextBoxColumn";
            // 
            // eredmenyDataGridViewTextBoxColumn
            // 
            eredmenyDataGridViewTextBoxColumn.DataPropertyName = "Eredmeny";
            eredmenyDataGridViewTextBoxColumn.HeaderText = "Eredmeny";
            eredmenyDataGridViewTextBoxColumn.Name = "eredmenyDataGridViewTextBoxColumn";
            // 
            // napDataGridViewTextBoxColumn
            // 
            napDataGridViewTextBoxColumn.DataPropertyName = "Nap";
            napDataGridViewTextBoxColumn.DataSource = napBindingSource;
            napDataGridViewTextBoxColumn.DisplayMember = "Nev";
            napDataGridViewTextBoxColumn.HeaderText = "Nap";
            napDataGridViewTextBoxColumn.Name = "napDataGridViewTextBoxColumn";
            napDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            napDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            napDataGridViewTextBoxColumn.ValueMember = "NapId";
            // 
            // DataGridViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 448);
            Controls.Add(eredményTextBox);
            Controls.Add(label5);
            Controls.Add(nézőTextBox);
            Controls.Add(label4);
            Controls.Add(FelvételButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(listBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(dataGridView1);
            Name = "DataGridViewForm";
            Text = "DataGridViewForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mérkőzésBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)napBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ListBox listBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
        private Button FelvételButton;
        private Label label4;
        private TextBox nézőTextBox;
        private TextBox eredményTextBox;
        private Label label5;
        private BindingSource mérkőzésBindingSource1;
        private BindingSource mérkőzésBindingSource2;
        private BindingSource napBindingSource;
        private BindingSource mérkőzésBindingSource;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn csapat1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn csapat2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nezoszamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bevételDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eredmenyDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn napDataGridViewTextBoxColumn;
    }
}