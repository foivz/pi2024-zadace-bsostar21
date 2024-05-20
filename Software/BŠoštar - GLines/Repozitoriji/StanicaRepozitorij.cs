using BŠoštar___GLines.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BŠoštar___GLines.Repozitoriji
{
    public class StanicaRepozitorij
    {
        public static Stanica GetStanica(int id)
        {
            Stanica stanica = null;

            string sql = $"SELECT * FROM Stanica WHERE IdStanica = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();  
                stanica = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return stanica;
        }

        public static List<Stanica> GetStanice()
        {
            var stanice = new List<Stanica>();

            string sql = "SELECT * FROM Stanica";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Stanica stanica = CreateObject(reader);
                stanice.Add(stanica);
            }
            reader.Close();
            DB.CloseConnection();

            return stanice;
        }

        private static Stanica CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["IdStanica"].ToString());
            string naziv = reader["nazivStanice"].ToString();
            string adresa = reader["adresaStanice"].ToString() ;

            var stanica = new Stanica
            {
                idStanica = id,
                nazivStanica = naziv,
                adresaStanica = adresa
            };

            return stanica;
        }


    }
}
