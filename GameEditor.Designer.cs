
namespace SportsSchedulePro
{
    partial class GameEditor
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClosureReschedule = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.cbTimeOn = new System.Windows.Forms.CheckBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnWeekDelay = new System.Windows.Forms.Button();
            this.btnShuffleTimes = new System.Windows.Forms.Button();
            this.btnCancelGame = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(365, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(423, 399);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.commandsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.commandsToolStripMenuItem.Text = "Commands";
            // 
            // btnClosureReschedule
            // 
            this.btnClosureReschedule.Location = new System.Drawing.Point(28, 244);
            this.btnClosureReschedule.Name = "btnClosureReschedule";
            this.btnClosureReschedule.Size = new System.Drawing.Size(140, 23);
            this.btnClosureReschedule.TabIndex = 2;
            this.btnClosureReschedule.Text = "Reschedule Day/Time";
            this.btnClosureReschedule.UseVisualStyleBackColor = true;
            this.btnClosureReschedule.Click += new System.EventHandler(this.button1_Click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(28, 188);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(291, 23);
            this.datePicker.TabIndex = 3;
            // 
            // cbTimeOn
            // 
            this.cbTimeOn.AutoSize = true;
            this.cbTimeOn.Location = new System.Drawing.Point(28, 217);
            this.cbTimeOn.Name = "cbTimeOn";
            this.cbTimeOn.Size = new System.Drawing.Size(52, 19);
            this.cbTimeOn.TabIndex = 4;
            this.cbTimeOn.Text = "Time";
            this.cbTimeOn.UseVisualStyleBackColor = true;
            this.cbTimeOn.CheckedChanged += new System.EventHandler(this.cbTimeOn_CheckedChanged);
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(87, 215);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(232, 23);
            this.timePicker.TabIndex = 5;
            this.timePicker.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(28, 307);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 6;
            // 
            // btnWeekDelay
            // 
            this.btnWeekDelay.Location = new System.Drawing.Point(28, 337);
            this.btnWeekDelay.Name = "btnWeekDelay";
            this.btnWeekDelay.Size = new System.Drawing.Size(103, 23);
            this.btnWeekDelay.TabIndex = 7;
            this.btnWeekDelay.Text = "Delay By Week";
            this.btnWeekDelay.UseVisualStyleBackColor = true;
            // 
            // btnShuffleTimes
            // 
            this.btnShuffleTimes.Location = new System.Drawing.Point(253, 337);
            this.btnShuffleTimes.Name = "btnShuffleTimes";
            this.btnShuffleTimes.Size = new System.Drawing.Size(106, 23);
            this.btnShuffleTimes.TabIndex = 8;
            this.btnShuffleTimes.Text = "Shuffle Time";
            this.btnShuffleTimes.UseVisualStyleBackColor = true;
            this.btnShuffleTimes.Click += new System.EventHandler(this.btnShuffleTimes_Click);
            // 
            // btnCancelGame
            // 
            this.btnCancelGame.Location = new System.Drawing.Point(253, 366);
            this.btnCancelGame.Name = "btnCancelGame";
            this.btnCancelGame.Size = new System.Drawing.Size(106, 23);
            this.btnCancelGame.TabIndex = 9;
            this.btnCancelGame.Text = "Cancel Game";
            this.btnCancelGame.UseVisualStyleBackColor = true;
            this.btnCancelGame.Click += new System.EventHandler(this.btnCancelGame_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(28, 60);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(291, 112);
            this.checkedListBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "League";
            // 
            // GameEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnCancelGame);
            this.Controls.Add(this.btnShuffleTimes);
            this.Controls.Add(this.btnWeekDelay);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.cbTimeOn);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.btnClosureReschedule);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameEditor";
            this.Text = "GameEditor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.Button btnClosureReschedule;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.CheckBox cbTimeOn;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnWeekDelay;
        private System.Windows.Forms.Button btnShuffleTimes;
        private System.Windows.Forms.Button btnCancelGame;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
    }
}