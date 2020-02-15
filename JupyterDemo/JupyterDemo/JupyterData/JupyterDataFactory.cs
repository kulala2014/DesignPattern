using System.Xml.Linq;

namespace JupyterDemo.JupyterServices
{
    public interface IJupyterDataFactory
    {
        JupyterData CreateJupyterData(XDocument data);
    }


    public class JupyterTypeADataFactory : IJupyterDataFactory
    {
        public JupyterData CreateJupyterData(XDocument data)
        {
            return new JupyterTypeAData()
            { 
                BOL = "test"
            };
        }
    }

    public class JupyterTypeBDataFactory : IJupyterDataFactory
    {
        public JupyterData CreateJupyterData(XDocument data)
        {
            return new JupyterTypeBData()
            {
                NumOfDays = "20"
            };
        }
    }

    public class JupyterTypeCDataFactory : IJupyterDataFactory
    {
        public JupyterData CreateJupyterData(XDocument data)
        {
            return new JupyterTypeCData()
            {
                DrawerAddress = "USA"
            };
        }
    }
}
