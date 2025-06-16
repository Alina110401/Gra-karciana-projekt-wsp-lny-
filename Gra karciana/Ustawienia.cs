using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra_karciana
{
    public partial class Ustawienia : Form
    {
        public int LiczbaGraczy { get; private set; } = 2; // domyślnie 2 graczy

        public Ustawienia()
        {
            InitializeComponent();
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            LiczbaGraczy = dataGridView1.Rows.Count - 1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Usun_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            LiczbaGraczy = dataGridView1.Rows.Count - 1;
            this.Close();
        }
    }

}
