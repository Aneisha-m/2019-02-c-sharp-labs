using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using lab_10;

namespace lab_10_entity
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)//main method
        {
            
            ////encapsulates database connection so its closed cleanly 
            using (var db = new NorthwindEntities()) {
                //    //customers list =(read from northwind)
                //    // (pull out all customers)
                //    //(send to list of customers)
             
                var customers2 = db.Customers;
            }
            //use list 
            foreach(var customer in customers)
            {
             Console.WriteLine($"{customer.ContactName} has ID" + $"{customer.CustomerID} from {customer.City}");
            }

            //CRUD  R = READ

            //select one customer

            using (var db = new NorthwindEntities())
            {
                //LINQ query : Microsoft thing : Language Independent Query
                var customerToUpdate =
                    (from customer in db.Customers //select all customers in northwind
                    where customer.CustomerID == "ALFKI" //choose the one ID matches
                    select customer).FirstOrDefault(); // output this one selected
                Console.WriteLine("\n\nfinding one customer\n");
                Console.WriteLine($"{customerToUpdate.ContactName}"+$" lives in {customerToUpdate.City}");
             }


            using (var db = new NorthwindEntities())
            {
                //LINQ query : Microsoft thing : Language Independent Query
                var customerToUpdate =
                    db.Customers.Where(c => c.CustomerID == "ALFKI").FirstOrDefault(); //using Lamda => //powerful when chaining queries
                Console.WriteLine("\n\nfinding one customer\n");
                Console.WriteLine($"{customerToUpdate.ContactName}" + $" lives in {customerToUpdate.City}");

                //Update
                customerToUpdate.ContactName = "Fred Flintstone"; //update customer
                db.SaveChanges(); //Update DB permmanently
            }

            //Insert New Customer
            using(var db = new NorthwindEntities())
            {
                Customer customerToCreate = new Customer //or use var instead of customer
                {
                    CustomerID = "Phil0",
                    ContactName = "Awesome Name",
                    City = "my city",
                    CompanyName ="Sparta"
                };

                //now add new customer to local db
                db.Customers.Add(customerToCreate); //db updates local cache copy so changes here wont be permanent

                //write changes permanently to real db
                db.SaveChanges();
            }

            //have a look at customers after insert and update is done
            Console.WriteLine("\n\nView Customers after INSERT and UPDATE\n\n");
            DisplayAll();

            //DELETE 
            using(var db = new NorthwindEntities())
            {
                var customerToDelete = db.Customers
                    .Where(c => c.CustomerID == "Phil0")
                    .FirstOrDefault();
                db.Customers.Remove(customerToDelete);
                db.SaveChanges();
            }

            //have a look at customers after delete is done
            Console.WriteLine("\n\nView Customers after DELETE\n\n");
            DisplayAll(); 

        }

        static void DisplayAll()
        {
            // encapsulates database connection so it's closed cleanly
            using (var db = new NorthwindEntities())
            {

                customers = db.Customers.ToList<Customer>();
            }


            // use list!!!
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"{customer.ContactName} has ID {customer.CustomerID} and lives in {customer.City}, {customer.Country}.\n");
            }
        }//display all method
    }
}
