using static System.Console;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstSpooler = new PrinterSpooler();
            //var firstSpooler = PrinterSpooler.Instance;
            firstSpooler.PrintDocument(new Document("Test", "Path"));

            var secondSpooler = new PrinterSpooler();
            //var secondSpooler = PrinterSpooler.Instance;
            secondSpooler.PrintDocument(new Document("Second test", "Path"));

            WriteLine($"{firstSpooler.GetNumberOfDocumentsToPrint} documents to print on first spooler");
            WriteLine($"{secondSpooler.GetNumberOfDocumentsToPrint} documents to print on second spooler");
            WriteLine($"Are the spooler equal? {ReferenceEquals(firstSpooler, secondSpooler)}");
            ReadKey();
        }

    }
}
