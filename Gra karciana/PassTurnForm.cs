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
            label1.Text = $"Tura gracza {playerNumber}. Przekaż kontrolę i kliknij „Gotowe”.";
        }
        private void buttonReady_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
