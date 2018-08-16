using System;

namespace ConsoleApp1
{
    public class Supervisor : Handler
    {
        public override void HandleRequest(PurchaseOrder purchase)
        {
            ISpecification<PurchaseOrder> specification = new Specification<PurchaseOrder>(x => x.Price < 200);

            if (specification.IsSatisfiedBy(purchase))
                Console.WriteLine("{0} approved purchase request #{1}", this.GetType().Name, purchase.RequestNumber);
            else if (successor != null)
                successor.HandleRequest(purchase);
        }
    }
}
