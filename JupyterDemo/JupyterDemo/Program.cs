using JupyterDemo.JupyterServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupyterDemo
{
    class Program
    {
        private static IJupyterService JupyterService;
        private static string ID;
        private static string docType;
        static void Main(string[] args)
        {
            ID = "sdafsafsa-123214-df";
            docType = DocType.TypeARecording;
            JupyterService = new JupyterService(ID, docType);
            JupyterService.PopulateJupyterData();
            Console.Read();
        }
    }
}
