using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for Saved.xaml
    /// </summary>
    public partial class Saved : Page
    {
        private List<CocktailModel> cocktail;

        public Saved()
        {
            InitializeComponent();
            LoadPage();
        }

        private void LoadPage()
        {
            cocktail = SqliteDataAccess.LoadCocktails();
            try { CocktailName1.Text = cocktail[0].Name; } catch { CocktailName1.Text = "";};
            try { CocktailName2.Text = cocktail[1].Name; } catch { CocktailName2.Text = "";};
            try { CocktailName3.Text = cocktail[2].Name; } catch { CocktailName3.Text = "";};
            try { CocktailName4.Text = cocktail[3].Name; } catch { CocktailName4.Text = "";};
            try { CocktailName5.Text = cocktail[4].Name; } catch { CocktailName5.Text = "";};
            try { CocktailName6.Text = cocktail[5].Name; } catch { CocktailName6.Text = "";};

            try { CocktailDescription1.Text = cocktail[0].Description; } catch { ButtonDel1.Visibility = Visibility.Hidden; CocktailDescription1.Text = "";};
            try { CocktailDescription2.Text = cocktail[1].Description; } catch { ButtonDel2.Visibility = Visibility.Hidden; CocktailDescription2.Text = "";};
            try { CocktailDescription3.Text = cocktail[2].Description; } catch { ButtonDel3.Visibility = Visibility.Hidden; CocktailDescription3.Text = "";};
            try { CocktailDescription4.Text = cocktail[3].Description; } catch { ButtonDel4.Visibility = Visibility.Hidden; CocktailDescription4.Text = "";};
            try { CocktailDescription5.Text = cocktail[4].Description; } catch { ButtonDel5.Visibility = Visibility.Hidden; CocktailDescription5.Text = "";};
            try { CocktailDescription6.Text = cocktail[5].Description; } catch { ButtonDel6.Visibility = Visibility.Hidden; CocktailDescription6.Text = "";};

            try { CocktailIngredient1_1.Text = cocktail[0].Ingredient1; } catch {CocktailIngredient1_1.Text = "";};
            try { CocktailIngredient1_2.Text = cocktail[1].Ingredient1; } catch {CocktailIngredient1_2.Text = "";};
            try { CocktailIngredient1_3.Text = cocktail[2].Ingredient1; } catch {CocktailIngredient1_3.Text = "";};
            try { CocktailIngredient1_4.Text = cocktail[3].Ingredient1; } catch {CocktailIngredient1_4.Text = "";};
            try { CocktailIngredient1_5.Text = cocktail[4].Ingredient1; } catch {CocktailIngredient1_5.Text = "";};
            try { CocktailIngredient1_6.Text = cocktail[5].Ingredient1; } catch {CocktailIngredient1_6.Text = ""; };

            try { CocktailIngredient2_1.Text = cocktail[0].Ingredient2; } catch { CocktailIngredient2_1.Text = "";};
            try { CocktailIngredient2_2.Text = cocktail[1].Ingredient2; } catch { CocktailIngredient2_2.Text = "";};
            try { CocktailIngredient2_3.Text = cocktail[2].Ingredient2; } catch { CocktailIngredient2_3.Text = "";};
            try { CocktailIngredient2_4.Text = cocktail[3].Ingredient2; } catch { CocktailIngredient2_4.Text = "";};
            try { CocktailIngredient2_5.Text = cocktail[4].Ingredient2; } catch { CocktailIngredient2_5.Text = "";};
            try { CocktailIngredient2_6.Text = cocktail[5].Ingredient2; } catch { CocktailIngredient2_6.Text = ""; };

            try { CocktailIngredient3_1.Text = cocktail[0].Ingredient3; } catch { CocktailIngredient3_1.Text = "";};
            try { CocktailIngredient3_2.Text = cocktail[1].Ingredient3; } catch { CocktailIngredient3_2.Text = "";};
            try { CocktailIngredient3_3.Text = cocktail[2].Ingredient3; } catch { CocktailIngredient3_3.Text = "";};
            try { CocktailIngredient3_4.Text = cocktail[3].Ingredient3; } catch { CocktailIngredient3_4.Text = "";};
            try { CocktailIngredient3_5.Text = cocktail[4].Ingredient3; } catch { CocktailIngredient3_5.Text = "";};
            try { CocktailIngredient3_6.Text = cocktail[5].Ingredient3; } catch { CocktailIngredient3_6.Text = ""; };

            try { CocktailIngredient4_1.Text = cocktail[0].Ingredient4; } catch { CocktailIngredient4_1.Text = "";};
            try { CocktailIngredient4_2.Text = cocktail[1].Ingredient4; } catch { CocktailIngredient4_2.Text = "";};
            try { CocktailIngredient4_3.Text = cocktail[2].Ingredient4; } catch { CocktailIngredient4_3.Text = "";};
            try { CocktailIngredient4_4.Text = cocktail[3].Ingredient4; } catch { CocktailIngredient4_4.Text = "";};
            try { CocktailIngredient4_5.Text = cocktail[4].Ingredient4; } catch { CocktailIngredient4_5.Text = "";};
            try { CocktailIngredient4_6.Text = cocktail[5].Ingredient4; } catch { CocktailIngredient4_6.Text = "";};
                                                                                                               
            try { CocktailIngredient5_1.Text = cocktail[0].Ingredient5; } catch { CocktailIngredient5_1.Text = "";};
            try { CocktailIngredient5_2.Text = cocktail[1].Ingredient5; } catch { CocktailIngredient5_2.Text = "";};
            try { CocktailIngredient5_3.Text = cocktail[2].Ingredient5; } catch { CocktailIngredient5_3.Text = "";};
            try { CocktailIngredient5_4.Text = cocktail[3].Ingredient5; } catch { CocktailIngredient5_4.Text = "";};
            try { CocktailIngredient5_5.Text = cocktail[4].Ingredient5; } catch { CocktailIngredient5_5.Text = "";};
            try { CocktailIngredient5_6.Text = cocktail[5].Ingredient5; } catch { CocktailIngredient5_6.Text = "";};
                                                                                                               
            try { CocktailIngredient6_1.Text = cocktail[0].Ingredient6; } catch { CocktailIngredient6_1.Text = "";};
            try { CocktailIngredient6_2.Text = cocktail[1].Ingredient6; } catch { CocktailIngredient6_2.Text = "";};
            try { CocktailIngredient6_3.Text = cocktail[2].Ingredient6; } catch { CocktailIngredient6_3.Text = "";};
            try { CocktailIngredient6_4.Text = cocktail[3].Ingredient6; } catch { CocktailIngredient6_4.Text = "";};
            try { CocktailIngredient6_5.Text = cocktail[4].Ingredient6; } catch { CocktailIngredient6_5.Text = "";};
            try { CocktailIngredient6_6.Text = cocktail[5].Ingredient6; } catch { CocktailIngredient6_6.Text = ""; };





        }

        private void onButtonDel1(object sender, RoutedEventArgs e)
        {
            SqliteDataAccess.DeleteCocktail(cocktail[0]);
            LoadPage();
        }

        private void onButtonDel2(object sender, RoutedEventArgs e)
        {
            SqliteDataAccess.DeleteCocktail(cocktail[1]);
            LoadPage();
        }

        private void onButtonDel3(object sender, RoutedEventArgs e)
        {
            SqliteDataAccess.DeleteCocktail(cocktail[2]);
            LoadPage();
        }

        private void onButtonDel4(object sender, RoutedEventArgs e)
        {
            SqliteDataAccess.DeleteCocktail(cocktail[3]);
            LoadPage();
        }

        private void onButtonDel5(object sender, RoutedEventArgs e)
        {
            SqliteDataAccess.DeleteCocktail(cocktail[4]);
            LoadPage();
        }

        private void onButtonDel6(object sender, RoutedEventArgs e)
        {
            SqliteDataAccess.DeleteCocktail(cocktail[5]);
            LoadPage();
        }
    }
}
