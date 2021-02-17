using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
namespace Dictionary
{
    public partial class FormDictionary : Form
    {
        DictionaryManager dictionaryManager;
        SpeechSynthesizer speaker;
        public FormDictionary()
        {
            InitializeComponent();

            comboBoxWord.DisplayMember = "Key";
            dictionaryManager = new DictionaryManager();
            dictionaryManager.LoadDataToComboBox(comboBoxWord);

            speaker = new SpeechSynthesizer();
            speaker.SelectVoiceByHints(VoiceGender.Female);
            speaker.Rate = 5;

        }

        private void FormDictionary_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
                return;
            }
            dictionaryManager.Serialize();
        }

        private void comboBoxWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.DataSource == null)
                return;
            DictionaryData dictionaryData = cb.SelectedItem as DictionaryData;
            textBoxMeaning.Text = dictionaryData.Meaning;
            textBoxExplanation.Text = dictionaryData.Explaination;
        }

        private void buttonSpeakEnglish_Click(object sender, EventArgs e)
        {
            speaker.Speak((comboBoxWord.SelectedItem as DictionaryData).Key);
        }
    }
}
