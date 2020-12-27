using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CalculadoraVigas.Modelos;

namespace CalculadoraVigas.Apresentacao
{
    public partial class ucFlexao : UserControl
    {
        private bool rectangleClicked = true;

        public ucFlexao()
        {
            InitializeComponent();

            PreencheControles();
        }

        private void PreencheControles()
        {
            ComboBoxAco.DataSource = new List<Aco>
            {
                new Aco(25),
                new Aco(50),
                new Aco(60)
            };

            ComboBoxAco.SelectedIndex = 1;

            txtDLinhaInferior.Leave += new System.EventHandler(txtDLinhaInferiorOnLeave);
        }

        private void btnSecaoRetangular_Click(object sender, EventArgs e)
        {
            txtLargura.Focus();
            btnSecaoRetangular.Image = CalculadoraVigas.Properties.Resources.retangular_clique;
            btnSecaoT.Image = CalculadoraVigas.Properties.Resources.t_normal;
            btnCalculaMd.Visible = true;
            rectangleClicked = true;
            tablePanelSecaoT.Visible = false;
        }

        private void btnSecaoT_Click(object sender, EventArgs e)
        {
            txtLargura.Focus();
            btnSecaoRetangular.Image = CalculadoraVigas.Properties.Resources.retangular_normal;
            btnSecaoT.Image = CalculadoraVigas.Properties.Resources.t_clique;
            rectangleClicked = false;
            btnCalculaMd.Visible = false;
            tablePanelSecaoT.Visible = true;
        }

        private void btnCalculaAs_Click(object sender, EventArgs e)
        {
            try
            {
                double largura = Convert.ToDouble(txtLargura.Text.Split(' ')[0]);
                double altura = Convert.ToDouble(txtAltura.Text.Split(' ')[0]);
                double momentoMajorado = Convert.ToDouble(txtMomento.Text.Split(' ')[0]);
                double dLinhaInferior = Convert.ToDouble(txtDLinhaInferior.Text.Split(' ')[0]);
                double dLinhaSuperior = Convert.ToDouble(txtDLinhaSuperior.Text.Split(' ')[0]);
                double fck = Convert.ToDouble(txtFck.Text.Split(' ')[0]) / 10.0;
                double fyk = (ComboBoxAco.SelectedItem as Aco).ResistenciaCaracteristica;
                if (rectangleClicked)
                {
                    SecaoRetangular secao = new SecaoRetangular(largura, altura, dLinhaInferior, dLinhaSuperior);
                    preencheResposta(secao);
                }
                else
                {
                    double larguraColaborante = Convert.ToDouble(txtLarguraColaborante.Text.Split(' ')[0]);
                    double espessuraMesa = Convert.ToDouble(txtEspessuraMesa.Text.Split(' ')[0]);
                    SecaoT secao = new SecaoT(largura, altura, dLinhaInferior, dLinhaSuperior, larguraColaborante, espessuraMesa);
                    preencheResposta(secao);
                }

                void preencheResposta(Secao secao)
                {
                    RespostaFlexaoAs resposta = secao.CalculaAreaAco(momentoMajorado, fck, fyk);
                    txtAreaTracionada.Text = resposta.ArmacaoTracionada.ToString("F2") + " cm²";
                    lbAreaComprimida.Text = resposta.ArmacaoComprimida.ToString("F2") + " cm²";
                    lbLinhaNeutra.Text = resposta.LinhaNeutra.ToString("F2") + " cm";
                    lbRazaoLN.Text =
                        (resposta.LinhaNeutra / secao.AlturaUtil).ToString("F2") +
                        $" ({(resposta.LinhaNeutra < 0.259 * secao.AlturaUtil ? "Domínio 2" : "Domínio 3")})";
                }
            }
            catch (ArgumentException er)
            {
                MessageBox.Show(er.Message, "Dados incoerentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique todos os dados inseridos.", "Erro não tratado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculaMd_Click(object sender, EventArgs e)
        {
            try
            {
                double largura = Convert.ToDouble(txtLargura.Text.Split(' ')[0]);
                double altura = Convert.ToDouble(txtAltura.Text.Split(' ')[0]);
                double momentoMajorado = Convert.ToDouble(txtMomento.Text.Split(' ')[0]);
                double dLinhaInferior = Convert.ToDouble(txtDLinhaInferior.Text.Split(' ')[0]);
                double dLinhaSuperior = Convert.ToDouble(txtDLinhaSuperior.Text.Split(' ')[0]);
                double fck = Convert.ToDouble(txtFck.Text.Split(' ')[0]) / 10.0;
                double fyk = (ComboBoxAco.SelectedItem as Aco).ResistenciaCaracteristica;
                double areaAco = Convert.ToDouble(txtAreaTracionada.Text.Split(' ')[0]);

                SecaoRetangular secao = new SecaoRetangular(largura, altura, dLinhaInferior, dLinhaSuperior);
                RespostaFlexaoMd resposta = secao.MomentoResistente(areaAco, fck, fyk);
                lbAreaComprimida.Text = resposta.AreaComprimida.ToString("F2") + " cm²";
                txtMomento.Text = resposta.MomentoSolicitante.ToString("F2") + " kN.cm";
                lbLinhaNeutra.Text = resposta.LinhaNeutra.ToString("F2") + " cm";
                lbRazaoLN.Text = (resposta.LinhaNeutra / secao.AlturaUtil).ToString("F2") + $" ({(resposta.LinhaNeutra < 0.259 * secao.AlturaUtil ? "Domínio 2" : "Domínio 3")})";
            }
            catch (ArgumentException er)
            {
                MessageBox.Show(er.Message, "Dados incoerentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique todos os dados inseridos.", "Erro não tratado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFck_Changed(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtFck.Text) > 50)
            {
                MessageBox.Show("Resistência característica deve ser inferior à 50 MPa. O valor será alterado para 50 MPa.", "Resistência característica não prevista", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFck.Text = "50";
            }

        }


        private void textBoxSelectAllOnEnter(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            textBox.SelectAll();
        }

        private void textBoxSplitOnLeave(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            textBox.Text = textBox.Text.Split(' ')[0] + ' ' +  textBox.Tag;
        }
        
        private void txtDLinhaInferiorOnLeave(object sender, EventArgs e)
        {
            txtDLinhaSuperior.Text = txtDLinhaInferior.Text.Split(' ')[0] + " cm";
        }

        private void textBoxAllowNumericOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
