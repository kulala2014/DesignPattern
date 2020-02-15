using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupyterDemo.JupyterServices
{
    class JupyterTypeCService : IJupyterTypeCService
    {
        private IPopulateTypeCService populateTypeCService;
        public JupyterTypeCService(IPopulateTypeCService service)
        {
            this.populateTypeCService = service;
        }

        public Func<JupyterData, string> PopulateJupyterDataForTypeC(string docType)
        {
            Func<JupyterData, string> Operator = null;
            if (docType.Equals("TypeCCapture"))
            {
                Operator = populateTypeCService.PopulateTypeCDataForACCPage;
            }
            if (docType.Equals("TypeCBasic"))
            {
                Operator = populateTypeCService.PopulateTypeCDataForBasicPage;
            }
            if (docType.Equals("TypeCInternal"))
            {
                Operator = populateTypeCService.PopulateTypeCDataForInternalPage;
            }
            if (docType.Equals("TypeCText"))
            {
                Operator = populateTypeCService.PopulateTypeCDataForTextPage;
            }
            return Operator;
        }
    }
}
