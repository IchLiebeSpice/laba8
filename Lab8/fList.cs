using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab8Library;

namespace Lab8
{
    public partial class fList : Form
    {
        private BindingList<River> river = new BindingList<River>();
        public fList()
        {
            InitializeComponent();
            lbRiverInfo.DataSource = river;
            lbRiverInfo.DisplayMember = "Рікалусса";


            lbRiverInfo.SelectedIndexChanged += new EventHandler(lbRiverInfo_SelectedIndexChanged);
        }

        private void btnAddRiver_Click(object sender, EventArgs e)
        {
            River river = new River();

            fRiver fr = new fRiver(river);

            if (fr.ShowDialog() == DialogResult.OK)
            {
                this.river.Add(river);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void lbRiverInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string family = lbRiverInfo.SelectedValue.ToString();

            River river = (River)lbRiverInfo.SelectedItem;
            MessageBox.Show("Рікалусса: " + river.Name + " |К-сть регіонів: " +
                river.Region + " | Притоки:  " +
                river.Pritoki + " | Довжина: " +
                river.Lenght + " | Довжина річки: " +
                river.Dlina + " | Інформація о наявності мостів: " +
                river.HasBridge);
        }
    }
}
