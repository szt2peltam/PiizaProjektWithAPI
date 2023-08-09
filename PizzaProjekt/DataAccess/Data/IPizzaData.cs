using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public interface IPizzaData
    {

        Task DeleteOrder(int ID);
        Task<IEnumerable<PizzaModel>> GetPizza(int ID);
        Task<IEnumerable<PizzaModel>> GetPizzas();
        Task InsertOrder(OrderPizzaModel Order);
    }
}
