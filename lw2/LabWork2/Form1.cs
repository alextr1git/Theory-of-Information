using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        internal class BasicReg
        {
            #region Private Members

            // Degree of our polynomial
            private int[] Degree;

            // Current state of LFSR
            private int[] rawReg;

            // Cells that take part in XOR operation
            private int[] CellXor;
            #endregion

            #region Constructor

            public BasicReg(int[] numbers, string initial)
            {
                // Copy Degree from our polynomial
                Degree = new int[numbers.Length]; //initializing x-degree values array 
                Array.Copy(numbers, 0, Degree, 0, numbers.Length);//setting degree array
                                                                   // Set rawReg length to number of register cells
                rawReg = new int[Degree.Max()];//initializing current state of LSFR array 
                int i = 0;
                for (; i < rawReg.Length && i < initial.Length; i++)
                {
                    //write key base state
                    rawReg[rawReg.Length - 1 - i] = (int)(initial[i] - '0');
                }
                for (; i < rawReg.Length; i++)//deletable
                    rawReg[rawReg.Length - 1 - i] = 1;
                // Set amount of XOR cells
                CellXor = new int[Degree.Length];
            }

            #endregion

            #region Public Methods
            // Generate new key bit
            public int CreateKBit()
            {
                // Get KBit
                int KBit = rawReg[rawReg.Length - 1];

                // Get cells that take part in XOR operation
                for (int i = 0; i < Degree.Length; i++)

                    CellXor[i] = rawReg[Degree[i] - 1];

                // Shift of register
                for (int i = rawReg.Length - 1; i > 0; i--)

                    rawReg[i] = rawReg[i - 1];

                // Generete new first bit
                rawReg[0] = CellXor[0];

                for (int i = 1; i < CellXor.Length; i++)

                    rawReg[0] ^= CellXor[i];

                return KBit;
            }
            #endregion
        }

        internal class Cryptor
        {
            
            private const int Bytes = 8;
            

            #region Method
            // Encode inforamtion from source file and write it to result file, show generated key
            public static void Encode(int[] Power, string initialKey, string pathToSrcFile, string pathToResFile, RichTextBox BegoreFile, RichTextBox GeneratedK, RichTextBox AfterFile)
            {
                try
                {
                    AfterFile.Text = string.Empty;

                    BegoreFile.Text = string.Empty;

                    GeneratedK.Text = string.Empty;

                    //polinom Degree and key state
                    BasicReg reg = new BasicReg(Power, initialKey);

                    byte[] srcBytes = File.ReadAllBytes(pathToSrcFile);

                    string KeyAll = "";

                    string textBased = "";

                    string Result = "";

                    for (long i = 0; i < srcBytes.Length; i++)
                    {

                        textBased += Convert.ToString(srcBytes[i], 2).PadLeft(Bytes, '0') + " "; //get format of 8bit=1byte


                        string KeyNow = string.Empty;

                        for (int j = 0; j < Bytes; j++)
                            KeyNow += reg.CreateKBit();//shift + add xored bit

                        byte keyByte = 0;

                        for (int j = 0; j < KeyNow.Length; j++)
                            keyByte += (byte)((byte)(KeyNow[j] - '0') * Math.Pow(2, Bytes - 1 - j));

                        KeyAll += KeyNow + " ";


                        srcBytes[i] ^= (byte)keyByte;

                        Result += Convert.ToString(srcBytes[i], 2).PadLeft(Bytes, '0') + " ";

                    }
                    File.WriteAllBytes(pathToResFile, srcBytes);
                    BegoreFile.AppendText(textBased);
                    AfterFile.AppendText(Result);
                    GeneratedK.AppendText(KeyAll);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("File not found");
                }
            }
            #endregion
        }

        private void bstart_Click(object sender, EventArgs e)
        {
            Cryptor.Encode(new int[] { 33, 13 }, initkey.Text, fbefore.Text, fafter.Text,
                isch, key, coded);
        }

        private void initkey_TextChanged(object sender, EventArgs e)
        {
            bstart.Enabled = (!fbefore.Text.Equals(String.Empty) && !fafter.Text.Equals("") && initkey.Text.Length == 33 && Validate(initkey.Text));
        }

        public bool Validate(string regState)
        {
            for (int i = 0; i < regState.Length; i++)
            {
                if (regState[i] != '0') return true;
            }
            return false;
        }

        private void initkey_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validKeys = new[] { Keys.Back, Keys.D0, Keys.D1 };

           // 

            if (!validKeys.Contains((Keys)e.KeyChar))
                MessageBox.Show("Only 1 and 0");
            e.Handled = !validKeys.Contains((Keys)e.KeyChar);
        }

        private void fafter_TextChanged(object sender, EventArgs e)
        {
            bstart.Enabled = (!fbefore.Text.Equals(String.Empty) && !fafter.Text.Equals("") && initkey.Text.Length == 33 && Validate(initkey.Text));
        }
    }
}
