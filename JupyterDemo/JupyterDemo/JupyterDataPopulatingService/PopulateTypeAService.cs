using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupyterDemo.JupyterServices
{
    public class PopulateTypeAService : IPopulateTypeAService
    {
        public string PopulateTypeADataForBasicPage(JupyterData data)
        {
            string result = "Populate TypeA basic";
            Console.WriteLine(result);
            return result;
        }
    }
}
