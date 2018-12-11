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
    public partial class fRiver : Form
    {
        private River TheRiver;
        internal fRiver(River t)
        {
            TheRiver = t;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheRiver.Name = tbName.Text.Trim();
            TheRiver.Region = tbRegion.Text.Trim();
            TheRiver.Pritoki = tbPritoki.Text.Trim();
            TheRiver.Lenght = int.Parse(tbLenght.Text.Trim());
            TheRiver.Dlina = int.Parse(tbDlina.Text.Trim());
            TheRiver.HasBridge = chbHasBridge.Checked;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fRiver_Load(object sender, EventArgs e)
        {
            if (TheRiver != null)
            {
                tbName.Text = TheRiver.Name;
                tbRegion.Text = TheRiver.Region;
                tbPritoki.Text = TheRiver.Pritoki;
                tbLenght.Text = TheRiver.Lenght.ToString();
                tbDlina.Text = TheRiver.Dlina.ToString();
                chbHasBridge.Checked = TheRiver.HasBridge;
            }
        }

        private void tbLenght_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '\b'))
            {
                MessageBox.Show("Заборонено використання літер та десяткових чисел.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void tbDlina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '\b'))
            {
                MessageBox.Show("Заборонено використання літер та десяткових чисел.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
