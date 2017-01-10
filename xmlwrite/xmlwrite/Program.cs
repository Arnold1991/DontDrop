using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace xmlwrite
{
    public void Main (string[] args)
    {
    string path = @"C:\users\Fluppie\Documents";
    string url = null;
    int counter = 0;
        if(File.Exists(path))
    {
        StreamReader myFile = new StreamReader(path);

        using (XmlWriter xw = XmlWriter.Create("highscore.xml"))
        {
            xw.WriteStartDocument();
            xw.WriteStartElement("urlset");
        }
    }
    }

        
    }
}
