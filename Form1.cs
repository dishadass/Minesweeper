using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class MainForm : Form
    {
        int counter = 0;
        public MainForm()
        {
            InitializeComponent();
        }
        // event handlers for radio buttons
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Play(object sender, EventArgs e)
        {
            int row=0, col=0,mines = 0;//row*col >=18, mines <= row*col/2
            String text = "";
            Form2 f = null;
            // details for each level of difficulty
            if (easy.Checked)
            {
                row = col = 9;
                mines = 10;
                text = "Easy";
            }
            else if (medium.Checked)
            {
                row = col = 16;
                mines = 40;
                text = "Medium";
            }
            else if (expert.Checked)
            {
                row = 30;
                col = 16;
                mines = 99;
                text = "Expert";
            }
            
            else if (custom.Checked)
            {
                Random rd = new Random();
                row = col = Convert.ToInt32(textBox1.Text);
                int calculateMax = row * col;
                mines = rd.Next(1, calculateMax);
                text = "Custom";
            }
            
            else
                return;
            
            int size = Math.Min(30, 1000 / Math.Max(row, col));
            counter++;
            openGames.Text = " ";
            f = new Form2(text, row, col, size,mines);
            f.Show();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void playerName_TextChanged(object sender, EventArgs e)
        {
            string userInput = playerName.Text;
        }

        private void openGames_TextChanged(object sender, EventArgs e)
        {
            openGames.Text = "Games running: " + counter;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                if (f is Form2)
                    forms.Add(f);

            foreach (Form f in forms)
            {
                f.Close();
            }
            //openGames.Text = "Games running: 0";


        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = 0, col = 0, mines = 0;//row*col >=18, mines <= row*col/2
            String text = "";
            Form2 f = null;
            row = col = 9;
            mines = 10;
            text = "Easy";
            int size = Math.Min(30, 1000 / Math.Max(row, col));
            counter++;
            openGames.Text = " ";
            f = new Form2(text, row, col, size, mines);
            f.Show();
        }
        
        private void playNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = 0, col = 0, mines = 0;//row*col >=18, mines <= row*col/2
            String text = "";
            Form2 f = null;
            row = col = 16;
            mines = 40;
            text = "Medium";
            int size = Math.Min(30, 1000 / Math.Max(row, col));
            counter++;
            openGames.Text = " ";
            f = new Form2(text, row, col, size, mines);
            f.Show();
        }

        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = 0, col = 0, mines = 0;//row*col >=18, mines <= row*col/2
            String text = "";
            Form2 f = null;
             row = 30;
                col = 16;
                mines = 99;
                text = "Expert";
            int size = Math.Min(30, 1000 / Math.Max(row, col));
            counter++;
            openGames.Text = " ";
            f = new Form2(text, row, col, size, mines);
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void closeAllGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                if (f is Form2)
                    forms.Add(f);

            foreach (Form f in forms)
            {
                f.Close();
            }
            openGames.Text = "Games running: 0";

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
