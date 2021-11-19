using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Projeto3Camadas.Code.BLL; 
using Projeto3Camadas.Code.DTO; 

namespace Projeto3Camadas.Ui
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_senha_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            LoginDTO.Email = txtEmail.Text;
            LoginDTO.Senha = txtSenha.Text;


            //Chamada do método para verificar o acesso: 
            if (LoginBLL.RealizarLogin(LoginDTO) == true)
            {

                Login frm_Medicamentos = new Login();
                frm_Medicamentos.ShowDialog();
            }
            else
            {
                //Mensagem de sucesso
                MessageBox.Show("Verifique e-mail e senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkLabEsqueceu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("11900695@aluno.cotemig.com.br", "lwkejdlxawtwpnjc"),
                EnableSsl = true
            };


            LoginDTO.Email = txtEmail.Text;
            string senha = LoginBLL.RetornarSenha(LoginDTO);


            client.Send("11900695@aluno.cotemig.com.br", $"{txtEmail.Text}", "Redefinição de Senha", $"Seu e-mail é {txtEmail.Text} com senha {senha}");


            MessageBox.Show("E-mail e senha enviados com sucesso.", "E-mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
