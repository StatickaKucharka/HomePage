using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace HomePage
{
    public class Recipe
    {

        private string name;
        private string image;
        private string ingrediencie;
        private string postup;

       

        public string Name { get { return this.name; } set { this.name = value; } }
        
        public string Image { get { return this.image; } set { this.image = value; } }
        public string Ingrediencie { get { return this.ingrediencie; } set { this.ingrediencie = value; } }
        public string Postup { get { return this.postup; } set { this.postup = value; } }
        
        public Recipe() { }
        public Recipe(string name, string image)
        {
            this.name = name;
            this.image = image;
        }
        public Recipe(string name, string image, string postup, string ingrediencie)
        {
            this.name = name;
            this.image = image;
            this.postup = postup;
            this.ingrediencie = ingrediencie;
            
        }
        
    }
}
