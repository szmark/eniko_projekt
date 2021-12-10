using System;
using System.Configuration;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;

namespace szamlazo
{

    internal class Adatbazis
    {
        private static Adatbazis instance = null;
        public DbConnection conn;

        private Adatbazis()
        {
        }

        private void initDb()
        {
            string dbPath = Path.GetFullPath(ConfigurationManager.AppSettings["dbFile"]);
            if (!System.IO.File.Exists(dbPath))
            {
                if (!System.IO.File.Exists(Path.GetDirectoryName(dbPath)))
                    System.IO.Directory.CreateDirectory(Path.GetDirectoryName(dbPath));
                System.IO.File.Create(dbPath).Close();
            }


            //conn = new SqliteConnection($"Filename={dbPath}");
            var connectionString = String.Format("Data Source={0}", dbPath);
            DbConnection conn2 = new SQLiteConnection(connectionString);
            conn = conn2;
            conn.Open();
        }

        public static Adatbazis init()
        {
            if(instance == null)
            {
                instance = new Adatbazis();
                instance.initDb();
            }
            return instance;
        }

        public static Adatbazis Instance
        {
            get
            {
                if (instance == null)
                {
                    throw new Exception("Adatbazis nincs inicializalva");
                }
                return instance;
            }
        }
    }
}
