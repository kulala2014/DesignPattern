using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupyterDemo.JupyterServices
{
    public class JupyterTypeAService : IJupyterTypeAService
    {
        private IPopulateTypeAService populateTypeAService;

        public JupyterTypeAService(IPopulateTypeAService service)
        {
            this.populateTypeAService = service;
        }

        public Func<JupyterData, string> PopulateJupyterDataForTypeA(string docType)
        {
            Func<JupyterData, string> TypeBOperator = null;
            if (docType.Equals("TypeARecording"))
            {
                TypeBOperator = populateTypeAService.PopulateTypeADataForBasicPage;
            }
            return TypeBOperator;
        }
    }
}
