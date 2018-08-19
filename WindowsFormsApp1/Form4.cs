using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class info : Form
    {
        public info(PersonModel person)
        {
            InitializeComponent();
            BackColor = Color.LightSteelBlue;
            label1.Text = "Nombre: " + person.Nombre;
            label2.Text = "Apellido: " + person.Apellido;
            label3.Text = "Fecha de nacimiento: " + person.dateNac.ToLongDateString();
            label4.Text = "Genero: ";
            if (person.sex)
                label4.Text += "Hombre";
            else
                label4.Text += "Mujer";
            label5.Text = "Estilo de musical preferido: " + person.musicStyles;
            label6.Text = "Colores preferidos: ";
            foreach(string style in person.favoriteColour)
            {
                if(person.favoriteColour[0].Equals(style))
                    label6.Text += style;
                else
                    label6.Text += ", " + style;

            }

        }
        
    }
}
