﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void but_trans_Click(object sender, EventArgs e)
        {
            char[] userInput = new char[1000000000];
            userInput = text_to_trans.Text.ToCharArray();
            input_text.Text = encryption(userInput).ToString();
        }
        private StringBuilder encryption(char[] input)
        {
            char[] alphabet = new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            StringBuilder output = new StringBuilder();
            for(int i = 0; i < input.Length;i++)
            {
                if (input[i] == ' ')
                {
                    output.Append(input[i]);
                }
                else
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
            }
            return output;
        }
    }
}