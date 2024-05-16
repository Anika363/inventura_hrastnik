using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Items;

namespace Items
{
    public class ItemsDataBase
    {
        //SQLiteDataReader reader;
        //latnisti 
        //konsruktor
        private SQLiteConnection conn = new SQLiteConnection("datasource=Items_database.db");
        public ItemsDataBase()
        {

        }

        //metode
        /*public string SaveItem(int kira)
        {

            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                if (kira == 0)
                {
                    cmd.CommandText = "INSERT INTO item (ime , cena, teza, nooforces, amountofram, hddsize) Values  ";
                }
                else if (kira == 1)
                {
                    cmd.CommandText = "INSERT INTO computer";
                }
                else if (kira == 2)
                {
                    cmd.CommandText = "INSERT INTO software";
                }
                else if (kira == 3)
                {
                    cmd.CommandText = "INSERT INTO hardware";
                }
                else if (kira == 4)
                {
                    cmd.CommandText = "INSERT INTO monitor";
                }

                return SaveItem(kira);
            }*/

        public string SaveintoItem(string ime, int ce, int sif)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {

                cmd.CommandText = "INSERT INTO item (ime , cena) VALUES ('" + ime + "','" + ce + "');";
                return cmd.CommandText;
            }


        }
        public string SaveintoComputer(string ime, int ce, float tez, int noo, int ram, int hdd)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "INSERT INTO racunalnik (ime , cena, teza, stjedr, ram, hddvel) VALUES (@ime, @ce, @tez, @noo, @ram, @hdd);";
                cmd.Parameters.AddWithValue("@ime", ime);
                cmd.Parameters.AddWithValue("@ce", ce);
                cmd.Parameters.AddWithValue("@tez", tez);
                cmd.Parameters.AddWithValue("@noo", noo);
                cmd.Parameters.AddWithValue("@ram", ram);
                cmd.Parameters.AddWithValue("@hdd", hdd);
                try
                {
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Test");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                
                //cmd.CommandText = "INSERT INTO item (ime , cena) VALUES ('" + ime + "','" + ce + "');";
                //cmd.ExecuteNonQuery();
                return cmd.CommandText;
            }
            
        }
        public string SaveintoHardware(string ime, int ce, float tez)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "INSERT INTO stojna (ime , cena, teza) VALUES ('" + ime + "','" + ce + "','" + tez + "');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO item (ime , cena) VALUES ('" + ime + "','" + ce + "');";
                cmd.ExecuteNonQuery();
                return cmd.CommandText;
            }

        }
        public string SaveintoMonitor(string ime, int ce, float tez, string res, string tip)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
               cmd.CommandText = "INSERT INTO monitor (ime , cena, teza, resolucija, tipmonitorja) VALUES ('" + ime + "','" + ce + "','" + tez + "','" + res + "','" + tip + "');";
                cmd.ExecuteNonQuery();
                return cmd.CommandText;
            }

        }
        public string SaveintoSoftware(string ime, int ce, string lice, int mb)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "INSERT INTO programska (ime , cena, kljuc, prostorMB ) VALUES ('" + ime + "','" + ce + "','" + lice + "','" + mb + "');";
                cmd.ExecuteNonQuery();
                return cmd.CommandText;
            }
        }

        public string ReadItem(string ime)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "SELECT * FROM item '" + ime + "', ;";
                return cmd.CommandText;
            }
        }
        public string ReadItemID(string kira, int idi)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "SELECT * FROM '" + kira + "' WHERE (id = '" + idi + "');";
                return cmd.CommandText;
            }
        }
        public string UpdateCmputer(int idi, string im, int ce, float tez, int cores, int ram, int hdd)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                
                cmd.CommandText = "UPDATE racunalnik SET ime='" + im + "', cena='" + ce + "', teza='" + tez + "', stjedr='" + cores + "', ram='" + ram + "', hddvel='" + hdd + "' WHERE id = '" + idi + "' ;";
                cmd.ExecuteNonQuery();
                return cmd.CommandText;
            }
        }
        public string UpdateHardware(int idi, string im, int ce, float tez)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "UPDATE stojna SET ime='" + im + "'cena='" + ce + "'teza='" + tez + "' WHERE id = '" + idi + "' ;";
                cmd.ExecuteNonQuery();
                return cmd.CommandText;
            }
        }
        public string UpdateItem(int idi, string im, int ce)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "UPDATE item SET ime='" + im + "'cena='" + ce + "' WHERE id = '" + idi + "' ;";
                cmd.ExecuteNonQuery();
                return cmd.CommandText;
            }
        }
        public string UpdateMonitor(int idi, string im, int ce, float tez, string res, string tip)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "UPDATE monitor SET ime='" + im + "',cena='" + ce + "',teza='" + tez + "',resolucija='" + res + "',tipmonitorja='" + tip + "' WHERE id = '" + idi + "' ;";
                cmd.ExecuteNonQuery();
                return cmd.CommandText;
            }
        }
        public string UpdateSoftware(int idi, string im, int ce, string key, int mb)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "UPDATE programska SET ime='" + im + "',cena='" + ce + "', kljuc='" + key + "', prostorMB='" + mb + "' WHERE id = '" + idi + "' ;";
                cmd.ExecuteNonQuery();
                return cmd.CommandText;
            }
        }
        public string DeliteComputer(int idi)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "DELETE FROM racunalnik WHERE id = '" + idi + "';";
                cmd.ExecuteNonQuery();
                return cmd.CommandText;
            }
        }
        public string DeliteHardware(int idi)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "DELETE FROM stojna WHERE id = '" + idi + "';";
                cmd.ExecuteNonQuery();
                return cmd.CommandText;
            }
        }
        public string DeliteItem(int idi)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "DELETE FROM item WHERE id = '" + idi + "';";
                cmd.ExecuteNonQuery();
                return cmd.CommandText;
            }
        }
        public string DeliteMonitor(int idi)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "DELETE FROM monitor WHERE id = '" + idi + "';";
                cmd.ExecuteNonQuery();
                return cmd.CommandText;
            }
        }
        // da prikaže na listbox

        public List<string> ReadItemsFromDatabaseMonitor()
        {
            List<string> items = new List<string>();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                string query = "SELECT id, ime, cena, teza, resolucija, tipmonitorja FROM monitor";

                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {

                    conn.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string itemName = reader["ime"].ToString()+ "|" + reader["id"].ToString()+ "|" + reader["cena"].ToString()+ "|" + reader["teza"].ToString()+ "|" + reader["resolucija"].ToString()+ 
                                "|" + reader["tipmonitorja"].ToString();
                            items.Add(itemName);
                        }
                    }
                }

            }

            return items;

        }
        public List<string> ReadItemsFromDatabaseSoftware()
        {
            List<string> items = new List<string>();

            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                string query = "SELECT id, ime , cena, kljuc, prostorMB FROM programska"; 

                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {

                    conn.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string itemName = reader["ime"].ToString()+ "|" + reader["id"].ToString()+ "|" + reader["cena"].ToString()+ "|" + reader["kljuc"].ToString()+ "|" + reader["prostorMB"].ToString();
                            items.Add(itemName);
                        }
                    }
                }
            }

            return items;

        }
        public List<string> ReadItemsFromDatabaseHardware()
        {
            List<string> items = new List<string>();

            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                string query = "SELECT id, ime, cena, teza FROM stojna"; // Assuming 'Name' is the column name in your database table

                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {

                    conn.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string itemName = reader["ime"].ToString()+ "|" + reader["id"].ToString()+ "|" + reader["cena"].ToString()+ "|" + reader["teza"].ToString();
                            items.Add(itemName);
                        }
                    }
                }
            }

            return items;

        }
        public List<string> ReadItemsFromDatabaseComputer()
        {
            List<string> items = new List<string>();

            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                string query = "SELECT id, ime, cena, teza, stjedr, ram, hddvel FROM racunalnik"; // Assuming 'Name' is the column name in your database table

                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {

                    conn.Open();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string itemName = reader["ime"].ToString()+ "|" + reader["id"].ToString()+ "|" + reader["cena"].ToString()+ "|" + reader["teza"].ToString()+ "|" + reader["stjedr"].ToString()+  "|" + reader["ram"].ToString()+ "|" + reader["hddvel"].ToString();
                            items.Add(itemName);
                        }
                    }
                }
            }

            return items;

        }
        public string DeliteSoftware(int idi)
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(conn))
            {
                cmd.CommandText = "DELETE FROM programska WHERE id = '" + idi + "';";
                return cmd.CommandText;
            }
        }
    }
}

