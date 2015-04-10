using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrcTester
{
    public partial class CRCTester : Form
    {
        public CRCTester()
        {
            InitializeComponent();
            //System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            //t.Start();
        }

        // this is here in case we want to have both forms active at the same time...
        // uncomment the thread start lines in the constructor above

        public static void ThreadProc()
        {
            Application.Run(new SimpleCrcGenerator());
        }
        
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            StringBuilder sbHex = new StringBuilder();
            StringBuilder sbBin = new StringBuilder();
            StringBuilder sbBinNoSpaces = new StringBuilder();
            List<byte> bytes = new List<byte>();

            // transpose text for ARINC 702A
            txtTransposed.Text = new string(txtInput.Text.Reverse().ToArray());
            txtDenomBits.Text = txtDenominator.Text.Length.ToString();
            if (txtDenominator.Text.Length > 0) 
                txtDenominatorExponents.Text = Arinc702Crc.GetBinaryExponentsString(txtDenominator.Text);

            foreach (char c in txtTransposed.Text)
            {
                sbHex.Append(Convert.ToByte(c).ToString("X"));
                sbHex.Append(" ");
                sbBin.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
                sbBinNoSpaces.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
                //sbBin.Append(" ");
                bytes.Add(Convert.ToByte(c));
            }
            txtHex.Text = sbHex.ToString();
            txtBin.Text = sbBin.ToString();
            txtTransposedBinary.Text = new string(sbBinNoSpaces.ToString().Reverse().ToArray());
            txtExponents.Text = Arinc702Crc.GetBinaryExponentsString(txtTransposedBinary.Text);

            TextBox tb = sender as TextBox;
            if(tb != null && tb.Name == "txtInput")
            {
                // numerator = 1's compliment first 16 bits of transposed binary shifted left 16 bits
                StringBuilder sbNumerator = new StringBuilder();
                for (int i = 0; i < Math.Min(16,txtTransposedBinary.Text.Length); i++)
                {
                    char c = txtTransposedBinary.Text[i];
                    if (c == '1') sbNumerator.Append('0');
                    else sbNumerator.Append('1');
                }
                for(int i = 16; i<txtTransposedBinary.Text.Length; i++)
                    sbNumerator.Append(txtTransposedBinary.Text[i]);

                sbNumerator.Append("0000000000000000");
                txtNumerator.Text = sbNumerator.ToString();
            }

            //// denominator = 10001000000100001 (16 12 5 1) -- this is actually a 17-bit CRC?
            //txtDenominator.Text = "10001000000100001";
            if(txtDenominator.Text.Length < 1)
                txtDenominator.Text = "10001000000100001";
            if (txtDenominator.Text.Length < 2 || txtNumerator.Text.Length < 2)
                return; // don't keep going with a 1 bit denominator

            // 1. left shift denominator to same digits as numerator
            // 2. xor numerator and denominator 
            // 3. next line is next numerator
            // 4. when can't do it anymore, you have the remainder

            txtLongDiv.Text = "";
            string thisNumerator = txtNumerator.Text;
            string thisDenominator;
            string thisRemainder = thisNumerator;
            if (thisNumerator[0] == '0')
                thisDenominator = "0".PadRight(txtNumerator.Text.Length, '0');
            else thisDenominator = txtDenominator.Text.PadRight(txtNumerator.Text.Length, '0');

            while (thisNumerator.Length >= txtDenominator.Text.Length)
            {
                thisRemainder = Arinc702Crc.BinaryStringXOR(thisNumerator, thisDenominator);
                txtLongDiv.AppendText("N: " + thisNumerator + "\n");
                txtLongDiv.AppendText("D: " + thisDenominator + "\n");
                txtLongDiv.AppendText("R: " + thisRemainder + "\r\n\r\n");

                thisNumerator = thisRemainder.Substring(1); // throw away leading zero
                if (thisNumerator.Length > 0 && thisNumerator[0] == '0')
                    thisDenominator = "0".PadRight(Math.Max(thisNumerator.Length,txtDenominator.Text.Length), '0');
                else thisDenominator = txtDenominator.Text.PadRight(thisNumerator.Length, '0');
            }

            txtRemainder.Text = thisNumerator; // the last remainder minus the leading zero is the final value
            StringBuilder sbCrc1 = new StringBuilder();
            txtCrc1.Text = Arinc702Crc.BinaryStringInvert(txtRemainder.Text);
            txtTransposedCrc.Text = Arinc702Crc.BinaryStringTranspose(txtCrc1.Text);
            txtHexCrc.Text = Arinc702Crc.BinaryStringToHexCharacterVals(txtTransposedCrc.Text);
            txtMsgBackwards.Text = txtHexCrc.Text + txtTransposed.Text;
            txtFinalMsg.Text = new string(txtMsgBackwards.Text.Reverse().ToArray());
            txtClassTest.Text = Arinc702Crc.AppendCrcToMessage(txtInput.Text);
        }
    }
}
