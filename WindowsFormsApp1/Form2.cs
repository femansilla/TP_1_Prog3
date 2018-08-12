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
    public partial class GAMEFORM : Form
    {
        public GAMEFORM()
        {
            InitializeComponent();
        }

        private void dateNac_ValueChanged(object sender, EventArgs e)
        {
            int yearNac = DateTime.Parse(dateNac.Text.ToString()).Year;
            string age = (DateTime.Today.Year - yearNac).ToString();
            this.lblAge.Text = "EDAD: " + age;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            GAMEOPTIONS opciones = new GAMEOPTIONS();
            this.Hide();
            opciones.Show();
        }

        private void txtNombre_MouseHover(object sender, EventArgs e)
        {
            this.txtNombre.BackColor = Color.Aqua;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GAMEFORM_Load(object sender, EventArgs e)
        {

        }
    }
}
