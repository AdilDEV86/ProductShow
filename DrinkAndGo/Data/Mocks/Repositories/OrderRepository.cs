using DrinkAndGo.Data.Interface;
using DrinkAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.Mocks.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly MyDbContext _myDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(MyDbContext myDbContext, ShoppingCart shoppingCart)
        {
            _myDbContext = myDbContext;
            _shoppingCart = shoppingCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            _myDbContext.Orders.Add(order);
            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
            foreach (var item in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = item.Amount,
                    DrinkId = item.Drink.DrinkId,
                    OrderId = order.OrderId,
                    Price = item.Drink.Price
                };
            }
        }
    }
}
