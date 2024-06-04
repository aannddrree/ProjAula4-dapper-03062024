using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ItemService
    {
        private IItemRepository _repository;

        public ItemService() { 
            _repository = new ItemRepository();
        }

        public int Inserir(Item item)
        {
            return _repository.Inserir(item);   
        }
    }
}
