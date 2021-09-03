using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorImoveis.Forms
{
    public partial class CarregarForm : Form
    {
        public CarregarForm()
        {
            InitializeComponent();
        }

        private void timer_Carregar_Tick(object sender, EventArgs e)
        {
            panel_bar.Width += 3;

            if (panel_bar.Width >= 1092)
            {
                timer_Carregar.Stop();

                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.Show();
                this.Hide();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
