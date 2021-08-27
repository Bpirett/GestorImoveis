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
    public partial class UploadImageForm : Form
    {
        //Cria dinamicamente ImageList em tempo de execução
        ImageList imageList = new ImageList();
        ImageList imageListPequeno = new ImageList();
        ImageList imageListGrande = new ImageList();

        int contador = 0;
        public string novoNomeImagem = "";
        string CodAnuncio = "";
        bool Alteracao = false;
        public Forms.Anuncios form;
        FileInfo fi;

        //abre uma janela de diálogo para selecionar imagens
        OpenFileDialog ofd = new OpenFileDialog()
        {
            Multiselect = true,
            ValidateNames = true,
            Filter = "JPG|*jpg|JPEG|*.jpeg|PNG|*.png"
        };

        public UploadImageForm(string pCodAnuncio, bool pTipoTelaAlteracao, Forms.Anuncios pForm)
        {
            InitializeComponent();
            //inicializa os ImageList 
            listImages.SmallImageList = imageListPequeno;
            listImages.SmallImageList = imageListGrande;
            this.KeyPreview = true;
            CodAnuncio = pCodAnuncio;
            lblCodAnuncio.Text = pCodAnuncio;
            Alteracao = pTipoTelaAlteracao;
            form = pForm;

            if (Alteracao)
                MontarAmbienteInicial(pCodAnuncio);
        }

        public void MontarAmbienteInicial(string pCodAnuncio)
        {
            // define o tamanho da das imagens no imagelist
            imageList.ImageSize = new Size(50, 50);
            imageListPequeno.ImageSize = new Size(32, 32);
            imageListGrande.ImageSize = new Size(90, 90);

            DirectoryInfo oDirectoryInfo = new DirectoryInfo(BoParametro.R_DIRANUN + pCodAnuncio);

            List<String> oListTiposImagens = new List<string>();
            //Adicione quantas extensões você desejar!
            oListTiposImagens.Add("*.jpeg");
            oListTiposImagens.Add("*.png");
            oListTiposImagens.Add("*.jpg");

            foreach (String strExtensao in oListTiposImagens)
            {
                List<FileInfo> oListFileInfo = oDirectoryInfo.GetFiles(strExtensao).ToList();
                foreach (FileInfo fi in oListFileInfo)
                {
                    using (FileStream stream = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read))
                    {
                        imageList.Images.Add(Image.FromStream(stream));
                        imageListPequeno.Images.Add(Image.FromStream(stream));
                        imageListGrande.Images.Add(Image.FromStream(stream));
                    }
                    listImages.LargeImageList = imageList;

                    listImages.Items.Add(new ListViewItem
                    {
                        ImageIndex = contador,
                        Text = fi.Name,
                        Tag = fi.FullName
                    });
                    contador++;
                }
               
            }

            lblcontadorSelecionadas.Text = contador.ToString();

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {

            // define o tamanho da das imagens no imagelist
            imageList.ImageSize = new Size(50, 50);
            imageListPequeno.ImageSize = new Size(32, 32);
            imageListGrande.ImageSize = new Size(90, 90);

            //seleciona as imagens e incluir no imagelist
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!Alteracao)
                    listImages.Items.Clear();

                foreach (string fileName in ofd.FileNames)
                {
                    fi = new FileInfo(fileName);
                    FileInfo fileinfo = new FileInfo(fileName);
                    using (FileStream stream = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read))
                    {
                        imageList.Images.Add(Image.FromStream(stream));
                        imageListPequeno.Images.Add(Image.FromStream(stream));
                        imageListGrande.Images.Add(Image.FromStream(stream));
                    }
                    listImages.LargeImageList = imageList;

                    listImages.Items.Add(new ListViewItem
                    {
                        ImageIndex = contador,
                        Text = fi.Name,
                        Tag = fi.FullName
                    });
                    contador++;
                }
            }

            lblcontadorSelecionadas.Text = contador.ToString();

            if (contador > 24)
            {
                listImages.Items.Clear();
                contador = 0; 
                MessageBox.Show("Limite Atingido! Selecionar no maximo 24 imagens ", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MontarAmbienteInicial(CodAnuncio);
            }
        }

        private void rdbLadoLado_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbLadoLado.Checked == true)
            {
                listImages.View = View.Tile;
            }
        }

        private void rdbLista_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbLista.Checked == true)
            {
                listImages.View = View.List;
            }
        }

        private void rdbPequenos_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbPequenos.Checked == true)
            {
                listImages.SmallImageList = imageListPequeno;
                listImages.View = View.SmallIcon;
            }
        }

        private void rdbGrandes_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbGrandes.Checked == true)
            {
                listImages.LargeImageList = imageListGrande;
                listImages.View = View.LargeIcon;
            }
        }

        private void listImages_MouseClick(object sender, MouseEventArgs e)
        {
            //aciona o menu de contexto com a opção - Renomear
            ContextMenu cm = new ContextMenu();
            listImages.ContextMenu = cm;
            var mi = new MenuItem("Renomear");

            listImages.LabelEdit = true;
            mi.MenuItems.Add(mi);
            mi.Click += OnMenuItemClick;
            cm.MenuItems.Add(mi);

        }

        //Renomeia a imagem iniciando a edição
        //Defina a propriedade LabelEdit como true para evitar erros
        private void OnMenuItemClick(object sender, EventArgs e)
        {
            listImages.SelectedItems[0].BeginEdit();
        }

        private void listImages_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label == null)
                return;

            novoNomeImagem = Convert.ToString(e.Label);

            ListViewItem item1 = listImages.SelectedItems[0];

            FileInfo fileInfo = new FileInfo(item1.Tag.ToString());
            string Tag = listImages.SelectedItems[0].Tag.ToString().Replace(listImages.SelectedItems[0].Text, "");
            listImages.SelectedItems[0].Text = novoNomeImagem + fileInfo.Extension;
            listImages.SelectedItems[0].Tag = Tag + novoNomeImagem + fileInfo.Extension;
            if (Alteracao)
            {
                if (File.Exists(BoParametro.R_DIRANUN + CodAnuncio + "\\" + fileInfo.Name))
                {
                    fileInfo.MoveTo(fileInfo.Directory.FullName + "\\" + novoNomeImagem + fileInfo.Extension);
                }
                else
                    fileInfo.CopyTo(fileInfo.Directory.FullName + "\\" + novoNomeImagem + fileInfo.Extension);
            }
            else
                fileInfo.CopyTo(fileInfo.Directory.FullName + "\\" + novoNomeImagem + fileInfo.Extension);
        }

        private void UploadImageForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                foreach (ListViewItem item in listImages.Items)
                {
                    item.Selected = true;
                    listImages.Focus();
                }
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listImages.SelectedItems)
            {
                listImages.Items.Remove(item);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(BoParametro.R_DIRANUN + CodAnuncio))
                Directory.CreateDirectory(BoParametro.R_DIRANUN + CodAnuncio);
            foreach (ListViewItem item in listImages.Items)
            {

                FileInfo fileInfo = new FileInfo(item.Tag.ToString());
                if (!File.Exists(BoParametro.R_DIRANUN + CodAnuncio + "\\" + fileInfo.Name))
                    fileInfo.MoveTo(BoParametro.R_DIRANUN + CodAnuncio + "\\" + fileInfo.Name);
            }

            MessageBox.Show("Imagens salvas com sucesso! ", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UploadImageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Alteracao)
                form.FinalizarAnuncio();
        }

        private void UploadImageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //form.FinalizarAnuncio();
        }

        //private void listImages_Click(object sender, EventArgs e)
        //{
        //    //exibe a imagem selecionada no Picturebox
        //    if (listImages.SelectedIndices.Count == 0)
        //        return;

        //    Int32 item = listImages.SelectedIndices[0];
        //    Image img1 = imageList.Images[item];

        //    picImagem.Visible = true;
        //    picImagem.Image = img1;
        //}

        //private void picImagem_Click(object sender, EventArgs e)
        //{
        //    //oculta a imagem exibida
        //    if (picImagem.Image != null)
        //    {
        //        picImagem.Image.Dispose();
        //        picImagem.Image = null;
        //    }
        //    picImagem.Visible = false;
        //}


    }
}
