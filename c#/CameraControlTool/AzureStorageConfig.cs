using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CameraControlTool
{
    public class AzureStorageConfig
    {
        public string AccountName { get { return "pucfacerecognition"; } } 
        public string AccountKey { get { return "nFXIPoMplSTgvvEsDMvWhwoCeLW5C2UnmtsHW/CaHCwvfuH9HP3DaCJOnb6EO45vncnlcnLLBir9crgF7NjQZQ=="; } }
        public string ImageContainer { get { return "photos"; } }
    }
}
