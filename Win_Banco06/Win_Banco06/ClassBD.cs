using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Win_Banco06
{
    public class ClassBD
    {
        string con = "server=127.0.0.1;" +
                     "user id=root;" +
                     "pwd='master';" +
                     "database=produto";

        MySqlDataAdapter dt = new MySqlDataAdapter();
        DataSet ds = new DataSet();
        private MySqlConnection AbreBanco()
        {
            MySqlConnection ocon = new MySqlConnection();
            ocon.ConnectionString = this.con;
            ocon.Open();
            return ocon;
        }

        private void FechaBanco(MySqlConnection ocon)
        {
            if (ocon.State == ConnectionState.Open)
            {
                ocon.Close();
            }
        }

        public MySqlDataReader ProcedureRetornaDataSet()
        {
            MySqlConnection ocon = new MySqlConnection();
            try
            {
                ocon = AbreBanco();
                MySqlCommand cmdComando = new MySqlCommand();
                cmdComando.CommandType = CommandType.StoredProcedure;
                cmdComando.CommandText = "Listar_Produtos";
                cmdComando.Connection = ocon;
                return cmdComando.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

    }
}
