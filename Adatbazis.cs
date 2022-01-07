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
        private void adatbazisinicializálás() 
        {
            DbCommand parancs = conn.CreateCommand();
            parancs.CommandText = @"CREATE TABLE IF NOT EXISTS cegek (
               id integer primary key, 
               nev varchar(128) not null, 
               cim varchar(256) not null,
               bankszamla_szam varchar(256) not null
);
";
            parancs.CommandText += @"CREATE TABLE IF NOT EXISTS szamlak (
               id integer primary key, 
               tipus integer not null,
               teljesites_datuma date,
               osszeg integer not null default 0,
               letrehozas_datuma date default (datetime('now','localtime')),
               ceg_id integer not null,
               megjegyzes varchar(512),
               foreign key (ceg_id) references cegek (id)
);
";
            parancs.ExecuteNonQuery();
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
                instance.adatbazisinicializálás();
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
