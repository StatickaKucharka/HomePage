using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HomePage
{
    internal class Recipe
    {



        public string Name { get; set; }
        public double Value { get; set; }
        public string Image { get; set; }
        public Recipe(string name, string image)
        {
            Name = name;
            Image = image;
        }
    }
}
