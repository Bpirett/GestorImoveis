using GestorImoveis.BLL;
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

namespace GestorImoveis.Forms
{
    public partial class DigitalizacaoForm : Form
    {
        public DigitalizacaoForm()
        {
            InitializeComponent();

            BoContrato boContrato = new BoContrato();
            cboContratos.DataSource = boContrato.ConsulContratos();
        }

        OpenFileDialog ofd = new OpenFileDialog();


        #region Constantes

        private const string  CONTRATO = "Contrato";

        private const string  SERVIÇO = "Serviço";

        private const string  ENTREGACHAVES_ENTRADA= "EntregaChavesEntrada";

        private const string  ENTREGACHAVES_SAIDA = "EntregaChavesSaida";

        private const string  DOCLOCADOR= "DocLocador";

        private const string  DOCLOCATARIO = "DocLocatario";

        private const string  RECIBOS = "Recibos";

        private const string  BOLETOS = "Boletos";

        private const string  OUTROS = "Outros";


        #endregion


        #region  Eventos

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(BoParametro.R_DIRDIGIT + CONTRATO + cboContratos.Text))
                Directory.CreateDirectory(BoParametro.R_DIRDIGIT + CONTRATO + cboContratos.Text);

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in ofd.FileNames)
                {
                    FileInfo fileInfo = new FileInfo(fileName);
                    if (!File.Exists(BoParametro.R_DIRDIGIT + CONTRATO + cboContratos.Text + "\\" + fileInfo.Name))
                    {
                        fileInfo.CopyTo(BoParametro.R_DIRDIGIT + CONTRATO + cboContratos.Text + "\\" + fileInfo.Name);
                        MessageBox.Show("Arquivo saldo com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show($"Arquivo {fileInfo.Name} já existe. Deseja sobrecrever o arquivo?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            File.Delete((BoParametro.R_DIRDIGIT + CONTRATO + cboContratos.Text + "\\" + fileInfo.Name));
                            fileInfo.CopyTo(BoParametro.R_DIRDIGIT + CONTRATO + cboContratos.Text + "\\" + fileInfo.Name);
                        }
                    }

                }
            }

        }

        private void btnServico_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(BoParametro.R_DIRDIGIT + SERVIÇO + cboContratos.Text))
                Directory.CreateDirectory(BoParametro.R_DIRDIGIT + SERVIÇO + cboContratos.Text);

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in ofd.FileNames)
                {
                    FileInfo fileInfo = new FileInfo(fileName);
                    if (!File.Exists(BoParametro.R_DIRDIGIT + SERVIÇO + cboContratos.Text + "\\" + fileInfo.Name))
                    {
                        fileInfo.CopyTo(BoParametro.R_DIRDIGIT + SERVIÇO + cboContratos.Text + "\\" + fileInfo.Name);
                        MessageBox.Show("Arquivo saldo com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show($"Arquivo {fileInfo.Name} já existe. Deseja sobrecrever o arquivo?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            File.Delete((BoParametro.R_DIRDIGIT + SERVIÇO + cboContratos.Text + "\\" + fileInfo.Name));
                            fileInfo.CopyTo(BoParametro.R_DIRDIGIT + SERVIÇO + cboContratos.Text + "\\" + fileInfo.Name);
                        }
                    }

                }
            }
        }

        private void btnEntragaChavesEntrada_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(BoParametro.R_DIRDIGIT + ENTREGACHAVES_ENTRADA + cboContratos.Text))
                Directory.CreateDirectory(BoParametro.R_DIRDIGIT + ENTREGACHAVES_ENTRADA + cboContratos.Text);

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in ofd.FileNames)
                {
                    FileInfo fileInfo = new FileInfo(fileName);
                    if (!File.Exists(BoParametro.R_DIRDIGIT + ENTREGACHAVES_ENTRADA + cboContratos.Text + "\\" + fileInfo.Name))
                    {
                        fileInfo.CopyTo(BoParametro.R_DIRDIGIT + ENTREGACHAVES_ENTRADA + cboContratos.Text + "\\" + fileInfo.Name);
                        MessageBox.Show("Arquivo saldo com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show($"Arquivo {fileInfo.Name} já existe. Deseja sobrecrever o arquivo?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            File.Delete((BoParametro.R_DIRDIGIT + ENTREGACHAVES_ENTRADA + cboContratos.Text + "\\" + fileInfo.Name));
                            fileInfo.CopyTo(BoParametro.R_DIRDIGIT + ENTREGACHAVES_ENTRADA + cboContratos.Text + "\\" + fileInfo.Name);
                        }
                    }

                }
            }
        }

        private void btnEntregaChavesSaida_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(BoParametro.R_DIRDIGIT + ENTREGACHAVES_SAIDA + cboContratos.Text))
                Directory.CreateDirectory(BoParametro.R_DIRDIGIT + ENTREGACHAVES_SAIDA + cboContratos.Text);

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in ofd.FileNames)
                {
                    FileInfo fileInfo = new FileInfo(fileName);
                    if (!File.Exists(BoParametro.R_DIRDIGIT + ENTREGACHAVES_SAIDA + cboContratos.Text + "\\" + fileInfo.Name))
                    {
                        fileInfo.CopyTo(BoParametro.R_DIRDIGIT + ENTREGACHAVES_SAIDA + cboContratos.Text + "\\" + fileInfo.Name);
                        MessageBox.Show("Arquivo saldo com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show($"Arquivo {fileInfo.Name} já existe. Deseja sobrecrever o arquivo?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            File.Delete((BoParametro.R_DIRDIGIT + ENTREGACHAVES_SAIDA + cboContratos.Text + "\\" + fileInfo.Name));
                            fileInfo.CopyTo(BoParametro.R_DIRDIGIT + ENTREGACHAVES_SAIDA + cboContratos.Text + "\\" + fileInfo.Name);
                        }
                    }

                }
            }
        }

        private void btnDocLocador_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(BoParametro.R_DIRDIGIT + DOCLOCADOR + cboContratos.Text))
                Directory.CreateDirectory(BoParametro.R_DIRDIGIT + DOCLOCADOR + cboContratos.Text);

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in ofd.FileNames)
                {
                    FileInfo fileInfo = new FileInfo(fileName);
                    if (!File.Exists(BoParametro.R_DIRDIGIT + DOCLOCADOR + cboContratos.Text + "\\" + fileInfo.Name))
                    {
                        fileInfo.CopyTo(BoParametro.R_DIRDIGIT + DOCLOCADOR + cboContratos.Text + "\\" + fileInfo.Name);
                        MessageBox.Show("Arquivo saldo com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show($"Arquivo {fileInfo.Name} já existe. Deseja sobrecrever o arquivo?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            File.Delete((BoParametro.R_DIRDIGIT + DOCLOCADOR + cboContratos.Text + "\\" + fileInfo.Name));
                            fileInfo.CopyTo(BoParametro.R_DIRDIGIT + DOCLOCADOR + cboContratos.Text + "\\" + fileInfo.Name);
                        }
                    }

                }
            }
        }

        private void btnDocLocatario_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(BoParametro.R_DIRDIGIT + DOCLOCATARIO + cboContratos.Text))
                Directory.CreateDirectory(BoParametro.R_DIRDIGIT + DOCLOCATARIO + cboContratos.Text);

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in ofd.FileNames)
                {
                    FileInfo fileInfo = new FileInfo(fileName);
                    if (!File.Exists(BoParametro.R_DIRDIGIT + DOCLOCATARIO + cboContratos.Text + "\\" + fileInfo.Name))
                    {
                        fileInfo.CopyTo(BoParametro.R_DIRDIGIT + DOCLOCATARIO + cboContratos.Text + "\\" + fileInfo.Name);
                        MessageBox.Show("Arquivo saldo com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show($"Arquivo {fileInfo.Name} já existe. Deseja sobrecrever o arquivo?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            File.Delete((BoParametro.R_DIRDIGIT + DOCLOCATARIO + cboContratos.Text + "\\" + fileInfo.Name));
                            fileInfo.CopyTo(BoParametro.R_DIRDIGIT + DOCLOCATARIO + cboContratos.Text + "\\" + fileInfo.Name);
                        }
                    }

                }
            }
        }

        private void btnRecibos_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(BoParametro.R_DIRDIGIT + RECIBOS + cboContratos.Text))
                Directory.CreateDirectory(BoParametro.R_DIRDIGIT + RECIBOS + cboContratos.Text);

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in ofd.FileNames)
                {
                    FileInfo fileInfo = new FileInfo(fileName);
                    if (!File.Exists(BoParametro.R_DIRDIGIT + RECIBOS + cboContratos.Text + "\\" + fileInfo.Name))
                    {
                        fileInfo.CopyTo(BoParametro.R_DIRDIGIT + RECIBOS + cboContratos.Text + "\\" + fileInfo.Name);
                        MessageBox.Show("Arquivo saldo com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show($"Arquivo {fileInfo.Name} já existe. Deseja sobrecrever o arquivo?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            File.Delete((BoParametro.R_DIRDIGIT + RECIBOS + cboContratos.Text + "\\" + fileInfo.Name));
                            fileInfo.CopyTo(BoParametro.R_DIRDIGIT + RECIBOS + cboContratos.Text + "\\" + fileInfo.Name);
                        }
                    }

                }
            }

        }

        private void btnBoletos_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(BoParametro.R_DIRDIGIT + BOLETOS + cboContratos.Text))
                Directory.CreateDirectory(BoParametro.R_DIRDIGIT + BOLETOS + cboContratos.Text);

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in ofd.FileNames)
                {
                    FileInfo fileInfo = new FileInfo(fileName);
                    if (!File.Exists(BoParametro.R_DIRDIGIT + BOLETOS + cboContratos.Text + "\\" + fileInfo.Name))
                    {
                        fileInfo.CopyTo(BoParametro.R_DIRDIGIT + BOLETOS + cboContratos.Text + "\\" + fileInfo.Name);
                        MessageBox.Show("Arquivo saldo com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show($"Arquivo {fileInfo.Name} já existe. Deseja sobrecrever o arquivo?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            File.Delete((BoParametro.R_DIRDIGIT + BOLETOS + cboContratos.Text + "\\" + fileInfo.Name));
                            fileInfo.CopyTo(BoParametro.R_DIRDIGIT + BOLETOS + cboContratos.Text + "\\" + fileInfo.Name);
                        }
                    }

                }
            }
        }

        private void btnOutro_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(BoParametro.R_DIRDIGIT + OUTROS + cboContratos.Text))
                Directory.CreateDirectory(BoParametro.R_DIRDIGIT + OUTROS + cboContratos.Text);

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in ofd.FileNames)
                {
                    FileInfo fileInfo = new FileInfo(fileName);
                    if (!File.Exists(BoParametro.R_DIRDIGIT + OUTROS + cboContratos.Text + "\\" + fileInfo.Name))
                    {
                        fileInfo.CopyTo(BoParametro.R_DIRDIGIT + OUTROS + cboContratos.Text + "\\" + fileInfo.Name);
                        MessageBox.Show("Arquivo saldo com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show($"Arquivo {fileInfo.Name} já existe. Deseja sobrecrever o arquivo?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            File.Delete((BoParametro.R_DIRDIGIT + OUTROS + cboContratos.Text + "\\" + fileInfo.Name));
                            fileInfo.CopyTo(BoParametro.R_DIRDIGIT + OUTROS + cboContratos.Text + "\\" + fileInfo.Name);
                        }
                    }

                }
            }
        }

        #endregion
    }
}
