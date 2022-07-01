using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Numerics;
using System.IO;

namespace LabWork4
{
    public partial class DSApp : Form
    {
        public DSApp()
        {
            InitializeComponent();

            ofdOpenFile.Filter = "Text files(*.txt)|*.txt";
            sfdSignFile.Filter = "Text files(*.txt)|*.txt";
        }

        string filename;
        string Signedfilename;
        string CheckSignedfilename;


        private void bSign_Click(object sender, EventArgs e)
        {
            try
            {

                string msg = File.ReadAllText(filename);

                BigInteger
                    p = BigInteger.Parse(tbP.Text),
                    q = BigInteger.Parse(tbQ.Text),
                    Kc = BigInteger.Parse(tbKc.Text),
                    eulerFunc = BigInteger.Multiply(BigInteger.Subtract(p, 1), BigInteger.Subtract(q, 1)); // psi=(q-1)(p-1)

                if (!Algorithms.InputValidation(p, q, Kc, eulerFunc))
                    return;

                BigInteger hashFunc;
                BigInteger S = DigitalSignature.createDS(p, q, 100, Kc, msg, out hashFunc);
                BigInteger Ko = Algorithms.RashEucExp(eulerFunc, Kc);


                FileWork.writeDS(Signedfilename, msg, S);
                tbHI.Text = hashFunc.ToString();
                tbDS.Text = S.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }
        private void bCheckSign_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = FileWork.getContent(CheckSignedfilename);

                BigInteger
                    S = FileWork.getDS(CheckSignedfilename),
                    p = BigInteger.Parse(tbP.Text),
                    q = BigInteger.Parse(tbQ.Text),
                    Kc = BigInteger.Parse(tbKc.Text),
                    hashFunc,
                    eulerFunc = BigInteger.Multiply(BigInteger.Subtract(p, 1), BigInteger.Subtract(q, 1));

                if (!Algorithms.InputValidation(p, q, Kc, eulerFunc))
                    return;

                BigInteger m1;
                BigInteger Ko = Algorithms.RashEucExp(eulerFunc, Kc);

                if (DigitalSignature.checkDS(p, q, 100, Ko, S, msg, out hashFunc, out m1))
                {
                    MessageBox.Show("Подпись действительна");
                }
                else
                {
                    MessageBox.Show("Подпись недействительна");
                }

                tbHIM.Text = hashFunc.ToString();
                tbOK.Text = Ko.ToString();
                tbCHI.Text = m1.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }


        private void bFileChoose_Click(object sender, EventArgs e)
        {
            if (ofdOpenFile.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            filename = ofdOpenFile.FileName;
            tbFpath.Text = Path.GetFileName(filename);
        }

        public void ChecktbInput(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbP_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChecktbInput(e);
        }

        private void tbQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChecktbInput(e);
        }

        private void tbKc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChecktbInput(e);
        }

        private void tbDS_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChecktbInput(e);
        }

        private void tbOK_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChecktbInput(e);
        }

        private void tbHI_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChecktbInput(e);
        }

        private void tbHIM_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChecktbInput(e);
        }

        private void tbCHI_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChecktbInput(e);
        }

        private void bSaveFile_Click(object sender, EventArgs e)
        {
            if (sfdSignFile.ShowDialog() == DialogResult.Cancel)
                return;

            Signedfilename = sfdSignFile.FileName;
            tbSFile.Text = Path.GetFileName(Signedfilename);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofdCheckFile.ShowDialog() == DialogResult.Cancel)
                return;

            CheckSignedfilename = ofdCheckFile.FileName;
            tbcheckfile.Text = Path.GetFileName(CheckSignedfilename);

        }

    }
}
