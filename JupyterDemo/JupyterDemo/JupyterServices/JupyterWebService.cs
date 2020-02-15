using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JupyterDemo.JupyterServices
{
    public class JupyterWebService : IJupyterWebService
    {
        public XDocument GetJupyterData(string ID)
        {
            return new XDocument();
        }
    }
}
