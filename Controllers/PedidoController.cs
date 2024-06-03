using Models;
using Services;

namespace Controllers
{
    public class PedidoController
    {
        private PedidoService _pedidoService;

        public PedidoController()
        {
            _pedidoService = new PedidoService();
        }
        public bool Inserir(Pedido pedido)
        {
            return _pedidoService.Inserir(pedido);
        }
    }
}
