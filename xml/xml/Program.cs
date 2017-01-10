using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace xml
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public class HighScore
        {
            public int Score
            {
                get;
                set;
            }

            public string Name
            {
                get;
                set;
            }
        }

        public class HighScoreCollection : List<HighScore>
        {
            public void SaveToXml(string fileName)
            {
                using (XmlWriter writer = XmlWriter.Create(fileName))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(HighScoreCollection));
                    ser.Serialize(writer, this);
                    writer.Flush();
                    writer.Close();
                }
            }
        }
    }
}
