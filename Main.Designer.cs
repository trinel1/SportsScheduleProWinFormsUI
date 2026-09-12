
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            createScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            createTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewAlertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewAlertContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewClubsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewCoachesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editorToolStripMenuItemFields = new System.Windows.Forms.ToolStripMenuItem();
            viewLeaguesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            viewLocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewRefereesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewSeasonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewTournamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnGameEditor = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            sendWeatherAlertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            sendFieldClosedAlertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            sendSeasonStartAlertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dBStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            dataGridView1 = new System.Windows.Forms.DataGridView();
            button1 = new System.Windows.Forms.Button();
            saveFileDialogExport = new System.Windows.Forms.SaveFileDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, toolStripMenuItem2, toolStripMenuItem1, dBStatusToolStripMenuItem, toolStripTextBox1 });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(1221, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(46, 27);
            fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { createScheduleToolStripMenuItem, createTeamsToolStripMenuItem, exportScheduleToolStripMenuItem, exportTeamsToolStripMenuItem, dataToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(72, 27);
            toolStripMenuItem2.Text = "Actions";
            // 
            // createScheduleToolStripMenuItem
            // 
            createScheduleToolStripMenuItem.Name = "createScheduleToolStripMenuItem";
            createScheduleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            createScheduleToolStripMenuItem.Text = "Create Schedule";
            createScheduleToolStripMenuItem.Click += createScheduleToolStripMenuItem_Click;
            // 
            // createTeamsToolStripMenuItem
            // 
            createTeamsToolStripMenuItem.Name = "createTeamsToolStripMenuItem";
            createTeamsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            createTeamsToolStripMenuItem.Text = "Create Teams";
            // 
            // exportScheduleToolStripMenuItem
            // 
            exportScheduleToolStripMenuItem.Name = "exportScheduleToolStripMenuItem";
            exportScheduleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            exportScheduleToolStripMenuItem.Text = "Export Schedule";
            exportScheduleToolStripMenuItem.Click += exportScheduleToolStripMenuItem_Click;
            // 
            // exportTeamsToolStripMenuItem
            // 
            exportTeamsToolStripMenuItem.Name = "exportTeamsToolStripMenuItem";
            exportTeamsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            exportTeamsToolStripMenuItem.Text = "Export Teams";
            // 
            // dataToolStripMenuItem
            // 
            dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { viewAlertsToolStripMenuItem, viewAlertContactsToolStripMenuItem, viewClubsToolStripMenuItem, viewCoachesToolStripMenuItem, viewFieldsToolStripMenuItem, viewLeaguesToolStripMenuItem, viewLocationsToolStripMenuItem, viewRefereesToolStripMenuItem, viewSeasonsToolStripMenuItem, viewTeamToolStripMenuItem, viewTournamentsToolStripMenuItem, viewGamesToolStripMenuItem });
            dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            dataToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            dataToolStripMenuItem.Text = "Data";
            // 
            // viewAlertsToolStripMenuItem
            // 
            viewAlertsToolStripMenuItem.Name = "viewAlertsToolStripMenuItem";
            viewAlertsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            viewAlertsToolStripMenuItem.Text = "View Alerts";
            viewAlertsToolStripMenuItem.Click += viewAlertsToolStripMenuItem_Click;
            // 
            // viewAlertContactsToolStripMenuItem
            // 
            viewAlertContactsToolStripMenuItem.Name = "viewAlertContactsToolStripMenuItem";
            viewAlertContactsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            viewAlertContactsToolStripMenuItem.Text = "View AlertContacts";
            viewAlertContactsToolStripMenuItem.Click += viewAlertContactsToolStripMenuItem_Click;
            // 
            // viewClubsToolStripMenuItem
            // 
            viewClubsToolStripMenuItem.Name = "viewClubsToolStripMenuItem";
            viewClubsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            viewClubsToolStripMenuItem.Text = "View Clubs";
            viewClubsToolStripMenuItem.Click += viewClubsToolStripMenuItem_Click;
            // 
            // viewCoachesToolStripMenuItem
            // 
            viewCoachesToolStripMenuItem.Name = "viewCoachesToolStripMenuItem";
            viewCoachesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            viewCoachesToolStripMenuItem.Text = "View Coaches";
            viewCoachesToolStripMenuItem.Click += viewCoachesToolStripMenuItem_Click;
            // 
            // viewFieldsToolStripMenuItem
            // 
            viewFieldsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { editorToolStripMenuItemFields });
            viewFieldsToolStripMenuItem.Name = "viewFieldsToolStripMenuItem";
            viewFieldsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            viewFieldsToolStripMenuItem.Text = "View Fields";
            viewFieldsToolStripMenuItem.Click += viewFieldsToolStripMenuItem_Click;
            // 
            // editorToolStripMenuItemFields
            // 
            editorToolStripMenuItemFields.Name = "editorToolStripMenuItemFields";
            editorToolStripMenuItemFields.Size = new System.Drawing.Size(132, 26);
            editorToolStripMenuItemFields.Text = "Editor";
            editorToolStripMenuItemFields.Click += editorFields_Click;
            // 
            // viewLeaguesToolStripMenuItem
            // 
            viewLeaguesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { editorToolStripMenuItem1 });
            viewLeaguesToolStripMenuItem.Name = "viewLeaguesToolStripMenuItem";
            viewLeaguesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            viewLeaguesToolStripMenuItem.Text = "View Leagues";
            viewLeaguesToolStripMenuItem.Click += viewLeaguesToolStripMenuItem_Click;
            // 
            // editorToolStripMenuItem1
            // 
            editorToolStripMenuItem1.Name = "editorToolStripMenuItem1";
            editorToolStripMenuItem1.Size = new System.Drawing.Size(132, 26);
            editorToolStripMenuItem1.Text = "Editor";
            editorToolStripMenuItem1.Click += editorToolStripMenuItem1_Click;
            // 
            // viewLocationsToolStripMenuItem
            // 
            viewLocationsToolStripMenuItem.Name = "viewLocationsToolStripMenuItem";
            viewLocationsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            viewLocationsToolStripMenuItem.Text = "View Locations";
            viewLocationsToolStripMenuItem.Click += viewLocationsToolStripMenuItem_Click;
            // 
            // viewRefereesToolStripMenuItem
            // 
            viewRefereesToolStripMenuItem.Name = "viewRefereesToolStripMenuItem";
            viewRefereesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            viewRefereesToolStripMenuItem.Text = "View Referees";
            viewRefereesToolStripMenuItem.Click += viewRefereesToolStripMenuItem_Click;
            // 
            // viewSeasonsToolStripMenuItem
            // 
            viewSeasonsToolStripMenuItem.Name = "viewSeasonsToolStripMenuItem";
            viewSeasonsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            viewSeasonsToolStripMenuItem.Text = "View Seasons";
            viewSeasonsToolStripMenuItem.Click += viewSeasonsToolStripMenuItem_Click;
            // 
            // viewTeamToolStripMenuItem
            // 
            viewTeamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { editorToolStripMenuItem });
            viewTeamToolStripMenuItem.Name = "viewTeamToolStripMenuItem";
            viewTeamToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            viewTeamToolStripMenuItem.Text = "View Teams";
            viewTeamToolStripMenuItem.Click += viewTeamToolStripMenuItem_Click;
            // 
            // editorToolStripMenuItem
            // 
            editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            editorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            editorToolStripMenuItem.Text = "Editor";
            editorToolStripMenuItem.Click += editorToolStripMenuItem_Click;
            // 
            // viewTournamentsToolStripMenuItem
            // 
            viewTournamentsToolStripMenuItem.Name = "viewTournamentsToolStripMenuItem";
            viewTournamentsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            viewTournamentsToolStripMenuItem.Text = "View Tournaments";
            viewTournamentsToolStripMenuItem.Click += viewTournamentsToolStripMenuItem_Click;
            // 
            // viewGamesToolStripMenuItem
            // 
            viewGamesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btnGameEditor });
            viewGamesToolStripMenuItem.Name = "viewGamesToolStripMenuItem";
            viewGamesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            viewGamesToolStripMenuItem.Text = "View Games";
            // 
            // btnGameEditor
            // 
            btnGameEditor.Name = "btnGameEditor";
            btnGameEditor.Size = new System.Drawing.Size(132, 26);
            btnGameEditor.Text = "Editor";
            btnGameEditor.Click += btnGameEditor_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { sendWeatherAlertToolStripMenuItem, sendFieldClosedAlertToolStripMenuItem, sendSeasonStartAlertToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(61, 27);
            toolStripMenuItem1.Text = "Alerts";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // sendWeatherAlertToolStripMenuItem
            // 
            sendWeatherAlertToolStripMenuItem.Name = "sendWeatherAlertToolStripMenuItem";
            sendWeatherAlertToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            sendWeatherAlertToolStripMenuItem.Text = "Send Weather Alert";
            sendWeatherAlertToolStripMenuItem.Click += sendWeatherAlertToolStripMenuItem_Click;
            // 
            // sendFieldClosedAlertToolStripMenuItem
            // 
            sendFieldClosedAlertToolStripMenuItem.Name = "sendFieldClosedAlertToolStripMenuItem";
            sendFieldClosedAlertToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            sendFieldClosedAlertToolStripMenuItem.Text = "Send Field Closed Alert";
            // 
            // sendSeasonStartAlertToolStripMenuItem
            // 
            sendSeasonStartAlertToolStripMenuItem.Name = "sendSeasonStartAlertToolStripMenuItem";
            sendSeasonStartAlertToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            sendSeasonStartAlertToolStripMenuItem.Text = "Send Season Start Alert";
            // 
            // dBStatusToolStripMenuItem
            // 
            dBStatusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { connectToolStripMenuItem, disconnectToolStripMenuItem });
            dBStatusToolStripMenuItem.Name = "dBStatusToolStripMenuItem";
            dBStatusToolStripMenuItem.Size = new System.Drawing.Size(87, 27);
            dBStatusToolStripMenuItem.Text = "DB Status";
            // 
            // connectToolStripMenuItem
            // 
            connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            connectToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            connectToolStripMenuItem.Text = "Connect";
            connectToolStripMenuItem.Click += connectToolStripMenuItem_Click;
            // 
            // disconnectToolStripMenuItem
            // 
            disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            disconnectToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            disconnectToolStripMenuItem.Text = "Disconnect";
            disconnectToolStripMenuItem.Click += disconnectToolStripMenuItem_Click;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.BackColor = System.Drawing.Color.DarkRed;
            toolStripTextBox1.Enabled = false;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(600, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(617, 579);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(853, 729);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(109, 29);
            button1.TabIndex = 2;
            button1.Text = "Add New ✨";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1221, 616);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "SportsSchedulePro";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.ToolStripMenuItem viewGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnGameEditor;
    }
}

