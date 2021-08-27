using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorImoveis.DAL;
using GestorImoveis.DAL.Clientes;
using GestorImoveis.DML;

namespace GestorImoveis.BLL
{
    public class BoCliente
    {

        public string ObterUltCodCli()
        {
            double UltCodcli;
            int i = 1;
            try
            {
                DalCliente dalCliente = new DalCliente();
                UltCodcli = Convert.ToDouble(dalCliente.ObterUltCodCli());
                UltCodcli += i;

                while (dalCliente.ValidaExistenciaCodCli(UltCodcli.ToString()))
                {
                    UltCodcli += i++;
                }
            }
            catch (Exception ex)
            {

                throw;
            }


            return UltCodcli.ToString().PadLeft(3, '0');

        }

        public void IncluirCliente(DML.Cliente pCliente)
        {

            DalCliente dalCliente = new DalCliente();

            dalCliente.IncluirCliente(pCliente);
        }

        public void AtualizarCliente(DML.Cliente pCliente)
        {

            DalCliente dalCliente = new DalCliente();

            dalCliente.AtualizarCliente(pCliente);
        }
        
        public List<Cliente> ConsultaClientes()
        {
            DalCliente dalCliente = new DalCliente();

            return dalCliente.ConsultaClientes();
        }

        public bool ValidaExistenciaCPF(string pCPF)
        {
            DalCliente dalCliente = new DalCliente();
            return dalCliente.ValidaExistenciaCPF(pCPF);
        }

        public List<Cliente> ObterCliente(string pParam, string pFiltro)
        {
            DalCliente dalCliente = new DalCliente();

            return dalCliente.ObterCliente(pParam , pFiltro);
        }

        public void GravarLogCliente(DML.Cliente pCliente)
        {

            DalCliente dalCliente = new DalCliente();

            dalCliente.GravarLogCliente(pCliente);
        }


    }
}
