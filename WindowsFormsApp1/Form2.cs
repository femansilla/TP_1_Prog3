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
            BackColor = Color.LightSteelBlue;
            btnaceptar.BackColor = Color.MediumSeaGreen;
            btncancelar.BackColor = Color.Tomato;
            txtNombre.Select();
        }

        private void dateNac_ValueChanged(object sender, EventArgs e)
        {
            this.lblAge.Text = "EDAD: " + (DateTime.Today.Year - DateTime.Parse(dateNac.Text.ToString()).Year).ToString();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            GAMEOPTIONS opciones = new GAMEOPTIONS();
            this.Hide();
            opciones.Show();
        }
        
        private void validateLengthInput(bool whatsInput)
        {
            if(!whatsInput)
            {
                if (this.txtNombre.Text.Length < 4)
                    txtNombre.BackColor = Color.IndianRed;
                else
                    txtNombre.BackColor = Color.White;
            }
            if(whatsInput)
            {
                if (this.txtApellido.Text.Length < 3)
                    txtApellido.BackColor = Color.IndianRed;
                else
                    txtApellido.BackColor = Color.White;
            }
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            validateLengthInput(false);
        }

        private void txtApellido_KeyUp(object sender, KeyEventArgs e)
        {
            validateLengthInput(true);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                validateLengthInput(false);
                txtApellido.Focus();
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                validateLengthInput(true);
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {

            info frm = new info();
            frm.ShowDialog(this);
        }
    }
}
