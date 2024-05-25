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
            string sql = $"SELECT * FROM Students WHERE ID_linije = {id}";
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
                Linija linija = CreateObject(reader) ;
                linije.Add(linija);
            }
            reader.Close();
            DB.CloseConnection( );
            return linije;
        }
        private static Linija CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID_linije"].ToString());
            
            var linija = new Linija {
                ID_linije = id
            
            };
            return linija;
        }
    }
}
