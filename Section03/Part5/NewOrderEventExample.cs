using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_course_20_AbuHadhoud_Console.Section3.Part5
{
    public class OrderEventArgs : EventArgs
    {
        public int OrderID { get; }
        public int OrderTotalPrice { get; }
        public string ClientEmail { get; }

        public OrderEventArgs(int orderID, int orderTotalPrice, string clientEmail)
        {
            this.OrderID = orderID;
            this.OrderTotalPrice = orderTotalPrice;
            this.ClientEmail = clientEmail;
        }

    }

    public class Order
    {
        public event EventHandler<OrderEventArgs> OnOrderCreated;

        public void Create(int orderID, int orederTotalPrice, string clientEmail)
        {
            Console.WriteLine("New Order created; now will notify everyone by raising the event.\n");

            if(OnOrderCreated != null)
            {
                OnOrderCreated.Invoke(this, new OrderEventArgs(orderID, orederTotalPrice, clientEmail));
            }
        }
    }


    public class EmailService
    {

        public void Subscribe(Order order)
        {
            order.OnOrderCreated += HandleEventOrder;
        }

        public void Unsubscribe(Order order)
        {
            order.OnOrderCreated -= HandleEventOrder;
        }

        public void HandleEventOrder(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"--------------------Email Service--------------------");
            Console.WriteLine($"Order ID: {e.OrderID}");
            Console.WriteLine($"Order Total Price: {e.OrderTotalPrice}");
            Console.WriteLine($"Cline Email: {e.ClientEmail}");
            Console.WriteLine($"\nSend an Email.");
            Console.WriteLine($"-----------------------------------------------------");

        }
    }



    public class SMSService
    {
        public void Subscribe(Order order)
        {
            order.OnOrderCreated += HandleEventOrder;
        }

        public void Unsubscribe(Order order)
        {
            order.OnOrderCreated -= HandleEventOrder;
        }

        public void HandleEventOrder(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"--------------------SMS Service--------------------");
            Console.WriteLine($"Order ID: {e.OrderID}");
            Console.WriteLine($"Order Total Price: {e.OrderTotalPrice}");
            Console.WriteLine($"Cline Email: {e.ClientEmail}");
            Console.WriteLine($"\nSend an SMS.");
            Console.WriteLine($"---------------------------------------------------");

        }
    }


    public class ShippingService
    {
        public void Subscribe(Order order)
        {
            order.OnOrderCreated += HandleEventOrder;
        }

        public void Unsubscribe(Order order)
        {
            order.OnOrderCreated -= HandleEventOrder;
        }

        public void HandleEventOrder(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"--------------------Shipping Service--------------------");
            Console.WriteLine($"Order ID: {e.OrderID}");
            Console.WriteLine($"Order Total Price: {e.OrderTotalPrice}");
            Console.WriteLine($"Cline Email: {e.ClientEmail}");
            Console.WriteLine($"\nSend an Shipping.");
            Console.WriteLine($"--------------------------------------------------------");

        }
    }
}
