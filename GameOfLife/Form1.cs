using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        public static int seed;
        Random rngS = new Random(seed);
        Random rng = new Random();

        public void SeedWorld()
        {
            if (seed == 0) //checks for seed and adds one if none exists
            { seed = rng.Next(); }
            for (int i = 0; i < scratchpad.GetLength(0); i++)
            {
                for (int j = 0; j < scratchpad.GetLength(1); j++)
                {
                    if (rngS.Next() % 3 == 0)
                    { scratchpad[i, j] = true; }
                    else { scratchpad[i, j] = false; }
                }
            }
        }
        
        private int CountingNeighborsT(int x, int y)
        {
            int count = 0;
            int xLength = universe.GetLength(0);
            int yLength = universe.GetLength(1);

            for (int yOffset = -1; yOffset <= 1; yOffset++)
            {
                for (int xOffset = -1; xOffset <= 1; xOffset++)
                {
                    int xCheck = x + xOffset;
                    int yCheck = y + yOffset;

                    if (xOffset == 0 && yOffset == 0)
                    { continue; }
                    if (xCheck < 0)
                    { xCheck = xLength - 1; }
                    if (yCheck < 0)
                    { yCheck = yLength - 1; }
                    if (xCheck >= xLength)
                    { xCheck = 0; }
                    if (yCheck >= yLength)
                    { yCheck = 0; }
                    if (universe[xCheck, yCheck] == true)
                        { count++; }
                }
            }
            return count;
        }

        // The universe array
        bool[,] universe = new bool[60, 30];
        // The scratchpad array
        bool[,] scratchpad = new bool[60, 30];

        // Drawing colors
        Color gridColor = Color.Black;
        Color cellColor = Color.Red;

        // The Timer class
        Timer timer = new Timer();

        // Generation count
        int generations = 0;

        public Form1()
        {
            InitializeComponent();

            // Setup the timer
            timer.Interval = 100; // milliseconds
            timer.Tick += Timer_Tick;
            timer.Enabled = false; // start timer running
        }

        // Calculate the next generation of cells
        private void NextGeneration()
        {
            for (int i = 0; i < universe.GetLength(0); i++)
            {
                for (int j = 0; j < universe.GetLength(1); j++)
                {
                    int neighbors = CountingNeighborsT(i, j);
                    if (universe[i,j] == true && (neighbors < 2))
                    { scratchpad[i,j] = false; }
                    else if (universe[i,j] == true && (neighbors > 3))
                    { scratchpad[i,j] = false; }
                    else if (universe[i,j] == true && (neighbors == 3 || neighbors == 2))
                    { scratchpad[i,j] = true; }
                    else if (universe[i,j] == false && (neighbors == 3))
                    { scratchpad[i,j] = true; }
                }
            }
            bool[,] temp = universe;
            universe = scratchpad;
            scratchpad = temp;
            for (int i = 0; i < scratchpad.GetLength(0); i++) //empties the scratchpad
            {
                for (int j = 0; j < scratchpad.GetLength(1); j++)
                {
                    scratchpad[i,j] = false;
                }
            }

            // Increment generation count
            generations++;

            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            toolStripSeedLabel.Text = "Seed = " + seed.ToString();
            graphicsPanel1.Invalidate();

        }

        // The event called by the timer every Interval milliseconds.
        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Calculate the width and height of each cell in pixels
            // CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
            int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

            int cellLength;
            if (cellWidth < cellHeight)
            {
                cellLength = cellWidth;
            }
            else { cellLength = cellHeight; }
            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);

            // A Brush for filling living cells interiors (color)
            Brush cellBrush = new SolidBrush(cellColor);

            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // A rectangle to represent each cell in pixels
                    Rectangle cellRect = Rectangle.Empty;
                    cellRect.X = x * cellLength;
                    cellRect.Y = y * cellLength;
                    cellRect.Width = cellLength;
                    cellRect.Height = cellLength;

                    // Fill the cell with a brush if alive
                    if (universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                    }

                    // Outline the cell with a pen
                    e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                }
            }

            // Cleaning up pens and brushes
            gridPen.Dispose();
            cellBrush.Dispose();
        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            // If the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                // Calculate the width and height of each cell in pixels
                int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
                int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

                int cellLength; //makes an int to make the cells a square
                if (cellWidth < cellHeight)
                {
                    cellLength = cellWidth;
                }
                else { cellLength = cellHeight; }

                // Calculate the cell that was clicked in
                // CELL X = MOUSE X / CELL WIDTH
                int x = e.X / cellLength;
                // CELL Y = MOUSE Y / CELL HEIGHT
                int y = e.Y / cellLength;

                // Toggle the cell's state
                universe[x, y] = !universe[x, y];

                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        private void NextGenButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == false)
            NextGeneration();
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            SeedWorld();
            NextGeneration();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < universe.GetLength(0); i++)
            {
                for (int j = 0; j < universe.GetLength(1); j++)
                {
                    universe[i, j] = false;
                }
            }
            generations = -1; //sets generations to 0 when the empty generation is displayed
            seed = 0; // resets seed to default
            NextGeneration();
        }
    }
}
