using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailApp
{
    class SqliteDataAccess
    {
        public static void SaveCocktail(CocktailModel cocktail)
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into cocktail (Id, Name, Description, Ingredient1, Ingredient2, Ingredient3, Ingredient4, Ingredient5, Ingredient6) " +
                    "values (@Id, @Name, @Description, @Ingredient1, @Ingredient2, @Ingredient3, @Ingredient4, @Ingredient5, @Ingredient6)", cocktail);
            }
        }

        public static void UpdateCocktail(CocktailModel cocktail)
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update cocktail set Name = @Name, Description = @Description, Ingredient1 = @Ingredient1, Ingredient2 = @Ingredient2, Ingredient3 = @Ingredient3, Ingredient4 = @Ingredient4, Ingredient5 = @Ingredient5, Ingredient6 = @Ingredient6 where Id = @Id", cocktail);
            }
        }

        public static void DeleteCocktail(CocktailModel cocktail)
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from cocktail where Id = @Id", cocktail);
            }
        }

        public static List<CocktailModel> LoadCocktails()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CocktailModel>("select * from cocktail", new DynamicParameters());
                return output.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
