namespace SOLID_Principles.OCP.ExWithUsingOCP
{
    class InvoiceWithOCP
    {
        public double GetInvoiceDiscount(double amount, IInvoiceDiscount invoiceDiscount)
        {
           return  invoiceDiscount.GetInvoiceDiscount(amount);
        }
    }
}
