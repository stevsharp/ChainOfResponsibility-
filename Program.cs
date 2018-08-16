using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var emp = new Employee();
                var superVisor = new Supervisor();
                var generalManager = new GeneralManager();

                emp.SetSuccessor(superVisor);
                superVisor.SetSuccessor(generalManager);

                List<PurchaseOrder> purchaseOrders = new List<PurchaseOrder>
                {
                    new PurchaseOrder { RequestNumber = 1, Amount = 1, Price = 50, Name = "Test Room 1" },
                    new PurchaseOrder { RequestNumber = 1, Amount = 1, Price = 150, Name = "Test Room 2" },
                    new PurchaseOrder { RequestNumber = 1, Amount = 1, Price = 200, Name = "Test Room 3" } ,
                };

                purchaseOrders.ForEach(x => emp.HandleRequest(x));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }


}
