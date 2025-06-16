using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uno
{
    public partial class PassTurnForm : Form
    {
        public PassTurnForm(int playerNumber)
        {
            InitializeComponent();
            label1.Text = $"Ход игрока {playerNumber}. Передайте управление и нажмите 'Готов'.";
        }
        private void buttonReady_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
