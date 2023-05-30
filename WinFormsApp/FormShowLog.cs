using System;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace WinFormsApp
{
    public partial class FormShowLog : Form
    {
        private DataTable table;
        private Form1Controller controller;


        public FormShowLog()
        {
            InitializeComponent();
            table = new DataTable();
            dataGridView1.DataSource = table;

            // Instantiate the Form1Controller

            controller = new Form1Controller(table, @"C:\Users\phamh\source\repos\New folder\WinFormsApp\information.txt");
        }


        private void FormShowLog_Load(object sender, EventArgs e)
        {
            // Add columns to the DataTable
            table.Columns.Add("Creator", typeof(string));
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Content", typeof(string));
            table.Columns.Add("Time", typeof(string));

            // Add a button column for "Edit"
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(editButtonColumn);

            // Add a button column for "Delete"
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteButtonColumn);


            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\phamh\source\repos\New folder\WinFormsApp\information.txt";
            string information = File.ReadAllText(filePath);

            controller.ShowDetails();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell belongs to the "Delete" button column
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Get the row index of the clicked cell
                int rowIndex = e.RowIndex;

                // Retrieve the data from the selected row
                string creator = dataGridView1.Rows[rowIndex].Cells["Creator"].Value.ToString();
                string title = dataGridView1.Rows[rowIndex].Cells["Title"].Value.ToString();
                string content = dataGridView1.Rows[rowIndex].Cells["Content"].Value.ToString();

                // Perform the desired delete action with the retrieved data
                DialogResult result = MessageBox.Show($"Are you sure you want to delete this record?\nCreator: {creator}\nTitle: {title}\nContent: {content}",
                    "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Perform the delete operation using the data
                    controller.DeleteRecord(creator, title, content);


                }
            }
            // Check if the clicked cell belongs to the "Edit" button column
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                //Get the row index of the clicked cell
                int rowIndex = e.RowIndex;
                // Retrieve the data from the selected row
                string creator = dataGridView1.Rows[rowIndex].Cells["Creator"].Value.ToString();
                string title = dataGridView1.Rows[rowIndex].Cells["Title"].Value.ToString();
                string content = dataGridView1.Rows[rowIndex].Cells["Content"].Value.ToString();

                // Assign the values to the text boxes
                txtCreator.Text = creator;
                txtTitle.Text = title;
                txtContent.Text = content;

                controller.DeleteRecord(creator, title, content);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string textCreator = txtCreator.Text;
            string textTitle = txtTitle.Text;
            string textContent = txtContent.Text;
            string time = DateTime.Now.ToString();
            controller.EditDetails(textCreator, textTitle, textContent, time);
            txtCreator.Text = string.Empty;
            txtTitle.Text = string.Empty;
            txtContent.Text = string.Empty;
        }
    }
}
