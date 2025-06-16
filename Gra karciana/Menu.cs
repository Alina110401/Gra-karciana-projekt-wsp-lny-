using Uno;

namespace Gra_karciana
{
    public partial class Menu : Form
    {
        int LiczbaGraczy = 2; // Domyœlna liczba graczy
        public Menu()
        {
            InitializeComponent();
        }

        private void Historia_Click(object sender, EventArgs e)
        {
            Historia historiaForm = new Historia();
            historiaForm.Show();
        }

        private void Uno_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm(LiczbaGraczy);
            gameForm.Show();
        }

        private void Tysiaca_Click(object sender, EventArgs e)
        {
            GraWTysiaca graForm = new GraWTysiaca(LiczbaGraczy);
            graForm.Show();
        }

        private void Ustawienia_Click(object sender, EventArgs e)
        {
            Ustawienia ustawieniaForm = new Ustawienia();

            if (ustawieniaForm.ShowDialog() == DialogResult.OK)
            {
                LiczbaGraczy = ustawieniaForm.LiczbaGraczy;
                MessageBox.Show($"Nowa liczba graczy: {LiczbaGraczy}");
            }
        }

    }
}
