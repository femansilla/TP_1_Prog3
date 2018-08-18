﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Dynamic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GAMEFORM : Form
    {
        public GAMEFORM()
        {
            InitializeComponent();
            BackColor = Color.LightSteelBlue;
            TransparencyKey = Color.Aqua;
            btnaceptar.BackColor = Color.MediumSeaGreen;
            btncancelar.BackColor = Color.Tomato;
            txtNombre.Select();
            ColourCHKList.CheckOnClick = true;
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
            if (!whatsInput)
            {
                if (this.txtNombre.Text.Length < 4)
                    txtNombre.BackColor = Color.IndianRed;
                else
                    txtNombre.BackColor = Color.White;
            }
            if (whatsInput)
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

        private PersonModel sendInfo()
        {
            //dynamic myObject = new ExpandoObject();

            //myObject.Nombre = this.txtNombre.Text;
            //myObject.Apellido = this.txtApellido.Text;

            //DateTime date = DateTime.Parse(this.dateNac.Text);
            //myObject.DateNac = date.ToLongDateString();

            //if (this.rdoMale.Checked)
            //    myObject.sex = "Hombre";
            //else
            //    myObject.sex = "Mujer";

            //if (cmbMusicStyles.SelectedItem != null)
            //{
            //    myObject.musicStyles = cmbMusicStyles.SelectedItem;
            //}
            //else
            //{
            //    myObject.musicStyles = "No selecciono ningun estilo musical.";
            //}

            //List<string> FavoriteColours = new List<string>();
            //if (ColourCHKList.CheckedItems.Count == 0)
            //{
            //    FavoriteColours.Add("No selecciono ningun color.");
            //}
            //else
            //{
            //    for (int i = 0; i < this.ColourCHKList.CheckedItems.Count; i++)
            //        FavoriteColours.Add(ColourCHKList.CheckedItems[i].ToString());
            //}
            //myObject.FavoriteColours = FavoriteColours;

            //string json = JsonConvert.SerializeObject(myObject);
            //return json;
            //----------------- fin forma flayera ------------------------
            PersonModel person = new PersonModel();

            person.Nombre = txtNombre.Text;
            person.Apellido = txtApellido.Text;
            person.dateNac = DateTime.Parse(this.dateNac.Text);

            if (this.rdoMale.Checked)
                person.sex = true;
            else
                person.sex = false;

            if (ColourCHKList.CheckedItems.Count == 0)
            {
                person.favoriteColour.Add("No selecciono ningun color.");
            }
            else
            {
                foreach(string colour in ColourCHKList.CheckedItems)
                    person.favoriteColour.Add(colour);
            }


            if (cmbMusicStyles.SelectedItem != null)
            {
                person.musicStyles = cmbMusicStyles.SelectedItem.ToString();
            }
            else
            {
                person.musicStyles = "No selecciono ningun estilo musical.";
            }
           
            return person;
        }

        private bool Validate()
        {
            bool ret = true;
            if(string.IsNullOrEmpty(txtNombre.Text))
            {
                ret = false;
                MessageBox.Show("El campo Nombre no puede estar vacio.\nVerifique por favor.");
                return ret;
            }

            if(string.IsNullOrEmpty(txtApellido.Text))
            {
                ret = false;
                MessageBox.Show("El campo Apellido no puede estar vacio.\nVerifique por favor.");
                return ret;
            }

            DateTime date = DateTime.Parse(this.dateNac.Text);
            DateTime dote = DateTime.Today.AddYears(-18);
            if (date == DateTime.Now || date >= dote)
            {
                ret = false;
                MessageBox.Show("La fecha de nacimiento no es valida.\nVerifique por favor.");
                return ret;
            }
            if (!rdoMale.Checked && !rdoFemale.Checked)
            {
                ret = false;
                MessageBox.Show("Seleccione un genero por favor.");
                return ret;
            }


            return ret;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                info frm = new info(this.sendInfo());
                frm.ShowDialog();
            } 
        }

        private void cmbMusicStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mierda = cmbMusicStyles.SelectedItem;
        }
    }
}
