namespace Password_Generator
{
    using System.Diagnostics;

    public static class Globals
    {
        public static String[] password;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Hello");
        }

        // variable declarations
        Random random = new Random();
        int passwordLength = 0;
        bool needsUppercase = false;
        bool needsSymbols = false;
        bool needsNumbers = false;


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void psLength_TextChanged(object sender, EventArgs e)
        {

        }

        public void passGenerator()
        {
            var chars = "abcdefghijklmnopqrstuvwxyz";
            var charU = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var nums = "0123456789";
            var symbols = "!@#$%^&*()<>";
            string passwordFinal = "";
            int randInt;
            char randChar;
            int selectNum;
            int selectChar = 0;
            
            if(needsUppercase == true && needsSymbols == true && needsNumbers == true)
            {
                for (int i = 0; i < Globals.password.Length ; i++)
                {
                    selectNum = random.Next(4, 5);
                    if (selectNum == 4) // generates uppercase letter
                    {
                        selectChar = random.Next(charU.Length);
                        Globals.password[i] = charU.Substring(selectChar, selectChar + 1);
                    }
                    else if (selectNum == 3) // generates lowercase letters
                    {
                        selectChar = random.Next(charU.Length);
                        Globals.password[i] = chars.Substring(selectChar, selectChar + 1);
                    }
                    else if (selectNum == 2) // generates numbers
                    {
                        selectChar = random.Next(charU.Length);
                        Globals.password[i] = nums.Substring(selectChar, selectChar + 1);
                    }
                    else // generates symbols
                    {
                       selectChar = random.Next(charU.Length);
                        Globals.password[i] = symbols.Substring(selectChar, selectChar + 1); 
                    }

                    passwordFinal.Concat(Globals.password[i]);
                }
            }
            //return passwordFinal;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            passwordLength = int.Parse(psLength.Text);
            Globals.password = new string[passwordLength-1];
            Debug.WriteLine(passwordLength);
            passGenerator();

        }

        private void isUppercase_CheckedChanged(object sender, EventArgs e)
        {
            needsUppercase = true;
        }
    }
}