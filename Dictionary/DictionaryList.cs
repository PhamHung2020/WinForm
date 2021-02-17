using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    [Serializable]
    public class DictionaryList
    {
        private List<DictionaryData> dataList;
        public List<DictionaryData> DataList 
        { 
            get => dataList; 
            set => dataList = value; 
        }

        public DictionaryList()
        {
            dataList = new List<DictionaryData>();
        }
    }
}
