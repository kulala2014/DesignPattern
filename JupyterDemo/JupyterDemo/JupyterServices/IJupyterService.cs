using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupyterDemo.JupyterServices
{
    public interface IJupyterService
    {
        string PopulateJupyterData();
    }

    public interface IJupyterTypeAService
    {
        Func<JupyterData, string> PopulateJupyterDataForTypeA(string docType);
    }

    public interface IJupyterTypeBService
    {
        Func<JupyterData, string> PopulateJupyterDataForTypeB(string docType);
    }

    public interface IJupyterTypeCService
    {
        Func<JupyterData, string> PopulateJupyterDataForTypeC(string docType);
    }
}
