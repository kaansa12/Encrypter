using System.Text;

namespace Encriypter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool decode = false;
        private void button1_Click(object sender, EventArgs e)
        {
            EncryptionClass encryptionClass = new EncryptionClass();
            encryptionClass.decodeGS = decode;
            encryptionClass.codeGS = Convert.ToInt32(codeTB.Text);
            encryptionClass.Encode(inputTB.Text);
            outputTB.Text = encryptionClass.encodedTextGS;

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            decode = checkBox1.Checked;
            if (decode)
            {
                checkBox1.Text = "Dekodla";
                button1.Text = "Dekodla";
            }
            else
            {
                checkBox1.Text = "Kodla";
                button1.Text = "Kodla";
            }
        }
    }

    public class EncryptionClass : Form1
    {
        public int code;
        public int codeGS { 
            get { return code; }
            set { code = value; }
        }

        public string encodedText;

        public string encodedTextGS
        {
            get { return encodedText; }
            set { encodedText = value; }
        }
        public bool decode;

        public bool decodeGS
        {
            get { return decode; }
            set { decode = value; }
        }

        public void Encode(string text)
        {
            List<int> indexList = new();
            List<int> encodedIndexList = new();
            List<char> encodedCharList = new List<char>();
            if (!decode) {
                foreach (char c in text)
                {
                    indexList.Add(getLetterIndex(c.ToString()));
                }

                foreach (int i in indexList)
                {
                    if (i+code <= 26) { encodedIndexList.Add(i+code); }
                    else { encodedIndexList.Add(-1+(code-(26-i))); }
                }

                foreach (int i in encodedIndexList)
                {
                    encodedCharList.Add(Convert.ToChar(getLetter(i)));
                }

                encodedText = new String(encodedCharList.ToArray());
            }
            else
            {
                foreach (char c in text)
                {
                    indexList.Add(getLetterIndex(c.ToString()));
                }

                foreach (int i in indexList)
                {
                    if (i-code >= 0) { encodedIndexList.Add(i-code); }
                    else { encodedIndexList.Add(1+26-code+i); }
                }

                foreach (int i in encodedIndexList)
                {
                    encodedCharList.Add(Convert.ToChar(getLetter(i)));
                }

                encodedText = new String(encodedCharList.ToArray());
            }
            
        }

        public string getLetter(int index)
        {
            List<string> letters = new List<string>() { //26 index
                "a", "b", "c", "d", "e", "f", "g", "h",
                "i", "j", "k", "l", "m", "n", "o", "p",
                 "q", "r", "s","t", "u","v","w", "x","y","z", " "};

            return letters[index];

        }

        public int getLetterIndex(string letter)
        {
            List<string> letters = new List<string>() {
                "a", "b", "c", "d", "e", "f", "g", "h",
                "i", "j", "k", "l", "m", "n", "o", "p",
                 "q", "r", "s","t", "u","v","w", "x","y","z", " "};

            return letters.IndexOf(letter);

        }
    }
}
