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

        private void btnAddValue_Click(object sender, EventArgs e)
        {
            this.listViewOrigin.Items.Add(this.txtAddValueToOrigin.Text.ToString());
            this.txtAddValueToOrigin.Text = "";
        }

        private void btnDeleteSelect_Click(object sender, EventArgs e)
        {
            var itemSelect = listViewDestiny.SelectedItems;
            this.listViewDestiny.Items.Remove(itemSelect[0]);
        }

        private void btnTraslateSelectFromOrigin_Click(object sender, EventArgs e)
        {
            var itemSelect = listViewOrigin.SelectedItems;
            this.listViewDestiny.Items.Add(itemSelect[0].Text);
        }

        private void btnTraslateSelectToOrigin_Click(object sender, EventArgs e)
        {
            var itemSelect = listViewDestiny.SelectedItems;
            this.listViewOrigin.Items.Add(itemSelect[0].Text);
        }

        private void btnTraslateAllFromOrigin_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listViewOrigin.Items.Count; i++)
            {
                listViewDestiny.Items.Add(listViewOrigin.Items[i].Text);
            }
            
        }
    }
}
