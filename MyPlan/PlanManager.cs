using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MyPlan
{
    class PlanManager
    {
        private PlanList dataList;

        public PlanList DataList { get => dataList; set => dataList = value; }

        public PlanManager()
        {
            DataList = new PlanList();
        }

        public void SerializeToXML(string filePath)
        {
            //FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            
            XmlSerializer xmlSerializer = new XmlSerializer(DataList.GetType());
            using (var writer = XmlWriter.Create(filePath))
            {
                xmlSerializer.Serialize(writer, dataList);
            }
            
        }

        public object DeserializeFormXML(string filePath)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(PlanList));
            try
            {
                object result = xmlSerializer.Deserialize(fileStream);
                fileStream.Close();
                return result;
            }
            catch
            {
                fileStream.Close();
                throw new Exception();
            }
            
        }
    }
}
