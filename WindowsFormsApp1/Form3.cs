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
    public partial class GAMELISTA : Form
    {
        public GAMELISTA()
        {
            InitializeComponent();

            this.listViewOrigin.MultiSelect = false;
            this.listViewDestiny.MultiSelect = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GAMEOPTIONS opciones = new GAMEOPTIONS();
            this.Hide();
            opciones.Show();
        }

        private bool ValidateExistValueInListOrigin()
        {
            for (int i = 0; i<listViewOrigin.Items.Count; i++)
            {
                if (listViewOrigin.Items[i].Text.Equals(txtAddValueToOrigin.Text.ToString()))
                {
                    MessageBox.Show("El valor ya existe en la lista.");
                    return true;
                }
            }
            return false;
        }

        private void btnAddValue_Click(object sender, EventArgs e)
        {
            if(listViewOrigin.Items.Count == 0)
                this.listViewOrigin.Items.Add(this.txtAddValueToOrigin.Text.ToString());
            else
            {
                if(!ValidateExistValueInListOrigin())
                    this.listViewOrigin.Items.Add(this.txtAddValueToOrigin.Text.ToString());
            }
            
            this.txtAddValueToOrigin.Text = "";
            this.txtAddValueToOrigin.BackColor = Color.White;
        }

        private void btnDeleteSelect_Click(object sender, EventArgs e)
        {
            var itemSelect = listViewDestiny.SelectedItems;
            if (itemSelect.Count == 0)
                MessageBox.Show("No selecciono ningun valor.");
            else
                this.listViewDestiny.Items.Remove(itemSelect[0]);
        }

        private void btnTraslateSelectFromOrigin_Click(object sender, EventArgs e)
        {
            var itemSelect = listViewOrigin.SelectedItems;
            if (itemSelect.Count == 0)
            {
                itemSelect = null;
                MessageBox.Show("No selecciono ningun valor.");
            }
            if (itemSelect != null)
            {
                if(validateContainsValue(itemSelect[0].Text, 2))
                    MessageBox.Show("El valor ya existe en la lista destino.");
                else
                    this.listViewDestiny.Items.Add(itemSelect[0].Text);
            }
        }

        private void btnTraslateSelectToOrigin_Click(object sender, EventArgs e)
        {
            var itemSelect = listViewDestiny.SelectedItems;
            if (itemSelect.Count == 0)
            {
                itemSelect = null;
                MessageBox.Show("No selecciono ningun valor.");
            }
            if (itemSelect != null)
            {
                if (validateContainsValue(itemSelect[0].Text, 1))
                    MessageBox.Show("El valor ya existe en la lista destino.");
                else
                    this.listViewOrigin.Items.Add(itemSelect[0].Text);
            }
        }

        private bool validateContainsValue(string value, int list)
        {
            bool ret = false;
            if(list == 1)
            {
                if (listViewOrigin.Items.Count == 0)
                    ret = false;

                for (int i = 0; i < listViewOrigin.Items.Count; i++)
                {
                    if (listViewOrigin.Items[i].Text.Equals(value))
                        ret = true;
                    if(i == listViewOrigin.Items.Count && !ret)
                        ret = false;
                }
            }
            if(list == 2)
            {
                if (listViewDestiny.Items.Count == 0)
                    ret = false;

                for (int i = 0; i < listViewDestiny.Items.Count; i++)
                {
                    if (listViewDestiny.Items[i].Text.Equals(value))
                        ret = true;
                    if (i == listViewDestiny.Items.Count && !ret)
                        ret = false;
                }
            }
            return ret;
        }

        private bool validateContainsValues()
        {
            if (listViewDestiny.Items.Count == 0)
                return false;
            for (int i = 0; i < listViewOrigin.Items.Count; i++)
            {
                if (listViewOrigin.Items[i].Text.Equals(listViewDestiny.Items[i].Text))
                    return true;
            }
            return false;
        }

        private void btnTraslateAllFromOrigin_Click(object sender, EventArgs e)
        {
            if(listViewOrigin.Items.Count == 0)
                MessageBox.Show("No hay valores en la lista de origen.");
            if(validateContainsValues())
                MessageBox.Show("1 o mas valores ya existen en la lista destino.");
            else
            {
                for (int i = 0; i < listViewOrigin.Items.Count; i++)
                {
                    listViewDestiny.Items.Add(listViewOrigin.Items[i].Text);
                }
            }
        }

        private void txtAddValueToOrigin_TextChanged(object sender, EventArgs e)
        {
            if (this.txtAddValueToOrigin.Text.Length < 3)
                txtAddValueToOrigin.BackColor = Color.IndianRed;
            else
                txtAddValueToOrigin.BackColor = Color.White;
        }
    }
}
