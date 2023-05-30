namespace WinFormsApp
{
    partial class FormShowLog
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            panel1 = new Panel();
            txtContent = new TextBox();
            txtTitle = new TextBox();
            txtCreator = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(907, 450);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(420, 468);
            button1.Name = "button1";
            button1.Size = new Size(128, 49);
            button1.TabIndex = 1;
            button1.Text = "Import";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtContent);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(txtCreator);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(985, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 450);
            panel1.TabIndex = 2;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(158, 270);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(253, 114);
            txtContent.TabIndex = 5;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(158, 167);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(253, 27);
            txtTitle.TabIndex = 4;
            // 
            // txtCreator
            // 
            txtCreator.Location = new Point(158, 37);
            txtCreator.Name = "txtCreator";
            txtCreator.Size = new Size(253, 27);
            txtCreator.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 305);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Content:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 174);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Title:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 44);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Creator:";
            // 
            // button2
            // 
            button2.Location = new Point(1156, 468);
            button2.Name = "button2";
            button2.Size = new Size(128, 49);
            button2.TabIndex = 0;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormShowLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1411, 529);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "FormShowLog";
            Text = "FormShowLog";
            Load += FormShowLog_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private Button button2;
        private Label label3;
        private Label label2;
        private TextBox txtContent;
        private TextBox txtTitle;
        private TextBox txtCreator;
    }
}