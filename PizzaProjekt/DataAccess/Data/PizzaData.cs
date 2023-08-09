using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class PizzaData : IPizzaData
    {
        private readonly ISqlDataAccess _db;

        public PizzaData(ISqlDataAccess db)
        {
            _db = db;

        }

        public Task<IEnumerable<PizzaModel>> GetPizzas() =>
            _db.LoadData<PizzaModel, dynamic>("dbo.spOrders_GetAll", new { });


        public async Task<IEnumerable< PizzaModel>> GetPizza(int UserID)
        {
            var results = await _db.LoadData<PizzaModel, dynamic>(
                "dbo.spOrders_Get",
                new { UserId = UserID });


            return results;

            
        }


        public Task DeleteOrder(int ID) =>
            _db.SaveData("dbo.spOrders_Delete", new { OrderId = ID });

        public Task InsertOrder(OrderPizzaModel Order) =>
        _db.SaveData("dbo.spOrders_Insert", new {Order.UserId, Order.DB,Order.Type,
        Order.Sauce, Order.Pepperoni, Order.Ham, Order.Bacon, Order.Chicken,
        Order.MincedMeat,Order.Tomato, Order.Pepper, Order.Corn,
        Order.Mushroom, Order.Pineapple, Order.Ruccola, Order.EggDB, Order.ExtraCheese});
    }
}
