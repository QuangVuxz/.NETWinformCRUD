using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Reflection.Metadata;

namespace WinFormsApp
{
    internal class Form1Controller
    {
        private DataTable table;
        string filepath = @"C:\Users\phamh\source\repos\New folder\WinFormsApp\information.txt";

        public Form1Controller(DataTable dataTable, string filePath)
        {
            table = dataTable;
            filepath = filePath;
        }

        public void SaveLog(string time, string creator, string title, string content)
        {
            string logEntry = $"{creator}\n{title}\n{content}\n{time}";

            using (StreamWriter logWriter = new StreamWriter(filepath, true))
            {
                logWriter.WriteLine(logEntry);
            }
        }

        public void ShowDetails()
        {
            // Clear the existing data in the DataTable
            table.Clear();

            try
            {
                // Read all the lines from the file
                string[] lines = File.ReadAllLines(filepath);

                // Process the lines and add them to the DataTable
                int infoCount = 0;
                int linesPerInfo = 4;

                for (int i = 0; i < lines.Length; i += linesPerInfo)
                {
                    if (i + linesPerInfo <= lines.Length)
                    {
                        string creator = lines[i];
                        string title = lines[i + 1];
                        string content = lines[i + 2];
                        string time = lines[i + 3];

                        table.Rows.Add(creator, title, content, time);
                        infoCount++;
                    }
                }

                MessageBox.Show($"Found {infoCount} information sets in the file.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading the file: {ex.Message}");
            }
        }

        public void DeleteRecord(string creator, string title, string content)
        {
            // Find the row in the DataTable that matches the provided creator, title, and content
            DataRow[] rowsToDelete = table.Select($"Creator = '{creator}' AND Title = '{title}' AND Content = '{content}'");

            // Delete the matched rows from the DataTable
            foreach (DataRow row in rowsToDelete)
            {
                table.Rows.Remove(row);
            }

            // Update the file with the modified data
            UpdateFile();
        }

        private void UpdateFile()
        {
            try
            {
                // Clear the contents of the file
                File.WriteAllText(filepath, string.Empty);

                // Write each row of the DataTable to the file
                using (StreamWriter logWriter = new StreamWriter(filepath, true))
                {
                    foreach (DataRow row in table.Rows)
                    {
                        string creator = row["Creator"].ToString();
                        string title = row["Title"].ToString();
                        string content = row["Content"].ToString();
                        string time = row["Time"].ToString();

                        string logEntry = $"{creator}\n{title}\n{content}\n{time}";

                        logWriter.WriteLine(logEntry);
                    }
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating the file: {ex.Message}");
            }
        }

        public void EditDetails(string? textCreator, string? textTitle, string? textContent, string? time)
        {
            MessageBox.Show($"Creator: {textCreator}\nTitle: {textTitle}\nContent: {textContent}\nTime: {time}");
            string logEntry = $"{textCreator}\n{textTitle}\n{textContent}\n{time}";

            using (StreamWriter logWriter = new StreamWriter(filepath, true))
            {
                logWriter.WriteLine(logEntry);
            }

        }
    }
}
