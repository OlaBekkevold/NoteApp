namespace NoteApp
{
    partial class Form1
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
            this.title = new System.Windows.Forms.TextBox();
            this.noteTitle = new System.Windows.Forms.Label();
            this.noteContent = new System.Windows.Forms.TextBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.prevNotes = new System.Windows.Forms.DataGridView();
            this.loadButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.selectedDateTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.prevNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedDateTable)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(395, 43);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(393, 22);
            this.title.TabIndex = 1;
            this.title.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // noteTitle
            // 
            this.noteTitle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTitle.Location = new System.Drawing.Point(395, 17);
            this.noteTitle.Name = "noteTitle";
            this.noteTitle.Size = new System.Drawing.Size(78, 23);
            this.noteTitle.TabIndex = 2;
            this.noteTitle.Text = "Title:";
            // 
            // noteContent
            // 
            this.noteContent.Location = new System.Drawing.Point(395, 97);
            this.noteContent.Multiline = true;
            this.noteContent.Name = "noteContent";
            this.noteContent.Size = new System.Drawing.Size(393, 323);
            this.noteContent.TabIndex = 3;
            this.noteContent.TextChanged += new System.EventHandler(this.noteContent_TextChanged);
            // 
            // noteLabel
            // 
            this.noteLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.Location = new System.Drawing.Point(395, 71);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(78, 23);
            this.noteLabel.TabIndex = 4;
            this.noteLabel.Text = "Note:";
            // 
            // prevNotes
            // 
            this.prevNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prevNotes.BackgroundColor = System.Drawing.Color.White;
            this.prevNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prevNotes.Location = new System.Drawing.Point(12, 17);
            this.prevNotes.Name = "prevNotes";
            this.prevNotes.RowTemplate.Height = 24;
            this.prevNotes.Size = new System.Drawing.Size(353, 346);
            this.prevNotes.TabIndex = 5;
            this.prevNotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prevNotes_CellDoubleClick);
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(12, 381);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(99, 29);
            this.loadButton.TabIndex = 6;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(127, 381);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(99, 29);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(243, 381);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(99, 29);
            this.newButton.TabIndex = 8;
            this.newButton.Text = "New Note";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(127, 416);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(99, 29);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(851, 43);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 10;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // selectedDateTable
            // 
            this.selectedDateTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.selectedDateTable.BackgroundColor = System.Drawing.Color.White;
            this.selectedDateTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedDateTable.Location = new System.Drawing.Point(851, 276);
            this.selectedDateTable.Name = "selectedDateTable";
            this.selectedDateTable.RowTemplate.Height = 24;
            this.selectedDateTable.Size = new System.Drawing.Size(276, 304);
            this.selectedDateTable.TabIndex = 11;
            this.selectedDateTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedDateTable_CellContentDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1203, 592);
            this.Controls.Add(this.selectedDateTable);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.prevNotes);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.noteContent);
            this.Controls.Add(this.noteTitle);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Note App";
            this.Load += new System.EventHandler(this.noteApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prevNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedDateTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView selectedDateTable;

        private System.Windows.Forms.MonthCalendar Calendar;

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button loadButton;

        private System.Windows.Forms.Button saveButton;

        private System.Windows.Forms.DataGridView prevNotes;

        private System.Windows.Forms.Label noteLabel;

        private System.Windows.Forms.Label noteTitle;

        private System.Windows.Forms.TextBox noteContent;

        private System.Windows.Forms.TextBox title;

        #endregion
    }
}