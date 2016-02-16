using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BruteForced
{
    public partial class Form1 : Form
    {
        private const int MD5_HASH_LENGHT = 32;
        private const int SHA224_HASH_LENGHT = 32;
        private const int SHA256_HASH_LENGHT = 32;

        private readonly List<char> numbers = new List<char> {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
        private readonly List<char> lowers = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private readonly List<char> uppers = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        private readonly List<char> specials = new List<char> { '!', '@', '#', '$', '%', '?', '&', '*', '(', ')' };

        private List<char> possibleChars;
        private List<int> possibleLenghts;

        private bool isFound;
        private MD5 MD5Hasher;

        public Form1()
        {
            InitializeComponent();
        }

        private string GetHash(string input)
        {
            StringBuilder stringBuilder = new StringBuilder();

            byte[] byteArray = MD5Hasher.ComputeHash(Encoding.UTF8.GetBytes(input));

            for (int i = 0; i < byteArray.Length; i++)
            {
                stringBuilder.Append(byteArray[i].ToString("x2"));
            }

            return stringBuilder.ToString();
        }

        private bool AreParametersValid()
        {
            if ((radioMD5.Checked && radioMD5.Enabled) || (radioSHA224.Checked && radioSHA224.Enabled) || (radioSHA256.Checked && radioSHA256.Enabled))
            {
                if (checkUppers.Checked || checkLowers.Checked || checkSpecials.Checked || checkNumbers.Checked)
                {
                    if (check1.Checked || check2.Checked || check3.Checked || check4.Checked || check5.Checked || check6.Checked || check7.Checked || check8.Checked || check9.Checked || check10.Checked){
                        return true;
                    }
                }
            }
            return false;
        }

        private void InitializePossibleChars()
        {
            possibleChars = new List<char>();
            if (checkLowers.Checked)
            {
                foreach (char _char in lowers)
                {
                    possibleChars.Add(_char);
                }
            }
            if (checkUppers.Checked)
            {
                foreach (char _char in uppers)
                {
                    possibleChars.Add(_char);
                }
            }
            if (checkNumbers.Checked)
            {
                foreach (char _char in numbers)
                {
                    possibleChars.Add(_char);
                }
            }
            if (checkSpecials.Checked)
            {
                foreach (char _char in specials)
                {
                    possibleChars.Add(_char);
                }
            }
        }

        private void InitializePossibleLenghts()
        {
            possibleLenghts = new List<int>();
            if (check1.Enabled)
            {
                possibleLenghts.Add(1);
            }
            if (check2.Enabled)
            {
                possibleLenghts.Add(2);
            }
            if (check3.Enabled)
            {
                possibleLenghts.Add(3);
            }
            if (check4.Enabled)
            {
                possibleLenghts.Add(4);
            }
            if (check5.Enabled)
            {
                possibleLenghts.Add(5);
            }
            if (check6.Enabled)
            {
                possibleLenghts.Add(6);
            }
            if (check7.Enabled)
            {
                possibleLenghts.Add(7);
            }
            if (check8.Enabled)
            {
                possibleLenghts.Add(8);
            }
            if (check9.Enabled)
            {
                possibleLenghts.Add(9);
            }
            if (check10.Enabled)
            {
                possibleLenghts.Add(10);
            }
        }

        private void BruteForcePressed(object sender, EventArgs e)
        {
            if (!AreParametersValid())
            {
                ShowWrongParametersAlert();
                return;
            }

            labelInfos.Text = "";
            isFound = false;
            MD5Hasher = MD5.Create();
            InitializePossibleChars();
            InitializePossibleLenghts();

            string generatedString = "";

            foreach (int lenght in possibleLenghts)
            {
                TryHashes(lenght, generatedString);
            }
        }

        private void TryHashes(int lenght, string generatedString)
        {
            if (generatedString.Length == lenght)
            {
                if (GetHash(generatedString) == txtHash.Text)
                {
                    labelInfos.Text = "Decrypted: " + generatedString;
                    labelInfos.BackColor = Color.Green;
                    isFound = true;
                    return;
                }
            }
            else
            {
                foreach (char _char in possibleChars)
                {
                    if (isFound)
                    {
                        return;
                    }
                    TryHashes(lenght, generatedString + _char);
                }
            }
        }

        private void ShowWrongParametersAlert()
        {
            string message = "At least one option must be selected in each box and the hash must be of the right size for the selected algorithm.";
            string title = "Invalid Parameters";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            MessageBox.Show(message, title, buttons);
        }

        private void DisableRadioButtons()
        {
            radioMD5.Enabled = false;
            radioSHA224.Enabled = false;
            radioSHA256.Enabled = false;
        }

        private void txtHash_TextChanged(object sender, EventArgs e)
        {
            DisableRadioButtons();
            if (txtHash.TextLength == MD5_HASH_LENGHT)
            {
                radioMD5.Enabled = true;
            }
            else if (txtHash.TextLength == SHA224_HASH_LENGHT)
            {
                radioSHA224.Enabled = true;
            }
            else if (txtHash.TextLength == SHA256_HASH_LENGHT)
            {
                radioSHA256.Enabled = true;
            }
        }


    }
}
