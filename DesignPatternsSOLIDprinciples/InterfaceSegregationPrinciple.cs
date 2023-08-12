using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSOLIDprinciples
{
    /// <summary>
    /// The Interface Segregation Principle states that 
    /// “Clients should not be forced to implement any methods they don’t use. Rather than one fat interface,
    /// numerous little interfaces are preferred based on groups of methods with each interface serving one 
    /// submodule“
    /// Let us break down the above definition into two parts.
    /// First, no class should be forced to implement any method(s) of an interface they don’t use.
    /// Secondly, instead of creating large or you can say fat interfaces, create multiple smaller interfaces with the aim that the clients should only think about the methods that are of interest to them.
    /// 
    /// </summary>

    //wrong implentation LiquidInkjetPrinter class doesn`t have feature of do Fax or PrintDuplex and it must implement them.
    #region wrong implentation


    public interface IPrinterTasks
    {
        void Print(string PrintContent);
        void Scan(string ScanContent);
        void Fax(string FaxContent);
        void PrintDuplex(string PrintDuplexContent);
    }

    public class HPLaserJetPrinter : IPrinterTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
        public void Fax(string FaxContent)
        {
            Console.WriteLine("Fax content");
        }
        public void PrintDuplex(string PrintDuplexContent)
        {
            Console.WriteLine("Print Duplex content");
        }
    }

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
        public void Fax(string FaxContent)
        {
            throw new NotImplementedException();
        }
        public void PrintDuplex(string PrintDuplexContent)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
    //correct implementation [do small interface as needed]
    #region correct implementation


    public interface IPrinterTasks_
    {
        void Print(string PrintContent);
        void Scan(string ScanContent);
    }
    interface IFaxTasks
    {
        void Fax(string content);
    }
    interface IPrintDuplexTasks
    {
        void PrintDuplex(string content);
    }

    //each class will inherit just the needed interfaces
    public class HPLaserJetPrinter_ : IPrinterTasks_, IFaxTasks,
                                     IPrintDuplexTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
        public void Fax(string FaxContent)
        {
            Console.WriteLine("Fax content");
        }
        public void PrintDuplex(string PrintDuplexContent)
        {
            Console.WriteLine("Print Duplex content");
        }
    }

    class LiquidInkjetPrinter_ : IPrinterTasks_
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
    }
    #endregion
}
