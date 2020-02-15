using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupyterDemo.JupyterServices
{
    public class PopulateTypeCService : IPopulateTypeCService
    {
        public string PopulateTypeCDataForACCPage(JupyterData data)
        {
            string result = "Populate TypeC Capture";
            Console.WriteLine(result);
            return result;
        }
        public string PopulateTypeCDataForBasicPage(JupyterData data)
        {
            string result = "Populate TypeC Basic";
            Console.WriteLine(result);
            return result;
        }
        public string PopulateTypeCDataForInternalPage(JupyterData data)
        {
            string result = "Populate TypeC Internal";
            Console.WriteLine(result);
            return result;
        }
        public string PopulateTypeCDataForTextPage(JupyterData data)
        {
            string result = "Populate TypeC Matain";
            Console.WriteLine(result);
            return result;
        }
    }
}
