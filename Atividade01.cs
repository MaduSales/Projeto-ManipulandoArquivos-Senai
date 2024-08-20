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

namespace ProjetoArquivo
{
    public partial class Atividade01 : Form
    {
        string pastaDestino;
        List<string> listaDeArquivos = new List<string>();
        public Atividade01()
        {
            InitializeComponent();
        }

        private void btnSelecionar01_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog(); // Configura o componente para selecionar arquivos

            openFileDialog.Title = "Selecionar os arquivos...";

            openFileDialog.Filter = "Todos (*.*)|*.*"; // Permite selecionar qualquer tipo de arquivo
            openFileDialog.Multiselect = true; // Permite selecionar vários arquivos

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                listaDeArquivos.Clear();
                listaDeArquivos.AddRange(openFileDialog.FileNames); // Adiciona os arquivos selecionados à lista

                MessageBox.Show($"Total de {listaDeArquivos.Count} arquivos selecionados"); // Mostra quantos arquivos foram selecionados

                txtOrigem.Text = Path.GetDirectoryName(openFileDialog.FileName);
            }

        }

        private void btnSelecionar02_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog(); // Cria um componente para selecionar uma pasta de destino dos arquivos

            folderBrowserDialog.Description = "Selecione a pasta destino";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                pastaDestino = folderBrowserDialog.SelectedPath;
                txtDestino.Text = pastaDestino;
            }
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var file in listaDeArquivos) // Percorre a lista de arquivos
                {
                    // Monta o nome do arquivo
                    var fileName = Path.GetFileName(file);
                    var destFile = Path.Combine(pastaDestino, fileName);

                    //Executa a função Copy para cada arquivo da listaDeArquivos
                    File.Copy(file, destFile, true);
                }

                MessageBox.Show("Arquivos copiados com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu o seguinte erro: {ex.Message}");
            }
        }
    }
}
