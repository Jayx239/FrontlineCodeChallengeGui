namespace FrontlineCodeChallengeGui
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
            this.decodeButton = new System.Windows.Forms.Button();
            this.outputTextArea = new System.Windows.Forms.RichTextBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unsortedRadio = new System.Windows.Forms.RadioButton();
            this.alphabeticalRadio = new System.Windows.Forms.RadioButton();
            this.asciiRadio = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(451, 452);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(75, 23);
            this.decodeButton.TabIndex = 0;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // outputTextArea
            // 
            this.outputTextArea.Location = new System.Drawing.Point(32, 100);
            this.outputTextArea.Name = "outputTextArea";
            this.outputTextArea.Size = new System.Drawing.Size(494, 194);
            this.outputTextArea.TabIndex = 1;
            this.outputTextArea.Text = "";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(158, 452);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(254, 22);
            this.inputTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "(";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = ")";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Encoded Text";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.asciiRadio);
            this.groupBox1.Controls.Add(this.alphabeticalRadio);
            this.groupBox1.Controls.Add(this.unsortedRadio);
            this.groupBox1.Location = new System.Drawing.Point(158, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 122);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort Type";
            // 
            // unsortedRadio
            // 
            this.unsortedRadio.AutoSize = true;
            this.unsortedRadio.Location = new System.Drawing.Point(23, 30);
            this.unsortedRadio.Name = "unsortedRadio";
            this.unsortedRadio.Size = new System.Drawing.Size(87, 21);
            this.unsortedRadio.TabIndex = 0;
            this.unsortedRadio.TabStop = true;
            this.unsortedRadio.Text = "Unsorted";
            this.unsortedRadio.UseVisualStyleBackColor = true;
            // 
            // alphabeticalRadio
            // 
            this.alphabeticalRadio.AutoSize = true;
            this.alphabeticalRadio.Location = new System.Drawing.Point(23, 57);
            this.alphabeticalRadio.Name = "alphabeticalRadio";
            this.alphabeticalRadio.Size = new System.Drawing.Size(106, 21);
            this.alphabeticalRadio.TabIndex = 1;
            this.alphabeticalRadio.TabStop = true;
            this.alphabeticalRadio.Text = "Alphabetical";
            this.alphabeticalRadio.UseVisualStyleBackColor = true;
            // 
            // asciiRadio
            // 
            this.asciiRadio.AutoSize = true;
            this.asciiRadio.Location = new System.Drawing.Point(23, 84);
            this.asciiRadio.Name = "asciiRadio";
            this.asciiRadio.Size = new System.Drawing.Size(62, 21);
            this.asciiRadio.TabIndex = 2;
            this.asciiRadio.TabStop = true;
            this.asciiRadio.Text = "ASCII";
            this.asciiRadio.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.importToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.outputTextArea);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Frontline Decoder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.RichTextBox outputTextArea;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton asciiRadio;
        private System.Windows.Forms.RadioButton alphabeticalRadio;
        private System.Windows.Forms.RadioButton unsortedRadio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
    }
}

