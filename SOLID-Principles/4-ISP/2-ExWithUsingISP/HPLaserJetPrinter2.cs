namespace SOLID_Principles.ISP.ExWithUsingISP
{
    class HPLaserJetPrinter2 : IPrinterTasks, IFaxTasks, IPrintDuplexTasks
    {
        public void Print(string PrintContent)
        {
            throw new NotImplementedException();
        }
        public void Scan(string ScanContent)
        {
            throw new NotImplementedException();
        }
        public void Fax(string content)
        {
            throw new NotImplementedException();
        }
        public void PrintDuplex(string content)
        {
            throw new NotImplementedException();
        }
    }
}
