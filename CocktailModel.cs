using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailApp
{
    public class CocktailModel
    {


        public string Name { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public string Ingredient1 { get; set; }
        public string Ingredient2 { get; set; }
        public string Ingredient3 { get; set; }
        public string Ingredient4 { get; set; }
        public string Ingredient5 { get; set; }
        public string Ingredient6 { get; set; }


        public CocktailModel(int id, string name, string description, string ingredient1, string ingredient2, string ingredient3, string ingredient4, string ingredient5, string ingredient6)
        {
            Id = id;
            Name = name;
            Description = description;
            Ingredient1 = ingredient1;
            Ingredient2 = ingredient2;
            Ingredient3 = ingredient3;
            Ingredient4 = ingredient4;
            Ingredient5 = ingredient5;
            Ingredient6 = ingredient6;

        }

        public CocktailModel()
        {

        }


    }
}
