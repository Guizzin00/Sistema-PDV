using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PDV
{
    class Conexao
    {
        public string conec = "SERVER=localhost; DATABASE=pdv; UID=root; PWD=; PORT=3306;";

        public MySqlConnection con = null;

        public void AbrirConexao()
        {
            con = new MySqlConnection(conec);
            con.Open();
        }

        public void FecharConexao()
        {
            con = new MySqlConnection(conec);
            con.Close();
            con.Dispose();
            con.ClearAllPoolsAsync();

        }

} //fim do projeto
}
