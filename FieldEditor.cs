using Microsoft.EntityFrameworkCore;
using SportsScheduleProLibrary.Data;
using SportsScheduleProLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsSchedulePro
{
    public partial class FieldEditor : Form
    {
        private SportsScheduleProDataContext dbc = new SportsScheduleProDataContext();

        public FieldEditor()
        {
            InitializeComponent();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            dbc.Fields.Add(new Field
            {
                IsDeleted = false,
            });
            dbc.SaveChanges();
            dataGridViewFields.DataSource = dbc.Fields.ToList();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridViewFields.SelectedRows)
            {
                int index = (int)dgvr.Cells[0].Value;
                Field field = dbc.Fields.Include(s => s.Club).Include(s => s.Games).FirstOrDefault(s => s.FieldId == index);

                textBoxName.Text = field.Name;
                checkBoxHasLights.Checked = field.HasLights;
                checkBoxFriday.Checked = field.IsOpenFriday;
                checkBoxSaturday.Checked = field.IsOpenSaturday;
                checkBoxSunday.Checked = field.IsOpenSunday;
                checkBoxMonday.Checked = field.IsOpenMonday;
                checkBoxTuesday.Checked = field.IsOpenTuesday;
                checkBoxWednesday.Checked = field.IsOpenWednesday;
                checkBoxThursday.Checked = field.IsOpenThursday;

                comboBoxClub.DataSource = dbc.Clubs.ToList();
                if (field != null && field.Club != null)
                    comboBoxClub.SelectedItem = dbc.Clubs.Where(s => s.Fields.Contains(field)).FirstOrDefault();

                dataGridViewGames.DataSource = dbc.Games.Include(s => s.Field).Where(s => s.Field.FieldId == field.FieldId).OrderByDescending(s => s.ChosenScheduleTime).ToList();
            }
        }

        private void FieldEditor_Load(object sender, EventArgs e)
        {
            dataGridViewFields.DataSource = dbc.Fields.OrderBy(s => s.FieldId).ToList();
            dataGridViewFields.Rows[0].Selected = true;
        }

        private void buttonSaveField_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridViewFields.SelectedRows)
            {
                int index = (int)dgvr.Cells[0].Value;
                Field field = dbc.Fields.Include(s => s.Club).FirstOrDefault(s => s.FieldId == index);
                field.Name = textBoxName.Text;
                field.IsDeleted = checkBoxDeleteField.Checked;
                field.Club = (Club)comboBoxClub.SelectedItem;
                field.HasLights = checkBoxHasLights.Checked;
                field.IsOpenSunday = checkBoxSunday.Checked;
                field.IsOpenMonday = checkBoxMonday.Checked;
                field.IsOpenTuesday = checkBoxTuesday.Checked;
                field.IsOpenWednesday = checkBoxWednesday.Checked;
                field.IsOpenThursday = checkBoxThursday.Checked;
                field.IsOpenFriday = checkBoxFriday.Checked;
                field.IsOpenSaturday = checkBoxSaturday.Checked;

                checkBoxDeleteField.Checked = false;

                dbc.Entry(field).State = EntityState.Modified;

                //field.Games = new List<Game>();
                //for (int x = 0; x < checkedListBoxFields.CheckedItems.Count; x++)
                //{
                //    league.Fields.Add((Field)checkedListBoxFields.CheckedItems[x]);
                //}

                //dbc.Entry(league).State = EntityState.Modified;
                comboBoxClub.DataSource = dbc.Clubs.Where(s => s.ClubId == field.Club.ClubId).ToList();

                //checkedListBoxFields.DataSource = dbc.Fields.ToList();

                //for (int x = 0; x < checkedListBoxFields.Items.Count; x++)
                //{
                //    if (league.Fields.Contains((Field)checkedListBoxFields.Items[x]))
                //    {
                //        checkedListBoxFields.SetItemChecked(x, true);
                //    }
                //    else
                //    {
                //        checkedListBoxFields.SetItemChecked(x, false);
                //    }
                //}
                dbc.SaveChanges();
            }
        }

        private void checkBoxDeleteField_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDeleteField.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this selection?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    checkBoxDeleteField.Checked = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    checkBoxDeleteField.Checked = false;
                }
            }
        }
    }
}
