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
        
        private void loadNotesFromFile(string json)
        {
            // Read the JSON and deserialize it to a DataTable
            notes = JsonConvert.DeserializeObject<DataTable>(json);
            // Set the DataSource of the DataGridView to the notes DataTable
            prevNotes.DataSource = notes;
                
            
        }

        private void notify()
        {
            // Find all notes for today and display a message box with the count
            var todaysNotes = notes.AsEnumerable()
                .Where(row => row.Field<DateTime>("Date").Date == DateTime.Now.Date);

            int noteCount = todaysNotes.Count(); 

            if (noteCount > 0)
            {
                MessageBox.Show($"There are {noteCount} notes for today");
            }
            else
            {
                MessageBox.Show("No notes for today");
            }

        }
        
        private void noteApp_Load(object sender, EventArgs e)
        {
            // Load existing notes or don't if there are none
            
            if (File.Exists("notes.json"))
            {
                string json = File.ReadAllText("notes.json");
                if (json.Contains("Title"))
                {
                    loadNotesFromFile(json);
                }
                else
                {
                    notes.Columns.Add("Title");
                    notes.Columns.Add("Note");
                    notes.Columns.Add("Date", typeof(DateTime));
                }
            }
            else
            {
                 notes.Columns.Add("Title");
                 notes.Columns.Add("Note");
                 notes.Columns.Add("Date", typeof(DateTime));
            }
            
            prevNotes.DataSource = notes;
            notify();
           
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
            if (title.Text == "" || noteContent.Text == "")
            {
                MessageBox.Show("Please enter a title and note");
            }
            else
            {
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
        }
        
        private void prevNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            title.Text = notes.Rows[prevNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteContent.Text = notes.Rows[prevNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
        
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DataTable selectedDateNotes = null;
            try
            {
                selectedDateNotes = notes.AsEnumerable()
                    .Where(row => row.Field<DateTime>("Date").Date == Calendar.SelectionStart.Date)
                    .CopyToDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No notes for this date");
            }
            
            
            selectedDateTable.DataSource = selectedDateNotes;
            
        }
        
        private void selectedDateTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                    title.Text = notes.Rows[selectedDateTable.CurrentCell.RowIndex].ItemArray[0].ToString();
                    noteContent.Text = notes.Rows[selectedDateTable.CurrentCell.RowIndex].ItemArray[1].ToString();
                    editing = true;
                }
        
        private void noteContent_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        
    }
}