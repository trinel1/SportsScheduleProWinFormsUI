using SportsSchedulePro.Data;
using SportsScheduleProLibrary;
using SportsScheduleProLibrary.Data;
using SportsScheduleProLibrary.Models;
using SportsScheduleProLibrary.Services;
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
    public partial class Main : Form
    {
        private SportsScheduleProDataContext dbc = new SportsScheduleProDataContext();

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //base.OnLoad(e);

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            dbc.Database.EnsureCreated();
            foreach (Team t in dbc.Teams.Where(s => s.Name == null))
            {
                dbc.Entry(t).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                dbc.SaveChanges();
            }
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbc = new SportsScheduleProDataContext();
            toolStripTextBox1.BackColor = Color.Green;
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbc = null;
            toolStripTextBox1.BackColor = Color.DarkRed;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dbc != null && dbc.Database.CanConnect())
                toolStripTextBox1.BackColor = Color.Green;
            else
                toolStripTextBox1.BackColor = Color.DarkRed;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void viewAlertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbc.Alerts.ToList();
        }

        private void sendWeatherAlertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alert alert = WeatherAlertService.SendWeatherAlert(team: new Team
            {
                Name = "Flaming Turtles",
                ShirtColorChosen = "Red/Yellow",
                ShortsColorChosen = "Green",
                Players = new List<Player> { new Player { Name = "Sue"} , new Player { Name = "Jenny"}, new Player { Name = "Sam"} },
                Coaches = new List<Coach> { new Coach { Name = "Greg Simms"} },
            });
            dbc.Alerts.Add(alert);
            dbc.SaveChanges();
        }

        private void createScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomScheduleService.GameSchedule();
        }

        private void viewTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbc.Teams.ToList();
            dataGridView1.ReadOnly = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.DataSource.GetType() == typeof(List<Team>))
            {
                dbc.Teams.Add(new Team
                {
                    IsDeleted = false,
                });
                dbc.SaveChanges();
                dataGridView1.DataSource = dbc.Teams.ToList();
            }
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TeamEditor().ShowDialog();
            if (dataGridView1.DataSource?.GetType() == typeof(List<Team>))
            {
                dataGridView1.DataSource = dbc.Teams.ToList();
            }
        }
    }
}
