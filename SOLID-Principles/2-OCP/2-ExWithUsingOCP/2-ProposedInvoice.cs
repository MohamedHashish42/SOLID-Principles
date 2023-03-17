namespace SOLID_Principles.OCP.ExWithUsingOCP
{
    class ProposedInvoice : IInvoiceDiscount
    {
        public double GetInvoiceDiscount(double amount)
        {
            return amount - 50;
        }
    }
}
