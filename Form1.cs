
namespace cs_hanyu
{
    public partial class Form1 : Form
    {

        private Dictionary<string,string> words = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setStatus("������...");
            words = Utils.loadWords();
            setStatus(String.Format("{0}�����Ѽ��أ�", words.Count));
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            richTextBox_output.Clear();

            string key = textBox_key.Text.Trim();
            if (key.Length == 0)
            {
                MessageBox.Show("�ؼ��ʲ���Ϊ��!");
                setStatus("������ؼ���!");
                return;
            }

            setStatus("������...");
            List<string> result = search(key, checkBox_word.Checked, checkBox_idiom.Checked);



            if (result == null)
            {
                setStatus("ʲô��û�ѵ�!");
                return;
            }

            setStatus(String.Format("{0}�������ѵ���", result.Count));
            int max = 0;
            foreach (string word in result)
            {
                //�����
                int len = word.Length;
                richTextBox_output.AppendText(word);
                richTextBox_output.Select(richTextBox_output.Text.Length - len, len);
                richTextBox_output.SelectionFont = new Font("Arial", 14, richTextBox_output.Font.Style | FontStyle.Bold);
                richTextBox_output.SelectionColor = Color.Firebrick;
                richTextBox_output.AppendText(Environment.NewLine);

                //�������
                int len_key = key.Length;
                int len_mean = words[word].Length;
                int idx = words[word].IndexOf(key);
                richTextBox_output.AppendText(words[word]);
                richTextBox_output.Select(richTextBox_output.Text.Length - len_mean + idx, len_key);
                richTextBox_output.SelectionFont = new Font("Arial", 12);
                richTextBox_output.SelectionColor = Color.Red;
                richTextBox_output.AppendText(Environment.NewLine);
                max = max + 1;
                if (max >= 1000)
                {
                    setStatus(String.Format("{0}�������ѵ���������̫�ֻ࣬չʾ��ǰ1000��������", result.Count));
                    break;
                }
            }


        }


        /// <summary>
        /// ����
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private List<string> search(string key,bool word,bool idiom)
        {
            List<string> ret = new List<string>();

            foreach (KeyValuePair<string, string> pair in words)
            {

                //���ûѡ�����������������
                if (idiom == false && pair.Key.Length == 4 && pair.Value.StartsWith("�����塿"))
                {
                    continue;
                }
                //���ûѡ�����������������
                if (word == false && pair.Value.StartsWith("�����塿") == false)
                {
                    continue;
                }



                if (pair.Value.Contains(key))
                {
                    ret.Add(pair.Key);
                }
            }
            return ret;
        }
        /// <summary>
        /// ����״̬
        /// </summary>
        /// <param name="msg"></param>
        private void setStatus(string msg)
        {
            toolStripStatusLabel1.Text = "[" + DateTime.Now.ToString() + "] " + msg;
        }
    }
}