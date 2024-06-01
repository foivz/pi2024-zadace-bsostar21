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
    public class LinijaVozniRedRepozitorij
    {
        public static LinijaVozniRed GetLinijaVozniRed(int IdLinija, int IdVozniRed)
        {
            LinijaVozniRed linijavozni = null;

            string sql = $"SELECT * FROM LinijaVozniRed WHERE IdLinija = {IdLinija} AND IdLinija = {IdVozniRed}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                linijavozni = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return linijavozni;
        }

        public static List<LinijaVozniRed> GetLinijaVozniRedovi()
        {
            var linijevozniredovi = new List<LinijaVozniRed>();

            string sql = "SELECT * FROM LinijaVozniRed";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                LinijaVozniRed linijavozni = CreateObject(reader);
                linijevozniredovi.Add(linijavozni);
            }
            reader.Close();
            DB.CloseConnection();

            return linijevozniredovi;
        }

        private static LinijaVozniRed CreateObject(SqlDataReader reader)
        {
            int idLinija = int.Parse(reader["IdLinija"].ToString());
            int idVozniRed = int.Parse(reader["IdVozniRed"].ToString());

            var linija = LinijaRepozitorij.GetLinija(idLinija);
            var stanica = VozniRedRepozitorij.GetVozniRed(idVozniRed);

            var linijavoznired = new LinijaVozniRed
            {
                IdVozniRed = idVozniRed,
                VozniRed = stanica,
                IdLinija = idLinija,
                Linija = linija
            };

            return linijavoznired;
        }

        public static int Save(LinijaVozniRed linijaVozni)
        {
            string sqlInsert = "INSERT INTO LinijaVozniRed (IdLinija, IdVozniRed) VALUES ('" + linijaVozni.IdLinija + "', '" + linijaVozni.IdVozniRed + "')";

            DB.OpenConnection();
            int rowsAffected = DB.ExecuteCommand(sqlInsert);
            DB.CloseConnection();

            return rowsAffected;
        }

        public static int Delete(LinijaVozniRed linijaVozni)
        {
            string sqlDelete = $"DELETE FROM LinijaVozniRed WHERE IdLinija = {linijaVozni.IdLinija} AND IdLinija = {linijaVozni.IdVozniRed}";

            DB.OpenConnection();
            int rowsAffected = DB.ExecuteCommand(sqlDelete);
            DB.CloseConnection();

            return rowsAffected;
        }
    }
}
