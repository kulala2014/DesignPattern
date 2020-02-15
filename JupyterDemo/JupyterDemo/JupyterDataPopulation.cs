using JupyterDemo.JupyterServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JupyterDemo
{
    public abstract class JupyterPopulation
    {
        public abstract string PopulateJupyterData(string docType, XDocument data);
        public string PopulateJupyterData<JupyterData>(Func<JupyterData, string> populatingOperator, JupyterData data)
        {
            var result = populatingOperator(data);
            return result;
        }
    }

    public class JupyterTypeAPopulation : JupyterPopulation
    {
        private IJupyterTypeAService JupyterTypeAService;
        private IJupyterDataFactory TypeAFactory;
        public JupyterTypeAPopulation(IJupyterTypeAService service, IJupyterDataFactory factory)
        {
            JupyterTypeAService = service;
            TypeAFactory = factory;

        }
        public override string PopulateJupyterData(string docType, XDocument data)
        {
            string result = string.Empty;
            JupyterData JupyterData = TypeAFactory.CreateJupyterData(data);
            var PopulationHandler = JupyterTypeAService.PopulateJupyterDataForTypeA(docType);
            if (PopulationHandler != null)
            {
                result = PopulateJupyterData<JupyterData>(PopulationHandler, JupyterData);
            }
            return result;
        }
    }

    public class JupyterTypeBPopulation : JupyterPopulation
    {
        private IJupyterTypeBService JupyterTypeBService;
        private IJupyterDataFactory TypeBFactory;
        public JupyterTypeBPopulation(IJupyterTypeBService service, IJupyterDataFactory factory)
        {
            JupyterTypeBService = service;
            TypeBFactory = factory;

        }
        public override string PopulateJupyterData(string docType, XDocument data)
        {
            JupyterData JupyterData = TypeBFactory.CreateJupyterData(data);
            var PopulationHandler = JupyterTypeBService.PopulateJupyterDataForTypeB(docType);
            return PopulateJupyterData<JupyterData>(PopulationHandler, JupyterData);
        }
    }

    public class JupyterTypeCPopulation : JupyterPopulation
    {
        private IJupyterTypeCService JupyterTypeCService;
        private IJupyterDataFactory TypeCFactory;
        public JupyterTypeCPopulation(IJupyterTypeCService service, IJupyterDataFactory factory)
        {
            JupyterTypeCService = service;
            TypeCFactory = factory;

        }
        public override string PopulateJupyterData(string docType, XDocument data)
        {
            JupyterData JupyterData = TypeCFactory.CreateJupyterData(data);
            var PopulationHandler = JupyterTypeCService.PopulateJupyterDataForTypeC(docType);
            return PopulateJupyterData<JupyterData>(PopulationHandler, JupyterData);
        }
    }
}
