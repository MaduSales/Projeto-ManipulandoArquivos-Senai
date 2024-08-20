using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViaCep;

namespace ProjetoArquivo
{
    public partial class Atividade02 : Form
    {
        public Atividade02()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var result = new ViaCepClient().Search(txtCep.Text);

            txtRua.Text = result.Street;
            txtBairro.Text = result.Neighborhood;
            txtCidade.Text = result.City;
            txtUf.Text = result.StateInitials;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string caminhoDoArquivo = @"C:\Users\Aluno\Desktop\Dados.txt";

            string nome, email, cpf, rg, telefone, celular;
            string cep, rua, bairro, cidade, numero, uf, complemento;

            nome = txtNome.Text;
            email = txtEmail.Text;
            rg = txtRg.Text;
            cpf = txtCpf.Text;
            telefone = txtTelefone.Text;
            celular = txtCelular.Text;

            rua = txtRua.Text;
            cep = txtCep.Text;
            bairro = txtBairro.Text;
            cidade = txtCidade.Text;
            complemento = txtComplemento.Text;
            numero = txtNumero.Text;
            uf = txtUf.Text;

            string conteudoDoArquivo = "=====================================\n" +
                                        $"Nome: {nome}\n" +
                                        $"Email: {email}\n" +
                                        $"RG: {rg}\n" +
                                        $"CPF: {cpf}\n" +
                                        $"Telefone: {telefone}\n" +
                                        $"Celular: {celular}\n" +
                                        $"Rua: {rua}\n" +
                                        $"CEP: {cep}\n" +
                                        $"Bairro: {bairro}\n" +
                                        $"Cidade: {cidade}\n" +
                                        $"Complemento: {complemento}\n" +
                                        $"Nº: {numero}\n" +
                                        $"UF: {uf}\n" +
                                        "======================================";

            try
            {
                // Grava o conteúdo no arquivo
                File.AppendAllText(caminhoDoArquivo, conteudoDoArquivo + Environment.NewLine);

                MessageBox.Show("Dados salvos com sucesso no arquive.");

                txtNome.Clear();
                txtEmail.Clear();
                txtRg.Clear();
                txtCpf.Clear();
                txtTelefone.Clear();
                txtCelular.Clear();
                txtRua.Clear();
                txtCep.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                txtNumero.Clear();
                txtUf.Clear();
                txtComplemento.Clear();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao salvar dados: " + erro.Message);
            }
        }
    }
}
