
namespace SportsSchedulePro
{
    partial class FieldEditor
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
            this.dataGridViewFields = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxClub = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkBoxDeleteField = new System.Windows.Forms.CheckBox();
            this.checkBoxHasLights = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSaturday = new System.Windows.Forms.CheckBox();
            this.checkBoxFriday = new System.Windows.Forms.CheckBox();
            this.checkBoxWednesday = new System.Windows.Forms.CheckBox();
            this.checkBoxTuesday = new System.Windows.Forms.CheckBox();
            this.checkBoxThursday = new System.Windows.Forms.CheckBox();
            this.checkBoxMonday = new System.Windows.Forms.CheckBox();
            this.checkBoxSunday = new System.Windows.Forms.CheckBox();
            this.buttonSaveField = new System.Windows.Forms.Button();
            this.dataGridViewGames = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFields)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFields
            // 
            this.dataGridViewFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFields.Location = new System.Drawing.Point(558, 3);
            this.dataGridViewFields.Name = "dataGridViewFields";
            this.dataGridViewFields.RowHeadersWidth = 51;
            this.dataGridViewFields.RowTemplate.Height = 29;
            this.dataGridViewFields.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFields.Size = new System.Drawing.Size(656, 554);
            this.dataGridViewFields.TabIndex = 0;
            this.dataGridViewFields.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridViewFields.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // comboBoxClub
            // 
            this.comboBoxClub.FormattingEnabled = true;
            this.comboBoxClub.Location = new System.Drawing.Point(32, 131);
            this.comboBoxClub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxClub.Name = "comboBoxClub";
            this.comboBoxClub.Size = new System.Drawing.Size(176, 28);
            this.comboBoxClub.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(32, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Club";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(32, 57);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(176, 27);
            this.textBoxName.TabIndex = 9;
            // 
            // checkBoxDeleteField
            // 
            this.checkBoxDeleteField.AutoSize = true;
            this.checkBoxDeleteField.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDeleteField.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBoxDeleteField.Location = new System.Drawing.Point(394, 48);
            this.checkBoxDeleteField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxDeleteField.Name = "checkBoxDeleteField";
            this.checkBoxDeleteField.Size = new System.Drawing.Size(83, 24);
            this.checkBoxDeleteField.TabIndex = 11;
            this.checkBoxDeleteField.Text = "Delete?";
            this.checkBoxDeleteField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxDeleteField.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.checkBoxDeleteField.UseVisualStyleBackColor = true;
            this.checkBoxDeleteField.CheckedChanged += new System.EventHandler(this.checkBoxDeleteField_CheckedChanged);
            // 
            // checkBoxHasLights
            // 
            this.checkBoxHasLights.AutoSize = true;
            this.checkBoxHasLights.Location = new System.Drawing.Point(267, 57);
            this.checkBoxHasLights.Name = "checkBoxHasLights";
            this.checkBoxHasLights.Size = new System.Drawing.Size(18, 17);
            this.checkBoxHasLights.TabIndex = 12;
            this.checkBoxHasLights.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Has Lights";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSaturday);
            this.groupBox1.Controls.Add(this.checkBoxFriday);
            this.groupBox1.Controls.Add(this.checkBoxWednesday);
            this.groupBox1.Controls.Add(this.checkBoxTuesday);
            this.groupBox1.Controls.Add(this.checkBoxThursday);
            this.groupBox1.Controls.Add(this.checkBoxMonday);
            this.groupBox1.Controls.Add(this.checkBoxSunday);
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(32, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 252);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Open Days";
            // 
            // checkBoxSaturday
            // 
            this.checkBoxSaturday.AutoSize = true;
            this.checkBoxSaturday.Location = new System.Drawing.Point(29, 218);
            this.checkBoxSaturday.Name = "checkBoxSaturday";
            this.checkBoxSaturday.Size = new System.Drawing.Size(89, 24);
            this.checkBoxSaturday.TabIndex = 6;
            this.checkBoxSaturday.Text = "Saturday";
            this.checkBoxSaturday.UseVisualStyleBackColor = true;
            // 
            // checkBoxFriday
            // 
            this.checkBoxFriday.AutoSize = true;
            this.checkBoxFriday.Location = new System.Drawing.Point(29, 188);
            this.checkBoxFriday.Name = "checkBoxFriday";
            this.checkBoxFriday.Size = new System.Drawing.Size(71, 24);
            this.checkBoxFriday.TabIndex = 5;
            this.checkBoxFriday.Text = "Friday";
            this.checkBoxFriday.UseVisualStyleBackColor = true;
            // 
            // checkBoxWednesday
            // 
            this.checkBoxWednesday.AutoSize = true;
            this.checkBoxWednesday.Location = new System.Drawing.Point(29, 128);
            this.checkBoxWednesday.Name = "checkBoxWednesday";
            this.checkBoxWednesday.Size = new System.Drawing.Size(107, 24);
            this.checkBoxWednesday.TabIndex = 4;
            this.checkBoxWednesday.Text = "Wednesday";
            this.checkBoxWednesday.UseVisualStyleBackColor = true;
            // 
            // checkBoxTuesday
            // 
            this.checkBoxTuesday.AutoSize = true;
            this.checkBoxTuesday.Location = new System.Drawing.Point(29, 98);
            this.checkBoxTuesday.Name = "checkBoxTuesday";
            this.checkBoxTuesday.Size = new System.Drawing.Size(85, 24);
            this.checkBoxTuesday.TabIndex = 3;
            this.checkBoxTuesday.Text = "Tuesday";
            this.checkBoxTuesday.UseVisualStyleBackColor = true;
            // 
            // checkBoxThursday
            // 
            this.checkBoxThursday.AutoSize = true;
            this.checkBoxThursday.Location = new System.Drawing.Point(29, 158);
            this.checkBoxThursday.Name = "checkBoxThursday";
            this.checkBoxThursday.Size = new System.Drawing.Size(90, 24);
            this.checkBoxThursday.TabIndex = 2;
            this.checkBoxThursday.Text = "Thursday";
            this.checkBoxThursday.UseVisualStyleBackColor = true;
            // 
            // checkBoxMonday
            // 
            this.checkBoxMonday.AutoSize = true;
            this.checkBoxMonday.Location = new System.Drawing.Point(29, 68);
            this.checkBoxMonday.Name = "checkBoxMonday";
            this.checkBoxMonday.Size = new System.Drawing.Size(85, 24);
            this.checkBoxMonday.TabIndex = 1;
            this.checkBoxMonday.Text = "Monday";
            this.checkBoxMonday.UseVisualStyleBackColor = true;
            // 
            // checkBoxSunday
            // 
            this.checkBoxSunday.AutoSize = true;
            this.checkBoxSunday.Location = new System.Drawing.Point(29, 38);
            this.checkBoxSunday.Name = "checkBoxSunday";
            this.checkBoxSunday.Size = new System.Drawing.Size(79, 24);
            this.checkBoxSunday.TabIndex = 0;
            this.checkBoxSunday.Text = "Sunday";
            this.checkBoxSunday.UseVisualStyleBackColor = true;
            // 
            // buttonSaveField
            // 
            this.buttonSaveField.Location = new System.Drawing.Point(827, 565);
            this.buttonSaveField.Name = "buttonSaveField";
            this.buttonSaveField.Size = new System.Drawing.Size(143, 29);
            this.buttonSaveField.TabIndex = 15;
            this.buttonSaveField.Text = "Post Properties ⚡";
            this.buttonSaveField.UseVisualStyleBackColor = true;
            this.buttonSaveField.Click += new System.EventHandler(this.buttonSaveField_Click);
            // 
            // dataGridViewGames
            // 
            this.dataGridViewGames.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGames.Location = new System.Drawing.Point(32, 441);
            this.dataGridViewGames.Name = "dataGridViewGames";
            this.dataGridViewGames.ReadOnly = true;
            this.dataGridViewGames.RowHeadersWidth = 51;
            this.dataGridViewGames.RowTemplate.Height = 29;
            this.dataGridViewGames.Size = new System.Drawing.Size(423, 151);
            this.dataGridViewGames.TabIndex = 16;
            // 
            // FieldEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 601);
            this.Controls.Add(this.dataGridViewGames);
            this.Controls.Add(this.buttonSaveField);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxHasLights);
            this.Controls.Add(this.checkBoxDeleteField);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxClub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFields);
            this.Name = "FieldEditor";
            this.Text = "FieldEditor";
            this.Load += new System.EventHandler(this.FieldEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFields)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFields;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxClub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxDeleteField;
        private System.Windows.Forms.CheckBox checkBoxHasLights;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxSaturday;
        private System.Windows.Forms.CheckBox checkBoxFriday;
        private System.Windows.Forms.CheckBox checkBoxWednesday;
        private System.Windows.Forms.CheckBox checkBoxTuesday;
        private System.Windows.Forms.CheckBox checkBoxThursday;
        private System.Windows.Forms.CheckBox checkBoxMonday;
        private System.Windows.Forms.CheckBox checkBoxSunday;
        private System.Windows.Forms.Button buttonSaveField;
        private System.Windows.Forms.DataGridView dataGridViewGames;
    }
}