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
            dataGridView1.DataSource = dbc.Teams.Include(s => s.ExcludedGameDates).ToList();
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
    }
}
