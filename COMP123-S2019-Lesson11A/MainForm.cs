using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace COMP123_S2019_Lesson11A
{
    enum StudentField
    {
        ID,
        STUDENT_ID,
        FIRST_NAME,
        LAST_NAME,
        NUM_OF_FIELDS
    }
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sectionCDatabaseDataSet.StudentTable' table. You can move, or remove it, as needed.
            this.studentTableTableAdapter.Fill(this.sectionCDatabaseDataSet.StudentTable);

        }

        private void MainForm_FontChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Event handler for the exit toolstrip menu item click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Event handler for the aboutToolStripMenuItem click event
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }

        private void ShowDataButton_Click(object sender, EventArgs e)
        {

        }

        private void StudentDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //local scope aliases
            var rowIndex = StudentDataGridView.CurrentCell.RowIndex;
            var rows = StudentDataGridView.Rows;
            var columnCount = StudentDataGridView.ColumnCount;
            var cells = rows[rowIndex].Cells;
            rows[rowIndex].Selected = true;
            string outputString = String.Empty;
            for (int index = 0; index < columnCount; index++)
            {
                outputString += cells[index].Value.ToString() + " ";
            }
            SelectionLabel.Text = outputString;
            Program.student.ID = int.Parse(cells[(int)StudentField.ID].Value.ToString());
            Program.student.StudentID = cells[(int)StudentField.STUDENT_ID].Value.ToString();
            Program.student.FirstName = cells[(int)StudentField.FIRST_NAME].Value.ToString();
            Program.student.LastName = cells[(int)StudentField.LAST_NAME].Value.ToString();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            StudentSaveFileDialog.FileName = "student.txt";
            StudentSaveFileDialog.Filter="Text Files (*.txt)|*.txt|All Files(*.*)| *.*";
                var result = StudentSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                using (StreamWriter outputString = new StreamWriter(
               File.Open(StudentSaveFileDialog.FileName, FileMode.Create)))
                {
                    outputString.WriteLine(Program.student.ID);
                    outputString.WriteLine(Program.student.StudentID);
                    outputString.WriteLine(Program.student.FirstName);
                    outputString.WriteLine(Program.student.LastName);
                    outputString.Close();
                    outputString.Dispose();
                }
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.studentInfo.Show();
            Hide();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            StudentOpenFileDialog.FileName = "Student.txt";
            StudentOpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)| *.*";
            var result = StudentOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                using (StreamReader inputStream = new StreamReader(
                File.Open(StudentOpenFileDialog.FileName, FileMode.Open)))
                {
                    Program.student.ID = int.Parse(inputStream.ReadLine());
                    Program.student.StudentID = inputStream.ReadLine();
                    Program.student.FirstName = inputStream.ReadLine();
                    Program.student.LastName = inputStream.ReadLine();
                    inputStream.Close();
                    inputStream.Dispose();

                }
                NextButton_Click(sender,e);
            }

            
        }
    }
}
