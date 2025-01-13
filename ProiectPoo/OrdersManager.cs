    internal class OrdersManager
    {
        private Queue<Order> orders = new Queue<Order>();
        public void AddOrder(Order order)
        {
            orders.Enqueue(order);
        }
        public bool DeleteOrder(int id)
        {
            Order orderToDelete = null;
            var ordersNewList = new Queue<Order>();
            while (orders.Count > 0)
            {
                var CurrentOrder = orders.Dequeue();
                if (CurrentOrder.ID == id)
                {
                    orderToDelete = CurrentOrder;
                }
                else
                {
                    ordersNewList.Enqueue(CurrentOrder);
                }
            }
            orders = ordersNewList;
            if (orderToDelete != null)
            {
                return true;
            }
            else return false;
        }
    }
