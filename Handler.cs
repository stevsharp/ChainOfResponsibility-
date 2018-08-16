namespace ConsoleApp1
{
    public abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler purchaseOrder )
        {
            this.successor = purchaseOrder;
        }
        public abstract void HandleRequest(PurchaseOrder purchase);
    }
}
