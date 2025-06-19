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
        public List<string> Nicknames { get; private set; } = new();

        public Ustawienia()
        {
            InitializeComponent();
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            Nicknames.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string imie = row.Cells[0].Value?.ToString()?.Trim() ?? "";
                string nazwisko = row.Cells[1].Value?.ToString()?.Trim() ?? "";

                if (!string.IsNullOrEmpty(imie) || !string.IsNullOrEmpty(nazwisko))
                {
                    Nicknames.Add($"{imie} {nazwisko}".Trim());
                }
            }

            LiczbaGraczy = Nicknames.Count;
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
