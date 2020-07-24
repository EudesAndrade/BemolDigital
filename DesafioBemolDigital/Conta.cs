using System;
using System.Net;
using System.Windows.Forms;
using System.IO;
using RestSharp;
using CEP.DTO;
using RestSharp.Serialization.Json;

namespace DesafioBemolDigital
{
    public partial class CriarConta : Form
    {
        public CriarConta()
        {
            InitializeComponent();
        }

        private void btCONSULTAR_Click(object sender, EventArgs e)
        {
            if (txtNOME.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo NOME!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.txtNOME.Focus();

                return;
            }

            if (!this.mskCEP.MaskFull)
            {
                MessageBox.Show("Preencha corretamente o campo Cep!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.mskCEP.Focus();

                return;
            }

            if (mskCEP.TextLength == 9)
            {
                try
                {
                    RestClient resCli = new RestClient(string.Format(URL.ConsultaCep, mskCEP.Text));

                    RestRequest resRiquest = new RestRequest(Method.GET);

                    IRestResponse restResponse = resCli.Execute(resRiquest);

                   if (restResponse.StatusCode == System.Net.HttpStatusCode.BadRequest )
                        MessageBox.Show(" Erro ao consultar Cep!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    else
                    {
                        Endereco Retornos = new JsonDeserializer().Deserialize<Endereco>(restResponse);

                        if (Retornos.cep == null)
                        {
                            MessageBox.Show("Cep não encontrado!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            return;
                        }
                           
                        mskCEP.Text = Retornos.cep;
                        txtLOGRADOURO.Text = Retornos.logradouro.Trim();
                        txtBAIRRO.Text = Retornos.bairro.Trim();
                        txtCIDADE.Text = Retornos.localidade.Trim();
                        txtUF.Text = Retornos.uf.Trim();
                        txtIBGE.Text = Retornos.ibge;
                    }

                }
                catch (WebException ex)
                {
                    string exception = ex.Message + (ex.InnerException != null ? "\n\n" + ex.InnerException : "");
                }
            }
        }

        private void btLipCampos_Click(object sender, EventArgs e)
        {
            txtNOME.Text = string.Empty;
            mskCEP.Text = string.Empty;
            txtLOGRADOURO.Text = string.Empty;
            txtBAIRRO.Text = string.Empty;
            txtCIDADE.Text = string.Empty;
            txtUF.Text = string.Empty;
            txtIBGE.Text = string.Empty;

            txtNOME.Focus();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da aplicação?", "Fechar aplicação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_ClienteDataSet);
        }

        private void CriarConta_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_ClienteDataSet.Table'. Você pode movê-la ou removê-la conforme necessário.
            this.tableTableAdapter.Fill(this.bD_ClienteDataSet.Table);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            txtNOME.Focus();
        }
    }
}
