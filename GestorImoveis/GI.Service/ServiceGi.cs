using GestorImoveis.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GI.Service
{
    public partial class ServiceGi : ServiceBase
    {
        private Timer Worked;
        private readonly int Interval = Convert.ToInt32(BoParametro.C_TIMERSER);


        public ServiceGi()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Worked = new Timer((GetBoletosVencer), null, 0, Interval);
        }

        protected override void OnStop()
        {


        }

        private static void GetBoletosVencer(object state)
        {
            AlertService alertService = new AlertService();
            alertService.AlertBoletosVencer();
        }

    }
}
