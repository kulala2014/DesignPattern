using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JupyterDemo.JupyterServices
{
    public interface IPopulateTypeCService
    {
        string PopulateTypeCDataForACCPage(JupyterData data);
        string PopulateTypeCDataForBasicPage(JupyterData data);
        string PopulateTypeCDataForInternalPage(JupyterData data);
        string PopulateTypeCDataForTextPage(JupyterData data);
    }
}
