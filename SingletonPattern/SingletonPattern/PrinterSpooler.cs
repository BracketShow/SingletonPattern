using System;
using System.Collections.Generic;
using System.Runtime.Caching;

namespace SingletonPattern
{
    public class PrinterSpooler
    {
        private readonly IList<Document> _documentsToPrint;

        public PrinterSpooler()
        {
            _documentsToPrint = new List<Document>();
        }

        public void PrintDocument(Document document)
        {
            _documentsToPrint.Add(document);
        }

        public int GetNumberOfDocumentsToPrint => _documentsToPrint.Count;


        // Singleton
        // Make constructor protected

        private static PrinterSpooler _instance;
        public static PrinterSpooler Instance => _instance ?? (_instance = new PrinterSpooler());


        private static volatile PrinterSpooler _threadSafeInstance;
        private static readonly object LockObject = new object();

        public static PrinterSpooler ThreadSafeInstance
        {
            get
            {
                if (_threadSafeInstance != null) return _threadSafeInstance;

                lock (LockObject)
                {
                    if (_threadSafeInstance == null) _threadSafeInstance = new PrinterSpooler();
                }
                return _threadSafeInstance;
            }
        }
    }
}
