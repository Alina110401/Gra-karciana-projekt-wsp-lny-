namespace Gra_karciana
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Historia_Click(object sender, EventArgs e)
        {
            Show().Historia historia = new Historia();

        }
    }
}
