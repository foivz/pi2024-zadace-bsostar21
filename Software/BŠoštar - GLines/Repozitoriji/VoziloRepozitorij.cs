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
    internal class VoziloRepozitorij
    {
        public static Vozilo GetVozilo(int id)
        {
            Vozilo vozilo = null;

            string sql = $"SELECT * FROM Vozilo WHERE IdVozilo = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                vozilo = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return vozilo;
        }

        public static List<Vozilo> GetVozila()
        {
            var vozila = new List<Vozilo>();

            string sql = "SELECT * FROM Vozilo";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Vozilo vozilo = CreateObject(reader);
                vozila.Add(vozilo);
            }
            reader.Close();
            DB.CloseConnection();

            return vozila;
        }

        private static Vozilo CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["IdVozilo"].ToString());
            string oznaka = reader["oznakaVozila"].ToString();
            string model = reader["modelVozila"].ToString();
            string marka = reader["markaVozila"].ToString();
            string naziv = reader["nazivVozila"].ToString();
            int sjedala = int.Parse(reader["brojSjedala"].ToString());
            int mjesta = int.Parse(reader["brojSlobodnihMjesta"].ToString());
            int linija = int.Parse(reader["IdLinija"].ToString());
            int voznired = int.Parse(reader["IdVozniRed"].ToString());


            var vozilo = new Vozilo
            {
                IdVozilo = id,
                oznakaVozila = oznaka,
                modelVozila = model,
                markaVozila = marka,
                nazivVozila = naziv,
                brojSjedala = sjedala,
                brojSlobodnihMjesta = mjesta,
                IdLinija = linija,
                IdVozniRed = voznired,
            };

            return vozilo;
        }

        public static int Save(Vozilo vozilo)
        {

            string sqlInsert = "";
            sqlInsert = "INSERT INTO Vozilo (oznakaVozila, modelVozila, markaVozila, nazivVozila, brojSjedala, brojSlobodnihMjesta, IdLinija, IdVozniRed  ) " +
                "VALUES ('" + vozilo.oznakaVozila + "', '" + vozilo.modelVozila + "', '" + vozilo.markaVozila + "', '" + vozilo.nazivVozila + "', '" + vozilo.brojSjedala + "', '" + vozilo.brojSlobodnihMjesta + "', '" + vozilo.IdLinija + "','" + vozilo.IdVozniRed + "')";

            DB.OpenConnection();
            int rowsAffected = DB.ExecuteCommand(sqlInsert);
            DB.CloseConnection();

            return rowsAffected;

        }

        public static int Delete(Vozilo vozilo)
        {
            string sqlDelete = "DELETE FROM Vozilo WHERE IdVozilo = " + vozilo.IdVozilo;

            DB.OpenConnection();
            int rowsAffected = DB.ExecuteCommand(sqlDelete);
            DB.CloseConnection();

            return rowsAffected;

        }

        public static int Update(Vozilo vozilo)
        {


            string sqlUpdate = "";
            sqlUpdate = "UPDATE Vozilo SET oznakaVozila = '"
                + vozilo.oznakaVozila + "', modelVozila = '"
                + vozilo.modelVozila + "', markaVozila = '"
                + vozilo.markaVozila + "', nazivVozila = '"
                + vozilo.nazivVozila + "', brojSjedala = '"
                + vozilo.brojSjedala + "', brojSlobodnihMjesta = '"
                + vozilo.brojSlobodnihMjesta + "',IdLinija = '"
                + vozilo.IdLinija + "', IdVozniRed = '"
                + vozilo.IdVozniRed
                + "' WHERE IdVozilo = " + vozilo.IdVozilo;
            DB.OpenConnection();
            int rowsAffected = DB.ExecuteCommand(sqlUpdate);
            DB.CloseConnection();

            return rowsAffected;

        }
    }
}
