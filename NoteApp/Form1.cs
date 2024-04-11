using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace NoteApp
{
    public partial class Form1 : Form
    {
        // Create a new DataTable to store notes
        DataTable notes = new DataTable();
        // Create a boolean to check if the user is editing a note
        bool editing = false;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void saveNotesToFile()
        {   
            // Serialize the notes DataTable to JSON and write it to a file
            string json = JsonConvert.SerializeObject(notes);
            File.WriteAllText("notes.json", json);
        }
        
        private void loadNotesFromFile()
        {
            // Check if the file exists, if it does, read the JSON and deserialize it to a DataTable
            if (File.Exists("notes.json"))
            {
                string json = File.ReadAllText("notes.json");
                notes = JsonConvert.DeserializeObject<DataTable>(json);
                // Set the DataSource of the DataGridView to the notes DataTable
                prevNotes.DataSource = notes;
            }
        }
        
        private void noteApp_Load(object sender, EventArgs e)
        {
            // Load existing notes or don't if there are none
            
            string content = File.ReadAllText("notes.json");

            if (content.Contains("Title"))
            { 
                loadNotesFromFile();
            }
            else
            {
                notes.Columns.Add("Title");
                notes.Columns.Add("Note");
                notes.Columns.Add("Date", typeof(DateTime));
            }
            
            prevNotes.DataSource = notes;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            // Load the selected note into the title and noteContent textboxes
           title.Text = notes.Rows[prevNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
           noteContent.Text = notes.Rows[prevNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
           editing = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Delete the selected note
            try
            {
                notes.Rows[prevNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No note selected");
            }
            saveNotesToFile();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            title.Text = "";
            noteContent.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Save the note to the DataTable
            if (editing)
            {
                notes.Rows[prevNotes.CurrentCell.RowIndex]["Title"] = title.Text;
                notes.Rows[prevNotes.CurrentCell.RowIndex]["Note"] = noteContent.Text;
                notes.Rows[prevNotes.CurrentCell.RowIndex]["Date"] = Calendar.SelectionStart;
            }
            else
            {
                notes.Rows.Add(title.Text, noteContent.Text, Calendar.SelectionStart);
            }
            title.Text = "";
            noteContent.Text = "";
            editing = false;
            
            saveNotesToFile();
        }
        
        private void prevNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            title.Text = notes.Rows[prevNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteContent.Text = notes.Rows[prevNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
        
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show($"The selected date is {e.Start.ToShortDateString()}");

            var selectedDateNotes = notes.AsEnumerable()
                .Where(row => row.Field<DateTime>("Date").Date == Calendar.SelectionStart.Date)
                .CopyToDataTable();
            
            selectedDateTable.DataSource = selectedDateNotes;
            
        }
        
        private void noteContent_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void selectedDateTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            title.Text = notes.Rows[selectedDateTable.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteContent.Text = notes.Rows[selectedDateTable.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}