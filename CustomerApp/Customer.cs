using System.Collections.Generic;
using Nest;


namespace CustomerApp
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;


        public Customer()
        {
            Orders = new List<Order>();     //always create an empty list 
        }

        public Customer(int id)
            : this()           // call the default constructor each time
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Id = id;
            this.Name = name;    
        }
    }
}