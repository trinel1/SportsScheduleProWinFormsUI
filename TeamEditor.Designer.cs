
namespace SportsSchedulePro
{
    partial class TeamEditor
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTournaments = new System.Windows.Forms.DataGridView();
            this.dataGridViewCoaches = new System.Windows.Forms.DataGridView();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.comboBoxSeason = new System.Windows.Forms.ComboBox();
            this.comboBoxLeague = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dataGridViewGames = new System.Windows.Forms.DataGridView();
            this.lblShirt = new System.Windows.Forms.Label();
            this.lblShort = new System.Windows.Forms.Label();
            this.dataGridViewExcludedDates = new System.Windows.Forms.DataGridView();
            this.checkedListBoxSeasons = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTournaments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoaches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcludedDates)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(676, 33);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(677, 455);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Insert\r\n ✨";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.button2.ForeColor = System.Drawing.Color.Gold;
            this.button2.Location = new System.Drawing.Point(1259, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete 🔥";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.DeleteRowButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(815, 494);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Post Properties ⚡";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Shirt Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Shorts Color";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBoxSeasons);
            this.groupBox1.Controls.Add(this.dataGridViewTournaments);
            this.groupBox1.Controls.Add(this.dataGridViewCoaches);
            this.groupBox1.Controls.Add(this.dataGridViewPlayers);
            this.groupBox1.Controls.Add(this.comboBoxLeague);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(24, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 568);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties";
            // 
            // dataGridViewTournaments
            // 
            this.dataGridViewTournaments.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewTournaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTournaments.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewTournaments.Location = new System.Drawing.Point(7, 452);
            this.dataGridViewTournaments.Name = "dataGridViewTournaments";
            this.dataGridViewTournaments.RowHeadersWidth = 51;
            this.dataGridViewTournaments.RowTemplate.Height = 29;
            this.dataGridViewTournaments.Size = new System.Drawing.Size(246, 110);
            this.dataGridViewTournaments.TabIndex = 10;
            // 
            // dataGridViewCoaches
            // 
            this.dataGridViewCoaches.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewCoaches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoaches.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewCoaches.Location = new System.Drawing.Point(266, 452);
            this.dataGridViewCoaches.Name = "dataGridViewCoaches";
            this.dataGridViewCoaches.RowHeadersWidth = 51;
            this.dataGridViewCoaches.RowTemplate.Height = 29;
            this.dataGridViewCoaches.Size = new System.Drawing.Size(334, 110);
            this.dataGridViewCoaches.TabIndex = 9;
            this.dataGridViewCoaches.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCoaches_CellContentClick);
            this.dataGridViewCoaches.DoubleClick += new System.EventHandler(this.dataGridViewCoaches_DoubleClick);
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Location = new System.Drawing.Point(7, 270);
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.RowHeadersWidth = 51;
            this.dataGridViewPlayers.RowTemplate.Height = 29;
            this.dataGridViewPlayers.Size = new System.Drawing.Size(593, 112);
            this.dataGridViewPlayers.TabIndex = 8;
            this.dataGridViewPlayers.DoubleClick += new System.EventHandler(this.dataGridViewPlayers_DoubleClick);
            // 
            // comboBoxSeason
            // 
            this.comboBoxSeason.FormattingEnabled = true;
            this.comboBoxSeason.Location = new System.Drawing.Point(676, 829);
            this.comboBoxSeason.Name = "comboBoxSeason";
            this.comboBoxSeason.Size = new System.Drawing.Size(259, 28);
            this.comboBoxSeason.TabIndex = 7;
            this.comboBoxSeason.Visible = false;
            this.comboBoxSeason.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBoxLeague
            // 
            this.comboBoxLeague.FormattingEnabled = true;
            this.comboBoxLeague.Location = new System.Drawing.Point(82, 56);
            this.comboBoxLeague.Name = "comboBoxLeague";
            this.comboBoxLeague.Size = new System.Drawing.Size(259, 28);
            this.comboBoxLeague.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tournaments";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Coaches";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Players";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Seasons";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "League";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(676, 548);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Games";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(121, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 20);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "lblName";
            // 
            // dataGridViewGames
            // 
            this.dataGridViewGames.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGames.Location = new System.Drawing.Point(676, 572);
            this.dataGridViewGames.Name = "dataGridViewGames";
            this.dataGridViewGames.RowHeadersWidth = 51;
            this.dataGridViewGames.RowTemplate.Height = 29;
            this.dataGridViewGames.Size = new System.Drawing.Size(677, 179);
            this.dataGridViewGames.TabIndex = 10;
            // 
            // lblShirt
            // 
            this.lblShirt.AutoSize = true;
            this.lblShirt.Location = new System.Drawing.Point(121, 62);
            this.lblShirt.Name = "lblShirt";
            this.lblShirt.Size = new System.Drawing.Size(56, 20);
            this.lblShirt.TabIndex = 11;
            this.lblShirt.Text = "lblShirt";
            // 
            // lblShort
            // 
            this.lblShort.AutoSize = true;
            this.lblShort.Location = new System.Drawing.Point(121, 92);
            this.lblShort.Name = "lblShort";
            this.lblShort.Size = new System.Drawing.Size(61, 20);
            this.lblShort.TabIndex = 12;
            this.lblShort.Text = "lblShort";
            // 
            // dataGridViewExcludedDates
            // 
            this.dataGridViewExcludedDates.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewExcludedDates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExcludedDates.Location = new System.Drawing.Point(290, 33);
            this.dataGridViewExcludedDates.Name = "dataGridViewExcludedDates";
            this.dataGridViewExcludedDates.RowHeadersWidth = 51;
            this.dataGridViewExcludedDates.RowTemplate.Height = 29;
            this.dataGridViewExcludedDates.Size = new System.Drawing.Size(334, 122);
            this.dataGridViewExcludedDates.TabIndex = 13;
            this.dataGridViewExcludedDates.DoubleClick += new System.EventHandler(this.dataGridViewExcludedDates_DoubleClick);
            // 
            // checkedListBoxSeasons
            // 
            this.checkedListBoxSeasons.FormattingEnabled = true;
            this.checkedListBoxSeasons.Location = new System.Drawing.Point(82, 130);
            this.checkedListBoxSeasons.Name = "checkedListBoxSeasons";
            this.checkedListBoxSeasons.Size = new System.Drawing.Size(217, 70);
            this.checkedListBoxSeasons.TabIndex = 11;
            // 
            // TeamEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 767);
            this.Controls.Add(this.dataGridViewExcludedDates);
            this.Controls.Add(this.lblShort);
            this.Controls.Add(this.lblShirt);
            this.Controls.Add(this.dataGridViewGames);
            this.Controls.Add(this.comboBoxSeason);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TeamEditor";
            this.Text = "TeamEditor";
            this.Load += new System.EventHandler(this.TeamEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTournaments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoaches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcludedDates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxLeague;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewTournaments;
        private System.Windows.Forms.DataGridView dataGridViewCoaches;
        private System.Windows.Forms.DataGridView dataGridViewPlayers;
        private System.Windows.Forms.ComboBox comboBoxSeason;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dataGridViewGames;
        private System.Windows.Forms.Label lblShirt;
        private System.Windows.Forms.Label lblShort;
        private System.Windows.Forms.DataGridView dataGridViewExcludedDates;
        private System.Windows.Forms.CheckedListBox checkedListBoxSeasons;
    }
}