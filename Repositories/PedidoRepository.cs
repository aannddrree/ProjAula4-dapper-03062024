using Dapper;
using Microsoft.Data.SqlClient;
using Models;

namespace Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private string Conn { get; set; } 

        public PedidoRepository()
        {
            Conn = "Server=DESKTOP-6NSSVDC;Database=projAula4;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=Yes";
        }

        public bool Inserir(Pedido pedido)
        {

            var status = false;

            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                db.Execute("INSERT INTO TB_PEDIDO (Descricao, Mesa) values (@Descricao, @Mesa)", pedido);
                //db.Execute("INSERT INTO TB_PEDIDO (Id, Descricao, Mesa) values (@pera, @uva, @abacate)", new { pera = "", uva = "", abacate = "" });
                status = true;
                db.Close();
            }
            return status;
        }

    }
}
