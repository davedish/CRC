using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrcTester
{
    class Arinc702Crc
    {
        public static string AppendCrcToMessage(string input)
        {
            StringBuilder sbHex = new StringBuilder();
            StringBuilder sbBin = new StringBuilder();
            StringBuilder sbBinNoSpaces = new StringBuilder();
            List<byte> bytes = new List<byte>();

            // transpose text for ARINC 702A
            string Transposed = new string(input.Reverse().ToArray());

            //txtDenomBits.Text = binDenominator.Length.ToString();
            //if (binDenominator.Length > 0)
            //    txtDenominatorExponents.Text = Arinc702Crc.GetBinaryExponentsString(binDenominator);

            foreach (char c in Transposed)
            {
                //sbHex.Append(Convert.ToByte(c).ToString("X"));
                //sbHex.Append(" ");
                sbBin.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
                //sbBinNoSpaces.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
                //sbBin.Append(" ");
                //bytes.Add(Convert.ToByte(c));
            }
            //txtHex.Text = sbHex.ToString();
            //Binary = sbBin.ToString();
            string binTransposed = new string(sbBin.ToString().Reverse().ToArray());
            //txtExponents.Text = Arinc702Crc.GetBinaryExponentsString(binTransposed);

            //TextBox tb = sender as TextBox;
            //if (tb != null && tb.Name == "txtInput")
            //{
                // numerator = 1's compliment first 16 bits of transposed binary shifted left 16 bits
                StringBuilder sbNumerator = new StringBuilder();
                for (int i = 0; i < Math.Min(16, binTransposed.Length); i++)
                {
                    char c = binTransposed[i];
                    if (c == '1') sbNumerator.Append('0');
                    else sbNumerator.Append('1');
                }
                for (int i = 16; i < binTransposed.Length; i++)
                    sbNumerator.Append(binTransposed[i]);

                sbNumerator.Append("0000000000000000"); // here's the left shift 16 bits
                string binNumerator = sbNumerator.ToString();
            //}

            // denominator = 10001000000100001 (16 12 5 1) -- the CRC generator polynomial
            string binDenominator = "10001000000100001";
            //if (binDenominator.Length < 2 || binNumerator.Length < 2)
            //    return; // don't keep going with a 1 bit denominator

            // 1. left shift denominator to same digits as numerator
            // 2. xor numerator and denominator 
            // 3. next line is next numerator
            // 4. when can't do it anymore, you have the remainder

            //txtLongDiv.Text = "";
            string binThisNumerator = binNumerator;
            string binThisDenominator;
            string binThisRemainder = binThisNumerator;
            if (binThisNumerator[0] == '0')
                binThisDenominator = "0".PadRight(binNumerator.Length, '0');
            else binThisDenominator = binDenominator.PadRight(binNumerator.Length, '0');

            while (binThisNumerator.Length >= binDenominator.Length)
            {
                binThisRemainder = Arinc702Crc.BinaryStringXOR(binThisNumerator, binThisDenominator);
                //txtLongDiv.AppendText("N: " + binThisNumerator + "\n");
                //txtLongDiv.AppendText("D: " + binThisDenominator + "\n");
                //txtLongDiv.AppendText("R: " + binThisRemainder + "\r\n\r\n");

                binThisNumerator = binThisRemainder.Substring(1); // throw away leading zero
                if (binThisNumerator.Length > 0 && binThisNumerator[0] == '0')
                    binThisDenominator = "0".PadRight(Math.Max(binThisNumerator.Length, binDenominator.Length), '0');
                else binThisDenominator = binDenominator.PadRight(binThisNumerator.Length, '0');
            }

            string binRemainder = binThisNumerator; // the last remainder minus the leading zero is the final value
            //StringBuilder sbCrc1 = new StringBuilder();
            string binRemainderInverted = Arinc702Crc.BinaryStringInvert(binRemainder);
            string binCrc = Arinc702Crc.BinaryStringTranspose(binRemainderInverted);
            string txtHexCrc = Arinc702Crc.BinaryStringToHexCharacterVals(binCrc);
            string txtMsgTransposed = txtHexCrc + Transposed;
            return new string(txtMsgTransposed.Reverse().ToArray());
        }

            
        public static string BinaryStringXOR(string value1, string value2)
        {
            StringBuilder sbThisRemainder = new StringBuilder();
            Debug.Assert(value1.Length == value2.Length);

            for (int i = 0; i < value1.Length; i++)
                if (value1[i] == value2[i]) sbThisRemainder.Append('0');
                else sbThisRemainder.Append('1');
            return sbThisRemainder.ToString();
        }

        public static List<UInt16> GetBinaryExponents(string binaryInput)
        {
            List<UInt16> output = new List<UInt16>();

            for (int i = 0; i < binaryInput.Length; i++)
            {
                if (binaryInput[i] == '1')
                    output.Add((UInt16)(binaryInput.Length - i - 1));
            }
            return output;
        }

        public static string GetBinaryExponentsString(string binaryInput)
        {
            List<UInt16> exponents = GetBinaryExponents(binaryInput);
            StringBuilder sbExponents = new StringBuilder();
            foreach (UInt16 exponent in exponents)
                sbExponents.Append(exponent.ToString() + " ");
            return sbExponents.ToString();
        }

        public static string BinaryStringInvert(string binaryInput)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in binaryInput)
                if (c == '1') sb.Append('0');
                else sb.Append('1');
            return sb.ToString();
        }

        public static string BinaryStringTranspose(string binaryInput)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = binaryInput.Length-1; i >= 0; i--)
                sb.Append(binaryInput[i]);
            return sb.ToString();
        }

        public static string BinaryToString(string data)
        {
            return Encoding.ASCII.GetString(BinaryToBytes(data).ToArray());
        }

        public static List<Byte> BinaryToBytes(string data)
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < data.Length; i += 8)
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            
            return byteList;
        }

        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));

            return sb.ToString();
        }

        // this assumes 4-character chunks of binary data, LSB right.
        // if a non-multiple of 4 characters are passed in, the odd
        // numbers will be attributed to the MSB side
        public static List<byte> BinaryStringToHexBytes(string data)
        {
            List<byte> returnVal = new List<byte>();
            int oddChars = data.Length % 4;
            if (oddChars > 0)
                returnVal.Add(Convert.ToByte(data.Substring(0, oddChars), 2)); // get first chunk
            for (int i = oddChars; i < data.Length; i += 4) // getting characters, not bytes
                returnVal.Add(Convert.ToByte(data.Substring(i, 4), 2));
            return returnVal;
        }

        public static string BinaryStringToHexCharacterVals(string data)
        {
            StringBuilder sb = new StringBuilder();
            List<byte> bytes = BinaryStringToHexBytes(data);
            foreach (byte b in bytes)
                sb.Append(b.ToString("X1"));
            return sb.ToString();
        }
    }
}
