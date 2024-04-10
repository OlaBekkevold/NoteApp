using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class Form1 : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;
        
        public Form1()
        {
            InitializeComponent();
        }
        

        private void noteApp_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");
            
            prevNotes.DataSource = notes;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
           title.Text = notes.Rows[prevNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
           noteContent.Text = notes.Rows[prevNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
           editing = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[prevNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No note selected");
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            title.Text = "";
            noteContent.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[prevNotes.CurrentCell.RowIndex]["Title"] = title.Text;
                notes.Rows[prevNotes.CurrentCell.RowIndex]["Note"] = noteContent.Text;
            }
            else
            {
                notes.Rows.Add(title.Text, noteContent.Text);
            }
            title.Text = "";
            noteContent.Text = "";
            editing = false;
        }
        
        private void prevNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            title.Text = notes.Rows[prevNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteContent.Text = notes.Rows[prevNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
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