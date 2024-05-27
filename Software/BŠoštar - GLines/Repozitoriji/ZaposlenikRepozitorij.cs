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
    public class ZaposlenikRepozitorij
    {
        public static Zaposlenik GetZaposlenik(string username)
        {
            string sql = $"SELECT * FROM Zaposlenik WHERE korIme = '{username}'";
            return FetchZaposlenik(sql);
        }


        public static Zaposlenik GetZaposlenik(int id)
        {
            string sql = $"SELECT * FROM Zaposlenik WHERE IdZaposlenik = {id}";
            return FetchZaposlenik(sql);
        }

        private static Zaposlenik FetchZaposlenik(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Zaposlenik teacher = null;

            if (reader.HasRows == true)
            {
                reader.Read();
                teacher = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return teacher;
        }

        private static Zaposlenik CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["IdZaposlenik"].ToString());
            string ime = reader["imeZaposlenik"].ToString();
            string prezime = reader["prezimeZaposlenik"].ToString();
            string korime = reader["korIme"].ToString();
            string lozz = reader["lozinka"].ToString();

            var zaposlenik = new Zaposlenik
            {
                IdZaposlenik = id,
                imeZaposlenik = ime,
                prezimeZaposlenik = prezime,
                korIme = korime,
                lozinka = lozz
            };

            return zaposlenik;
        }
    }
}
