
namespace SportsSchedulePro
{
    partial class LeagueEditor
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
            this.dataGridViewLeagues = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBoxClubs = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBoxFields = new System.Windows.Forms.CheckedListBox();
            this.comboBoxClub = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxDeleteLeague = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownGameLength = new System.Windows.Forms.NumericUpDown();
            this.textBoxLeagueName = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxAgeGroup = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerStartingAge = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndingAge = new System.Windows.Forms.DateTimePicker();
            this.gbDates = new System.Windows.Forms.GroupBox();
            this.dateTimePickerSundayEarliestTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSaturdayEarliestTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerWeekdayEarliestTime = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownSundaySlots = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSaturdaySlots = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWeekdaySlots = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownPlayEachTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeagues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGameLength)).BeginInit();
            this.gbDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSundaySlots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaturdaySlots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeekdaySlots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayEachTime)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLeagues
            // 
            this.dataGridViewLeagues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeagues.Location = new System.Drawing.Point(682, 13);
            this.dataGridViewLeagues.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewLeagues.MultiSelect = false;
            this.dataGridViewLeagues.Name = "dataGridViewLeagues";
            this.dataGridViewLeagues.RowHeadersWidth = 51;
            this.dataGridViewLeagues.RowTemplate.Height = 25;
            this.dataGridViewLeagues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLeagues.Size = new System.Drawing.Size(669, 759);
            this.dataGridViewLeagues.TabIndex = 0;
            this.dataGridViewLeagues.SelectionChanged += new System.EventHandler(this.dataGridViewLeagues_SelectionChanged);
            this.dataGridViewLeagues.DoubleClick += new System.EventHandler(this.dataGridViewLeagues_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(945, 778);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Post Properties ⚡";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBoxClubs
            // 
            this.checkedListBoxClubs.FormattingEnabled = true;
            this.checkedListBoxClubs.Location = new System.Drawing.Point(16, 524);
            this.checkedListBoxClubs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListBoxClubs.Name = "checkedListBoxClubs";
            this.checkedListBoxClubs.Size = new System.Drawing.Size(11, 4);
            this.checkedListBoxClubs.TabIndex = 2;
            this.checkedListBoxClubs.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(37, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Club";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(37, 621);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fields";
            // 
            // checkedListBoxFields
            // 
            this.checkedListBoxFields.FormattingEnabled = true;
            this.checkedListBoxFields.Location = new System.Drawing.Point(37, 645);
            this.checkedListBoxFields.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListBoxFields.Name = "checkedListBoxFields";
            this.checkedListBoxFields.Size = new System.Drawing.Size(428, 136);
            this.checkedListBoxFields.TabIndex = 4;
            // 
            // comboBoxClub
            // 
            this.comboBoxClub.FormattingEnabled = true;
            this.comboBoxClub.Location = new System.Drawing.Point(37, 575);
            this.comboBoxClub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxClub.Name = "comboBoxClub";
            this.comboBoxClub.Size = new System.Drawing.Size(428, 28);
            this.comboBoxClub.TabIndex = 6;
            this.comboBoxClub.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Age Group";
            // 
            // checkBoxDeleteLeague
            // 
            this.checkBoxDeleteLeague.AutoSize = true;
            this.checkBoxDeleteLeague.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDeleteLeague.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxDeleteLeague.Location = new System.Drawing.Point(593, 31);
            this.checkBoxDeleteLeague.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxDeleteLeague.Name = "checkBoxDeleteLeague";
            this.checkBoxDeleteLeague.Size = new System.Drawing.Size(83, 24);
            this.checkBoxDeleteLeague.TabIndex = 10;
            this.checkBoxDeleteLeague.Text = "Delete?";
            this.checkBoxDeleteLeague.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxDeleteLeague.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.checkBoxDeleteLeague.UseVisualStyleBackColor = true;
            this.checkBoxDeleteLeague.CheckedChanged += new System.EventHandler(this.checkBoxDeleteLeague_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Length (Minutes)";
            // 
            // numericUpDownGameLength
            // 
            this.numericUpDownGameLength.Location = new System.Drawing.Point(37, 149);
            this.numericUpDownGameLength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownGameLength.Name = "numericUpDownGameLength";
            this.numericUpDownGameLength.Size = new System.Drawing.Size(114, 27);
            this.numericUpDownGameLength.TabIndex = 12;
            // 
            // textBoxLeagueName
            // 
            this.textBoxLeagueName.Location = new System.Drawing.Point(37, 57);
            this.textBoxLeagueName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLeagueName.Name = "textBoxLeagueName";
            this.textBoxLeagueName.Size = new System.Drawing.Size(114, 27);
            this.textBoxLeagueName.TabIndex = 13;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(166, 57);
            this.comboBoxGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(103, 28);
            this.comboBoxGender.TabIndex = 14;
            // 
            // comboBoxAgeGroup
            // 
            this.comboBoxAgeGroup.FormattingEnabled = true;
            this.comboBoxAgeGroup.Items.AddRange(new object[] {
            "U5",
            "U6",
            "U7",
            "U8",
            "U10",
            "U13"});
            this.comboBoxAgeGroup.Location = new System.Drawing.Point(288, 57);
            this.comboBoxAgeGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxAgeGroup.Name = "comboBoxAgeGroup";
            this.comboBoxAgeGroup.Size = new System.Drawing.Size(97, 28);
            this.comboBoxAgeGroup.TabIndex = 15;
            this.comboBoxAgeGroup.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Starting Age";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ending Age";
            // 
            // dateTimePickerStartingAge
            // 
            this.dateTimePickerStartingAge.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartingAge.Location = new System.Drawing.Point(18, 56);
            this.dateTimePickerStartingAge.Name = "dateTimePickerStartingAge";
            this.dateTimePickerStartingAge.Size = new System.Drawing.Size(114, 27);
            this.dateTimePickerStartingAge.TabIndex = 18;
            // 
            // dateTimePickerEndingAge
            // 
            this.dateTimePickerEndingAge.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndingAge.Location = new System.Drawing.Point(151, 56);
            this.dateTimePickerEndingAge.Name = "dateTimePickerEndingAge";
            this.dateTimePickerEndingAge.Size = new System.Drawing.Size(103, 27);
            this.dateTimePickerEndingAge.TabIndex = 19;
            // 
            // gbDates
            // 
            this.gbDates.Controls.Add(this.dateTimePickerSundayEarliestTime);
            this.gbDates.Controls.Add(this.dateTimePickerSaturdayEarliestTime);
            this.gbDates.Controls.Add(this.dateTimePickerWeekdayEarliestTime);
            this.gbDates.Controls.Add(this.numericUpDownSundaySlots);
            this.gbDates.Controls.Add(this.numericUpDownSaturdaySlots);
            this.gbDates.Controls.Add(this.numericUpDownWeekdaySlots);
            this.gbDates.Controls.Add(this.label16);
            this.gbDates.Controls.Add(this.label14);
            this.gbDates.Controls.Add(this.label15);
            this.gbDates.Controls.Add(this.label13);
            this.gbDates.Controls.Add(this.label12);
            this.gbDates.Controls.Add(this.label9);
            this.gbDates.Controls.Add(this.dateTimePickerEndDate);
            this.gbDates.Controls.Add(this.label10);
            this.gbDates.Controls.Add(this.dateTimePickerStartDate);
            this.gbDates.Controls.Add(this.label7);
            this.gbDates.Controls.Add(this.dateTimePickerEndingAge);
            this.gbDates.Controls.Add(this.label8);
            this.gbDates.Controls.Add(this.dateTimePickerStartingAge);
            this.gbDates.ForeColor = System.Drawing.Color.SeaGreen;
            this.gbDates.Location = new System.Drawing.Point(37, 247);
            this.gbDates.Name = "gbDates";
            this.gbDates.Size = new System.Drawing.Size(529, 291);
            this.gbDates.TabIndex = 20;
            this.gbDates.TabStop = false;
            this.gbDates.Text = "Dates/Times";
            // 
            // dateTimePickerSundayEarliestTime
            // 
            this.dateTimePickerSundayEarliestTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerSundayEarliestTime.Location = new System.Drawing.Point(253, 257);
            this.dateTimePickerSundayEarliestTime.Name = "dateTimePickerSundayEarliestTime";
            this.dateTimePickerSundayEarliestTime.Size = new System.Drawing.Size(119, 27);
            this.dateTimePickerSundayEarliestTime.TabIndex = 34;
            // 
            // dateTimePickerSaturdayEarliestTime
            // 
            this.dateTimePickerSaturdayEarliestTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerSaturdayEarliestTime.Location = new System.Drawing.Point(253, 229);
            this.dateTimePickerSaturdayEarliestTime.Name = "dateTimePickerSaturdayEarliestTime";
            this.dateTimePickerSaturdayEarliestTime.Size = new System.Drawing.Size(119, 27);
            this.dateTimePickerSaturdayEarliestTime.TabIndex = 33;
            // 
            // dateTimePickerWeekdayEarliestTime
            // 
            this.dateTimePickerWeekdayEarliestTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerWeekdayEarliestTime.Location = new System.Drawing.Point(253, 202);
            this.dateTimePickerWeekdayEarliestTime.Name = "dateTimePickerWeekdayEarliestTime";
            this.dateTimePickerWeekdayEarliestTime.Size = new System.Drawing.Size(119, 27);
            this.dateTimePickerWeekdayEarliestTime.TabIndex = 32;
            // 
            // numericUpDownSundaySlots
            // 
            this.numericUpDownSundaySlots.Location = new System.Drawing.Point(378, 257);
            this.numericUpDownSundaySlots.Name = "numericUpDownSundaySlots";
            this.numericUpDownSundaySlots.Size = new System.Drawing.Size(132, 27);
            this.numericUpDownSundaySlots.TabIndex = 31;
            // 
            // numericUpDownSaturdaySlots
            // 
            this.numericUpDownSaturdaySlots.Location = new System.Drawing.Point(378, 229);
            this.numericUpDownSaturdaySlots.Name = "numericUpDownSaturdaySlots";
            this.numericUpDownSaturdaySlots.Size = new System.Drawing.Size(132, 27);
            this.numericUpDownSaturdaySlots.TabIndex = 30;
            this.numericUpDownSaturdaySlots.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDownWeekdaySlots
            // 
            this.numericUpDownWeekdaySlots.Location = new System.Drawing.Point(378, 201);
            this.numericUpDownWeekdaySlots.Name = "numericUpDownWeekdaySlots";
            this.numericUpDownWeekdaySlots.Size = new System.Drawing.Size(132, 27);
            this.numericUpDownWeekdaySlots.TabIndex = 29;
            this.numericUpDownWeekdaySlots.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(253, 178);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 20);
            this.label16.TabIndex = 28;
            this.label16.Text = "Earliest Game";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 258);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Sunday Earliest Game";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(378, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "Time Slots Per Day";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Saturday Earliest Game";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Weekday Earliest Game";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "League Start";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(151, 129);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(103, 27);
            this.dateTimePickerEndDate.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(145, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "League End";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(18, 129);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(114, 27);
            this.dateTimePickerStartDate.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(288, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Play Each Time";
            // 
            // numericUpDownPlayEachTime
            // 
            this.numericUpDownPlayEachTime.Location = new System.Drawing.Point(288, 148);
            this.numericUpDownPlayEachTime.Name = "numericUpDownPlayEachTime";
            this.numericUpDownPlayEachTime.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownPlayEachTime.TabIndex = 22;
            this.numericUpDownPlayEachTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LeagueEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 815);
            this.Controls.Add(this.numericUpDownPlayEachTime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gbDates);
            this.Controls.Add(this.comboBoxAgeGroup);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textBoxLeagueName);
            this.Controls.Add(this.numericUpDownGameLength);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxDeleteLeague);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxClub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBoxFields);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxClubs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewLeagues);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LeagueEditor";
            this.Text = "LeagueEditor";
            this.Load += new System.EventHandler(this.LeagueEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeagues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGameLength)).EndInit();
            this.gbDates.ResumeLayout(false);
            this.gbDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSundaySlots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaturdaySlots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeekdaySlots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayEachTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLeagues;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBoxClubs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBoxFields;
        private System.Windows.Forms.ComboBox comboBoxClub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxDeleteLeague;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownGameLength;
        private System.Windows.Forms.TextBox textBoxLeagueName;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxAgeGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartingAge;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndingAge;
        private System.Windows.Forms.GroupBox gbDates;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDownPlayEachTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerSundayEarliestTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerSaturdayEarliestTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerWeekdayEarliestTime;
        private System.Windows.Forms.NumericUpDown numericUpDownSundaySlots;
        private System.Windows.Forms.NumericUpDown numericUpDownSaturdaySlots;
        private System.Windows.Forms.NumericUpDown numericUpDownWeekdaySlots;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}