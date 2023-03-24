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

namespace Random1to100
{
    public partial class Form1 : Form
    {
        private int[] listNums = new int[2];
        int previousResult = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_generate_Click(object sender, EventArgs e)
        {
            RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();

            // Create a byte array to hold the random number
            byte[] randomNumber = new byte[4];

            try
            {
                int minNum = Int32.Parse(et_min.Text.ToString());
                int maxNum = Int32.Parse(et_max.Text.ToString());


                if (minNum < 1 || maxNum > 100)
                {
                    MessageBox.Show("Minimum number is 1 and Max number is 100.");
                }
                else if (minNum <= maxNum)
                {


                    // Fill the byte array with a random number
                    randomNumberGenerator.GetBytes(randomNumber);

                    // Convert the bytes to a UInt32
                    UInt32 scale = BitConverter.ToUInt32(randomNumber, 0);

                    int randomInt = (int)(minNum + (maxNum + 1 - minNum) * (scale / (uint.MaxValue + 1.0)));


                    result_txt.Text = randomInt.ToString();

                    lbl_previous.Text = "Last: " + previousResult.ToString();

                    if (previousResult == randomInt)
                    {
                        lbl_previous.ForeColor = Color.Red;
                    }
                    else
                    {
                        lbl_previous.ForeColor = Color.Black;
                    }

                    previousResult = randomInt;

                   

                }

                else
                {
                    MessageBox.Show("Minimum number has to be lower than Max Number.");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid [Minimum Number] or [Max Number].");
            }




        }
    }
}
