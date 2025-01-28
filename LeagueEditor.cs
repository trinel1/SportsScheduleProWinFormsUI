using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SportsScheduleProLibrary.Data;
using SportsScheduleProLibrary.Models;

namespace SportsSchedulePro
{
    public partial class LeagueEditor : Form
    {
        private SportsScheduleProDataContext dbc = new SportsScheduleProDataContext();

        public LeagueEditor()
        {
            InitializeComponent();
        }

        private void LeagueEditor_Load(object sender, EventArgs e)
        {
            dataGridViewLeagues.DataSource = dbc.Leagues.ToList();
            dataGridViewLeagues.Rows[0].Selected = true;

        }

        private void dataGridViewLeagues_DoubleClick(object sender, EventArgs e)
        {
            dbc.Leagues.Add(new League
            {
                IsDeleted = false,
            });
            dbc.SaveChanges();
            dataGridViewLeagues.DataSource = dbc.Leagues.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridViewLeagues.SelectedRows)
            {
                int index = (int)dgvr.Cells[0].Value;
                League league = dbc.Leagues.Include(s => s.Club).FirstOrDefault(s => s.LeagueId == index);
                league.AgeGroup = comboBoxAgeGroup.Text?.ToString();
                league.Gender = comboBoxGender.Text?.ToString();
                league.Name = textBoxLeagueName.Text;
                league.GameLengthWindow = (int) numericUpDownGameLength.Value;
                league.IsDeleted = checkBoxDeleteLeague.Checked;
                league.Club = (Club) comboBoxClub.SelectedItem;
                league.PlayEachTimeCount = (int) numericUpDownPlayEachTime.Value;
                league.AgeGroupEarliestDate = dateTimePickerStartingAge.Value;
                league.AgeGroupLatestDate = dateTimePickerEndingAge.Value;
                league.StartDate = dateTimePickerStartDate.Value;
                league.EndDate = dateTimePickerEndDate.Value;
                league.EarliestGameTimeHourWeekday = dateTimePickerWeekdayEarliestTime.Value.Hour;
                league.EarliestGameTimeMinuteWeekday = dateTimePickerWeekdayEarliestTime.Value.Minute;
                league.EarliestGameTimeHourSaturday = dateTimePickerSaturdayEarliestTime.Value.Hour;
                league.EarliestGameTimeMinuteSaturday = dateTimePickerSaturdayEarliestTime.Value.Minute;
                league.EarliestGameTimeHourSunday = dateTimePickerSundayEarliestTime.Value.Hour;
                league.EarliestGameTimeMinuteSunday = dateTimePickerSundayEarliestTime.Value.Minute;
                league.DailyGamesPerFieldSaturday = (int)numericUpDownSaturdaySlots.Value;
                league.DailyGamesPerFieldSunday = (int)numericUpDownSundaySlots.Value;
                league.DailyGamesPerFieldWeekday = (int)numericUpDownWeekdaySlots.Value;

                checkBoxDeleteLeague.Checked = false;

                dbc.Entry(league).State = EntityState.Modified;

                league.Fields = new List<Field>();
                for (int x = 0; x < checkedListBoxFields.CheckedItems.Count; x++)
                {
                    league.Fields.Add((Field)checkedListBoxFields.CheckedItems[x]);
                }

                dbc.Entry(league).State = EntityState.Modified;
                comboBoxClub.DataSource = dbc.Clubs.Where(s => s.ClubId == league.Club.ClubId).ToList();

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewLeagues_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridViewLeagues.SelectedRows)
            {
                int index = (int)dgvr.Cells[0].Value;
                League league = dbc.Leagues.Include(s => s.Club).Include(s => s.Fields).FirstOrDefault(s => s.LeagueId == index);

                textBoxLeagueName.Text = league.Name;
                comboBoxGender.Text = league.Gender;
                comboBoxAgeGroup.Text = league.AgeGroup;
                numericUpDownGameLength.Value = league.GameLengthWindow;
                numericUpDownPlayEachTime.Value = league.PlayEachTimeCount;
                dateTimePickerStartingAge.Value = league.AgeGroupEarliestDate ?? dateTimePickerStartingAge.Value;
                dateTimePickerEndingAge.Value = league.AgeGroupLatestDate ?? dateTimePickerEndingAge.Value;
                dateTimePickerStartDate.Value = league.StartDate ?? dateTimePickerStartDate.Value;
                dateTimePickerEndDate.Value = league.EndDate ?? dateTimePickerEndDate.Value;
                dateTimePickerWeekdayEarliestTime.Value = new DateTime(2000, 1, 1, league.EarliestGameTimeHourWeekday, league.EarliestGameTimeMinuteWeekday, 0);
                dateTimePickerSaturdayEarliestTime.Value = new DateTime(2000, 1, 1, league.EarliestGameTimeHourSaturday, league.EarliestGameTimeMinuteSaturday, 0);
                dateTimePickerSundayEarliestTime.Value = new DateTime(2000, 1, 1, league.EarliestGameTimeHourSunday, league.EarliestGameTimeMinuteSunday, 0);
                numericUpDownWeekdaySlots.Value = league.DailyGamesPerFieldWeekday;
                numericUpDownSaturdaySlots.Value = league.DailyGamesPerFieldSaturday;
                numericUpDownSundaySlots.Value = league.DailyGamesPerFieldSunday;

                checkBoxDeleteLeague.Checked = league.IsDeleted;

                comboBoxClub.DataSource = dbc.Clubs.ToList();
                if (league != null && league.Club != null)
                    comboBoxClub.SelectedItem = dbc.Clubs.Where(s => s.Leagues.Contains(league)).FirstOrDefault();

                checkedListBoxFields.DataSource = dbc.Fields.OrderBy(s=> s.Name).ToList();

                for (int x = 0; x < checkedListBoxFields.Items.Count; x++)
                {
                    if (league.Fields.Contains((Field)checkedListBoxFields.Items[x]))
                    {
                        checkedListBoxFields.SetItemChecked(x, true);
                    }
                    else
                    {
                        checkedListBoxFields.SetItemChecked(x, false);
                    }
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxDeleteLeague_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDeleteLeague.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this selection?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    checkBoxDeleteLeague.Checked = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    checkBoxDeleteLeague.Checked = false;
                }
            }
        }
    }
}
