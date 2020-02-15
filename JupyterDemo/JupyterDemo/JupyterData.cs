using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public class JupyterData
    {
        public string hasValue { get; set; } = "false";
    }

    public class JupyterTypeAData : JupyterData
    {
        public string BOL { get; set; }
    }

    public class JupyterTypeBData : JupyterData
    {
        public string NumOfDays { get; set; }
    }

    public  class JupyterTypeCData : JupyterData
    {
        public string DrawerAddress { get; set; }
    }

    public class DocType
    {
        public const string TypeARecording = "TypeARecording";
        public const string TypeBRecording = "TypeBRecording";
        public const string TypeCRecording = "TypeCRecording";
        public const string TypeBCapture = "TypeBCapture";
        public const string TypeCCapture = "TypeCCapture";
    }
}
