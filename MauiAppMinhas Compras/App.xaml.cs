using MauiAppMinhas_Compras.Helpers;
using MauiAppMinhas_Compras;

namespace MauiAppMinhas_Compras
{
    public partial class App : Application
    {
        static SQLiteDatabaseHelper _db; //_db é um campo

        public static SQLiteDatabaseHelper Db // Db é uma propriedade
        {
            get
            {
                if(_db == null) // verifico se já tenho objetivo no _db
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData),
                        "banco_sqlite_compras.db3");
                    _db = new SQLiteDatabaseHelper(path);
                }

                return _db;
            }



        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Resources.Views.ListaProduto());
            
        }

    }
}
