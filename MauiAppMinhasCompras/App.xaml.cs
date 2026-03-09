<<<<<<< HEAD
﻿using MauiAppMinhasCompras.Helpers;

namespace MauiAppMinhasCompras
{
    public partial class App : Application
    {
        static SQLiteDatabaseHelper _db;

        public static SQLiteDatabaseHelper Db
        {
            get
            {
                if(_db == null) 
                {
                    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "banco_sqlite_compras.db3");

                    _db = new SQLiteDatabaseHelper(path);
                }

                return _db;
            }
        }

=======
﻿namespace MauiAppMinhasCompras
{
    public partial class App : Application
    {
>>>>>>> fd04fca7bd29b75a4532fe3b6690102664185527
        public App()
        {
            InitializeComponent();

<<<<<<< HEAD
            //MainPage = New AppShell();
=======
            //MainPage = new AppShell();
>>>>>>> fd04fca7bd29b75a4532fe3b6690102664185527
            MainPage = new NavigationPage(new Views.ListaProduto());
        }
    }
}
