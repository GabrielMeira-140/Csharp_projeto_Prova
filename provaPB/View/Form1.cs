using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace provaPB
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        //Chamando List<T>
        List<LerDados> ListaPiloto = new List<LerDados>();

        public Form1()
        {
            InitializeComponent();

            txt_Numero.MaxLength = 3;
            txt_LarguraCarro.MaxLength = 4;
            pnlExcluireEditar.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlExcluireEditar.Visible = true;

            //pegando os dados forms/LerDados
            LerDados Dados = new LerDados(
                txt_Nome.Text,
                txt_Escuderia.Text,
                Convert.ToInt32(txt_Numero.Text),
                float.Parse(txt_LarguraCarro.Text),
                maskedTB_Volta.Text,
                maskedTB_Prova.Text
            );

            //adicionando dados na lista
            ListaPiloto.Add(Dados);

            //mostrando dados no DataGridView
            dataVGDados.DataSource = null;
            dataVGDados.DataSource = ListaPiloto;
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Deseja Excluir? ", "Excluir dado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (msg == System.Windows.Forms.DialogResult.Yes)
            {
                //exclui dados do list<T>
                Excluir(txtExcluir.Text);

                //mostrando dados no DataGridView
                dataVGDados.DataSource = null;
                dataVGDados.DataSource = ListaPiloto;
            }
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            //adiciona dados do list<T>
            Alterar(txtExcluir.Text);

            //mostrando dados no DataGridView
            dataVGDados.DataSource = null;
            dataVGDados.DataSource = ListaPiloto;
        }

        //metodos
        public void Alterar(string edita_info)
        {
            //altera dados da lista
            foreach (var Dadospiloto in ListaPiloto)
            {
                if (Dadospiloto.Nome == txt_Editar.Text)
                {
                    Dadospiloto.Nome = txt_Nome.Text;
                    Dadospiloto.Escuderia = txt_Escuderia.Text;
                    Dadospiloto.NumeroCarro = Convert.ToInt32(txt_Numero.Text);
                    Dadospiloto.LarguraCarro = float.Parse(txt_LarguraCarro.Text);
                    Dadospiloto.TempoVolta = maskedTB_Volta.Text;
                    Dadospiloto.DataProva = maskedTB_Prova.Text;
                }
            }
        }

        public void Excluir(string excluir_info)
        {
            //remove dados na lista
            foreach (var Dadospiloto in ListaPiloto)
            {
                if (Dadospiloto.Nome == txt_Editar.Text)
                {
                    ListaPiloto.Remove(Dadospiloto);
                    break;
                }
            }
        }
    }
}
