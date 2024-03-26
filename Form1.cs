using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


namespace PrimeiroSistema
{
    public partial class FormTelaSistema : System.Windows.Forms.Form
    {
        public FormTelaSistema()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TextCamp.Text = "Msg";// Preenche o formulário com a atribuição escrita
            string nome = FormNome.Text.Trim(); // Obtém o texto digitado no formulário Textbox e remove espaços em branco
            string email = FormEmail.Text.Trim();

            // Verifica se o nome e o email são válidos
            if (nome.Length > 0)
            {
                if (IsValidEmail(email))
                {
                    MessageBox.Show("Nome: " + nome + " & " + "E-mail:" + email + ". Validos!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, digite um email válido.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, digite um nome válido.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormNome.Text = "";
            FormEmail.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FormTelaSistema_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        //Validação de Email
        private bool IsValidEmail(string email)
        {
            // Regex para validar o padrão básico de um endereço de e-mail
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        
        }
    }
}
