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
    public class StanicaLinijaRepozitorij
    {
        public static StanicaLinija GetStanicaLinija(int IdStanica, int IdLinija)
        {
            StanicaLinija stanicalinija = null;

            string sql = $"SELECT * FROM StanicaLinija WHERE IdStanica = {IdStanica} AND IdLinija = {IdLinija}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                stanicalinija = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return stanicalinija;
        }

         public static List<StanicaLinija> GetStanicaLinije()
        {
            var stanicalinije = new List<StanicaLinija>();

            string sql = "SELECT * FROM StanicaLinija";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                StanicaLinija stanicalinija = CreateObject(reader);
                stanicalinije.Add(stanicalinija);
            }
            reader.Close();
            DB.CloseConnection();

            return stanicalinije;
        }

        private static StanicaLinija CreateObject(SqlDataReader reader)
        {
            int idStanica = int.Parse(reader["IdStanica"].ToString());
            int idLinija = int.Parse(reader["IdLinija"].ToString());

            var stanica = StanicaRepozitorij.GetStanica(idStanica);
            var linija = LinijaRepozitorij.GetLinija(idLinija);

            var stanicalinija = new StanicaLinija
            {
                IdStanica = idStanica,
                Stanica = stanica,
                IdLinija = idLinija,
                Linija = linija
            };

            return stanicalinija;
        }

        public static int Save(StanicaLinija stanicaLinija)
        {
            string sqlInsert = "INSERT INTO StanicaLinija (IdStanica, IdLinija) VALUES ('" + stanicaLinija.IdStanica + "', '" + stanicaLinija.IdLinija + "')";

            DB.OpenConnection();
            int rowsAffected = DB.ExecuteCommand(sqlInsert);
            DB.CloseConnection();

            return rowsAffected;
        }

        public static int Delete(StanicaLinija stanicaLinija)
        {
            string sqlDelete = $"DELETE FROM StanicaLinija WHERE IdStanica = {stanicaLinija.IdStanica} AND IdLinija = {stanicaLinija.IdLinija}";

            DB.OpenConnection();
            int rowsAffected = DB.ExecuteCommand(sqlDelete);
            DB.CloseConnection();

            return rowsAffected;
        }
    }
    
}
