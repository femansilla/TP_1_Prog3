using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class PersonModel
    {
        public string Nombre;
        public string Apellido;
        public DateTime dateNac;
        public bool sex;
        public string musicStyles;
        public List<string> favoriteColour = new List<string>();
    }
}
