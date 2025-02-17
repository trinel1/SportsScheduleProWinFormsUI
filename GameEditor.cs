using Microsoft.EntityFrameworkCore;
using SportsScheduleProLibrary.Data;
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
    public partial class GameEditor : Form
    {
        private SportsScheduleProDataContext dbc = new SportsScheduleProDataContext();

        public GameEditor()
        {
            dataGridView1.DataSource = dbc.Games.Include(s => s.Field).Include(s => s.League).ToList();
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1)
            {
                dataGridView1.ReadOnly = true;
                datePicker.Enabled = true;
                timePicker.Enabled = true;
                btnShuffleTimes.Enabled = true;
            }
            else
            {
                dataGridView1.ReadOnly = false;
                datePicker.Enabled = false;
                timePicker.Enabled = false;
                btnShuffleTimes.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cbTimeOn_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTimeOn.Checked)
                timePicker.Visible = true;
            else
                timePicker.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShuffleTimes_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelGame_Click(object sender, EventArgs e)
        {

        }
    }
}
