using System;

namespace ConsoleApp1
{
    public class Employee : Handler
    {
        public override void HandleRequest(PurchaseOrder purchase)
        {
            ISpecification<PurchaseOrder> specification = new Specification<PurchaseOrder>(x => x.Price < 100);
            specification.And(new Specification<PurchaseOrder>(x => x.Amount == 1));

            if (specification.IsSatisfiedBy(purchase))
                Console.WriteLine("{0} approved purchase request #{1}", this.GetType().Name, purchase.RequestNumber);
            else if (successor != null)
                successor.HandleRequest(purchase);
        }
    }
}
