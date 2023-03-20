using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1FoodLibrary.Repository
{
    public interface IOrderRepository
    {
        public void CreateOrder(OrderDTO orderDTO);
        public void CreateOrderDetails(OrderDTO orderDTO);
        public OrderDTO GetOrderByOrderID(string orderID);
        public IEnumerable<OrderDetailsDTO> GetListOrderDetailsByOrderID(string orderID);
        public IEnumerable<OrderDTO> GetListOrderByAccountID(string accountID);
        public IEnumerable<OrderDTO> GetAllOrder();
    }
}
