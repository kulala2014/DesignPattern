using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupyterDemo.JupyterServices
{
    public class JupyterTypeBService : IJupyterTypeBService
    {
        private IPopulateTypeBService populateTypeBService;
        public JupyterTypeBService(IPopulateTypeBService service)
        {
            this.populateTypeBService = service;
        }

        public Func<JupyterData, string> PopulateJupyterDataForTypeB(string docType)
        {
            Func<JupyterData, string> TypeBOperator = null;
            if (docType.Equals("TypeBCapture"))
            {
                TypeBOperator = populateTypeBService.PopulateTypeBDataForAccPage;
            }

            if (docType.Equals("TypeBBasic"))
            {
                TypeBOperator = populateTypeBService.PopulateTypeBDataForBasicPage;
            }

            if (docType.Equals("TypeBInternal"))
            {
                TypeBOperator = populateTypeBService.PopulateTypeBDataForInternalPage;
            }

            if (docType.Equals("TypeBCapture"))
            {
                TypeBOperator = populateTypeBService.PopulateTypeBDataForMatainPage;
            }

            return TypeBOperator;
        }
    }
}
