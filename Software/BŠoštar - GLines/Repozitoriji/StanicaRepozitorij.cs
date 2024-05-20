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
                nazivStanice = naziv,
                adresaStanice = adresa
            };

            return stanica;
        }

        public static int Save(Stanica stanice)
        {
            string sqlInsert = "";
            sqlInsert = "INSERT INTO Stanica (nazivStanice, adresaStanice) VALUES ('" + stanice.nazivStanice + "', '" + stanice.adresaStanice + "')";

            DB.OpenConnection();
            int rowsAffected = DB.ExecuteCommand(sqlInsert);
            DB.CloseConnection();

            return rowsAffected;

        }

        public static int Delete(Stanica stanice)
        {
            string sqlDelete = "DELETE FROM Stanica WHERE IdStanica = " + stanice.idStanica;

            DB.OpenConnection();
            int rowsAffected = DB.ExecuteCommand(sqlDelete);
            DB.CloseConnection();

            return rowsAffected;

        }

        public static int Update(Stanica stanice)
        {
            string sqlUpdate = "";
            sqlUpdate = "UPDATE Stanica SET nazivStanice = '"
                + stanice.nazivStanice + "', adresaStanice = '"
                + stanice.adresaStanice
                + "' WHERE IdStanica = " + stanice.idStanica;

            DB.OpenConnection();
            int rowsAffected = DB.ExecuteCommand(sqlUpdate);
            DB.CloseConnection();

            return rowsAffected;

        }


    }
}
