namespace SOLID_Principles.OCP.ExWithUsingOCP
{
    class FinalInvoice : IInvoiceDiscount
    {

        public double GetInvoiceDiscount(double amount)
        {
            return amount - 100;
        }
    }
}
