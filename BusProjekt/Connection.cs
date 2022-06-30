using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


namespace BusProjekt
{
    public class Connection
    {

        static string verbindung = "datasource=172.26.136.209;;port=3306;database=busprojekt;username='omen15';password='1234'";
        static MySqlConnection conn = new MySqlConnection(verbindung);


        public void OpenConnection()
        {
            try { conn.Open(); }
            catch (Exception ex) { Console.WriteLine(ex.Message); return; }
            finally{CloseConnection();}
        }

        public void CloseConnection()
        {
            conn.Close();

        }

        public void Inserts(string sql)
        {
            try
            {
                conn.Open();
                MySqlCommand registrarClient = new MySqlCommand(sql, conn);
                MySqlDataReader datareader;
                datareader = registrarClient.ExecuteReader();
                while (datareader.Read()) { }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return; }
            finally { CloseConnection();}              
        }

        public bool Selects(string sql,string inputPasswort)
        {
            try
            {
                string[] dataUser = new string[4];
                conn.Open();
                MySqlCommand queryUser = new MySqlCommand(sql, conn);
                MySqlDataReader datareader = queryUser.ExecuteReader();
                while (datareader.Read())
                {
                    dataUser[0] = datareader["namee"].ToString();
                    dataUser[1] = datareader["vorname"].ToString();
                    dataUser[2] = datareader["email"].ToString();
                    dataUser[3] = datareader["passwort"].ToString();
                }

                string nameUser = dataUser[0]; 
                string vornameUser = dataUser[1]; 
                string emailUser= dataUser[2]; 
                string passwortUser= dataUser[3];


                if (BCrypt.Net.BCrypt.Verify(inputPasswort,passwortUser)){return true;} 
                else{return false;}

            } catch (Exception ex) { Console.WriteLine(ex.Message); return false; }

            finally { CloseConnection();}
        }

    }
}