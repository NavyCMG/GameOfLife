using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Options : Form
    {
        public int seed
        {
            get { return (int)numericUpDownSeed.Value; }
            set { numericUpDownSeed.Value = value; }
        }
        public int x //world width
        {
            get { return (int)numericUpDownX.Value; }
            set { numericUpDownX.Value = value; }
        }
        public int y //world hight
        {
            get { return (int)numericUpDownY.Value; }
            set { numericUpDownY.Value = value; }
        }
        public int timer //generation timer
        {
            get { return (int)numericUpDownTimer.Value; }
            set { numericUpDownTimer.Value = value; }
        }

        public Options()
        {
            InitializeComponent();
        }

        private void CellColorB_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current background color.
            MyDialog.Color = CellColorB.BackColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                CellColorB.BackColor = MyDialog.Color;
        }
        public Color Cell
        {
            get { return CellColorB.BackColor;}
            set { CellColorB.BackColor = value; }
        }

        private void BackgroundColorB_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current background color.
            MyDialog.Color = BackgroundColorB.BackColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                BackgroundColorB.BackColor = MyDialog.Color;
        }
        public Color Background
        {
            get { return BackgroundColorB.BackColor; }
            set { BackgroundColorB.BackColor = value; }
        }
        private void GridColorB_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current background color.
            MyDialog.Color = GridColorB.BackColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                GridColorB.BackColor = MyDialog.Color;
        }
        public Color Grid
        {
            get { return GridColorB.BackColor; }
            set { GridColorB.BackColor = value; }
        }
    }
}
