using Models;
using Repositories;

namespace Services
{
    public class PedidoService
    {
        private IPedidoRepository _pedidoRepository;

        public PedidoService()
        {
            _pedidoRepository = new PedidoRepository();
        }

        public bool Inserir(Pedido pedido)
        {
            return _pedidoRepository.Inserir(pedido);
        }
    }
}
