namespace thrid_lab
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
            filename = new TextBox();
            statsLabel = new Label();
            openFileDialog = new OpenFileDialog();
            OpenFile = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // filename
            // 
            filename.Location = new Point(165, 45);
            filename.Name = "filename";
            filename.Size = new Size(217, 23);
            filename.TabIndex = 1;
            filename.TextChanged += filename_TextChanged;
            // 
            // statsLabel
            // 
            statsLabel.AutoSize = true;
            statsLabel.Location = new Point(165, 27);
            statsLabel.Name = "statsLabel";
            statsLabel.Size = new Size(68, 15);
            statsLabel.TabIndex = 2;
            statsLabel.Text = "Current File";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            openFileDialog.FileOk += openFileDialog_FileOk;
            // 
            // OpenFile
            // 
            OpenFile.Location = new Point(55, 45);
            OpenFile.Name = "OpenFile";
            OpenFile.Size = new Size(75, 23);
            OpenFile.TabIndex = 4;
            OpenFile.Text = "Open File";
            OpenFile.UseVisualStyleBackColor = true;
            OpenFile.Click += OpenFile_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(55, 86);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(434, 483);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 617);
            Controls.Add(textBox1);
            Controls.Add(OpenFile);
            Controls.Add(statsLabel);
            Controls.Add(filename);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox filename;
        private Label statsLabel;
        private OpenFileDialog openFileDialog;
        private Button OpenFile;
        private TextBox textBox1;
    }
}
