namespace GameOfLife
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelGenerations = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLivingCells = new System.Windows.Forms.ToolStripStatusLabel();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SettingButton = new System.Windows.Forms.ToolStripButton();
            this.PlayButton = new System.Windows.Forms.ToolStripButton();
            this.PauseButton = new System.Windows.Forms.ToolStripButton();
            this.NextGenButton = new System.Windows.Forms.ToolStripButton();
            this.RandomButton = new System.Windows.Forms.ToolStripButton();
            this.UniverseTypeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripStatusLabelUniverseType = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neighborCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicsPanel1 = new GameOfLife.GraphicsPanel();
            this.resetSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelGenerations,
            this.toolStripSeedLabel,
            this.toolStripLivingCells,
            this.toolStripStatusLabelUniverseType});
            this.statusStrip1.Location = new System.Drawing.Point(0, 323);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(573, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelGenerations
            // 
            this.toolStripStatusLabelGenerations.Name = "toolStripStatusLabelGenerations";
            this.toolStripStatusLabelGenerations.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabelGenerations.Text = "Generations = 0";
            // 
            // toolStripSeedLabel
            // 
            this.toolStripSeedLabel.Name = "toolStripSeedLabel";
            this.toolStripSeedLabel.Size = new System.Drawing.Size(52, 17);
            this.toolStripSeedLabel.Text = "Seed = 0";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.SettingButton,
            this.PlayButton,
            this.PauseButton,
            this.NextGenButton,
            this.RandomButton,
            this.UniverseTypeButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(573, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLivingCells
            // 
            this.toolStripLivingCells.Name = "toolStripLivingCells";
            this.toolStripLivingCells.Size = new System.Drawing.Size(87, 17);
            this.toolStripLivingCells.Text = "Living Cells = 0";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "Load";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SettingButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingButton.Image")));
            this.SettingButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(23, 22);
            this.SettingButton.Text = "Options";
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PlayButton.Image = global::GameOfLife.Properties.Resources.Play;
            this.PlayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(23, 22);
            this.PlayButton.Text = "Play";
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PauseButton.Image = global::GameOfLife.Properties.Resources.Pause;
            this.PauseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(23, 22);
            this.PauseButton.Text = "Pause";
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // NextGenButton
            // 
            this.NextGenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextGenButton.Image = global::GameOfLife.Properties.Resources.PlayStep;
            this.NextGenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextGenButton.Name = "NextGenButton";
            this.NextGenButton.Size = new System.Drawing.Size(23, 22);
            this.NextGenButton.Text = "NextGen";
            this.NextGenButton.Click += new System.EventHandler(this.NextGenButton_Click);
            // 
            // RandomButton
            // 
            this.RandomButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RandomButton.Image = ((System.Drawing.Image)(resources.GetObject("RandomButton.Image")));
            this.RandomButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(23, 22);
            this.RandomButton.Text = "Random";
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // UniverseTypeButton
            // 
            this.UniverseTypeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UniverseTypeButton.Image = global::GameOfLife.Properties.Resources.Method;
            this.UniverseTypeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UniverseTypeButton.Name = "UniverseTypeButton";
            this.UniverseTypeButton.Size = new System.Drawing.Size(23, 22);
            this.UniverseTypeButton.Text = "UniverType";
            this.UniverseTypeButton.Click += new System.EventHandler(this.UniverseTypeButton_Click);
            // 
            // toolStripStatusLabelUniverseType
            // 
            this.toolStripStatusLabelUniverseType.Name = "toolStripStatusLabelUniverseType";
            this.toolStripStatusLabelUniverseType.Size = new System.Drawing.Size(132, 17);
            this.toolStripStatusLabelUniverseType.Text = "UniverseType = Torodial";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridToolStripMenuItem,
            this.neighborCountToolStripMenuItem,
            this.hUDToolStripMenuItem,
            this.resetSettingsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.Checked = true;
            this.gridToolStripMenuItem.CheckOnClick = true;
            this.gridToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.gridToolStripMenuItem.Text = "Grid";
            this.gridToolStripMenuItem.Click += new System.EventHandler(this.gridToolStripMenuItem_Click);
            // 
            // neighborCountToolStripMenuItem
            // 
            this.neighborCountToolStripMenuItem.Checked = true;
            this.neighborCountToolStripMenuItem.CheckOnClick = true;
            this.neighborCountToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.neighborCountToolStripMenuItem.Name = "neighborCountToolStripMenuItem";
            this.neighborCountToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.neighborCountToolStripMenuItem.Text = "NeighborCount";
            this.neighborCountToolStripMenuItem.Click += new System.EventHandler(this.neighborCountToolStripMenuItem_Click);
            // 
            // hUDToolStripMenuItem
            // 
            this.hUDToolStripMenuItem.CheckOnClick = true;
            this.hUDToolStripMenuItem.Name = "hUDToolStripMenuItem";
            this.hUDToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.hUDToolStripMenuItem.Text = "HUD";
            this.hUDToolStripMenuItem.Click += new System.EventHandler(this.hUDToolStripMenuItem_Click);
            // 
            // graphicsPanel1
            // 
            this.graphicsPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.graphicsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel1.Location = new System.Drawing.Point(0, 25);
            this.graphicsPanel1.Name = "graphicsPanel1";
            this.graphicsPanel1.Size = new System.Drawing.Size(573, 298);
            this.graphicsPanel1.TabIndex = 3;
            this.graphicsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel1_Paint);
            this.graphicsPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseClick);
            // 
            // resetSettingsToolStripMenuItem
            // 
            this.resetSettingsToolStripMenuItem.Name = "resetSettingsToolStripMenuItem";
            this.resetSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetSettingsToolStripMenuItem.Text = "Reset Settings";
            this.resetSettingsToolStripMenuItem.Click += new System.EventHandler(this.resetSettingsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 345);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.graphicsPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private GraphicsPanel graphicsPanel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGenerations;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton SettingButton;
        private System.Windows.Forms.ToolStripButton PlayButton;
        private System.Windows.Forms.ToolStripButton PauseButton;
        private System.Windows.Forms.ToolStripButton NextGenButton;
        private System.Windows.Forms.ToolStripButton RandomButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSeedLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLivingCells;
        private System.Windows.Forms.ToolStripButton UniverseTypeButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUniverseType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neighborCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hUDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetSettingsToolStripMenuItem;
    }
}

