using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxes
{
    public partial class frmTeams : Form
    {
        public frmTeams()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstATeam.Items.Add(txtName.Text);
            txtName.Clear();
        }

        private void btnToB_Click(object sender, EventArgs e)
        {
            lstBTeam.Items.Add(lstATeam.SelectedItem);
            lstATeam.Items.Remove(lstATeam.SelectedItem);
        }
        
        private void btnToA_Click(object sender, EventArgs e)
        {
            lstATeam.Items.Add(lstBTeam.SelectedItem);
            lstBTeam.Items.Remove(lstBTeam.SelectedItem);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstATeam.Items.Clear();
            lstBTeam.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
