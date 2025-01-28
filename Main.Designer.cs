
namespace SportsSchedulePro
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.createScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAlertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAlertContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewClubsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCoachesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItemFields = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLeaguesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRefereesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSeasonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTournamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sendWeatherAlertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFieldClosedAlertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendSeasonStartAlertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialogExport = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.dBStatusToolStripMenuItem,
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1220, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createScheduleToolStripMenuItem,
            this.createTeamsToolStripMenuItem,
            this.exportScheduleToolStripMenuItem,
            this.exportTeamsToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(72, 27);
            this.toolStripMenuItem2.Text = "Actions";
            // 
            // createScheduleToolStripMenuItem
            // 
            this.createScheduleToolStripMenuItem.Name = "createScheduleToolStripMenuItem";
            this.createScheduleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createScheduleToolStripMenuItem.Text = "Create Schedule";
            this.createScheduleToolStripMenuItem.Click += new System.EventHandler(this.createScheduleToolStripMenuItem_Click);
            // 
            // createTeamsToolStripMenuItem
            // 
            this.createTeamsToolStripMenuItem.Name = "createTeamsToolStripMenuItem";
            this.createTeamsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createTeamsToolStripMenuItem.Text = "Create Teams";
            // 
            // exportScheduleToolStripMenuItem
            // 
            this.exportScheduleToolStripMenuItem.Name = "exportScheduleToolStripMenuItem";
            this.exportScheduleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportScheduleToolStripMenuItem.Text = "Export Schedule";
            this.exportScheduleToolStripMenuItem.Click += new System.EventHandler(this.exportScheduleToolStripMenuItem_Click);
            // 
            // exportTeamsToolStripMenuItem
            // 
            this.exportTeamsToolStripMenuItem.Name = "exportTeamsToolStripMenuItem";
            this.exportTeamsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportTeamsToolStripMenuItem.Text = "Export Teams";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAlertsToolStripMenuItem,
            this.viewAlertContactsToolStripMenuItem,
            this.viewClubsToolStripMenuItem,
            this.viewCoachesToolStripMenuItem,
            this.viewFieldsToolStripMenuItem,
            this.viewLeaguesToolStripMenuItem,
            this.viewLocationsToolStripMenuItem,
            this.viewRefereesToolStripMenuItem,
            this.viewSeasonsToolStripMenuItem,
            this.viewTeamToolStripMenuItem,
            this.viewTournamentsToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // viewAlertsToolStripMenuItem
            // 
            this.viewAlertsToolStripMenuItem.Name = "viewAlertsToolStripMenuItem";
            this.viewAlertsToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.viewAlertsToolStripMenuItem.Text = "View Alerts";
            this.viewAlertsToolStripMenuItem.Click += new System.EventHandler(this.viewAlertsToolStripMenuItem_Click);
            // 
            // viewAlertContactsToolStripMenuItem
            // 
            this.viewAlertContactsToolStripMenuItem.Name = "viewAlertContactsToolStripMenuItem";
            this.viewAlertContactsToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.viewAlertContactsToolStripMenuItem.Text = "View AlertContacts";
            // 
            // viewClubsToolStripMenuItem
            // 
            this.viewClubsToolStripMenuItem.Name = "viewClubsToolStripMenuItem";
            this.viewClubsToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.viewClubsToolStripMenuItem.Text = "View Clubs";
            // 
            // viewCoachesToolStripMenuItem
            // 
            this.viewCoachesToolStripMenuItem.Name = "viewCoachesToolStripMenuItem";
            this.viewCoachesToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.viewCoachesToolStripMenuItem.Text = "View Coaches";
            // 
            // viewFieldsToolStripMenuItem
            // 
            this.viewFieldsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorToolStripMenuItemFields});
            this.viewFieldsToolStripMenuItem.Name = "viewFieldsToolStripMenuItem";
            this.viewFieldsToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.viewFieldsToolStripMenuItem.Text = "View Fields";
            this.viewFieldsToolStripMenuItem.Click += new System.EventHandler(this.viewFieldsToolStripMenuItem_Click);
            // 
            // editorToolStripMenuItemFields
            // 
            this.editorToolStripMenuItemFields.Name = "editorToolStripMenuItemFields";
            this.editorToolStripMenuItemFields.Size = new System.Drawing.Size(132, 26);
            this.editorToolStripMenuItemFields.Text = "Editor";
            this.editorToolStripMenuItemFields.Click += new System.EventHandler(this.editorFields_Click);
            // 
            // viewLeaguesToolStripMenuItem
            // 
            this.viewLeaguesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorToolStripMenuItem1});
            this.viewLeaguesToolStripMenuItem.Name = "viewLeaguesToolStripMenuItem";
            this.viewLeaguesToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.viewLeaguesToolStripMenuItem.Text = "View Leagues";
            this.viewLeaguesToolStripMenuItem.Click += new System.EventHandler(this.viewLeaguesToolStripMenuItem_Click);
            // 
            // editorToolStripMenuItem1
            // 
            this.editorToolStripMenuItem1.Name = "editorToolStripMenuItem1";
            this.editorToolStripMenuItem1.Size = new System.Drawing.Size(132, 26);
            this.editorToolStripMenuItem1.Text = "Editor";
            this.editorToolStripMenuItem1.Click += new System.EventHandler(this.editorToolStripMenuItem1_Click);
            // 
            // viewLocationsToolStripMenuItem
            // 
            this.viewLocationsToolStripMenuItem.Name = "viewLocationsToolStripMenuItem";
            this.viewLocationsToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.viewLocationsToolStripMenuItem.Text = "View Locations";
            // 
            // viewRefereesToolStripMenuItem
            // 
            this.viewRefereesToolStripMenuItem.Name = "viewRefereesToolStripMenuItem";
            this.viewRefereesToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.viewRefereesToolStripMenuItem.Text = "View Referees";
            // 
            // viewSeasonsToolStripMenuItem
            // 
            this.viewSeasonsToolStripMenuItem.Name = "viewSeasonsToolStripMenuItem";
            this.viewSeasonsToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.viewSeasonsToolStripMenuItem.Text = "View Seasons";
            // 
            // viewTeamToolStripMenuItem
            // 
            this.viewTeamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorToolStripMenuItem});
            this.viewTeamToolStripMenuItem.Name = "viewTeamToolStripMenuItem";
            this.viewTeamToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.viewTeamToolStripMenuItem.Text = "View Teams";
            this.viewTeamToolStripMenuItem.Click += new System.EventHandler(this.viewTeamToolStripMenuItem_Click);
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.editorToolStripMenuItem.Text = "Editor";
            this.editorToolStripMenuItem.Click += new System.EventHandler(this.editorToolStripMenuItem_Click);
            // 
            // viewTournamentsToolStripMenuItem
            // 
            this.viewTournamentsToolStripMenuItem.Name = "viewTournamentsToolStripMenuItem";
            this.viewTournamentsToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.viewTournamentsToolStripMenuItem.Text = "View Tournaments";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendWeatherAlertToolStripMenuItem,
            this.sendFieldClosedAlertToolStripMenuItem,
            this.sendSeasonStartAlertToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 27);
            this.toolStripMenuItem1.Text = "Alerts";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // sendWeatherAlertToolStripMenuItem
            // 
            this.sendWeatherAlertToolStripMenuItem.Name = "sendWeatherAlertToolStripMenuItem";
            this.sendWeatherAlertToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.sendWeatherAlertToolStripMenuItem.Text = "Send Weather Alert";
            this.sendWeatherAlertToolStripMenuItem.Click += new System.EventHandler(this.sendWeatherAlertToolStripMenuItem_Click);
            // 
            // sendFieldClosedAlertToolStripMenuItem
            // 
            this.sendFieldClosedAlertToolStripMenuItem.Name = "sendFieldClosedAlertToolStripMenuItem";
            this.sendFieldClosedAlertToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.sendFieldClosedAlertToolStripMenuItem.Text = "Send Field Closed Alert";
            // 
            // sendSeasonStartAlertToolStripMenuItem
            // 
            this.sendSeasonStartAlertToolStripMenuItem.Name = "sendSeasonStartAlertToolStripMenuItem";
            this.sendSeasonStartAlertToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.sendSeasonStartAlertToolStripMenuItem.Text = "Send Season Start Alert";
            // 
            // dBStatusToolStripMenuItem
            // 
            this.dBStatusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.dBStatusToolStripMenuItem.Name = "dBStatusToolStripMenuItem";
            this.dBStatusToolStripMenuItem.Size = new System.Drawing.Size(87, 27);
            this.dBStatusToolStripMenuItem.Text = "DB Status";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.DarkRed;
            this.toolStripTextBox1.Enabled = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(600, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(617, 579);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(853, 729);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add New ✨";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 616);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "SportsSchedulePro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem createScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTeamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportTeamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendWeatherAlertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendFieldClosedAlertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendSeasonStartAlertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAlertsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAlertContactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewClubsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCoachesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewFieldsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLeaguesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLocationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRefereesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSeasonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTournamentsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItemFields;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExport;
    }
}

