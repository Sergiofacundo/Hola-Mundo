using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text;
            string confirmPassword = textBox2.Text;

            // Expresión regular: al menos una mayúscula, una minúscula, un número y un símbolo
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[\W_]).+$";

            if (!Regex.IsMatch(password, pattern))
            {
                MessageBox.Show("La contraseña no cumple con los requisitos.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            MessageBox.Show("La contraseña ha sido validada");
        }
    }
}
