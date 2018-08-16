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
        public info(string values)
        {
            InitializeComponent();
            BackColor = Color.LightSteelBlue;
            JsonTextReader reader = new JsonTextReader(new StringReader(values));
            int i = 0;
            while (reader.Read())
            {
                if (reader.Value != null)
                {
                    if (i == 1)
                    {
                        label1.Text = "Nombre: " + reader.Value;
                        i = 0;
                    }

                    if (i == 2)
                    {
                        label2.Text = "Apellido: " + reader.Value;
                        i = 0;
                    }
                    if(i == 3)
                    {
                        label3.Text = "Fecha de nacimiento: " + reader.Value;
                        i = 0;
                    }
                    if(i == 4)
                    {
                        label4.Text = "Genero: " + reader.Value;
                        i = 0;
                    }

                    if (i == 6 && !reader.Value.Equals("FavoriteColours"))
                        label5.Text += ", " + reader.Value;
                    if (i == 5)
                    {
                        label5.Text = "Estilos de musica preferidos: " + reader.Value;
                        i++;
                    }

                    if (i == 8)
                        label6.Text += ", " + reader.Value;
                    if (i == 7)
                    {
                        label6.Text = "Colores preferidos: " + reader.Value;
                        i++;
                    }

                    if (reader.Value.Equals("Nombre"))
                        i++;
                    if (reader.Value.Equals("Apellido"))
                        i+=2;
                    if (reader.Value.Equals("DateNac"))
                        i+=3;
                    if (reader.Value.Equals("sex"))
                        i+=4;
                    if (reader.Value.Equals("musicStyles"))
                        i+=5;
                    if (reader.Value.Equals("FavoriteColours"))
                        i=7;
                    
                    //Console.WriteLine(reader.Value);
                }
            }
        }
        
    }
}
