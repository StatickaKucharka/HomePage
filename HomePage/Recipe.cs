using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace HomePage
{
    public class Recipe
    {

        private string name;
        private string image; 

       

        public string Name { get { return this.name; } set { this.name = value; } }
        
        public string Image { get { return this.image; } set { this.image = value; } }
        public Recipe() { }
        public Recipe(string name, string image)
        {
            this.name = name;
            this.image = image;
        }
    }
}
