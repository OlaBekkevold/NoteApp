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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(519, 43);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(269, 22);
            this.title.TabIndex = 1;
            this.title.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // noteTitle
            // 
            this.noteTitle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTitle.Location = new System.Drawing.Point(519, 17);
            this.noteTitle.Name = "noteTitle";
            this.noteTitle.Size = new System.Drawing.Size(78, 23);
            this.noteTitle.TabIndex = 2;
            this.noteTitle.Text = "Title:";
            // 
            // noteContent
            // 
            this.noteContent.Location = new System.Drawing.Point(519, 97);
            this.noteContent.Multiline = true;
            this.noteContent.Name = "noteContent";
            this.noteContent.Size = new System.Drawing.Size(269, 323);
            this.noteContent.TabIndex = 3;
            this.noteContent.TextChanged += new System.EventHandler(this.noteContent_TextChanged);
            // 
            // noteLabel
            // 
            this.noteLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.Location = new System.Drawing.Point(519, 68);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(78, 23);
            this.noteLabel.TabIndex = 4;
            this.noteLabel.Text = "Note:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.noteContent);
            this.Controls.Add(this.noteTitle);
            this.Controls.Add(this.title);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Note App";
            this.Load += new System.EventHandler(this.noteApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.Label noteLabel;

        private System.Windows.Forms.Label noteTitle;

        private System.Windows.Forms.TextBox noteContent;

        private System.Windows.Forms.TextBox title;

        #endregion
    }
}