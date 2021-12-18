using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CocktailApp
{
    /// <summary>
    /// Interaction logic for Discover.xaml
    /// </summary>
    public partial class Discover : Page
    {
        public Discover()
        {
            InitializeComponent();

        }

        CocktailModel Cocktail1;
        CocktailModel Cocktail2;
        CocktailModel Cocktail3;
        CocktailModel Cocktail4;
        CocktailModel Cocktail5;
        CocktailModel Cocktail6;

        public void LoadJson(object sender, RoutedEventArgs e)
        {
            WebRequest request = HttpWebRequest.Create("https://mb.sinners.be/api.php");
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            string Cocktail_JSON = reader.ReadToEnd();

            Cocktails myCocktails = Newtonsoft.Json.JsonConvert.DeserializeObject<Cocktails>(Cocktail_JSON);

            Cocktail1 = new CocktailModel(1, myCocktails.drinks[0].strDrink, myCocktails.drinks[0].strInstructions, myCocktails.drinks[0].strIngredient1, myCocktails.drinks[0].strIngredient2, myCocktails.drinks[0].strIngredient3, myCocktails.drinks[0].strIngredient4, myCocktails.drinks[0].strIngredient5, myCocktails.drinks[0].strIngredient6);
            Cocktail2 = new CocktailModel(2, myCocktails.drinks[1].strDrink, myCocktails.drinks[1].strInstructions, myCocktails.drinks[1].strIngredient1, myCocktails.drinks[1].strIngredient2, myCocktails.drinks[1].strIngredient3, myCocktails.drinks[1].strIngredient4, myCocktails.drinks[1].strIngredient5, myCocktails.drinks[1].strIngredient6);
            Cocktail3 = new CocktailModel(3, myCocktails.drinks[2].strDrink, myCocktails.drinks[2].strInstructions, myCocktails.drinks[2].strIngredient1, myCocktails.drinks[2].strIngredient2, myCocktails.drinks[2].strIngredient3, myCocktails.drinks[2].strIngredient4, myCocktails.drinks[2].strIngredient5, myCocktails.drinks[2].strIngredient6);
            Cocktail4 = new CocktailModel(4, myCocktails.drinks[3].strDrink, myCocktails.drinks[3].strInstructions, myCocktails.drinks[3].strIngredient1, myCocktails.drinks[3].strIngredient2, myCocktails.drinks[3].strIngredient3, myCocktails.drinks[3].strIngredient4, myCocktails.drinks[3].strIngredient5, myCocktails.drinks[3].strIngredient6);
            Cocktail5 = new CocktailModel(5, myCocktails.drinks[4].strDrink, myCocktails.drinks[4].strInstructions, myCocktails.drinks[4].strIngredient1, myCocktails.drinks[4].strIngredient2, myCocktails.drinks[4].strIngredient3, myCocktails.drinks[4].strIngredient4, myCocktails.drinks[4].strIngredient5, myCocktails.drinks[4].strIngredient6);
            Cocktail6 = new CocktailModel(6, myCocktails.drinks[5].strDrink, myCocktails.drinks[5].strInstructions, myCocktails.drinks[5].strIngredient1, myCocktails.drinks[5].strIngredient2, myCocktails.drinks[5].strIngredient3, myCocktails.drinks[5].strIngredient4, myCocktails.drinks[5].strIngredient5, myCocktails.drinks[5].strIngredient6);

            

            // 01 ======== BEGIN
            CocktailName1.Text = Cocktail1.Name;
            CocktailDescription1.Text = Cocktail1.Description;

            CocktailIngredient1_1.Text = Cocktail1.Ingredient1; //Alles heeft minstens 1 ingredient.

            // Ingredienten van 2 tot 6
            if (Cocktail1.Ingredient2 == "null" || Cocktail1.Ingredient2 == null)
            {
                CocktailIngredient2_1.Text = "";
            } else
            {
                CocktailIngredient2_1.Text = Cocktail1.Ingredient2;
            }

            if (Cocktail1.Ingredient3 == "null" || Cocktail1.Ingredient3 == null)
            {
                CocktailIngredient3_1.Text = "";
            }
            else
            {
                CocktailIngredient3_1.Text = Cocktail1.Ingredient3;
            }

            if (Cocktail1.Ingredient4 == "null" || Cocktail1.Ingredient4 == null)
            {
                CocktailIngredient4_1.Text = "";
            }
            else
            {
                CocktailIngredient4_1.Text = Cocktail1.Ingredient4;
            }

            if (Cocktail1.Ingredient5 == "null" || Cocktail1.Ingredient5 == null)
            {
                CocktailIngredient5_1.Text = "";
            }
            else
            {
                CocktailIngredient5_1.Text = Cocktail1.Ingredient5;
            }

            if (Cocktail1.Ingredient6 == "null" || Cocktail1.Ingredient6 == null)
            {
                CocktailIngredient6_1.Text = "";
            }
            else
            {
                CocktailIngredient6_1.Text = Cocktail1.Ingredient6;
            }
            // 01 ======== END

            // 02 ======== BEGIN
            CocktailName2.Text = Cocktail2.Name;
            CocktailDescription2.Text = Cocktail2.Description;

            CocktailIngredient1_2.Text = Cocktail2.Ingredient1; //Alles heeft minstens 1 ingredient.

            // Ingredienten van 2 tot 6
            if (Cocktail2.Ingredient2 == "null" || Cocktail2.Ingredient2 == null)
            {
                CocktailIngredient2_2.Text = "";
            }
            else
            {
                CocktailIngredient2_2.Text = Cocktail2.Ingredient2;
            }

            if (Cocktail2.Ingredient3 == "null" || Cocktail2.Ingredient3 == null)
            {
                CocktailIngredient3_2.Text = "";
            }
            else
            {
                CocktailIngredient3_2.Text = Cocktail2.Ingredient3;
            }

            if (Cocktail2.Ingredient4 == "null" || Cocktail2.Ingredient4 == null)
            {
                CocktailIngredient4_2.Text = "";
            }
            else
            {
                CocktailIngredient4_2.Text = Cocktail2.Ingredient4;
            }

            if (Cocktail2.Ingredient5 == "null" || Cocktail2.Ingredient5 == null)
            {
                CocktailIngredient5_2.Text = "";
            }
            else
            {
                CocktailIngredient5_2.Text = Cocktail2.Ingredient5;
            }

            if (Cocktail2.Ingredient6 == "null" || Cocktail2.Ingredient6 == null)
            {
                CocktailIngredient6_2.Text = "";
            }
            else
            {
                CocktailIngredient6_2.Text = Cocktail2.Ingredient6;
            }
        
            // 02 ======== END

            // 03 ======== BEGIN
            CocktailName3.Text = Cocktail3.Name;
            CocktailDescription3.Text = Cocktail3.Description;

            CocktailIngredient1_3.Text = Cocktail3.Ingredient1; //Alles heeft minstens 1 ingredient.

            // Ingredienten van 2 tot 6
            if (Cocktail3.Ingredient2 == "null" || Cocktail3.Ingredient2 == null)
            {
                CocktailIngredient2_3.Text = "";
            }
            else
            {
                CocktailIngredient2_3.Text = Cocktail3.Ingredient2;
            }

            if (Cocktail3.Ingredient3 == "null" || Cocktail3.Ingredient3 == null)
            {
                CocktailIngredient3_3.Text = "";
            }
            else
            {
                CocktailIngredient3_3.Text = Cocktail3.Ingredient3;
            }

            if (Cocktail3.Ingredient4 == "null" || Cocktail3.Ingredient4 == null)
            {
                CocktailIngredient4_3.Text = "";
            }
            else
            {
                CocktailIngredient4_3.Text = Cocktail3.Ingredient4;
            }

            if (Cocktail3.Ingredient5 == "null" || Cocktail3.Ingredient5 == null)
            {
                CocktailIngredient5_3.Text = "";
            }
            else
            {
                CocktailIngredient5_3.Text = Cocktail3.Ingredient5;
            }

            if (Cocktail3.Ingredient6 == "null" || Cocktail3.Ingredient6 == null)
            {
                CocktailIngredient6_3.Text = "";
            }
            else
            {
                CocktailIngredient6_3.Text = Cocktail3.Ingredient6;
            }
            // 03 ======== END

            // 04 ======== BEGIN
            CocktailName4.Text = Cocktail4.Name;
            CocktailDescription4.Text = Cocktail4.Description;

            CocktailIngredient1_4.Text = Cocktail4.Ingredient1; //Alles heeft minstens 1 ingredient.

            // Ingredienten van 2 tot 6
            if (Cocktail4.Ingredient2 == "null" || Cocktail4.Ingredient2 == null)
            {
                CocktailIngredient2_4.Text = "";
            }
            else
            {
                CocktailIngredient2_4.Text = Cocktail4.Ingredient2;
            }

            if (Cocktail4.Ingredient3 == "null" || Cocktail4.Ingredient3 == null)
            {
                CocktailIngredient3_4.Text = "";
            }
            else
            {
                CocktailIngredient3_4.Text = Cocktail4.Ingredient3;
            }

            if (Cocktail4.Ingredient4 == "null" || Cocktail4.Ingredient4 == null)
            {
                CocktailIngredient4_4.Text = "";
            }
            else
            {
                CocktailIngredient4_4.Text = Cocktail4.Ingredient4;
            }

            if (Cocktail4.Ingredient5 == "null" || Cocktail4.Ingredient5 == null)
            {
                CocktailIngredient5_4.Text = "";
            }
            else
            {
                CocktailIngredient5_4.Text = Cocktail4.Ingredient5;
            }

            if (Cocktail4.Ingredient6 == "null" || Cocktail4.Ingredient6 == null)
            {
                CocktailIngredient6_4.Text = "";
            }
            else
            {
                CocktailIngredient6_4.Text = Cocktail4.Ingredient6;
            }
            // 04 ======== END

            // 05 ======== BEGIN
            CocktailName5.Text = Cocktail5.Name;
            CocktailDescription5.Text = Cocktail5.Description;

            CocktailIngredient1_5.Text = Cocktail5.Ingredient1; //Alles heeft minstens 1 ingredient.

            // Ingredienten van 2 tot 6
            if (Cocktail5.Ingredient2 == "null" || Cocktail5.Ingredient2 == null)
            {
                CocktailIngredient2_5.Text = "";
            }
            else
            {
                CocktailIngredient2_5.Text = Cocktail5.Ingredient2;
            }

            if (Cocktail5.Ingredient3 == "null" || Cocktail5.Ingredient3 == null)
            {
                CocktailIngredient3_5.Text = "";
            }
            else
            {
                CocktailIngredient3_5.Text = Cocktail5.Ingredient3;
            }

            if (Cocktail5.Ingredient4 == "null" || Cocktail5.Ingredient4 == null)
            {
                CocktailIngredient4_5.Text = "";
            }
            else
            {
                CocktailIngredient4_5.Text = Cocktail5.Ingredient4;
            }

            if (Cocktail5.Ingredient5 == "null" || Cocktail5.Ingredient5 == null)
            {
                CocktailIngredient5_5.Text = "";
            }
            else
            {
                CocktailIngredient5_5.Text = Cocktail5.Ingredient5;
            }

            if (Cocktail5.Ingredient6 == "null" || Cocktail5.Ingredient6 == null)
            {
                CocktailIngredient6_5.Text = "";
            }
            else
            {
                CocktailIngredient6_5.Text = Cocktail5.Ingredient6;
            }
            // 05 ======== END

            // 06 ======== BEGIN
            CocktailName6.Text = Cocktail6.Name;
            CocktailDescription6.Text = Cocktail6.Description;

            CocktailIngredient1_6.Text = Cocktail6.Ingredient1; //Alles heeft minstens 1 ingredient.

            // Ingredienten van 2 tot 6
            if (Cocktail6.Ingredient2 == "null" || Cocktail6.Ingredient2 == null)
            {
                CocktailIngredient2_6.Text = "";
            }
            else
            {
                CocktailIngredient2_6.Text = Cocktail6.Ingredient2;
            }

            if (Cocktail6.Ingredient3 == "null" || Cocktail6.Ingredient3 == null)
            {
                CocktailIngredient3_6.Text = "";
            }
            else
            {
                CocktailIngredient3_6.Text = Cocktail6.Ingredient3;
            }

            if (Cocktail6.Ingredient4 == "null" || Cocktail6.Ingredient4 == null)
            {
                CocktailIngredient4_6.Text = "";
            }
            else
            {
                CocktailIngredient4_6.Text = Cocktail6.Ingredient4;
            }

            if (Cocktail6.Ingredient5 == "null" || Cocktail6.Ingredient5 == null)
            {
                CocktailIngredient5_6.Text = "";
            }
            else
            {
                CocktailIngredient5_6.Text = Cocktail6.Ingredient5;
            }

            if (Cocktail6.Ingredient1 == "null" || Cocktail6.Ingredient6 == null)
            {
                CocktailIngredient6_6.Text = "";
            }
            else
            {
                CocktailIngredient6_6.Text = Cocktail6.Ingredient6;
            }
            // 06 ======== END


        }


        private void onButtonSave1(object sender, RoutedEventArgs e)
        {
            List<CocktailModel> cocktails;
            List<int> IndexCocktails = new List<int>();
            cocktails = SqliteDataAccess.LoadCocktails();
            foreach (CocktailModel cocktail in cocktails)
            {
                IndexCocktails.Add( cocktail.Id);
            }
            if(IndexCocktails.Contains(1)) 
            {
                SqliteDataAccess.UpdateCocktail(Cocktail1);
            } else
            {
                SqliteDataAccess.SaveCocktail(Cocktail1);

            }


        }

        private void onButtonSave2(object sender, RoutedEventArgs e)
        {
            List<CocktailModel> cocktails;
            List<int> IndexCocktails = new List<int>();
            cocktails = SqliteDataAccess.LoadCocktails();
            foreach (CocktailModel cocktail in cocktails)
            {
                IndexCocktails.Add(cocktail.Id);
            }
            if (IndexCocktails.Contains(2))
            {
                SqliteDataAccess.UpdateCocktail(Cocktail2);
            }
            else
            {
                SqliteDataAccess.SaveCocktail(Cocktail2);

            }
        }
        private void onButtonSave3(object sender, RoutedEventArgs e)
        {
            List<CocktailModel> cocktails;
            List<int> IndexCocktails = new List<int>();
            cocktails = SqliteDataAccess.LoadCocktails();
            foreach (CocktailModel cocktail in cocktails)
            {
                IndexCocktails.Add(cocktail.Id);
            }
            if (IndexCocktails.Contains(3))
            {
                SqliteDataAccess.UpdateCocktail(Cocktail3);
            }
            else
            {
                SqliteDataAccess.SaveCocktail(Cocktail3);

            }
        }
        private void onButtonSave4(object sender, RoutedEventArgs e)
        {
            List<CocktailModel> cocktails;
            List<int> IndexCocktails = new List<int>();
            cocktails = SqliteDataAccess.LoadCocktails();
            foreach (CocktailModel cocktail in cocktails)
            {
                IndexCocktails.Add(cocktail.Id);
            }
            if (IndexCocktails.Contains(4))
            {
                SqliteDataAccess.UpdateCocktail(Cocktail4);
            }
            else
            {
                SqliteDataAccess.SaveCocktail(Cocktail4);

            }
        }
        private void onButtonSave5(object sender, RoutedEventArgs e)
        {
            List<CocktailModel> cocktails;
            List<int> IndexCocktails = new List<int>();
            cocktails = SqliteDataAccess.LoadCocktails();
            foreach (CocktailModel cocktail in cocktails)
            {
                IndexCocktails.Add(cocktail.Id);
            }
            if (IndexCocktails.Contains(5))
            {
                SqliteDataAccess.UpdateCocktail(Cocktail5);
            }
            else
            {
                SqliteDataAccess.SaveCocktail(Cocktail5);

            }
        }
        private void onButtonSave6(object sender, RoutedEventArgs e)
        {
            List<CocktailModel> cocktails;
            List<int> IndexCocktails = new List<int>();
            cocktails = SqliteDataAccess.LoadCocktails();
            foreach (CocktailModel cocktail in cocktails)
            {
                IndexCocktails.Add(cocktail.Id);
            }
            if (IndexCocktails.Contains(6))
            {
                SqliteDataAccess.UpdateCocktail(Cocktail6);
            }
            else
            {
                SqliteDataAccess.SaveCocktail(Cocktail6);

            }
        }

        public class Drink
        {
            public string idDrink { get; set; }
            public string strDrink { get; set; }
            public object strDrinkAlternate { get; set; }
            public string strTags { get; set; }
            public string strVideo { get; set; }
            public string strCategory { get; set; }
            public string strIBA { get; set; }
            public string strAlcoholic { get; set; }
            public string strGlass { get; set; }
            public string strInstructions { get; set; }
            public object strInstructionsES { get; set; }
            public string strInstructionsDE { get; set; }
            public object strInstructionsFR { get; set; }
            public string strInstructionsIT { get; set; }

            [JsonProperty("strInstructionsZH-HANS")]
            public object StrInstructionsZHHANS { get; set; }

            [JsonProperty("strInstructionsZH-HANT")]
            public object StrInstructionsZHHANT { get; set; }
            public string strDrinkThumb { get; set; }
            public string strIngredient1 { get; set; }
            public string strIngredient2 { get; set; }
            public string strIngredient3 { get; set; }
            public string strIngredient4 { get; set; }
            public string strIngredient5 { get; set; }
            public string strIngredient6 { get; set; }
            public object strIngredient7 { get; set; }
            public object strIngredient8 { get; set; }
            public object strIngredient9 { get; set; }
            public object strIngredient10 { get; set; }
            public object strIngredient11 { get; set; }
            public object strIngredient12 { get; set; }
            public object strIngredient13 { get; set; }
            public object strIngredient14 { get; set; }
            public object strIngredient15 { get; set; }
            public string strMeasure1 { get; set; }
            public string strMeasure2 { get; set; }
            public string strMeasure3 { get; set; }
            public string strMeasure4 { get; set; }
            public string strMeasure5 { get; set; }
            public string strMeasure6 { get; set; }
            public object strMeasure7 { get; set; }
            public object strMeasure8 { get; set; }
            public object strMeasure9 { get; set; }
            public object strMeasure10 { get; set; }
            public object strMeasure11 { get; set; }
            public object strMeasure12 { get; set; }
            public object strMeasure13 { get; set; }
            public object strMeasure14 { get; set; }
            public object strMeasure15 { get; set; }
            public string strImageSource { get; set; }
            public string strImageAttribution { get; set; }
            public string strCreativeCommonsConfirmed { get; set; }
            public string dateModified { get; set; }
        }

        public class Cocktails
        {
            public List<Drink> drinks { get; set; }
        }



    }
}
