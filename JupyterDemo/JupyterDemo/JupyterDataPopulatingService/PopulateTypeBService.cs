using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupyterDemo.JupyterServices
{
    public class PopulateTypeBService : IPopulateTypeBService
    {
        public string PopulateTypeBDataForAccPage(JupyterData data)
        {
            string result = "Populate TypeB Capture";
            Console.WriteLine(result);
            return result;
        }
        public string PopulateTypeBDataForBasicPage(JupyterData data)
        {
            string result = "Populate TypeB Basic";
            Console.WriteLine(result);
            return result;
        }
        public string PopulateTypeBDataForInternalPage(JupyterData data)
        {
            string result = "Populate TypeB Internal";
            Console.WriteLine(result);
            return result;
        }
        public string PopulateTypeBDataForMatainPage(JupyterData data)
        {
            string result = "Populate TypeB Matain";
            Console.WriteLine(result);
            return result;
        }
    }
}
