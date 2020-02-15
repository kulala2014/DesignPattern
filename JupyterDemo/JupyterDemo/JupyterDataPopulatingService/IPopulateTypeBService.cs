using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupyterDemo.JupyterServices
{
   public interface IPopulateTypeBService
    {
        string PopulateTypeBDataForAccPage(JupyterData data);
        string PopulateTypeBDataForBasicPage(JupyterData data);
        string PopulateTypeBDataForInternalPage(JupyterData data);

        string PopulateTypeBDataForMatainPage(JupyterData data);
    }
}
