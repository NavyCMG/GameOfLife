using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        #region Variables
        public static bool universeType = Properties.Settings.Default.UniverseType; //true = torodial false = finite
        public static bool showGrid = Properties.Settings.Default.ShowGrid;
        public static bool showNeighborCount = Properties.Settings.Default.ShowNeighborCount;
        public static bool showHUD = Properties.Settings.Default.ShowHUD;
        public static int seed; //seed for the universe
        public static int genTimer = Properties.Settings.Default.GenTimer; //generation timer in mil seconds
        public static int worldWidth = Properties.Settings.Default.WorldWidth; 
        public static int worldHeight = Properties.Settings.Default.WorldHeight;
        Random rngS = new Random(seed);
        Random rng = new Random(); // needed to create a seed if none exists
        // The universe array
        bool[,] universe = new bool[worldWidth,worldHeight ];
        // The scratchpad array
        bool[,] scratchpad = new bool[worldWidth, worldHeight];
        // Drawing colors
        Color gridColor = Properties.Settings.Default.GridColor;
        Color cellColor = Properties.Settings.Default.CellColor;
        Color backColor = Properties.Settings.Default.BackgroundColor;
        // The Timer class
        Timer timer = new Timer(); 
        // Generation count
        int generations = 0;
        #endregion

        #region Methods
        public int NumAlive()
        {
            int count = 0;
            for (int i = 0; i < universe.GetLength(0); i++)
            {
                for (int j = 0; j < universe.GetLength(1); j++)
                {
                    if (universe[i, j] == true) count++;
                }
            }
            return count;
        }
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
        public void NewWorld()
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
        public void SaveAs()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "All Files|*.*|Cells|*.cells";
            dlg.FilterIndex = 2; dlg.DefaultExt = "cells";

            if (DialogResult.OK == dlg.ShowDialog())
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);

                // Write any comments you want to include first.
                // Prefix all comment strings with an exclamation point.
                // Use WriteLine to write the strings to the file. 
                // It appends a CRLF for you.
                writer.WriteLine("!This is my comment.");

                // Iterate through the universe one row at a time.
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    // Create a string to represent the current row.
                    String currentRow = string.Empty;

                    // Iterate through the current row one cell at a time.
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        if (universe[x, y] == false) //check if cell is dead
                        {
                            currentRow = currentRow + '0';
                        }
                        else { currentRow = currentRow + '1'; }
                    }
                    // Once the current row has been read through and the 
                    // string constructed then write it to the file using WriteLine.
                    writer.WriteLine(currentRow);
                    currentRow = string.Empty;
                }
                // After all rows and columns have been written then close the file.
                writer.Close();
            }
        }
        public void Open()
        {
            int rowNum;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files|*.*|Cells|*.cells";
            dlg.FilterIndex = 2;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                StreamReader reader = new StreamReader(dlg.FileName);

                // Create a couple variables to calculate the width and height
                // of the data in the file.
                int maxWidth = 0;
                int maxHeight = 0;

                // Iterate through the file once to get its size.
                while (!reader.EndOfStream)
                {
                    // Read one row at a time.
                    string row = reader.ReadLine();

                    // If the row begins with '!' then it is a comment
                    // and should be ignored.
                    if (row[0] == '!') continue;

                    // If the row is not a comment then it is a row of cells.
                    // Increment the maxHeight variable for each row read.
                    else 
                    {
                        // Get the length of the current row string
                        // and adjust the maxWidth variable if necessary.
                        maxHeight++;
                        maxWidth = row.Length;
                    }
                }
                // Resize the current universe and scratchPad
                // to the width and height of the file calculated above.
                universe = new bool[maxWidth, maxHeight];
                scratchpad = new bool[maxWidth, maxHeight];

                // Reset the file pointer back to the beginning of the file.
                reader.BaseStream.Seek(0, SeekOrigin.Begin);
                rowNum = 0;
                // Iterate through the file again, this time reading in the cells.
                while (!reader.EndOfStream)
                {
                    // Read one row at a time.
                    string row = reader.ReadLine();

                    // If the row begins with '!' then
                    // it is a comment and should be ignored.
                    if (row[0] == '!') continue ;
                    // If the row is not a comment then 
                    // it is a row of cells and needs to be iterated through.
                    else
                    {
                        for (int xPos = 0; xPos < row.Length; xPos++)
                        {
                            // If row[xPos] is a '1'
                            // set the corresponding cell in the universe to alive.
                            if (row[xPos] == '1') universe[xPos, rowNum] = true;
                            // If row[xPos] is a '0'
                            // set the corresponding cell in the universe to dead.
                            else universe[xPos, rowNum] = false;
                        }
                    }
                    rowNum++;
                }
                // Close the file.
                reader.Close();
                graphicsPanel1.Invalidate();
            }
        }

        int CountingNeighbors(int x, int y, bool universType)
        {
            if (universType == true)
            {
                return CountingNeighborsT(x,y);
            }
            else { return CountNeighborsFinite(x, y); }
        }
        private int CountingNeighborsT(int x, int y) //torodial border option
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
        private int CountNeighborsFinite(int x, int y)
        {
            int count = 0;
            int xLen = universe.GetLength(0);
            int yLen = universe.GetLength(1);
            for (int yOffset = -1; yOffset <= 1; yOffset++)
            {
                for (int xOffset = -1; xOffset <= 1; xOffset++)
                {
                    int xCheck = x + xOffset;
                    int yCheck = y + yOffset;
                    if (xOffset == 0 && yOffset == 0)
                    { continue;}
                    if (xCheck < 0)
                    { continue;}
                    if (yCheck < 0)
                    { continue;}
                    if (xCheck >= xLen)
                    { continue;}
                    if (yCheck >= yLen)
                    { continue;}
                    if (universe[xCheck, yCheck] == true) count++;
                }
            }
            return count;
        }

        public Form1()
        {
            InitializeComponent();

            // Setup the timer
            timer.Interval = genTimer; // milliseconds
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
                    int neighbors = CountingNeighbors(i, j, universeType);
                    if (universe[i, j] == true && (neighbors < 2))
                    { scratchpad[i, j] = false; }
                    else if (universe[i, j] == true && (neighbors > 3))
                    { scratchpad[i, j] = false; }
                    else if (universe[i, j] == true && (neighbors == 3 || neighbors == 2))
                    { scratchpad[i, j] = true; }
                    else if (universe[i, j] == false && (neighbors == 3))
                    { scratchpad[i, j] = true; }
                }
            }
            bool[,] temp = universe;
            universe = scratchpad;
            scratchpad = temp;
            for (int i = 0; i < scratchpad.GetLength(0); i++) //empties the scratchpad
            {
                for (int j = 0; j < scratchpad.GetLength(1); j++)
                {
                    scratchpad[i, j] = false;
                }
            }

            // Increment generation count
            generations++;

            // Update all status strips
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            toolStripSeedLabel.Text = "Seed = " + seed.ToString();
            toolStripLivingCells.Text = "Living Cells =" + NumAlive();
            if( universeType == true)
            { toolStripStatusLabelUniverseType.Text = "UniverseType = Toroidal"; }
            else { toolStripStatusLabelUniverseType.Text = "UniverseType = Finite"; }
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
            //setting the background color
            graphicsPanel1.BackColor = backColor;
            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);
            if (showGrid == false)
            { gridPen.Color = Color.Transparent; }

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
                    Font font = new Font("Arial", 8f);

                    if (CountingNeighbors(x, y, universeType) > 0 && (showNeighborCount == true))
                    {
                        StringFormat stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Center;

                        int neighbors = CountingNeighbors(x, y, universeType);

                        e.Graphics.DrawString(neighbors.ToString(), font, Brushes.Black, cellRect, stringFormat);
                    }
                }
            }
            //HUD
            string bordertype;
            if(universeType == true)
            {
                bordertype = "Torodial";
            }
            else { bordertype = "Finite"; }

            Font HUDFont = new Font("Arial", 15);

            Rectangle hud = Rectangle.Empty;
            hud.Y = graphicsPanel1.ClientSize.Height - 130;

            if (showHUD == true)
            {
                e.Graphics.DrawString($"Generation = {generations}\nCell Count = {NumAlive()}\nUniverse Type = {bordertype}\nUniverse Size = {worldWidth} x {worldHeight}", 
                    HUDFont, Brushes.Black, hud);
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

        #endregion
        #region Buttons
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
            NewWorld();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.x = worldWidth;
            options.y = worldHeight;
            options.timer = genTimer;
            options.seed = seed;
            options.Cell = cellColor;
            options.Background = backColor;
            options.Grid = gridColor;
            if (options.ShowDialog() == DialogResult.OK)
            {
                seed = options.seed;
                worldWidth = options.x;
                worldHeight = options.y;
                genTimer = options.timer;
                timer.Interval = genTimer;
                cellColor = options.Cell;
                gridColor = options.Grid;
                backColor = options.Background;
                graphicsPanel1.BackColor = backColor;

                universe = new bool [worldWidth, worldHeight];
                scratchpad = new bool [worldWidth, worldHeight];
                NewWorld();
            }
        }

        private void UniverseTypeButton_Click(object sender, EventArgs e)
        {
            universeType = !universeType;
            graphicsPanel1.Invalidate();
        }

        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showGrid = !showGrid;
            graphicsPanel1.Invalidate();
        }

        private void neighborCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showNeighborCount = !showNeighborCount;
            graphicsPanel1.Invalidate();
        }

        private void hUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showHUD = !showHUD;
            graphicsPanel1.Invalidate ();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.UniverseType = universeType;
            Properties.Settings.Default.ShowGrid = showGrid;
            Properties.Settings.Default.ShowNeighborCount = showNeighborCount;
            Properties.Settings.Default.ShowHUD = showHUD;
            Properties.Settings.Default.GenTimer = genTimer; 
            Properties.Settings.Default.WorldWidth = worldWidth; 
            Properties.Settings.Default.WorldHeight = worldHeight;
            Properties.Settings.Default.GridColor = gridColor;
            Properties.Settings.Default.CellColor = cellColor;
            Properties.Settings.Default.BackgroundColor = backColor;

            Properties.Settings.Default.Save();
        }

        private void resetSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();

            universeType = Properties.Settings.Default.UniverseType;
            showGrid = Properties.Settings.Default.ShowGrid;
            showNeighborCount = Properties.Settings.Default.ShowNeighborCount;
            showHUD = Properties.Settings.Default.ShowHUD;
            genTimer = Properties.Settings.Default.GenTimer;
            worldWidth = Properties.Settings.Default.WorldWidth;
            worldHeight = Properties.Settings.Default.WorldHeight;
            gridColor = Properties.Settings.Default.GridColor;
            cellColor = Properties.Settings.Default.CellColor;
            backColor = Properties.Settings.Default.BackgroundColor;

            graphicsPanel1.BackColor = backColor;
            universe = new bool [worldWidth, worldHeight];
            scratchpad = new bool [worldWidth, worldHeight];
            graphicsPanel1.Invalidate();
        }
    }
} 
#endregion
