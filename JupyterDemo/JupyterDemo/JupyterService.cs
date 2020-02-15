using JupyterDemo.JupyterServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JupyterDemo
{
    public class JupyterService : IJupyterService
    {
        private string ID;
        private string docType;
        private IJupyterWebService JupyterWebservice;
        private Dictionary<string, JupyterPopulation> JupyterPopulationHandler =
            new Dictionary<string, JupyterPopulation>();


        public JupyterService(string id, string DocType)
        {
            ID = id;
            docType = DocType;
            JupyterWebservice = new JupyterWebService();
            CreatePopulationHandler();
        }

        public string PopulateJupyterData()
        {
            string result = string.Empty;
            var data = JupyterWebservice.GetJupyterData(ID);
            if (data != null)
            {
                var Operator = JupyterPopulationHandler[docType];
                result = DoPopulation(Operator, data);
            }
            return result;
        }

        private string DoPopulation(JupyterPopulation JupyterStrategy, XDocument data)
        {
            return JupyterStrategy.PopulateJupyterData(docType, data);
        }

        private void CreatePopulationHandler()
        {
            if (JupyterPopulationHandler.Count == 0)
            {
                JupyterPopulationHandler.Add(
                    DocType.TypeARecording,
                    new JupyterTypeAPopulation(
                        new JupyterTypeAService(new PopulateTypeAService() as IPopulateTypeAService),
                        new JupyterTypeADataFactory())
                    );
                JupyterPopulationHandler.Add(
                    DocType.TypeBRecording,
                    new JupyterTypeBPopulation(
                        new JupyterTypeBService(new PopulateTypeBService() as IPopulateTypeBService),
                        new JupyterTypeCDataFactory())
                    );
                JupyterPopulationHandler.Add(
                    DocType.TypeBCapture,
                    new JupyterTypeBPopulation(
                        new JupyterTypeBService(new PopulateTypeBService() as IPopulateTypeBService),
                        new JupyterTypeCDataFactory())
                    );
                JupyterPopulationHandler.Add(
                    DocType.TypeCRecording,
                    new JupyterTypeCPopulation(
                        new JupyterTypeCService(new PopulateTypeCService() as IPopulateTypeCService),
                        new JupyterTypeBDataFactory())
                    );
                JupyterPopulationHandler.Add(
                    DocType.TypeCCapture,
                    new JupyterTypeCPopulation(
                        new JupyterTypeCService(new PopulateTypeCService() as IPopulateTypeCService),
                        new JupyterTypeBDataFactory())
                    );
            }
        }
    }
}
