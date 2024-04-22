using Dark.Net;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Random1to100
{
    public partial class Form1 : Form
    {
        private int[] listNums = new int[2];
        int previousResult = -1;
        bool isDark = true;
        private PictureBox themeTogglePictureBox; // Changed from Button to PictureBox

        public Form1()
        {
            InitializeComponent();
            InitializeThemeTogglePictureBox();
            ToggleTheme();
        }

        private void InitializeThemeTogglePictureBox()
        {
            themeTogglePictureBox = new PictureBox();
            themeTogglePictureBox.Size = new Size(16, 16);
            themeTogglePictureBox.Location = new Point(15, 180);
            themeTogglePictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Set the SizeMode
            themeTogglePictureBox.BackColor = Color.Transparent;
            themeTogglePictureBox.Image = Image.FromFile(@"Images\bright.png");
            themeTogglePictureBox.Anchor = AnchorStyles.Left |AnchorStyles.Bottom;
            themeTogglePictureBox.Click += ThemeTogglePictureBox_Click;

            Controls.Add(themeTogglePictureBox);
        }

        private void ThemeTogglePictureBox_Click(object sender, EventArgs e)
        {
            isDark = !isDark;
            ToggleTheme();
        }

        private void ToggleTheme()
        {
            Theme theme = isDark ? Theme.Dark : Theme.Light;
            DarkNet.Instance.SetCurrentProcessTheme(theme);

            BackColor = isDark ? Color.FromArgb(45, 45, 45) : Color.WhiteSmoke;
            ForeColor = isDark ? Color.White : Color.Black;

            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox textBox = ctrl as TextBox;
                    textBox.BackColor = isDark ? Color.FromArgb(64, 64, 64) : Color.White;
                    textBox.ForeColor = isDark ? Color.White : Color.Black;
                }
                else if (ctrl is Button)
                {
                    Button button = ctrl as Button;
                    button.BackColor = isDark ? Color.FromArgb(30, 30, 30) : Color.Gainsboro;
                    button.ForeColor = isDark ? Color.White : Color.Black;
                }
            }
            themeTogglePictureBox.Image = isDark ? Image.FromFile(@"Images\moon.png") : Image.FromFile(@"Images\bright.png");
        }

        private void bt_generate_Click(object sender, EventArgs e)
        {
            RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();

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
                    randomNumberGenerator.GetBytes(randomNumber);
                    UInt32 scale = BitConverter.ToUInt32(randomNumber, 0);
                    int randomInt = (int)(minNum + (maxNum + 1 - minNum) * (scale / (uint.MaxValue + 1.0)));

                    result_txt.Text = randomInt.ToString();
                    lbl_previous.Text = "Last: " + previousResult.ToString();

                    if (previousResult == randomInt)
                    {
                        lbl_previous.Font = new Font(lbl_previous.Font, FontStyle.Bold);
                    }
                    else
                    {
                        lbl_previous.Font = new Font(lbl_previous.Font, FontStyle.Regular);
                    }

                    previousResult = randomInt;


                }
                else
                {
                    et_max.Text = "100";
                    et_min.Text = "1";
                    MessageBox.Show("Minimum number has to be lower than Max Number.");                    
                }
            }
            catch (Exception exception)
            {
                et_max.Text = "100";
                et_min.Text = "1";
                MessageBox.Show("Invalid [Minimum Number] or [Max Number].");
            }
        }
    }
}
