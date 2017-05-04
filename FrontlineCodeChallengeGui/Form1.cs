using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontlineCodeChallenge;

namespace FrontlineCodeChallengeGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            parser = new Parser();
        }
        
        private Parser parser;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            parser = new Parser();
            parser.Parse("("+inputTextBox.Text+")");
            string output = parser.GetPrettyString(getSortType());
            outputTextArea.Text = output;
        }

        private Sorting.SortType getSortType()
        {
            if (unsortedRadio.Checked)
                return Sorting.SortType.UNSORTED;
            else if (alphabeticalRadio.Checked)
                return Sorting.SortType.ALPHABETICAL_SORT;
            else if (asciiRadio.Checked)
                return Sorting.SortType.ASCII_SORT;
            
            /* Default to unsorted */
            return Sorting.SortType.UNSORTED;
        }

        /* Save method saves the input text to a file in the directory that
         * the program is running in
         */
        private void save(string fileName)
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory + fileName;
            System.IO.StreamWriter file = new System.IO.StreamWriter(path);
            file.Write(inputTextBox.Text);
            file.Close();
            
        }

        /* Import method reads in input text from file found in directory the
         * program is running in */
        private void import(string fileName)
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory + fileName;
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            inputTextBox.Text = file.ReadLine();
            file.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                save("lastentry.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving current entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                import("lastentry.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error importing previous entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Jason Gallagher between 5/3/2017 and 5/4/2017","About",MessageBoxButtons.OK,MessageBoxIcon.Question);
        }
    }
}
