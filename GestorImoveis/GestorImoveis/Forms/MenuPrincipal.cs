using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GestorImoveis.BLL;

namespace GestorImoveis.Forms
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            AbrirforminPanel(new InicioResumo());
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            AbrirforminPanel(new CadastroCliente());
        }

        private void btnCadContratos_Click(object sender, EventArgs e)
        {
            AbrirforminPanel(new CadastroContrato());
        }

        private void btnslide_Click(object sender, EventArgs e)
        {
            if (PanelMenuVertical.Width == 200)
            {
                PanelMenuVertical.Width = 58;
            }
            else
                PanelMenuVertical.Width = 200;
        }

        public void AbrirforminPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AbrirforminPanel(new InicioResumo());
        }

        private void btnBoletos_Click(object sender, EventArgs e)
        {
            AbrirforminPanel(new BoletosForm());
        }

        private void btnAnuncios_Click(object sender, EventArgs e)
        {
            AbrirforminPanel(new Anuncios());
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            AbrirforminPanel(new RelatoriosForms());
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            AbrirforminPanel(new Configuracao());
        }

        private void btnDigitalizacao_Click(object sender, EventArgs e)
        {
            AbrirforminPanel(new DigitalizacaoForm());
        }

        private void PanelMenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuNotificacoes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Exit")
            {
                Environment.Exit(0);
            }
            else if (e.ClickedItem.Text == "Restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void PictureMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TimerNotificacao_Tick(object sender, EventArgs e)
        {
            AlertForm alertForm = new AlertForm();
            if (alertForm.GetAlertBoletosVencer())
                alertForm.ShowDialog();

        }

        private void picture_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
