using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class Form1 : Form
    {
        char[] alphabet = new char[] { 
            ' ','~', 'к','q','v', 'в', 'о','0', 'я','o','`','2', 'п', 'w',';','з','.','x','ц','+', 'с','p', '@', 'л', '3',
            'а', 'т', 'a','ю', '#', '4','г', 'и','i','\'','5','6','7','s','ж','%','d','t','f','y',
            'ё', '&', 'у','g', '8','9','h','$','l',']','_','{','b','й','2','*','z', 'ф', '?','х', 'c','м','D','(','1','x', 'ч', 'д',')', ':', 'б', 'щ',
            'ъ','^','\\', 'ы','j','№','>', 'н', 'р','/','e', 'е','-', 'n','ь','r', ',','k','э','ш','u','\"','=', 'm', '[','}'};
        public Form1()
        {
            InitializeComponent();
        }

        private void but_trans_Click(object sender, EventArgs e)
        {
            char[] userInput = new char[1000000000];
            userInput = text_to_trans.Text.ToLower().ToCharArray();
            if (type_of_trans.Text == "Перевод из зашифрованного текста в читаемый")
            {
                input_text.Text = decryption(userInput).ToString();
            }
            if (type_of_trans.Text == "Перевод из читаемого текста в зашифрованный")
            {
                input_text.Text = encryption(userInput).ToString();
            }
        }

        private void copy_but_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(input_text.Text);
        }

        private StringBuilder decryption(char[] input)
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (input[i] == alphabet[j])
                    {
                        if (j - Convert.ToInt32(key_code.Text) >= 0)
                        {
                            output.Append(alphabet[j - Convert.ToInt32(key_code.Text)]);
                        }
                        else
                        {
                            output.Append(alphabet[j - Convert.ToInt32(key_code.Text) + alphabet.Length]);
                        }
                    }
                    
                }
            }
            return output;
        }

        private StringBuilder encryption(char[] input)
        {
            StringBuilder output = new StringBuilder();
            for(int i = 0; i < input.Length;i++)
            {
                    for (int j = 0; j < alphabet.Length; j++)
                    {
                        if (input[i] == alphabet[j])
                        {
                            if (j + Convert.ToInt32(key_code.Text) <= alphabet.Length)
                            {
                                output.Append(alphabet[j + Convert.ToInt32(key_code.Text)]);
                            }
                            else
                            {
                                output.Append(alphabet[j + Convert.ToInt32(key_code.Text) - alphabet.Length]);
                            }
                        }
                    }
                
            }
            return output;
        }
    }
}