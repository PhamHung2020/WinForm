using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Dictionary
{
    public class DictionaryManager
    {
        #region Property
        private DictionaryList dicList;
        public DictionaryList DicList 
        {
            get => dicList; 
            set => dicList = value; 
        }

        private string filePath = "Data.xml";
        #endregion

        #region Methods

        public DictionaryManager()
        {
            dicList = (DictionaryList)DeserializeFromXML(filePath);
        }
        public void LoadDataToComboBox(ComboBox combobox)
        {
            combobox.DataSource = dicList.DataList;
        }

        public void Serialize()
        {
            SerializeToXML(dicList, filePath);
        }
        private void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer sr = new XmlSerializer(typeof(DictionaryList));
            sr.Serialize(fs, data);
        }

        public object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer sr = new XmlSerializer(typeof(DictionaryList));

            object obj = sr.Deserialize(fs);
            fs.Close();
            return obj;
        }

        #endregion
    }
}
