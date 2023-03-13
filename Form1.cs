namespace Password_Generator
{
    using System.Diagnostics;
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
        int amountGenerate = 0;
        bool needsUppercase = false;
        bool needsSymbols = false;
        bool needsNumbers = false;


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            needsUppercase = true;
            needsSymbols = true;
            needsNumbers = true;
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
            Globals.passwordFinal = "";
            int randInt;
            char randChar;
            int selectNum;
            int selectChar = 0;

            Debug.WriteLine(Globals.passwordFinal);

            for (int i = 0; i < passwordLength; i++)
            {
                selectNum = random.Next(1, 5);
                Debug.WriteLine("loop entered");
                if (needsUppercase == true && selectNum == 4) // generates uppercase letter
                {
                    selectChar = random.Next(0, charU.Length);
                    Globals.password[i] = charU[selectChar].ToString();
                    // Debug.WriteLine("character added");
                }
                else if (needsSymbols == true && selectNum == 3) // generates symbols
                {
                    selectChar = random.Next(0, symbols.Length - 1);
                    Globals.password[i] = symbols[selectChar].ToString();
                    Globals.password[i] = symbols[selectChar].ToString();
                }
                else if (needsNumbers == true && selectNum == 2) // generates numbers
                {
                    selectChar = random.Next(0, nums.Length - 1);
                    Globals.password[i] = nums[selectChar].ToString();
                }
                else // generates letters 
                {
                    selectChar = random.Next(0, chars.Length - 1);
                    Globals.password[i] = chars[selectChar].ToString();
                }

                Globals.passwordFinal = Globals.passwordFinal + Globals.password[i];
                Debug.WriteLine("password created: " + Globals.passwordFinal);
            }
            displayText(Globals.passwordFinal);
            //return passwordFinal;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (outputBox.Text != "")
                outputBox.Text = "";
            amountGenerate = int.Parse(numGenerate.Text);
            passwordLength = int.Parse(psLength.Text);
            Globals.password = new string[passwordLength];
            Debug.WriteLine(passwordLength);
            for (int i = 0; i <= amountGenerate; i++)
            {
                Debug.WriteLine("amount generated: " + i);
                passGenerator();
            }

        }

        public void displayText(string pass)
        {
            Debug.WriteLine(pass);
            outputBox.Text = outputBox.Text + pass + "\n";
        }

        private void isUppercase_CheckedChanged(object sender, EventArgs e)
        {
            if(isUppercase.Checked == true)
                needsUppercase = true;
            else
                needsUppercase = false; 
        }

        private void hasNums_CheckedChanged(object sender, EventArgs e)
        {
            if (hasNums.Checked == true)
                needsNumbers = true;
            else
                needsNumbers = false;
        }

        private void hasSymbols_CheckedChanged(object sender, EventArgs e)
        {
            if (hasSymbols.Checked == true)
                needsSymbols = true;
            else
                needsSymbols = false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            bool overwrite = false;
            Globals.fPath = Environment.ExpandEnvironmentVariables("%USERPROFILE%\\Documents\\Password Generator");
            Globals.path = Environment.ExpandEnvironmentVariables("%USERPROFILE%\\Documents\\Password Generator\\savedPasswords.txt");
            if (!System.IO.Directory.Exists(Globals.fPath)) {
                Debug.WriteLine("path created");
                System.IO.Directory.CreateDirectory(Globals.fPath); }
            if (!System.IO.File.Exists(Globals.path))
            {
                Debug.WriteLine("file created");
                File.WriteAllText(Globals.path, outputBox.Text);
            }
            else
            {
                overwrite = warningMsg();
                if (overwrite == true)
                    File.WriteAllText(Globals.path, outputBox.Text);
                else
                    File.AppendAllText(Globals.path, (outputBox.Text + Environment.NewLine));
            }
        }
        public bool warningMsg()
        {
            DialogResult d = MessageBox.Show("Would you like to overwrite the previous stored data?", "Saving...", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

// global vars
    public static class Globals
    {
        public static String[] password;
        public static String passwordFinal;
        public static String fPath;
        public static String path;
    }

}