using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using Models;
using System.Configuration;

namespace Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private string Conn { get; set; } 

        public PedidoRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public bool Inserir(Pedido pedido)
        {

            var status = false;

            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                
                db.Execute("INSERT INTO TB_PEDIDO (Descricao, Mesa, IdItem) values (@Descricao, @Mesa, @IdItem)", 
                    new { Descricao = pedido.Descricao, Mesa = pedido.Mesa, IdItem = pedido.Item.Id });

                status = true;
                db.Close();
            }
            return status;
        }

    }
}
