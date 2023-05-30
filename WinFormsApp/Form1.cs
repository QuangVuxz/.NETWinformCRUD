using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WinFormsApp.Form1Controller;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private Form1Controller controller;
        private DataTable table;
        

        public Form1()
        {
            InitializeComponent();
            controller = new Form1Controller(table, @"C:\Users\phamh\source\repos\New folder\WinFormsApp\information.txt");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string creator = txtCreator.Text;
            string title = txtTitle.Text;
            string content = txtContent.Text;
            string time = DateTime.Now.ToString();

            controller.SaveLog(time, creator, title, content);

            MessageBox.Show("Save successfully!");

            txtCreator.Text = string.Empty;
            txtTitle.Text = string.Empty;
            txtContent.Text = string.Empty;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormShowLog formShowLog = new FormShowLog();
            formShowLog.ShowDialog();
            
        }
    }
}