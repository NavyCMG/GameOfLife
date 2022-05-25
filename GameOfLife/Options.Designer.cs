namespace GameOfLife
{
    partial class Options
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
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.X = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.UniverseSize = new System.Windows.Forms.Label();
            this.numericUpDownTimer = new System.Windows.Forms.NumericUpDown();
            this.GenTimer = new System.Windows.Forms.Label();
            this.Colors = new System.Windows.Forms.Label();
            this.CellColor = new System.Windows.Forms.Label();
            this.CellColorB = new System.Windows.Forms.Button();
            this.BackgroundColor = new System.Windows.Forms.Label();
            this.BackgroundColorB = new System.Windows.Forms.Button();
            this.GridColor = new System.Windows.Forms.Label();
            this.GridColorB = new System.Windows.Forms.Button();
            this.numericUpDownSeed = new System.Windows.Forms.NumericUpDown();
            this.SeedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeed)).BeginInit();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(300, 415);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(82, 23);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(422, 415);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(377, 111);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownY.TabIndex = 2;
            this.numericUpDownY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(377, 70);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownX.TabIndex = 3;
            this.numericUpDownX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(330, 72);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(17, 13);
            this.X.TabIndex = 4;
            this.X.Text = "X:";
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Location = new System.Drawing.Point(330, 113);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(17, 13);
            this.Y.TabIndex = 5;
            this.Y.Text = "Y:";
            // 
            // UniverseSize
            // 
            this.UniverseSize.AutoSize = true;
            this.UniverseSize.Location = new System.Drawing.Point(232, 72);
            this.UniverseSize.Name = "UniverseSize";
            this.UniverseSize.Size = new System.Drawing.Size(72, 13);
            this.UniverseSize.TabIndex = 6;
            this.UniverseSize.Text = "Universe Size";
            // 
            // numericUpDownTimer
            // 
            this.numericUpDownTimer.Location = new System.Drawing.Point(377, 154);
            this.numericUpDownTimer.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTimer.Name = "numericUpDownTimer";
            this.numericUpDownTimer.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTimer.TabIndex = 7;
            this.numericUpDownTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GenTimer
            // 
            this.GenTimer.AutoSize = true;
            this.GenTimer.Location = new System.Drawing.Point(232, 156);
            this.GenTimer.Name = "GenTimer";
            this.GenTimer.Size = new System.Drawing.Size(88, 13);
            this.GenTimer.TabIndex = 8;
            this.GenTimer.Text = "Generation Timer";
            // 
            // Colors
            // 
            this.Colors.AutoSize = true;
            this.Colors.Location = new System.Drawing.Point(232, 216);
            this.Colors.Name = "Colors";
            this.Colors.Size = new System.Drawing.Size(70, 13);
            this.Colors.TabIndex = 9;
            this.Colors.Text = "Color Options";
            // 
            // CellColor
            // 
            this.CellColor.AutoSize = true;
            this.CellColor.Location = new System.Drawing.Point(330, 216);
            this.CellColor.Name = "CellColor";
            this.CellColor.Size = new System.Drawing.Size(29, 13);
            this.CellColor.TabIndex = 10;
            this.CellColor.Text = "Cells";
            // 
            // CellColorB
            // 
            this.CellColorB.Location = new System.Drawing.Point(422, 211);
            this.CellColorB.Name = "CellColorB";
            this.CellColorB.Size = new System.Drawing.Size(75, 23);
            this.CellColorB.TabIndex = 11;
            this.CellColorB.UseVisualStyleBackColor = true;
            this.CellColorB.Click += new System.EventHandler(this.CellColorB_Click);
            // 
            // BackgroundColor
            // 
            this.BackgroundColor.AutoSize = true;
            this.BackgroundColor.Location = new System.Drawing.Point(330, 262);
            this.BackgroundColor.Name = "BackgroundColor";
            this.BackgroundColor.Size = new System.Drawing.Size(65, 13);
            this.BackgroundColor.TabIndex = 12;
            this.BackgroundColor.Text = "Background";
            // 
            // BackgroundColorB
            // 
            this.BackgroundColorB.Location = new System.Drawing.Point(422, 257);
            this.BackgroundColorB.Name = "BackgroundColorB";
            this.BackgroundColorB.Size = new System.Drawing.Size(75, 23);
            this.BackgroundColorB.TabIndex = 13;
            this.BackgroundColorB.UseVisualStyleBackColor = true;
            this.BackgroundColorB.Click += new System.EventHandler(this.BackgroundColorB_Click);
            // 
            // GridColor
            // 
            this.GridColor.AutoSize = true;
            this.GridColor.Location = new System.Drawing.Point(330, 307);
            this.GridColor.Name = "GridColor";
            this.GridColor.Size = new System.Drawing.Size(26, 13);
            this.GridColor.TabIndex = 14;
            this.GridColor.Text = "Grid";
            // 
            // GridColorB
            // 
            this.GridColorB.Location = new System.Drawing.Point(422, 302);
            this.GridColorB.Name = "GridColorB";
            this.GridColorB.Size = new System.Drawing.Size(75, 23);
            this.GridColorB.TabIndex = 15;
            this.GridColorB.UseVisualStyleBackColor = true;
            this.GridColorB.Click += new System.EventHandler(this.GridColorB_Click);
            // 
            // numericUpDownSeed
            // 
            this.numericUpDownSeed.Location = new System.Drawing.Point(377, 24);
            this.numericUpDownSeed.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDownSeed.Name = "numericUpDownSeed";
            this.numericUpDownSeed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSeed.TabIndex = 16;
            // 
            // SeedLabel
            // 
            this.SeedLabel.AutoSize = true;
            this.SeedLabel.Location = new System.Drawing.Point(267, 26);
            this.SeedLabel.Name = "SeedLabel";
            this.SeedLabel.Size = new System.Drawing.Size(32, 13);
            this.SeedLabel.TabIndex = 17;
            this.SeedLabel.Text = "Seed";
            // 
            // Options
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SeedLabel);
            this.Controls.Add(this.numericUpDownSeed);
            this.Controls.Add(this.GridColorB);
            this.Controls.Add(this.GridColor);
            this.Controls.Add(this.BackgroundColorB);
            this.Controls.Add(this.BackgroundColor);
            this.Controls.Add(this.CellColorB);
            this.Controls.Add(this.CellColor);
            this.Controls.Add(this.Colors);
            this.Controls.Add(this.GenTimer);
            this.Controls.Add(this.numericUpDownTimer);
            this.Controls.Add(this.UniverseSize);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.numericUpDownX);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Label UniverseSize;
        private System.Windows.Forms.NumericUpDown numericUpDownTimer;
        private System.Windows.Forms.Label GenTimer;
        private System.Windows.Forms.Label Colors;
        private System.Windows.Forms.Label CellColor;
        private System.Windows.Forms.Button CellColorB;
        private System.Windows.Forms.Label BackgroundColor;
        private System.Windows.Forms.Button BackgroundColorB;
        private System.Windows.Forms.Label GridColor;
        private System.Windows.Forms.Button GridColorB;
        private System.Windows.Forms.NumericUpDown numericUpDownSeed;
        private System.Windows.Forms.Label SeedLabel;
    }
}