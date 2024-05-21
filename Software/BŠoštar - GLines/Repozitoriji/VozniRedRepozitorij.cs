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
    public class VozniRedRepozitorij
    {
        public static VozniRed GetVozniRed(int id)
        {
            VozniRed vozni = null;

            string sql = $"SELECT * FROM VozniRed WHERE IdVozniRed = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                vozni = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return vozni;
        }

        public static List<VozniRed> GetVozneRedove()
        {
            var voznuredovi = new List<VozniRed>();

            string sql = "SELECT * FROM VozniRed";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                VozniRed vozni = CreateObject(reader);
                voznuredovi.Add(vozni);
            }
            reader.Close();
            DB.CloseConnection();

            return voznuredovi;
        }

        private static VozniRed CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["IdVozniRed"].ToString());
            DateTime polazak;
            DateTime.TryParse(reader["vrijemePolaska"].ToString(), out polazak);

            DateTime dolazak;
            DateTime.TryParse(reader["vrijemeDolaska"].ToString(), out dolazak);
            string polazakstanica = reader["stanicaPolaska"].ToString() ;
            string dolazakstanica = reader["stanicaDolaska"].ToString();
            string dan = reader["danUTjednu"].ToString();

            var vozni = new VozniRed
            {
                IdVOzniRed = id,
                vrijemePolaska = polazak,
                vrijemeDolaska = dolazak,
                stanicaPolaska = polazakstanica,
                stanicaDolaska = dolazakstanica,
                danUTjednu = dan,
            };

            return vozni;
        }

        public static int Save(VozniRed redovi)
        {
            string vrijemeP = redovi.vrijemePolaska.ToString("HH:mm");
            string vrijemeD = redovi.vrijemeDolaska.ToString("HH:mm");

            string sqlInsert = "";
            sqlInsert = "INSERT INTO VozniRed (vrijemePolaska, vrijemeDolaska, stanicaPolaska, stanicaDolaska, danUTjednu) VALUES ('" + vrijemeP + "', '" + vrijemeD + "', '" + redovi.stanicaPolaska + "', '" + redovi.stanicaDolaska + "', '" + redovi.danUTjednu + "')";

            DB.OpenConnection();
            int rowsAffected = DB.ExecuteCommand(sqlInsert);
            DB.CloseConnection();

            return rowsAffected;

        }

        public static int Delete(VozniRed redovi)
        {
            string sqlDelete = "DELETE FROM VozniRed WHERE IdVozniRed = " + redovi.IdVOzniRed;

            DB.OpenConnection();
            int rowsAffected = DB.ExecuteCommand(sqlDelete);
            DB.CloseConnection();

            return rowsAffected;

        }

        public static int Update(VozniRed redovi)
        {

            string vrijemeP = redovi.vrijemePolaska.ToString("HH:mm");
            string vrijemeD = redovi.vrijemeDolaska.ToString("HH:mm");

            string sqlUpdate = "";
            sqlUpdate = "UPDATE VozniRed SET vrijemePolaska = '"
                + vrijemeP + "', vrijemeDolaska = '"
                + vrijemeD + "', stanicaPolaska = '"
                + redovi.stanicaPolaska + "', stanicaDolaska = '"
                + redovi.stanicaDolaska + "', danUTjednu = '" + redovi.danUTjednu
                + "' WHERE IdVozniRed = " + redovi.IdVOzniRed;
            DB.OpenConnection();
            int rowsAffected = DB.ExecuteCommand(sqlUpdate);
            DB.CloseConnection();

            return rowsAffected;

        }
    }
}
