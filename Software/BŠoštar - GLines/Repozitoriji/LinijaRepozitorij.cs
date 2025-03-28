﻿using BŠoštar___GLines.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BŠoštar___GLines.Repozitoriji
{
    public class LinijaRepozitorij
    {
        public static Linija GetLinija(int id)
        {
            Linija linija = null;

            string sql = $"SELECT * FROM Linija WHERE IdLinija = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                linija = CreateObject(reader);
                reader.Close();

            }
            DB.CloseConnection();
            return linija;  
        }

        public static List<Linija> GetLinije()
        {
            var linije = new List<Linija>();

            string sql = "SELECT * FROM Linija";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Linija linija = CreateObject(reader);
                linije.Add(linija);
            }
            reader.Close();
            DB.CloseConnection();

            return linije;
        }

        public static List<Linija> GetLinijaByName(string naziv)
        {
            var linije = new List<Linija>();

            string sql = $"SELECT * FROM Linija WHERE nazivLinije LIKE '%{naziv}%'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Linija linija = CreateObject(reader);
                linije.Add(linija);
            }
            reader.Close();
            DB.CloseConnection();

            return linije;
        }


        private static Linija CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["IdLinija"].ToString());
            string naziv = reader["nazivLinije"].ToString();
            string polazisna = reader["polazisnaStanica"].ToString() ;
            string odredisna = reader["odredisnaStanica"].ToString();
            int vrijeme = int.Parse(reader["vrijemePutovanja"].ToString());

            var linija = new Linija
            {
                idLinija = id,
                nazivLinije = naziv,
                polazisnaStanica = polazisna,
                odredisnaStanica = odredisna,
                vrijemePutovanja = vrijeme
            };

            return linija;
        }

        public static int Save(Linija linije)
        {
            string sqlInsert = "";
            sqlInsert = "INSERT INTO Linija (nazivLinije, polazisnaStanica, odredisnaStanica, vrijemePutovanja) VALUES ('" + linije.nazivLinije + "', '" + linije.polazisnaStanica + "', '" + linije.odredisnaStanica + "', '" + linije.vrijemePutovanja + "')";

            DB.OpenConnection();
            int rowsAffected = DB.ExecuteCommand(sqlInsert);
            DB.CloseConnection();


            return rowsAffected;

        }

        public static int Delete(Linija linija)
        {
            
            if (IsLinijaInUse(linija.idLinija))
            {
                MessageBox.Show("Linija se koristi.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
            else
            {
                string sqlDeleteStanicaLinija = "DELETE FROM StanicaLinija WHERE IdLinija = " + linija.idLinija;
                DB.OpenConnection();
                int rowsAffectedStanicaLinija = DB.ExecuteCommand(sqlDeleteStanicaLinija);
                DB.CloseConnection();

                string sqlDeleteLinija = "DELETE FROM Linija WHERE IdLinija = " + linija.idLinija;
                DB.OpenConnection();
                int rowsAffectedLinija = DB.ExecuteCommand(sqlDeleteLinija);
                DB.CloseConnection();

                return rowsAffectedLinija;
            }
            
        }

        public static int Update(Linija linije)
        {
            string sqlUpdate = "";
            sqlUpdate = "UPDATE Linija SET nazivLinije = '"
                + linije.nazivLinije + "', polazisnaStanica = '"
                + linije.polazisnaStanica + "', odredisnaStanica = '"
                + linije.odredisnaStanica + "', vrijemePutovanja = '"
                + linije.vrijemePutovanja
                + "' WHERE IdLinija = " + linije.idLinija;
            DB.OpenConnection();
            int rowsAffected = DB.ExecuteCommand(sqlUpdate);
            DB.CloseConnection();

            return rowsAffected;

        }

        public static bool IsLinijaInUse(int id)
        {
            bool isInUse = false;

            string sqlCheckReference = "SELECT COUNT(*) FROM VozniRed WHERE IdLinija = " + id;
            DB.OpenConnection();
            var reader = DB.GetDataReader(sqlCheckReference);

            if (reader.Read())
            {
                int count = reader.GetInt32(0);
                isInUse = count > 0;
            }

            reader.Close();
            DB.CloseConnection();

            return isInUse;
        }
    }
}
