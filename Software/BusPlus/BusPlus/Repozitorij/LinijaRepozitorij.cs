using System;
using DBLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusPlus.Klase;
using System.Data.SqlClient;

namespace BusPlus.Repozitorij
{
    public class LinijaRepozitorij
    {
        public static Linija GetLinija(int id)
        {
            Linija linija = null;
            string sql = $"SELECT * FROM AutobusneLinije WHERE ID_linije = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if(reader.HasRows)
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
            string sql = "SELECT * FROM AutobusneLinije";
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
            int id = int.Parse(reader["ID_linije"].ToString());
            string pocStanica = reader["PocetnaStanica"].ToString();
            string zavrStanica = reader["ZavrsnaStanica"].ToString() ;
            int brBus = int.Parse(reader["BrojAutobusa"].ToString()) ;
            string pocVrijeme = reader["PocetnoVrijeme"].ToString();
            string zavrVrijeme = reader["ZavrsnoVrijeme"].ToString();
            var linija = new Linija (id, pocStanica, zavrStanica, brBus, pocVrijeme, zavrVrijeme) {
                ID_linije = id,
                PocetnaStanica = pocStanica,
                ZavrsnaStanica = zavrStanica,
                BrojAutobusa = brBus,
                PocetnoVrijeme= pocVrijeme,
                ZavrsnoVrijeme = zavrVrijeme,
            };
            return linija;
        }
        public static void ubaciLiniju(Linija linija, int id, string pocstan, string zavrstan, int brbus, string pocvreme, string zavrvreme)
        {
            
            string uvjet = $"INSERT INTO AutobusneLinije (ID_linije, PocetnaStanica, ZavrsnaStanica, BrojAutobusa, PocetnoVrijeme, ZavrsnoVrijeme) VALUES ({id}, {pocstan}, {zavrstan}, {brbus}, {pocvreme}, {zavrvreme})";
            DB.OpenConnection();
            DB.ExecuteCommand(uvjet);
            DB.CloseConnection();
        }
        public static void azurirajLiniju(Linija linija, int id, string pocstan, string zavrstan, int brbus, string pocvreme, string zavrvreme)
        { 
            string uvjet = $"UPDATE AutobusneLinije SET ID_linije = {id}, PocetnaStanica = {pocstan}, ZavrsnaStanica = {zavrstan}, BrojAutobusa = {brbus}, PocetnoVrijeme = {pocvreme}, ZavrsnoVrijeme = {zavrvreme}";
            DB.OpenConnection();
            DB.ExecuteCommand(uvjet);
            DB.CloseConnection( );
        }
    }
}
