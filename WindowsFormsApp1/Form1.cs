using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GAMEOPTIONS : Form
    {
        public GAMEOPTIONS()
        {
            InitializeComponent();
            BackColor = Color.Gray;

            BTNFORMULARIO.BackColor = Color.MediumSeaGreen;
            BTNLISTA.BackColor = Color.MediumSeaGreen;
            //TransparencyKey = BackColor;
        }

        private void BTNFORMULARIO_Click(object sender, EventArgs e)
        {
            GAMEFORM fomulario = new GAMEFORM();
            this.Hide();
            fomulario.Show();
        }

        private void BTNLISTA_Click(object sender, EventArgs e)
        {
            GAMELISTA lista = new GAMELISTA();
            this.Hide();
            lista.Show();
        }
    }
}
