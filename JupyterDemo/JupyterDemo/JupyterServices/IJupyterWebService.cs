using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JupyterDemo.JupyterServices
{
    public interface IJupyterWebService
    {
        XDocument GetJupyterData(string ID);
    }
}
