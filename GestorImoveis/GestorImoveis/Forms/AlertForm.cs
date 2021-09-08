using GestorImoveis.BLL;
using GestorImoveis.Properties;
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
    public partial class AlertForm : Form
    {
        public AlertForm()
        {
            InitializeComponent();
            
        }

        private int x, y;


        private void ShowNotify(string pMsg, enmType pTipe)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
            this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * 1 - 5 * 1;
            this.Location = new Point(this.x, this.y);

            switch (pTipe)
            {
                case enmType.Success:
                    this.pictureBox1.Image = Resources.error;
                    this.BackColor = Color.SeaGreen;
                    break;
                case enmType.Error:
                    this.pictureBox1.Image = Resources.error;
                    this.BackColor = Color.DarkRed;
                    break;
                case enmType.Info:
                    this.pictureBox1.Image = Resources.info;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case enmType.Warning:
                    this.pictureBox1.Image = Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    break;
            }
            this.lblMsg.Text = pMsg;
        }

        private void AlertForm_Load(object sender, EventArgs e)
        {
            timerclose.Start();
        }

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }

        private void timerclose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region Metodos

        public bool GetAlertBoletosVencer()
        {
            ShowNotify("Existem Boletos a vencer!", enmType.Warning);
            BoBoletos boBoletos = new BoBoletos();
            return boBoletos.BoletosVencer();
        }


        public void GetAlertSecessGeneric(string pMsg)
        {
            ShowNotify(pMsg, enmType.Success);
        }



        #endregion


    }
}
