//using GestorImoveis.BLL;
using GestorImoveis.BLL;
using GestorImoveis.DML;
using GestorImoveis.Helpers;
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
    public partial class Anuncios : Form
    {
        #region Globais
        /// <summary>
        /// 
        /// </summary>
        bool Alteracao = false;
        #endregion

        #region Construtor
        public Anuncios()
        {
            InitializeComponent();
            HabilitarCampos(false);
            AplicarEventos(txtPreco);
            AplicarEventos(txtIPTU);
        }
        #endregion


        #region Eventos

        private void RadioCriar_CheckedChanged(object sender, EventArgs e)
        {
            Alteracao = false;
            BoAnuncio boContrato = new BoAnuncio();
            HabilitarCampos(true);
            LimparCampos();
            gridAnuncio.DataSource = null;
            PreencherCombos();

        }

        private void RBAlterar_CheckedChanged(object sender, EventArgs e)
        {
            Alteracao = true;
            BoAnuncio boAnuncio = new BoAnuncio();
            HabilitarCampos(false);
            LimparCampos();
            gridAnuncio.DataSource = boAnuncio.ConsultaAnuncio();
            MontarGrid();
            gridAnuncio.Enabled = true;
            PreencherCombos();
        }

        private void RbConsultar_CheckedChanged(object sender, EventArgs e)
        {
            Alteracao = false;
            HabilitarCampos(false);
            LimparCampos();
            BoAnuncio boAnuncio = new BoAnuncio();
            gridAnuncio.DataSource = boAnuncio.ConsultaAnuncio();
            MontarGrid();
            gridAnuncio.Enabled = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RbNomeProp_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void RbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            BoAnuncio boAnuncio = new BoAnuncio();

            try
            {

                if (RbCodigo.Checked == true && !string.IsNullOrEmpty(TxtPesquisa.Text))
                {
                    gridAnuncio.DataSource = boAnuncio.PesqContrato(TxtPesquisa.Text, RbCodigo.Text);
                }
                else if (RbRegiao.Checked == true && !string.IsNullOrEmpty(cboRegiaoPesq.Text))
                {
                    gridAnuncio.DataSource = boAnuncio.PesqContrato(cboRegiaoPesq.Text, RbRegiao.Text);
                }
                else if (RbNomeProp.Checked == true && !string.IsNullOrEmpty(TxtPesquisa.Text))
                {
                    gridAnuncio.DataSource = boAnuncio.PesqContrato(TxtPesquisa.Text, RbNomeProp.Text);
                }
                else
                {
                    gridAnuncio.DataSource = boAnuncio.ConsultaAnuncio();
                }

                MontarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboNeg_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoAnuncio boAnuncio = new BoAnuncio();

            if (!this.Alteracao && RbConsultar.Checked == false)
            {
                if (cboNeg.Text == "Venda")
                    txtId.Text = boAnuncio.GeraCodigoSequencial(cboNeg.Text, "V");
                else if (cboNeg.Text == "Alugar")
                    txtId.Text = boAnuncio.GeraCodigoSequencial(cboNeg.Text, "A");
            }

        }

        private void cboRegiao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRegiao.Text == "Zona Norte" || cboRegiao.Text == "Zona Leste" || cboRegiao.Text == "Zona Oeste" || cboRegiao.Text == "Zona Sul")
            {
                string[] cidade = { "São Paulo" };

                cboCidade.DataSource = cidade;
            }
            else if (cboRegiao.Text == "Grande ABC")
            {
                string[] cidade = { "Selecionar", "Santo André", "São Bernardo do Campo", "São Caetano do Sul", "Diadema", "Ribeirão Pires", "Mauá", "Franco da Rocha", "Rio Grande da Serra" };

                cboCidade.DataSource = cidade;
            }
            else if (cboRegiao.Text == "Litoral")
            {
                string[] cidade = { "Praia Grande", "Santos", "Mongaguá", "Itanhaém", "Guarujá", "São Vicente", "Peruíbe", "Bertioga", "Ubatuba", "Caraguatatuba", "São Sebastião", "Ilhabela", "Ilha Comprida", "Iguape", "Cananéia", "Cubatão", "Itararé" };

                cboCidade.DataSource = cidade;
            }

        }

        private void cboCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCidade.Text == "São Paulo" && cboRegiao.Text == "Zona Norte")
            {
                string[] bairo = {  "Água Fria",  "Alto de Santana",  "Armênia",  "Associação Sobradinho",  "Barro Branco (Zona Norte)",  "Bortolândia",  "Brasilândia",  "Cachoeirinha",  "Carandiru",  "Casa Verde",
                "Casa Verde Alta",  "Casa Verde Baixa",  "Casa Verde Média",  "Chácara do Encosto",  "Chácara Inglesa (ZN)",  "Chácara Nossa Senhora Aparecida",  "Chora Menino",  "City Jaraguá",  "Cohab Santa Terezinha",
                "Conjunto dos Bancários",  "Conjunto Habitacional Brigadeiro Eduardo Gomes",  "Freguesia do Ó",  "Furnas",  "Guapira",  "Horto Florestal",  "Imirim",  "Itaberaba",  "Jaçanã",  "Jaguaré",
                "Jardim Almanara",  "Jardim Alvorada",  "Jardim Andaraí",  "Jardim Antártica",  "Jardim Ataliba Leonel",  "Jardim Bandeirantes (Zona Norte)",  "Jardim Bela Vista (Zona Norte)",  "Jardim Bibi",
                "Jardim Brasil",  "Jardim Brasília (Zona Norte)",  "Jardim Cabuçu",  "Jardim Cachoeira",  "Jardim Carlu",  "Jardim Carombé",  "Jardim Cecy",  "Jardim Centenário",  "Jardim Corisco",  "Jardim Damasceno",
                "Jardim das Cerejeiras",  "Jardim das Graças",  "Jardim das Laranjeiras",  "Jardim das Pedras",  "Jardim das Rosas",  "Jardim Daysy",  "Jardim do Colégio",  "Jardim do Tiro",  "Jardim dos Francos",
                "Jardim Elisa Maria",  "Jardim Elisio",  "Jardim Entre Serras",  "Jardim Estrela D'alva",  "Jardim Felicidade",  "Jardim Filhos da Terra",  "Jardim Flor de Maio",  "Jardim Floresta",  "Jardim Fontalis",
                "Jardim França",  "Jardim Francisco Mendes",  "Jardim Guançã",  "Jardim Guapira",  "Jardim Guarani",  "Jardim Ibiratiba",  "Jardim Íris",  "Jardim Itatinga",  "Jardim Jaçanã",  "Jardim Japão",
                "Jardim Joamar",  "Jardim Joana D'Arc",  "Jardim Julieta",  "Jardim Kherlakhian",  "Jardim Labitary",  "Jardim Leonor Mendes de Barros",  "Jardim Mangalot (ZN)",  "Jardim Maracanã",  "Jardim Mariliza",
                "Jardim Maristela",  "Jardim Martins Silva",  "Jardim Modelo",  "Jardim Monjolo",  "Jardim Monte Alegre",  "Jardim Nossa Senhora da Consolata",  "Jardim Ondina",  "Jardim Paquetá",  "Jardim Paraíso",
                "Jardim Paulistano (Zona Norte)",  "Jardim Pereira Leite",  "Jardim Peri",  "Jardim Peri Novo",  "Jardim Picolo",  "Jardim Primavera",  "Jardim Princesa",  "Jardim Recanto Verde",  "Jardim Regina",
                "Jardim Rincão",  "Jardim Rossin",  "Jardim Santa Cruz",  "Jardim Santa Inês",  "Jardim Santa Lucrécia",  "Jardim Santo Alberto",  "Jardim São Bento",  "Jardim São Domingo",  "Jardim São José (Zona Norte)",
                "Jardim São Paulo",  "Jardim Teresa",  "Jardim Tiro ao Pombo",  "Jardim Tremembé",  "Jardim Vila Rica",  "Jardim Virginia Bianca",  "Jardim Vista Alegre",  "Jardim Vitória Régia",  "Jardim Yara",
                "Jova Rural",  "Lauzane Paulista",  "Limão",  "Mandaqui",  "Moinho Velho",  "Morro Grande",  "Nossa Senhora do Ó",  "Núcleo do Engordador",  "Palmas do Tremembé",  "Parada de Taipas",  "Parada Inglesa",
                "Parque Anhembi",  "Parque Belém",  "Parque Casa de Pedra",  "Parque Edu Chaves",  "Parque Itaberaba",  "Parque Mandaqui",  "Parque Mandi",  "Parque Monteiro Soares",  "Parque Novo Mundo",
                "Parque Palmas do Tremembé",  "Parque Peruche",  "Parque Ramos Freitas",  "Parque Rodrigues Alves",  "Parque São Luís",  "Parque Tietê",  "Parque Vila Maria",  "Parque Vitória",  "Pedra Branca",  "Perus",
                "Piqueri (ZN)",  "Ponte Pequena",  "Protendit",  "Reserva Nova Cantareira",  "Santa Inês",  "Santa Teresinha",  "Santana",  "Serra da Cantareira",  "Sítio do Mandaqui",  "Sítio do Morro",  "Sítio do Piqueri",
                "Sítio Morro Grande",  "Taipas",  "Tietê",  "Tremembé",  "Três Cruzes",  "Tucuruvi",  "Vila Albertina",  "Vila Amália (Zona Norte)",  "Vila Amélia",  "Vila América",  "Vila Arcádia",  "Vila Aurora (Zona Norte)",
                "Vila Bancária Munhoz",  "Vila Bandeirantes",  "Vila Barbosa",  "Vila Baruel",  "Vila Basileia",  "Vila Bela Vista (Zona Norte)",  "Vila Bianca",  "Vila Brasil",  "Vila Brasilândia",  "Vila Bruna",  "Vila Cachoeira",
                "Vila Caiúba",  "Vila Carbone",  "Vila Carolina",  "Vila Catupia",  "Vila Cavaton",  "Vila Celeste",  "Vila Constança",  "Vila Continental",  "Vila Cruz das Almas",  "Vila Dionisia",  "Vila Diva (Zona Norte)",  "Vila Dom Pedro II",
                "Vila Dona Augusta",  "Vila Dorna",  "Vila dos Andrades",  "Vila Duarte",  "Vila Ede",  "Vila Espanhola",  "Vila Ester",  "Vila Fiat Lux (ZN)",  "Vila Fidalgo",  "Vila Florentina",  "Vila Francos",
                "Vila Germinal",  "Vila Gouveia",  "Vila Guaca",  "Vila Guilherme",  "Vila Gustavo",  "Vila Hebe",  "Vila Hermínia",  "Vila Iório",  "Vila Irmãos Arnoni",  "Vila Isolina Mazzei",  "Vila Itaberaba",
                "Vila Jaraguá",  "Vila João Batista",  "Vila Leonor",  "Vila Mangalot",  "Vila Maria",  "Vila Maria Alta",  "Vila Maria Baixa",  "Vila Maria Luisa",  "Vila Maria Trindade",  "Vila Marina",
                "Vila Mariza Mazzei",  "Vila Mazzei",  "Vila Medeiros",  "Vila Miriam",  "Vila Munhoz",  "Vila Nelson",  "Vila Nilo",  "Vila Nina",  "Vila Nivi",  "Vila Nossa Senhora do Retiro",  "Vila Nova Cachoeirinha",
                "Vila Nova Carolina",  "Vila Nova Galvão",  "Vila Nova Mazzei",  "Vila Nova Parada",  "Vila Paiva",  "Vila Palmeiras",  "Vila Paulicéia",  "Vila Paulistana",  "Vila Pedra Branca",  "Vila Penteado",
                "Vila Pereira Barreto",   "Vila Pereira Cerca",  "Vila Pirituba",  "Vila Pita",  "Vila Portuguesa",  "Vila Prado",  "Vila Primavera (Zona Norte)",  "Vila Progresso (Zona Norte)",  "Vila Ramos (ZN)",
                "Vila Regina (Zona Norte)",  "Vila Renato (Zona Norte)",  "Vila Rica",  "Vila Romero",  "Vila Roque",  "Vila Rosa",  "Vila Sabrina",  "Vila Santa Delfina",  "Vila Santa Maria",  "Vila Santa Terezinha (ZN)",
                "Vila Santista (ZN)",  "Vila Santos",  "Vila Serralheiro",  "Vila Siqueira (Zona Norte)",  "Vila Souza",  "Vila Teresinha",  "Vila Timóteo", "Vila Toninho",  "Vila União (Zona Norte)",
                "Vila Virginia  (Zona Norte)",  "Vila Vitório Mazzei",  "Vila Yara",  "Vila Zat",  "Vila Zilda",  "Vila Zulmira",  "Vista Verde"};

                cboBairro.DataSource = bairo;
            }

            if (cboCidade.Text == "São Paulo" && cboRegiao.Text == "Zona Leste")
            {
                string[] bairo = { "Água Rasa",   "Alamandas",  "Alto da Moóca",  "Alto do Pari",  "Altos de Vila Prudente",  "Aricanduva",  "Artur Alvim",  "Belém",  "Belenzinho",  "Brás",
                  "Bresser",  "Burgo Paulista",  "Cangaíba",  "Canindé",  "Capão do Émbira",  "Carrão",  "Catumbi",  "Chácara Belenzinho",  "Chácara Califórnia",  "Chácara Cruzeiro do Sul",  "Chácara Mafalda",
                  "Chácara Santa Etelvina",  "Chácara Santo Antônio (ZL)",  "Chácara Seis de Outubro",  "Chácara Tatuapé",  "Cidade A. E. Carvalho",  "Cidade Centenário",  "Cidade Continental",  "Cidade Kemel",
                  "Cidade Líder",  "Cidade Mãe do Céu",  "Cidade Nova São Miguel",  "Cidade Patriarca",  "Cidade São Mateus",  "Cidade São Miguel",  "Cidade Satélite Santa Bárbara",  "Cidade Tiradentes",
                  "Cohab A E Carvalho",  "Cohab Barreira Grande",  "Cohab Barro Branco I",  "Cohab Barro Branco II",  "Cohab Castro Alves",  "Cohab Fazenda do Carmo",  "Cohab I (Artur Alvim)",  "Cohab Inácio Monteiro",
                  "Cohab José Bonifácio",  "Cohab Juscelino Kubitschek",  "Cohab Mal Mascarenhas de Morais",  "Cohab P. Man. de Paiva",  "Cohab Padre José de Anchieta",  "Cohab Padre Manoel da Nóbrega",
                  "Cohab Santa Etelvina",  "Cohab Santa Etelvina II",  "Cohab Santa Etelvina III",  "Cohab Teotonio Vilela",  "Colônia (ZL)",  "Conj. Res. Prestes Maia",  "Conjunto Jaú",  "Conjunto Promorar Sapopemba",
                  "Engenheiro Goulart",  "Ermelino Matarazzo",  "Fazenda Aricanduva",  "Fazenda Caguaçu",  "Fazenda da Juta",  "Fazenda Itaim",  "Gleba do Pêssego",  "Guaianases",  "Guaiaúna",  "Iguatemi",
                  "Itaim Paulista",  "Itaquera",  "Jardim Adelaide",  "Jardim Adutora",  "Jardim Aimore",  "Jardim Alto Alegre (ZL)",  "Jardim Alto Pedroso",  "Jardim América da Penha",  "Jardim Ana Rosa",
                  "Jardim Anália Franco",  "Jardim Ângela (ZL)",  "Jardim Aricanduva",  "Jardim Arize",  "Jardim Artur Alvim",  "Jardim Assunção",  "Jardim Avelino",  "Jardim Bandeirante (São Rafael)",  "Jardim Belém",
                  "Jardim Benfica",  "Jardim Brasília (ZL)",  "Jardim Caguassu",  "Jardim Camargo Novo",  "Jardim Casa Pintada",  "Jardim Castelo",  "Jardim Catarina",  "Jardim Cibele",  "Jardim Cinco de Julho",
                  "Jardim Coimbra",  "Jardim Colonial",  "Jardim Colorado",  "Jardim Cotching",  "Jardim Cotiana",  "Jardim Cotinha",  "Jardim da Conquista (ZL)",  "Jardim Danfer",  "Jardim das Camélias",
                  "Jardim das Carmelitas",  "Jardim das Figueiras (ZL)",  "Jardim das Oliveiras",  "Jardim das Rosas (Iguatemi)",  "Jardim das Rosas (Zona Leste I)",  "Jardim de Lorenzo",  "Jardim Dona Sinhá",
                  "Jardim dos Ipês",  "Jardim Egle",  "Jardim Elba (Zona Leste)",  "Jardim Eliane",  "Jardim Etelvina",  "Jardim Fanganiello",  "Jardim Fernandes",  "Jardim Gianetti",  "Jardim Gonzaga",
                  "Jardim Grimaldi",  "Jardim Guaianases",  "Jardim Guairaca",  "Jardim Helena",  "Jardim Helian",  "Jardim Hercilia",  "Jardim Ibitirama",  "Jardim Iguatemi",  "Jardim Imperador (ZL)",  "Jardim Indaiá",
                  "Jardim Independência",  "Jardim Ipanema (Cidade Líder)",  "Jardim Ipanema (São Miguel)",  "Jardim Irene",  "Jardim Itália",  "Jardim Itapema",  "Jardim Itapemirim",  "Jardim Itápolis",  "Jardim IV Centenário",
                  "Jardim Iva",  "Jardim Ivone",  "Jardim Jaú (ZL)",  "Jardim Lageado",  "Jardim Lajeado",  "Jardim Laone",  "Jardim Laura",  "Jardim Liderança",  "Jardim Limoeiro",  "Jardim Lisboa",
                  "Jardim Lourdes",  "Jardim Lucinda",  "Jardim Maia",  "Jardim Marabá",  "Jardim Marília",  "Jardim Marilu (ZL)",  "Jardim Maringá",  "Jardim Marpu",  "Jardim Matarazzo",  "Jardim Mimar",
                  "Jardim Miriam",  "Jardim Morganti",  "Jardim Nazareth",  "Jardim Nélia",  "Jardim Nice",  "Jardim Nordeste",  "Jardim Norma",  "Jardim Nossa Senhora do Carmo",  "Jardim Nove de Julho",
                  "Jardim Novo Carrão",  "Jardim Panorama (ZL)",  "Jardim Paraguaçu",  "Jardim Pedra Branca (ZL)",  "Jardim Pedro José Nunes",  "Jardim Penha",  "Jardim Pérola III",  "Jardim Piqueroby",
                  "Jardim Piratininga",  "Jardim Planalto",  "Jardim Ponte Rasa",  "Jardim Popular",  "Jardim Porteira Grande",  "Jardim Record",  "Jardim Redilv",  "Jardim Ricardo",  "Jardim Robru",  "Jardim Rodolfo Pirani",
                  "Jardim Romano",  "Jardim Roseli",  "Jardim Samara",  "Jardim Sandra Maria",  "Jardim Santa Adélia",  "Jardim Santa Maria",  "Jardim Santa Terezinha",  "Jardim Santa Terezinha (ZL)",  "Jardim Santa Terezinha I (ZL)",
                  "Jardim Santa Terezinha III(ZL)",  "Jardim Santo André",  "Jardim Santo Antônio",  "Jardim São Carlos (Zona Leste)",  "Jardim São Cristóvão",  "Jardim São Francisco (ZL)",  "Jardim São Gabriel",
                  "Jardim São José (Artur Alvim)",  "Jardim São José (São Mateus)",  "Jardim São Nicolau",  "Jardim São Paulo(ZL)",  "Jardim São Pedro",  "Jardim São Roberto",  "Jardim São Sebastião",  "Jardim São Vicente",
                  "Jardim Sapopemba",  "Jardim Sílvia (ZL)",  "Jardim Soares",  "Jardim Soraia",  "Jardim Tango",  "Jardim Teresa",  "Jardim Textil",  "Jardim Tietê",  "Jardim Três Marias",  "Jardim Triana",
                  "Jardim Tuã",  "Jardim Vera Cruz(ZL)",  "Jardim Verônia",  "Jardim Vila Carrão",  "Jardim Vila Formosa",  "Jardim Vitória",  "José Bonifacio",  "Lajeado",  "Largo São José do Maranhão",  "Limoeiro",
                  "Maranhão",  "Mooca",  "Núcleo Lageado",  "Parada XV de Novembro",  "Pari",  "Parque Artur Alvim",  "Parque Boa Esperança",  "Parque Boturussu",  "Parque Central (ZL)",  "Parque Císper",  "Parque Cruzeiro do Sul",
                  "Parque da Mooca",  "Parque da Vila Prudente",  "Parque das Flores",  "Parque das Paineiras",  "Parque do Carmo",  "Parque Dom João Neri",  "Parque dos Bancários",  "Parque Guaianases",
                  "Parque Guarani",  "Parque Industrial",  "Parque Maria Luiza",  "Parque Paineiras",  "Parque Paulistano",  "Parque Penha",  "Parque Pereira",  "Parque Residencial Oratório",  "Parque Santa Madalena",  "Parque Santa Rita",  "Parque Santo Eduardo",
                  "Parque São Jorge",  "Parque São Lourenço",  "Parque São Lucas",  "Parque São Rafael",  "Parque Savoy City",  "Parque Sevilha",  "Parque Tomas Saraiva",  "Penha",  "Ponte Rasa",  "Quarta Parada",  "Quinta da Paineira",  "Recanto Verde do Sol",  "São Lucas",
                  "São Mateusv",  "São Miguel Paulista",  "Sapopemba",  "Sítio da Figueira",  "Sítio Pinheirinho",  "Tatuapé",  "Vila Alpina",  "Vila Alzira",  "Vila Amália (ZL)",  "Vila Americana", "Vila Antonieta",
                  "Vila Antonina",  "Vila Aparecida",  "Vila Araguaia",  "Vila Aricanduva",  "Vila Aurea",  "Vila Azevedo",  "Vila Bancária",  "Vila Bauab",  "Vila Beatriz (ZL)",  "Vila Bela",  "Vila Bertioga",
                  "Vila Brasil",  "Vila Buenos Aires",  "Vila Caju",  "Vila Califórnia",  "Vila Campanela",  "Vila Canero",  "Vila Cardoso Franco",  "Vila Carlos de Campos",  "Vila Carmem",  "Vila Carmosina",  "Vila Carolina",  "Vila Carrão",  "Vila Celeste",  "Vila Centenário",  "Vila Chabilândia",  "Vila Charlote",  "Vila Chuca",  "Vila Cisper",
                  "Vila Cláudia",  "Vila Cleonice",  "Vila Conceição",  "Vila Constança (ZL)",  "Vila Cosmopolita",  "Vila Costa Melo",  "Vila Cunha Bueno",  "Vila Curuçá",  "Vila Dalila",  "Vila Danubio Azul",  "Vila Darli",  "Vila Diva (ZL)",  "Vila Divina Pastorav",
                  "Vila Domitila",  "Vila Doutor Eiras",  "Vila Ema",  "Vila Esperança",  "Vila Euthalia",  "Vila Fátima",  "Vila Feliz (ZL)",  "Vila Fernandes",  "Vila Formosa",  "Vila Franci",  "Vila Frugoli",  "Vila Germaine",
                  "Vila Giordano",  "Vila Gomes Cardim",  "Vila Graciosa",  "Vila Granada",  "Vila Guarani(ZL)",  "Vila Guilhermina",  "Vila Helena",  "Vila Hortência",  "Vila Industrial",  "Vila Invernada",  "Vila Iolanda(Lajeado)",
                  "Vila Itaim",  "Vila Ivg",  "Vila Ivone",  "Vila Jacuí",  "Vila Laís",  "Vila Lar Nacional",  "Vila Leme",  "Vila Libanesa",  "Vila Londrina", "Vila Lourdes (ZL)",  "Vila Lúcia",  "Vila Lúcia Elvira",  "Vila Macedópolis",  "Vila Mafra",  "Vila Mara",  "Vila Margarida",
                  "Vila Maria Zélia",  "Vila Marieta (ZL)",  "Vila Matias",  "Vila Matilde",  "Vila Mendes",  "Vila Mesquita",  "Vila Miami",  "Vila Monte Santo",  "Vila Moreira",  "Vila Nancy",  "Vila Nhocune",  "Vila Norma",  "Vila Nova",  "Vila Nova Curuçá",
                  "Vila Nova Manchester",  "Vila Nova Pauliceia",  "Vila Nova Savoia",  "Vila Nova Utinga", "Vila Nova York",  "Vila Odete",  "Vila Olinda",  "Vila Oratório",  "Vila Paranaguá",  "Vila Paulistania",
                  "Vila Paulo Silas",  "Vila Pedroso",  "Vila Pierina",  "Vila Ponte Rasa",  "Vila Popular",  "Vila Primavera (Zona Leste)",  "Vila Princesa Isabel",  "Vila Progresso (Zona Leste)",  "Vila Prudente",
                  "Vila Ré",  "Vila Regente Feijó",  "Vila Regina (Zona Leste)",  "Vila Reis",  "Vila Renato (Zona Leste)",  "Vila Rica (Zona Leste)",  "Vila Rio Branco",  "Vila Robertina",  "Vila Rosaria",  "Vila Rui Barbosa",  "Vila Salete",  "Vila Santa Clara",
                  "Vila Santa Cruz (Zona Leste)",  "Vila Santa Inês",  "Vila Santa Isabel",  "Vila Santa Teresa (Zona Leste)", "Vila Santa Teresinha",  "Vila Santa Virginia",  "Vila Santana",  "Vila Santo Estevão",  "Vila Santo Henrique",  "Vila São Francisco",  "Vila São Geraldo",
                  "Vila São Nicolau",  "Vila São Silvestre",  "Vila Sara",  "Vila Sílvia",  "Vila Siria",  "Vila Suiça",  "Vila Talarico",  "Vila Taquari",  "Vila Tolstoi",  "Vila União (ZL)",  "Vila Verde",
                  "Vila Vessoni",  "Vila Virginia (Zona Leste)",  "Vila Zelina",  "Vila Zilda (Zona Leste)"};

                cboBairro.DataSource = bairo;
            }

            if (cboCidade.Text == "São Paulo" && cboRegiao.Text == "Zona Oeste")
            {
                string[] bairro = {   "Aclimação",  "Água Branca",  "Alto da Lapa ",  "Alto de Pinheiros",  "Anhangabaú",  "Anhangüera",  "Barra Funda",  "Bela Aliança",  "Bela Vista",  "Boaçava",
                "Bom Retiro",  "Butantã ",  "Campos Elíseos",  "Caxingui",  "Centro de São Paulo",  "Cerqueira César",  "Chácara Inglesa (Zona Oeste)",
                "Chácara Itaim",  "Chácara Jaraguá",  "Chácara Maria Trindade",  "Chácara São João",  "Cidade D'Abril",  "Cidade dos Bandeirantes",  "Cidade São Francisco",  "City América",  "City Jaraguá",
                "City Lapa",  "City Pinheirinho",  "City Pirituba",  "City Recanto Anastácio",
                "Conj. City Jaraguá",  "Conj. Hab. Turística",  "Conj. Res. Butantã",  "Conj. Res. Elisio Teixeira Leite",  "Conj. Res. Jardim Canaã",  "Conj. Res. Novo Pacaembu",
                "Conj. Res. Vista Verde",  "Consolação",  "Ferreira",  "Glicério",  "Higienópolis",  "Instituto de Previdência",  "Jaguaré",  "Jaraguá (ZO)",  "Jardim Alvorada (Z.Oeste)",  "Jardim Amaralina",  "Jardim Arpoador",  "Jardim Bandeirantes (ZN)",
                "Jardim Belaura",  "Jardim Boa Vista (Zona Oeste)",  "Jardim Bonfiglioli",  "Jardim Britânia",  "Jardim Celeste (Zona Oeste)",  "Jardim Cidade Pirituba",  "Jardim Cláudia",  "Jardim Colombo",  
                "Jardim D'Abril",  "Jardim das Bandeiras",  "Jardim das Perdizes",  "Jardim das Vertentes",  "Jardim do Lago",  "Jardim Dracena",  "Jardim Esmeralda",  "Jardim Ester",  "Jardim Ester Yolanda",  "Jardim Everest", 
                "Jardim Felicidade (Zona Oeste)",  "Jardim Gilda Maria",  "Jardim Glória",  "Jardim Guarau",  "Jardim Guedala",  "Jardim Humaitá",  "Jardim Ipanema (Zona Oeste)",  "Jardim Íris",  "Jardim Ivana ", 
                "Jardim Jaqueline",  "Jardim Jaraguá",  "Jardim Jussara ",  "Jardim Líbano",  "Jardim Lider",  "Jardim Luísa ",  "Jardim Mangalot",  "Jardim Maria Luiza",  "Jardim Marilú",  "Jardim Marisa", 
                "Jardim Maristela",  "Jardim Monte Alegre",  "Jardim Monte Kemel",  "Jardim Morumbi",  "Jardim Mutinga",  "Jardim Olympia",  "Jardim Parque Morumbi",  "Jardim Paulista",
                "Jardim Paulistano",  "Jardim Paulo VI",  "Jardim Peri Peri",  "Jardim Pinheiros",  "Jardim Pirituba",  "Jardim Raposo Tavares",  "Jardim Regina",  "Jardim Rincão ",  "Jardim Rio Pequeno",  "Jardim Rizzo", 
                "Jardim Rosa Maria ",  "Jardim Russo",  "Jardim Santa Fé (Zona Oeste)",  "Jardim Santa Mônica",  "Jardim Santo Elias",  "Jardim Santos Dumont",  "Jardim São João",  "Jardim São Jorge",  "Jardim São José",
                "Jardim São Ricardo", "Jardim Sarah",  "Jardim Sydney",  "Jardim Taipas ",  "Jardim Trussardi ",  "Jardim Valparaiso",  "Jardim Vazani",  "Jardim Vista Linda",  "Jardim Vivan ",  "Jardins ",
                "Lapa",  "Lapa de Baixo",  "Liberdade ",  "Loteamento City Jaragua ",  "Luz",  "Morro Doce ",  "Morro dos Ingleses ",  "Pacaembu",  "Parada de Taipas ",  "Paraíso do Morumbi",  "Paraisópolis",  "Parque Anhangüera  ",
                "Parque Continental",  "Parque do Morumbi",  "Parque Dom Pedro",  "Parque dos Príncipes",  "Parque Industrial Tomas Edson",  "Parque Ipê ",  "Parque Maria Domitila ",  "Parque Nações Unidas",  "Parque Panamericano ",  "Parque Reboucas",
                "Parque Residencial da Lapa",  "Parque São Domingos",  "Parque Taipas",  "Perdizes",  "Perus",  "Pinheiros ",  "Piqueri",  "Pirituba",  "Pompéia",  "Portal dos Bandeirantes (Pirituba)",  "Raposo Tavares",
                "República",  "Residencial Morumbi",  "Retiro Morumbi",  "Rio Pequeno",  "Santa Cecília ",  "Santa Efigênia",  "São Bento ",  "São Domingos ",  "Sé ",  "Siciliano ",  "Sítio Morro Grande",  "Sumaré ",  "Sumarezinho",  "Várzea da Barra Funda",  
                "Vila Adalgisa",  "Vila Anastácio",  "Vila Anglo Brasileira",  "Vila Antônio",  "Vila Arcádia",  "Vila Augusto (ZO)",  "Vila Barreto",  "Vila Boaçava",  "Vila Bonilha",  "Vila Buarque",
                "Vila Butantã",  "Vila Chica Luisa ",  "Vila Clarice ",  "Vila Comercial",  "Vila Cruz das Almas ",  "Vila Dalva ",  "Vila dos Remédios",  "Vila Fiat Lux (ZO)",  "Vila Gomes",  "Vila Guedes",  "Vila Hamburguesa ",  "Vila Ida",
                "Vila Inah",  "Vila Indiana",  "Vila Ipojuca",  "Vila Jaguara",  "Vila Jaguari",  "Vila Jaraguá",  "Vila Lageado",  "Vila Leopoldina",  "Vila Madalena ",  "Vila Mangalot",  "Vila Marina",  "Vila Mirante",  "Vila Miriam",  "Vila Morse",  
                "Vila Nossa Senhora do Retiro",  "Vila Nova Alba",  "Vila Nova Jaraguá",  "Vila Nova Parada",  "Vila Pereira Barreto",  "Vila Perus",  "Vila Piauí",  "Vila Picinin",  "Vila Pirajussara",  "Vila Pirituba",  "Vila Polopoli",  "Vila Portugal",
                "Vila Progredior","Vila Ramos ",  "Vila Renato",  "Vila Ribeiro de Barros ",  "Vila Romana",  "Vila Santa Edwiges",  "Vila São Domingos",  "Vila São Francisco (ZO)",  "Vila São Luís(Zona Oeste)",  "Vila São Silvestre",  "Vila São Vicente",  "Vila Sônia",  "Vila Tiradentes",  "Vila Tramontano",
                "Vila Yara",  "Vila Zat",  "Vista Verde"};

                cboBairro.DataSource = bairro;
            }

            if (cboCidade.Text == "São Paulo" && cboRegiao.Text == "Zona Sul")
            {
                string[] bairro = {  "Aclimação",  "Água Funda",  "Alto da Boa Vista",  "Alto do Ipiranga",  "Americanópolis",  "Berrini",  "Bosque da Saúde",  "Brooklin",  "Brooklin Novo",
                "Brooklin Paulista",  "Cambuci",  "Cambuci (Zona Sul)",  "Campininha",  "Campo Belo",  "Campo Belo (Zona Sul)",  "Campo Grande",  "Campo Limpo (Zona Sul)",  "Cantinho do Céu",  "Capão Redondo", 
                "Capela do Socorro",  "Chácara Flora",  "Chácara Inglesa",  "Chácara Japonesa",  "Chácara Klabin",  "Chácara Meyer",  "Chácara Monte Alegre",  "Chácara Santa Maria",  "Chácara Santana",  "Chácara Santo Antônio (ZS)",
                "Cidade Ademar",   "Cidade Domitila", "Cidade Dutra",  "Cidade Jardim",  "Cidade Monções",  "Cidade Nova Heliópolis",  "Cidade Vargas",  "Conceição",  "Conj. Hab. Brg. Faria Lima",  "Conjunto Residencial Jardim Canaã",  "Cupecê",  "Cursino",
                "Eldorado",  "Fazenda Morumbi",  "Grajaú",  "Granja Julieta",  "Guarapiranga",  "Horto do Ipê",  "Ibirapuera",  "Indianópolis",  "Interlagos",  "Ipiranga",  "Itaim",  "Itaim Bibi",  "Jabaquara",
                "Jardim Aeroporto",  "Jardim Alvorada (Zona Sul)",  "Jardim América",  "Jardim Ampliação",  "Jardim Ângela (Zona Sul)",  "Jardim Anhanguera",  "Jardim Bela Vista (Zona Sul)",  "Jardim Bélgica",  "Jardim Bom Refúgio",  "Jardim Botânico",  "Jardim Botucatu",  "Jardim Brasil (Zona Sul)",
                "Jardim Caboré",  "Jardim Campinas",  "Jardim Campo Grande",  "Jardim Caravelas",  "Jardim Casa Grande",  "Jardim Celeste (Zona Sul)",  "Jardim Cidália",  "Jardim Clímax",  "Jardim Cliper",  "Jardim Consórcio",
                "Jardim Cordeiro",  "Jardim Cruzeiro",  "Jardim Cupecê",  "Jardim da Campina",  "Jardim da Glória",  "Jardim da Pedreira",  "Jardim da Saúde",  "Jardim das Acácias",  "Jardim das Camélias (Zona Sul)",  "Jardim das Flores",  "Jardim das Imbuias",
                "Jardim das Rosas (Zona Sul)",  "Jardim do Golf",  "Jardim Dom Bosco",  "Jardim Dom José",  "Jardim dos Estados",  "Jardim dos Lagos",  "Jardim Europa",  "Jardim Fonte do Morumbi",
                "Jardim Helga",  "Jardim Hípico",  "Jardim Iracema (Zona Sul)",  "Jardim Itacolomi",  "Jardim Jabaquara",  "Jardim Kioto",  "Jardim Lar São Paulo",  "Jardim Leonor",  "Jardim Londrina",  "Jardim Lourdes (Zona Sul)",  "Jardim Luanda",
                "Jardim Luzitânia",  "Jardim Macedônia",  "Jardim Marabá(Zona Sul)",  "Jardim Marajoara",  "Jardim Maria Duarte",  "Jardim Maria Estela (Zona Sul)",  "Jardim Marquesa",  "Jardim Mirante",  "Jardim Miriam",  "Jardim Mitsutani",
                "Jardim Monte Azul",  "Jardim Nossa Senhora Aparecida",  "Jardim Nosso Lar",  "Jardim Novo Santo Amaro",  "Jardim Novo Taboão",  "Jardim Oriental - Parelheiros",  "Jardim Panorama",  "Jardim Patente",  "Jardim Patente Novo",  "Jardim Petrópolis",  "Jardim Piracuama",  "Jardim Pirajussara",
                "Jardim Previdência",  "Jardim Promissão",  "Jardim Prudência",  "Jardim Represa",  "Jardim Riviera",  "Jardim Sabará",  "Jardim Sandra",  "Jardim Santa Bárbara",  "Jardim Santa Cruz (Sacomã)",  "Jardim Santa Efigênia",  "Jardim Santa Emília",
                "Jardim Santa Helena",  "Jardim Santa Terezinha (Pedreira)",  "Jardim Santo Amaro",  "Jardim Santo Antoninho",  "Jardim São Bernardo",  "Jardim São Luís",  "Jardim São Savério",  "Jardim Satélite",  "Jardim Sipramar",  "Jardim Sônia (Zona Sul)",
                "Jardim Sul",  "Jardim Taboão",  "Jardim Taquaral",  "Jardim Tenani",  "Jardim Ubirajara (Zona Sul)",  "Jardim Umarizal",  "Jardim Umuarama",  "Jardim Vaz de Lima",  "Jardim Vera Cruz(Zona Sul)",  "Jardim Vergueiro (Sacomã)",  "Jardim Vila Mariana",  "Jordanópolis",
                "Jurubatuba",  "Mirandópolis",  "Moema",  "Morumbi",  "Nova Piraju",  "Paineiras do Morumbi",  "Panamby",  "Paraíso",  "Paraíso (Zona Sul)",  "Paraíso do Morumbi",  "Paraisópolis (Zona Sul)",  "Parelheiros",
                "Parque Alves de Lima",  "Parque Bairro Morumbi",  "Parque Bristol",  "Parque Colonial",  "Parque das Árvores",  "Parque Esmeralda",  "Parque Fernanda",  "Parque Fongaro",  "Parque Ibirapuera",  "Parque Imperial",
                "Parque Jabaquara",  "Parque Maria Helena",  "Parque Munhoz",  "Parque Novo Santo Amaro",  "Parque Rebouças",  "Parque Santa Cecília",  "Pedreira",  "Pirajussara",  "Planalto Paulista",  "Praça da Arvore",  "Real Parque",  "Rio Bonito",  "Riviera Paulista",  "Sacomã",  "Santa Cruz",
                "Santo Amaro",  "São João Clímaco",  "São Judas",  "Saúde",  "Sete Praias",  "Socorro",  "Super Quadra Morumbi",  "Usina Piratininga",  "Várzea de Baixo",  "Veleiros",  "Vila Água Funda",  "Vila Alexandria",  "Vila Almeida",  "Vila Andrade",  "Vila Anhangüera",  "Vila Arapuã",
                "Vila Arriete",  "Vila Babilônia",  "Vila Bela Vista (Zona Sul)",  "Vila Brasilina",  "Vila Brasílio Machado",  "Vila Campestre",  "Vila Campo Grande",  "Vila Caraguatá",  "Vila Carioca",  "Vila Castelo",  "Vila Clara",  "Vila Clementino",
                "Vila Congonhas",  "Vila Cordeiro",  "Vila Cruzeiro",  "Vila da Paz",  "Vila da Saúde",  "Vila das Belezas",  "Vila das Mercês",  "Vila Deodoro",  "Vila do Bosque",  "Vila do Castelo",
                "Vila do Encontro",  "Vila Dom Pedro I",  "Vila Elvira",  "Vila Emir",  "Vila Erna",  "Vila Ernesto",  "Vila Fachini",  "Vila Firmiano Pinto",  "Vila Gertrudes",  "Vila Guarani(Zona Sul)",  "Vila Gumercindo",  "Vila Império",  "Vila Independência",
                "Vila Inglesa",  "Vila Isa",  "Vila Joaniza",  "Vila Liviero",  "Vila Marari",  "Vila Mariana",  "Vila Martev",  "Vila Mascote",  "Vila Mira",  "Vila Missionária", "Vila Moinho Velho",  "Vila Monte Alegre",  "Vila Monumento",
                "Vila Moraes",  "Vila Morumbi",  "Vila Nair",  "Vila Natália",  "Vila Nova Conceição",  "Vila Nova das Belezas",  "Vila Olímpia",  "Vila Olímpia (Zona Sul)",  "Vila Parque Jabaquara",
                "Vila Paulista",  "Vila Praia",  "Vila Prel",  "Vila Progredior (Zona Sul)",  "Vila Progresso (Zona Sul)",  "Vila Santa Catarina",  "Vila Santa Eulalia",  "Vila Santa Lúcia",  "Vila Santa Teresa (Zona Sul)",
                "Vila Santo Estéfano",  "Vila São José",  "Vila São José (Cidade Dutra)",  "Vila São José (Ipiranga)",  "Vila São Paulo",  "Vila São Pedro",  "Vila Socorro",  "Vila Sofia",  "Vila Sônia (Zona Sul)",  "Vila Suzana",  "Vila Uberabinha",  "Vila Vera",  "Vila Vermelha"};

                cboBairro.DataSource = bairro;
            }
        }

        private void gridAnuncio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex == 27)
            {
                BoAnuncio boAnuncio = new BoAnuncio();
                string CodAnuncio = gridAnuncio.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString();
                var table = boAnuncio.ObterAnuncio(CodAnuncio);
                if (RBAlterar.Checked == true)
                {
                    HabilitarCampos(true);
                    BtnUploadImage.Enabled = true;
                    BtnUploadImage.Visible = true;
                }

                txtId.Text = table[0].Codigo;
                cboNeg.Text = table[0].Negocio;
                cboRegiao.Text = table[0].Regiao;
                cboTipoImov.Text = table[0].TipoImovel;
                txtPreco.Text = table[0].Valor.ToString();
                txtIPTU.Text = table[0].VlrIptu.ToString();
                txtDorm.Text = table[0].Dormitorio.ToString();
                txtSuites.Text = table[0].Suites.ToString();

                txtVagas.Text = table[0].Vagas.ToString();
                txtArea.Text = table[0].Area.ToString();
                cboCidade.Text = table[0].Cidade;
                cboBairro.Text = table[0].Bairro;
                txtEndereco.Text = table[0].Endereco;
                cboSituacao.Text = UtilHelpers.TipoSituacao.Ativo == table[0].Ativo ? "Ativo" : "Inativo";

                txtNomeProp.Text = table[0].Proprietario;
                txtObs.Text = table[0].Obs;

                ckPermuta.Checked = table[0].Permuta;
                ckChurrasqueira.Checked = table[0].Churrasqueira;
                chPiscina.Checked = table[0].Piscina;
                ckBrinquedoteca.Checked = table[0].Brinquedoteca;
                ckPlayground.Checked = table[0].Playgroud;
                ckPoliesportiva.Checked = table[0].Poliesportiva;
                ckGinástica.Checked = table[0].Ginastica;
                ckFestas.Checked = table[0].Festas;
                ckJogos.Checked = table[0].Jogos;


            }

            if (e.ColumnIndex == 1 || e.ColumnIndex == 28)
            {
                BoAnuncio boAnuncio = new BoAnuncio();
                string CodAnuncio = gridAnuncio.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString();
                boAnuncio.DeleteAnuncio(CodAnuncio);
                MessageBox.Show($"Anuncio {CodAnuncio} removido com sucesso", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridAnuncio.DataSource = boAnuncio.ConsultaAnuncio();
                InciarAmbiente();
            }
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            BoAnuncio boAnuncio = new BoAnuncio();
            try
            {
                Anuncio anuncio = ConverterFormToDML();
                if (Alteracao == true)
                {
                    boAnuncio.AtualizarAnuncio(anuncio);
                    MessageBox.Show("Registro alterado com sucesso", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridAnuncio.DataSource = boAnuncio.ConsultaAnuncio();
                    InciarAmbiente();
                }
                else
                {
                    boAnuncio.IncluirAnuncio(anuncio);
                    MessageBox.Show("Cadastro realizado com sucesso", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HabilitarCampos(false);

                    BtnUploadImage.Enabled = true;
                    buttonGravar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                lblMsgErro.Text = string.Empty;
                lblMsgErro.Visible = true;
                lblMsgErro.Text = ex.Message;
            }
        }

        private void RbRegiao_CheckedChanged(object sender, EventArgs e)
        {
            TxtPesquisa.Visible = false;
            cboRegiaoPesq.Visible = true;
            string[] regiao = { "Selecionar", "Zona Norte", "Zona Leste", "Zona Oeste", "Zona Sul", "Grande ABC", "Litoral" };
            cboRegiaoPesq.DataSource = regiao;
        }

        private void BtnUploadImage_Click(object sender, EventArgs e)
        {
            Forms.UploadImageForm Form = null;
            if (Alteracao)
                Form = new UploadImageForm(txtId.Text, true, null);
            else
                Form = new UploadImageForm(txtId.Text, false, this);

            Form.ShowDialog();
        }

        #endregion

        #region Metodos

        /// <summary>
        /// 
        /// </summary>
        private void MontarGrid()
        {
            if (!RadioCriar.Checked == true)
            {
                DataGridViewButtonColumn BtnEdit = new DataGridViewButtonColumn();
                BtnEdit.Name = "BtnEdit";
                BtnEdit.Width = 30;
                BtnEdit.UseColumnTextForButtonValue = true;
                BtnEdit.HeaderText = "Alt.";


                DataGridViewButtonColumn BtnPrint = new DataGridViewButtonColumn();
                BtnEdit.Name = "BtnExcluir";
                BtnEdit.Width = 30;
                BtnEdit.UseColumnTextForButtonValue = true;


                if (!gridAnuncio.Columns.Contains(BtnEdit.Name = "BtnEdit"))
                {
                    gridAnuncio.Columns.Add(BtnEdit);
                }

                if (!gridAnuncio.Columns.Contains(BtnPrint.Name = "BtnExcluir"))
                {
                    gridAnuncio.Columns.Add(BtnPrint);
                }

                gridAnuncio.Columns["Codigo"].HeaderText = "Cod.";
                gridAnuncio.Columns["Codigo"].Width = 40;
                gridAnuncio.Columns["Codigo"].DisplayIndex = 0;

                gridAnuncio.Columns["Proprietario"].HeaderText = "Proprietario";
                gridAnuncio.Columns["Proprietario"].Width = 146;
                gridAnuncio.Columns["Proprietario"].DisplayIndex = 1;

                gridAnuncio.Columns["Negocio"].HeaderText = "Neg.";
                gridAnuncio.Columns["Negocio"].Width = 48;
                gridAnuncio.Columns["Negocio"].DisplayIndex = 2;

                gridAnuncio.Columns["Bairro"].HeaderText = "Bairro";
                gridAnuncio.Columns["Bairro"].Width = 120;
                gridAnuncio.Columns["Bairro"].DisplayIndex = 3;

                gridAnuncio.Columns["Cidade"].HeaderText = "Cidade";
                gridAnuncio.Columns["Cidade"].Width = 80;
                gridAnuncio.Columns["Cidade"].DisplayIndex = 4;

                gridAnuncio.Columns["Regiao"].HeaderText = "Regiao";
                gridAnuncio.Columns["Regiao"].Width = 80;
                gridAnuncio.Columns["Regiao"].DisplayIndex = 5;

                gridAnuncio.Columns["TipoImovel"].HeaderText = "Tipo Imovel";
                gridAnuncio.Columns["TipoImovel"].Width = 90;
                gridAnuncio.Columns["TipoImovel"].DisplayIndex = 6;

                gridAnuncio.Columns["DataAtualizacao"].HeaderText = "Data de Atualização";
                gridAnuncio.Columns["DataAtualizacao"].Width = 70;
                gridAnuncio.Columns["DataAtualizacao"].DisplayIndex = 7;

                gridAnuncio.Columns["Valor"].HeaderText = "Valor";
                gridAnuncio.Columns["Valor"].Width = 80;
                gridAnuncio.Columns["Valor"].DisplayIndex = 8;

                gridAnuncio.Columns["Ativo"].HeaderText = "Ativo";
                gridAnuncio.Columns["Ativo"].Width = 50;
                gridAnuncio.Columns["Ativo"].DisplayIndex = 9;

                gridAnuncio.Columns["BtnEdit"].DisplayIndex = 10;
                gridAnuncio.Columns["BtnExcluir"].DisplayIndex = 11;
                gridAnuncio.Columns["BtnExcluir"].Width = 30;
                gridAnuncio.Columns["BtnExcluir"].HeaderText = "Del.";

                gridAnuncio.Columns["Endereco"].Visible = false;
                gridAnuncio.Columns["VlrIptu"].Visible = false;
                gridAnuncio.Columns["Dormitorio"].Visible = false;
                gridAnuncio.Columns["Suites"].Visible = false;
                gridAnuncio.Columns["Vagas"].Visible = false;
                gridAnuncio.Columns["Area"].Visible = false;
                gridAnuncio.Columns["Obs"].Visible = false;
                gridAnuncio.Columns["DataCadastro"].Visible = false;
                gridAnuncio.Columns["Permuta"].Visible = false;
                gridAnuncio.Columns["Churrasqueira"].Visible = false;
                gridAnuncio.Columns["Piscina"].Visible = false;
                gridAnuncio.Columns["Brinquedoteca"].Visible = false;
                gridAnuncio.Columns["Playgroud"].Visible = false;
                gridAnuncio.Columns["Poliesportiva"].Visible = false;
                gridAnuncio.Columns["Ginastica"].Visible = false;
                gridAnuncio.Columns["Festas"].Visible = false;
                gridAnuncio.Columns["Jogos"].Visible = false;

                gridAnuncio.ColumnHeadersVisible = true;
            }
            else
                gridAnuncio.ColumnHeadersVisible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        private void InciarAmbiente()
        {
            LimparCampos();
            this.Refresh();
            RadioCriar.Checked = false;
            MontarGrid();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pHabilitar"></param>
        private void HabilitarCampos(bool pHabilitar)
        {
            cboNeg.Enabled = pHabilitar;
            cboRegiao.Enabled = pHabilitar;
            cboTipoImov.Enabled = pHabilitar;
            txtId.Enabled = false;
            txtPreco.Enabled = pHabilitar;
            txtIPTU.Enabled = pHabilitar;
            txtDorm.Enabled = pHabilitar;
            txtSuites.Enabled = pHabilitar;

            txtVagas.Enabled = pHabilitar;
            txtArea.Enabled = pHabilitar;
            cboCidade.Enabled = pHabilitar;
            cboBairro.Enabled = pHabilitar;

            txtNomeProp.Enabled = pHabilitar;
            txtEndereco.Enabled = pHabilitar;
            txtObs.Enabled = pHabilitar;
            cboSituacao.Enabled = pHabilitar;

            ckPermuta.Enabled = pHabilitar;
            ckChurrasqueira.Enabled = pHabilitar;
            chPiscina.Enabled = pHabilitar;
            ckBrinquedoteca.Enabled = pHabilitar;
            ckPlayground.Enabled = pHabilitar;
            ckPoliesportiva.Enabled = pHabilitar;
            ckGinástica.Enabled = pHabilitar;
            ckFestas.Enabled = pHabilitar;
            ckJogos.Enabled = pHabilitar;

            TxtPesquisa.Enabled = false;
            RbNomeProp.Enabled = false;
            RbCodigo.Enabled = false;
            RbRegiao.Enabled = false;
            BtnPesquisa.Enabled = false;
            cboRegiaoPesq.Visible = false;

            buttonGravar.Visible = pHabilitar;
            buttonGravar.Enabled = pHabilitar;
            BtnUploadImage.Enabled = false;
            BtnUploadImage.Visible = false;

            if (RbConsultar.Checked == true || RBAlterar.Checked == true)
            {
                TxtPesquisa.Enabled = true;
                RbNomeProp.Enabled = true;
                RbCodigo.Enabled = true;
                RbRegiao.Enabled = true;
                BtnPesquisa.Enabled = true;
            }

            if (RadioCriar.Checked == true)
            {
                buttonGravar.Visible = true;
                buttonGravar.Enabled = true;
                BtnUploadImage.Visible = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void LimparCampos()
        {
            cboNeg.Text = string.Empty;
            cboRegiao.Text = string.Empty;
            cboTipoImov.Text = string.Empty;
            txtId.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtIPTU.Text = string.Empty;
            txtDorm.Text = string.Empty;
            txtSuites.Text = string.Empty;

            txtVagas.Text = string.Empty;
            txtArea.Text = string.Empty;
            cboCidade.Text = string.Empty;
            cboBairro.Text = string.Empty;

            txtNomeProp.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtObs.Text = string.Empty;

            ckPermuta.Checked = false;
            ckChurrasqueira.Checked = false;
            chPiscina.Checked = false;
            ckBrinquedoteca.Checked = false;
            ckPlayground.Checked = false;
            ckPoliesportiva.Checked = false;
            ckGinástica.Checked = false;
            ckFestas.Checked = false;
            ckJogos.Checked = false;
            lblMsgErro.Text = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Anuncio ConverterFormToDML()
        {
            var dmlAnuncio = new Anuncio();
            if (!string.IsNullOrEmpty(txtId.Text))
                dmlAnuncio.Codigo = Convert.ToString(txtId.Text);
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblCodigo.Text);

            if (!string.IsNullOrEmpty(cboNeg.Text))
                dmlAnuncio.Negocio = cboNeg.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblNeg.Text);

            if (!string.IsNullOrEmpty(cboRegiao.Text))
                dmlAnuncio.Regiao = cboRegiao.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblReg.Text);

            if (!string.IsNullOrEmpty(cboTipoImov.Text))
                dmlAnuncio.TipoImovel = cboTipoImov.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblTipoImovel.Text);

            if (!string.IsNullOrEmpty(txtPreco.Text))
                dmlAnuncio.Valor = Convert.ToDouble(txtPreco.Text.Replace("R$", "").Trim());
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblPreco.Text);

            if (!string.IsNullOrEmpty(txtIPTU.Text))
                dmlAnuncio.VlrIptu = Convert.ToDouble(txtIPTU.Text.Replace("R$", "").Trim());
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblIptu.Text);

            if (!string.IsNullOrEmpty(txtDorm.Text))
                dmlAnuncio.Dormitorio = Convert.ToInt32(txtDorm.Text);
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblDorm.Text);

            if (!string.IsNullOrEmpty(txtSuites.Text))
                dmlAnuncio.Suites = Convert.ToInt32(txtSuites.Text);
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblsuites.Text);

            if (!string.IsNullOrEmpty(txtVagas.Text))
                dmlAnuncio.Vagas = Convert.ToInt32(txtVagas.Text);
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblVagas.Text);

            if (!string.IsNullOrEmpty(txtArea.Text))
                dmlAnuncio.Area = Convert.ToInt32(txtArea.Text);
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblArea.Text);

            if (!string.IsNullOrEmpty(cboCidade.Text))
                dmlAnuncio.Cidade = cboCidade.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblCidade.Text);

            if (!string.IsNullOrEmpty(cboBairro.Text))
                dmlAnuncio.Bairro = cboBairro.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblBairro.Text);

            if (!string.IsNullOrEmpty(txtNomeProp.Text))
                dmlAnuncio.Proprietario = txtNomeProp.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblNomeProp.Text);

            if (!string.IsNullOrEmpty(txtEndereco.Text))
                dmlAnuncio.Endereco = txtEndereco.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblEndereco.Text);

            if (!string.IsNullOrEmpty(txtObs.Text))
                dmlAnuncio.Obs = txtObs.Text;
            else
                BoErro.DesErro(BoErro.CERRO_CAMPOOBRIGATORIO, lblObs.Text);


            if (cboSituacao.Text == "Ativo")
                cboSituacao.Text = "A";
            else
                cboSituacao.Text = "I";

            dmlAnuncio.Ativo = UtilHelpers.ConverterTipoSituacao(cboSituacao.Text);
            dmlAnuncio.DataCadastro = DateTime.Now.Date;

            // checkbox
            dmlAnuncio.Permuta = ckPermuta.Checked;
            dmlAnuncio.Churrasqueira = ckChurrasqueira.Checked;
            dmlAnuncio.Piscina = chPiscina.Checked;
            dmlAnuncio.Brinquedoteca = ckBrinquedoteca.Checked;
            dmlAnuncio.Playgroud = ckPlayground.Checked;
            dmlAnuncio.Poliesportiva = ckPoliesportiva.Checked;
            dmlAnuncio.Ginastica = ckGinástica.Checked;
            dmlAnuncio.Festas = ckFestas.Checked;
            dmlAnuncio.Jogos = ckJogos.Checked;

            return dmlAnuncio;
        }

        /// <summary>
        /// 
        /// </summary>
        private void PreencherCombos()
        {
            string[] regiao = { "Selecionar", "Zona Norte", "Zona Leste", "Zona Oeste", "Zona Sul", "Grande ABC", "Litoral" };
            cboRegiao.DataSource = regiao;

            string[] negocio = { "Selecionar", "Venda", "Alugar" };
            cboNeg.DataSource = negocio;

            string[] tipoImovel = { "Selecionar", "Apartamento", "Sobrado", "Casa Térrea", "Condomínio Fechado", "Apartamento Duplex", "Cobertura", "Flat / Studio", "Kitnet / Loft", "Imóvel para Renda", "Chácara / Sítio", "Terreno", "Prédio", "Casa Comercial", "Sala Comercial", "Galpão / Salão", "Ponto Comercial", "Prédio Comercial", "Loja de Shopping", "Quiosque", "Pousada / Chalé" };
            cboTipoImov.DataSource = tipoImovel;


            cboSituacao.DataSource = Enum.GetValues(typeof(UtilHelpers.TipoSituacao));
        }

        public void FinalizarAnuncio()
        {
            RadioCriar.Checked = false;
            HabilitarCampos(false);
            LimparCampos();
            MessageBox.Show($"Anuncio {txtId.Text} cadastrado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AplicarEventos(TextBox txt)
        {
            txt.Enter += UtilHelpers.TirarMascara;
            txt.Leave += UtilHelpers.RetornarMascaraMoeda;
            txt.KeyPress += UtilHelpers.ApenasValorNumerico;
        }

        #endregion

    }
}
