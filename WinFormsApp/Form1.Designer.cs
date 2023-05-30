namespace WinFormsApp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCreator = new TextBox();
            txtTitle = new TextBox();
            txtContent = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 79);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Creator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 163);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 258);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "Content";
            // 
            // txtCreator
            // 
            txtCreator.Location = new Point(405, 76);
            txtCreator.Name = "txtCreator";
            txtCreator.Size = new Size(227, 27);
            txtCreator.TabIndex = 3;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(405, 160);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(227, 27);
            txtTitle.TabIndex = 4;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(405, 255);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(227, 112);
            txtContent.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(148, 406);
            button1.Name = "button1";
            button1.Size = new Size(166, 43);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(442, 406);
            button2.Name = "button2";
            button2.Size = new Size(166, 43);
            button2.TabIndex = 7;
            button2.Text = "Show Log";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtContent);
            Controls.Add(txtTitle);
            Controls.Add(txtCreator);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCreator;
        private TextBox txtTitle;
        private TextBox txtContent;
        private Button button1;
        private Button button2;
    }
}