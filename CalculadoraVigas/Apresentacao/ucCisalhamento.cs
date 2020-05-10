using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CalculadoraVigas.Modelos;
using Syncfusion.Windows.Forms.Tools;
using static CalculadoraVigas.Modelos.Matematica;

namespace CalculadoraVigas.Apresentacao
{
    public partial class ucCisalhamento : UserControl
    {
        private const int MAXIMA_TENSAO_ESCOAMENTO = 50;

        public ucCisalhamento()
        {
            InitializeComponent();

            PreencheControles();

            FormataToolTips();
        }

        private void FormataToolTips()
        {
            GeradorToolTip geradorToolTip = new GeradorToolTip(sfToolTip1);

            geradorToolTip.InsereToolTip(
                global::CalculadoraVigas.Properties.Resources.bw,
                "{\\rtf1\\ansi\\ansicpg1252\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}\r\n{\\colortbl ;\\red245\\green245\\blue245;}\r\n\\" +
                "viewkind4\\uc1\\pard\\cf1\\lang1033\\b0\\fs12\\par\r\n\\b\\f0\\fs30 bw \\b0\\f0\\fs4\\par\r\n\\par\r\n\\f0\\fs18 \\b0\\f0\\fs28\\par" +
                "\r\n\\par\r\n\\f0\\fs18 Largura da nervura da viga. Será a \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 largura da viga no caso de vigas " +
                "\\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 retangulares.",
                this.txtLargura);

            geradorToolTip.InsereToolTip(
                global::CalculadoraVigas.Properties.Resources.d,
                "{\\rtf1\\ansi\\ansicpg1252\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}\r\n{\\colortbl ;\\red245\\green245\\blue245;}\r\n\\" +
                "viewkind4\\uc1\\pard\\cf1\\lang1033\\b0\\fs12\\par\r\n\\b\\f0\\fs30 d \\b0\\f0\\fs4\\par\r\n\\par\r\n\\f0\\fs18 \\b0\\f0\\fs28\\par" +
                "\r\n\\par\r\n\\f0\\fs18 Altura útil da viga. \\b0\\f0\\fs3\\par\r\n\\par\r\n\\f0\\fs18 Diferença entre h e d'.",
                this.txtAlturaUtil);
        }

        private void PreencheControles()
        {
            sfComboBoxAco.DataSource = new List<Aco>
            {
                new Aco(25),
                new Aco(50),
                new Aco(60)
            };

            rbModeloI.Tag = new CalculadoraModeloI();
            rbModeloII.Tag = new CalculadoraModeloII();

            sfComboBoxAco.SelectedIndex = 1;
        }

        private void btnCalculaAs_Click(object sender, EventArgs e)
        {
            try
            {
                double largura = Convert.ToDouble(txtLargura.Value);
                double alturaUtil = Convert.ToDouble(txtAlturaUtil.Value);
                double fck = Convert.ToDouble(txtFck.Value) / 10.0;
                double fyk = Math.Min((sfComboBoxAco.SelectedItem as Aco).ResistenciaCaracteristica, MAXIMA_TENSAO_ESCOAMENTO);
                double cortante = Convert.ToDouble(txtCortante.Value);
                double inclinacaoBiela = ConverteRadiano(Convert.ToDouble(txtInclinacaoBiela.Value));
                double inclinacaoEstribo = ConverteRadiano(Convert.ToDouble(txtInclinacaoEstribo.Value));

                SecaoRetangular secao = new SecaoRetangular(largura, alturaUtil, 0.0, 0.0);

                var botaoSelecionado = tablePanelModelo.Controls.OfType<RadioButtonAdv>()
                                      .FirstOrDefault(r => r.Checked);

                RespostaCisalhamento resposta = 
                    (botaoSelecionado.Tag as CalculadoraCisalhamento)
                    .Calcula(secao, cortante, fck, fyk, inclinacaoBiela, inclinacaoEstribo);

                lbVrd2.Text = cortante > resposta.VRd2
                    ? $"{resposta.VRd2.ToString("F2")} kN \n VSd > VRd2"
                    : resposta.VRd2.ToString("F2") + " kN";
                lbVrd2.ForeColor = cortante > resposta.VRd2
                    ? Color.Red
                    : Color.Black;

                lbVc.Text = resposta.Vc.ToString("F2") + " kN";
                txtAreaTracionada.Value = cortante > resposta.VRd2 || cortante <= resposta.Vc 
                    ? 0 
                    : resposta.AreaTransversal;
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

        private void rbModeloII_CheckChanged(object sender, EventArgs e)
        {
            txtInclinacaoBiela.Enabled = rbModeloII.Checked;
            txtInclinacaoBiela.Value = rbModeloI.Checked ? 45 : txtInclinacaoBiela.Value;
        }
    }
}
