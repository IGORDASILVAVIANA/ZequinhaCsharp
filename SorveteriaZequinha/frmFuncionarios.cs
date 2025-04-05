using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorveteriaZequinha
{
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
            //executando o método desabilitar campos;
            desabilitarCampos();


        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarFuncionarios abrir = new frmPesquisarFuncionarios();
            abrir.Show();
            this.Hide();
        }

        //desabilitandoos componentes

        public void desabilitarCampos() {
        
            txtNome.Enabled = false;
            txtCidade.Enabled = false;
            txtComplemento.Enabled = false;
            txtEmail.Enabled = false;
            txtNumero.Enabled = false; 
            txtLogradouro.Enabled = false;

            mskCEP.Enabled = false; 
            mskCPF.Enabled = false; 
            mskTelefone.Enabled = false; 
            
            cbbEstado.Enabled = false;  
            cbbFuncao.Enabled = false;  
            cbbUF.Enabled = false;

            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnLimpar.Enabled = false;
            btnExcluir.Enabled = false;

            dtpDataNascimento.Enabled = false;  
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            
        }

        //desabilitandoos componentes

        public void habilitarCampos()
        {
            txtCidade.Enabled = true;
            txtComplemento.Enabled = true;
            txtEmail.Enabled = true;
            txtNumero.Enabled = true;
            txtLogradouro.Enabled = true;
            txtNome.Enabled = true;
         

            mskCEP.Enabled = true;
            mskCPF.Enabled = true;
            mskTelefone.Enabled = true;

            cbbEstado.Enabled = true;
            cbbFuncao.Enabled = true;
            cbbUF.Enabled = true;

            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = true;
            btnLimpar.Enabled = true;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;

            dtpDataNascimento.Enabled = true;

            txtNome.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || (txtEmail.Text.Equals("")) || (mskCPF.Text.Equals("   .   .   -")
                || (cbbFuncao.Text.Equals("")) || (mskTelefone.Text.Equals("     -")
                || mskCEP.Text.Equals("     -") || (txtNumero.Text.Equals("")) || (txtLogradouro.Text.Equals(""))
                || (cbbEstado.Text.Equals("")) || (cbbUF.Text.Equals("")
                || (txtComplemento.Text.Equals("")) || (txtCidade.Text.Equals("")) ))))
            {
                MessageBox.Show("Favor inserir valores");

            } else
            {
                MessageBox.Show("Cadastro realizador com sucesso");
                desabilitarCampos();
            }

        }

        private void dtpDataNascimento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
