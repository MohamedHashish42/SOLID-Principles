namespace SOLID_Principles.ISP.ExWithoutUsingISP
{
    class LiquidInkjetPrinter : IPrinterTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }

        #region Methods we dont't need (Violation to ISP)
        public void Fax(string FaxContent)
        {
            throw new NotImplementedException();
        }
        public void PrintDuplex(string PrintDuplexContent)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
