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

            FormataToolTips();
        }

        private void FormataToolTips()
        {
            GeradorToolTip geradorToolTip = new GeradorToolTip(sfToolTip1);

            geradorToolTip.InsereToolTip(
                global::CalculadoraVigas.Properties.Resources.di,
                "{\\rtf1\\ansi\\ansicpg1252\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}\r\n{\\colortbl ;\\red245\\green245\\blue245;}\r\n\\" +
                "viewkind4\\uc1\\pard\\cf1\\lang1033\\b0\\fs12\\par\r\n\\b\\f0\\fs30 di' \\b0\\f0\\fs4\\par\r\n\\par\r\n\\f0\\fs18 \\b0\\f0\\fs28\\par" +
                "\r\n\\par\r\n\\f0\\fs18 Distância entre a armadura \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 inferior e a borda inferior.",
                this.txtDLinhaInferior);

            geradorToolTip.InsereToolTip(
                global::CalculadoraVigas.Properties.Resources.ds,
                "{\\rtf1\\ansi\\ansicpg1252\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}\r\n{\\colortbl ;\\red245\\green245\\blue245;}\r\n\\" +
                "viewkind4\\uc1\\pard\\cf1\\lang1033\\b0\\fs12\\par\r\n\\b\\f0\\fs30 ds' \\b0\\f0\\fs4\\par\r\n\\par\r\n\\f0\\fs18 \\b0\\f0\\fs28\\par" +
                "\r\n\\par\r\n\\f0\\fs18 Distância entre a armadura \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 superior e a borda superior",
                this.txtDLinhaSuperior);

            geradorToolTip.InsereToolTip(
                global::CalculadoraVigas.Properties.Resources.h,
                "{\\rtf1\\ansi\\ansicpg1252\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}\r\n{\\colortbl ;\\red245\\green245\\blue245;}\r\n\\" +
                "viewkind4\\uc1\\pard\\cf1\\lang1033\\b0\\fs12\\par\r\n\\b\\f0\\fs30 h \\b0\\f0\\fs4\\par\r\n\\par\r\n\\f0\\fs18 \\b0\\f0\\fs28\\par" +
                "\r\n\\par\r\n\\f0\\fs18 Altura total da seção \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 (seja ela retangular ou T).",
                this.txtAltura);

            geradorToolTip.InsereToolTip(
                global::CalculadoraVigas.Properties.Resources.bw,
                "{\\rtf1\\ansi\\ansicpg1252\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}\r\n{\\colortbl ;\\red245\\green245\\blue245;}\r\n\\" +
                "viewkind4\\uc1\\pard\\cf1\\lang1033\\b0\\fs12\\par\r\n\\b\\f0\\fs30 bw \\b0\\f0\\fs4\\par\r\n\\par\r\n\\f0\\fs18 \\b0\\f0\\fs28\\par" +
                "\r\n\\par\r\n\\f0\\fs18 Largura da nervura da viga. Será a \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 largura da viga no caso de vigas " +
                "\\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 retangulares.",
                this.txtLargura);

            geradorToolTip.InsereToolTip(
                global::CalculadoraVigas.Properties.Resources.bf,
                "{\\rtf1\\ansi\\ansicpg1252\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}\r\n{\\colortbl ;\\red245\\green245\\blue245;}\r\n\\" +
                "viewkind4\\uc1\\pard\\cf1\\lang1033\\b0\\fs12\\par\r\n\\b\\f0\\fs30 bf \\b0\\f0\\fs4\\par\r\n\\par\r\n\\f0\\fs18 \\b0\\f0\\fs28\\par" +
                "\r\n\\par\r\n\\f0\\fs18 Largura de todo o flange da viga T.",
                this.txtLarguraColaborante);

            geradorToolTip.InsereToolTip(
                global::CalculadoraVigas.Properties.Resources.hf,
                "{\\rtf1\\ansi\\ansicpg1252\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}\r\n{\\colortbl ;\\red245\\green245\\blue245;}\r\n\\" +
                "viewkind4\\uc1\\pard\\cf1\\lang1033\\b0\\fs12\\par\r\n\\b\\f0\\fs30 hf \\b0\\f0\\fs4\\par\r\n\\par\r\n\\f0\\fs18 \\b0\\f0\\fs28\\par" +
                "\r\n\\par\r\n\\f0\\fs18 Espessura apenas da mesa, ou seja, do \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 flange da viga T",
                this.txtEspessuraMesa);
        }

        private void PreencheControles()
        {
            sfComboBoxAco.DataSource = new List<Aco>
            {
                new Aco(25),
                new Aco(50),
                new Aco(60)
            };

            sfComboBoxAco.SelectedIndex = 1;
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
                double largura = Convert.ToDouble(txtLargura.Value);
                double altura = Convert.ToDouble(txtAltura.Value);
                double momentoMajorado = Convert.ToDouble(txtMomento.Value);
                double dLinhaInferior = Convert.ToDouble(txtDLinhaInferior.Value);
                double dLinhaSuperior = Convert.ToDouble(txtDLinhaSuperior.Value);
                double fck = Convert.ToDouble(txtFck.Value) / 10.0;
                double fyk = (sfComboBoxAco.SelectedItem as Aco).ResistenciaCaracteristica;
                if (rectangleClicked)
                {
                    SecaoRetangular secao = new SecaoRetangular(largura, altura, dLinhaInferior, dLinhaSuperior);
                    preencheResposta(secao);
                }
                else
                {
                    double larguraColaborante = Convert.ToDouble(txtLarguraColaborante.Value);
                    double espessuraMesa = Convert.ToDouble(txtEspessuraMesa.Value);
                    SecaoT secao = new SecaoT(largura, altura, dLinhaInferior, dLinhaSuperior, larguraColaborante, espessuraMesa);
                    preencheResposta(secao);
                }

                void preencheResposta(Secao secao)
                {
                    RespostaFlexaoAs resposta = secao.CalculaAreaAco(momentoMajorado, fck, fyk);
                    txtAreaTracionada.Text = resposta.ArmacaoTracionada.ToString("F2");
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
                double largura = Convert.ToDouble(txtLargura.Value);
                double altura = Convert.ToDouble(txtAltura.Value);
                double momentoMajorado = Convert.ToDouble(txtMomento.Value);
                double dLinhaInferior = Convert.ToDouble(txtDLinhaInferior.Value);
                double dLinhaSuperior = Convert.ToDouble(txtDLinhaSuperior.Value);
                double fck = Convert.ToDouble(txtFck.Value) / 10.0;
                double fyk = (sfComboBoxAco.SelectedItem as Aco).ResistenciaCaracteristica;
                double areaAco = Convert.ToDouble(txtAreaTracionada.Value);

                SecaoRetangular secao = new SecaoRetangular(largura, altura, dLinhaInferior, dLinhaSuperior);
                RespostaFlexaoMd resposta = secao.MomentoResistente(areaAco, fck, fyk);
                lbAreaComprimida.Text = resposta.AreaComprimida.ToString("F2") + " cm²";
                txtMomento.Text = resposta.MomentoSolicitante.ToString("F2");
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
            if (Convert.ToDouble(txtFck.Value) > 50)
            {
                MessageBox.Show("Resistência característica deve ser inferior à 50 MPa. O valor será alterado para 50 MPa.", "Resistência característica não prevista", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFck.Value = 50;
            }

        }
    }
}
