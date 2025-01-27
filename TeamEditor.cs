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
    public partial class TeamEditor : Form
    {
        private SportsScheduleProDataContext dbc = new SportsScheduleProDataContext();

        public TeamEditor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbc.Teams.Add(new Team
            {
                IsDeleted = false,
            });
            dbc.SaveChanges();
            dataGridView1.DataSource = dbc.Teams.ToList();
        }

        private void TeamEditor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbc.Teams.Include(s => s.ExcludedGameDates).Include(s => s.League).Include(s => s.Seasons).OrderBy(s => s.League).ToList();
            dataGridView1.Rows[0].Selected = true;
        }

        private void DeleteRowButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this selection?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //delete the rows
                foreach (DataGridViewRow dgvr in dataGridView1.SelectedRows)
                {
                    int index = (int) dgvr.Cells[0].Value;
                    Team team = dbc.Teams.FirstOrDefault(s => s.TeamId == index);
                    team.IsDeleted = true;

                    dbc.Entry(team).State = EntityState.Modified;
                }
                dbc.SaveChanges();
                dataGridView1.DataSource = dbc.Teams.Include(s => s.ExcludedGameDates).ToList();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridView1.SelectedRows)
            {
                int index = (int)dgvr.Cells[0].Value;
                Team team = dbc.Teams.Include(s => s.Seasons).FirstOrDefault(s => s.TeamId == index);

                lblName.Text = team.Name;
                lblShirt.Text = team.ShirtColorChosen;
                lblShort.Text = team.ShortsColorChosen;

                comboBoxLeague.DataSource = dbc.Leagues.ToList();
                if(team != null && team.League != null)
                    comboBoxLeague.SelectedItem = dbc.Leagues.FirstOrDefault(s => s.LeagueId == team.League.LeagueId);

                checkedListBoxSeasons.DataSource = dbc.Seasons.ToList();

                for(int x = 0; x < checkedListBoxSeasons.Items.Count; x++)
                {
                    if(team.Seasons.Contains((Season) checkedListBoxSeasons.Items[x]))
                    {
                        checkedListBoxSeasons.SetItemChecked(x, true);
                    }
                    else
                    {
                        checkedListBoxSeasons.SetItemChecked(x, false);
                    }
                }

                dataGridViewGames.DataSource = dbc.Games.Include(s => s.Field).Where(s => s.HomeTeamId == team.TeamId || s.AwayTeamId == team.TeamId).ToList();
                dataGridViewCoaches.DataSource = dbc.Coaches.Include(s => s.Teams).Where(s => s.Teams.Contains(team)).ToList();
                dataGridViewPlayers.DataSource = dbc.Players.Include(s => s.Teams).Where(s => s.Teams.Contains(team)).ToList();
                dataGridViewTournaments.DataSource = dbc.Tournaments.Include(s => s.Teams).Where(s => s.Teams.Contains(team)).ToList();
                dataGridViewExcludedDates.DataSource = dbc.ExcludedGameDates.Include(s => s.Team).Where(s => s.Team == team).ToList();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewPlayers_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridView1.SelectedRows)
            {
                int index = (int)dgvr.Cells[0].Value;
                Team team = dbc.Teams.FirstOrDefault(s => s.TeamId == index);
                Player p = new Player
                {
                    IsDeleted = false,
                };
                dbc.Players.Add(p);

                team.Players.Add(p);
                dbc.Entry(team).State = EntityState.Modified;

                dbc.SaveChanges();
                dbc.Entry(p).Reload();

                dataGridViewPlayers.DataSource = dbc.Players.Include(s => s.Teams).Where(s => s.Teams.Contains(team)).ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridView1.SelectedRows)
            {
                int index = (int)dgvr.Cells[0].Value;
                Team team = dbc.Teams.FirstOrDefault(s => s.TeamId == index);
                team.League = (League) comboBoxLeague.SelectedValue;
                team.Seasons = new List<Season>();
                for(int x = 0; x < checkedListBoxSeasons.CheckedItems.Count; x++)
                {
                    team.Seasons.Add((Season)checkedListBoxSeasons.CheckedItems[x]);
                }

                dbc.Entry(team).State = EntityState.Modified;
            }
            foreach(DataGridViewRow dgvr in dataGridViewPlayers.SelectedRows)
            {
                int index = (int)dgvr.Cells[0].Value;
                Player player = dbc.Players.FirstOrDefault(s => s.PersonId == index);

                dbc.Entry(player).State = EntityState.Modified;
            }
            foreach (DataGridViewRow dgvr in dataGridViewCoaches.SelectedRows)
            {
                int index = (int)dgvr.Cells[0].Value;
                Coach coach = dbc.Coaches.FirstOrDefault(s => s.PersonId == index);

                dbc.Entry(coach).State = EntityState.Modified;
            }
            foreach (DataGridViewRow dgvr in dataGridViewExcludedDates.SelectedRows)
            {
                int index = (int)dgvr.Cells[0].Value;
                ExcludedGameDate egd = dbc.ExcludedGameDates.FirstOrDefault(s => s.ExcludedGameDateId == index);

                dbc.Entry(egd).State = EntityState.Modified;
            }

            foreach (DataGridViewRow dgvr in dataGridView1.SelectedRows)
            {
                int index = (int)dgvr.Cells[0].Value;
                Team team = dbc.Teams.FirstOrDefault(s => s.TeamId == index);

                dataGridView1.DataSource = dbc.Teams.ToList();
                dataGridViewGames.DataSource = dbc.Games.Include(s => s.Field).Where(s => s.HomeTeamId == team.TeamId || s.AwayTeamId == team.TeamId).ToList();
                dataGridViewCoaches.DataSource = dbc.Coaches.Include(s => s.Teams).Where(s => s.Teams.Contains(team)).ToList();
                dataGridViewPlayers.DataSource = dbc.Players.Include(s => s.Teams).Where(s => s.Teams.Contains(team)).ToList();
                dataGridViewTournaments.DataSource = dbc.Tournaments.Include(s => s.Teams).Where(s => s.Teams.Contains(team)).ToList();
                dataGridViewExcludedDates.DataSource = dbc.ExcludedGameDates.Include(s => s.Team).Where(s => s.Team == team).ToList();
            }
            dbc.SaveChanges();
        }

        private void dataGridViewCoaches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewCoaches_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridView1.SelectedRows)
            {
                int index = (int)dgvr.Cells[0].Value;
                Team team = dbc.Teams.FirstOrDefault(s => s.TeamId == index);
                Coach coach = new Coach
                {
                    IsDeleted = false,
                };
                dbc.Coaches.Add(coach);

                team.Coaches.Add(coach);
                dbc.Entry(team).State = EntityState.Modified;

                dbc.SaveChanges();
                dbc.Entry(coach).Reload();

                dataGridViewCoaches.DataSource = dbc.Coaches.Include(s => s.Teams).Where(s => s.Teams.Contains(team)).ToList();
            }
        }

        private void dataGridViewExcludedDates_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridView1.SelectedRows)
            {
                int index = (int)dgvr.Cells[0].Value;
                Team team = dbc.Teams.FirstOrDefault(s => s.TeamId == index);
                ExcludedGameDate egd = new ExcludedGameDate
                {
                    IsDeleted = false,
                };
                dbc.ExcludedGameDates.Add(egd);

                team.ExcludedGameDates.Add(egd);
                dbc.Entry(team).State = EntityState.Modified;

                dbc.SaveChanges();
                dbc.Entry(egd).Reload();

                dataGridViewExcludedDates.DataSource = dbc.ExcludedGameDates.Include(s => s.Team).Where(s => s.Team == team).ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
