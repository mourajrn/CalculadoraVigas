using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CalculadoraVigas.Modelos;
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
        }

        private void PreencheControles()
        {
            ComboBoxAco.DataSource = new List<Aco>
            {
                new Aco(25),
                new Aco(50),
                new Aco(60)
            };

            rbModeloI.Tag = new CalculadoraModeloI();
            rbModeloII.Tag = new CalculadoraModeloII();

            ComboBoxAco.SelectedIndex = 1;
        }

        private void rbModeloII_CheckChanged(object sender, EventArgs e)
        {
            txtInclinacaoBiela.Enabled = rbModeloII.Checked;
            txtInclinacaoBiela.Text = rbModeloI.Checked ? "45" : txtInclinacaoBiela.Text;
        }

        private void textBoxSelectAllOnEnter(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            textBox.SelectAll();
        }

        private void textBoxSplitOnLeave(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            textBox.Text = textBox.Text.Split(' ')[0] + ' ' + textBox.Tag;
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

        private void btnCalculaAs_Click(object sender, EventArgs e)
        {
            double fck = Convert.ToDouble(txtFck.Text.Split(' ')[0]) / 10.0;
            double fyk = (ComboBoxAco.SelectedItem as Aco).ResistenciaCaracteristica;

            double inclinacaoBiela = Convert.ToDouble(txtInclinacaoBiela.Text.Split(' ')[0]) * Math.PI / 180.0;
            double inclinacaoEstribo = Convert.ToDouble(txtInclinacaoEstribo.Text.Split(' ')[0]) * Math.PI / 180.0;

            double largura = Convert.ToDouble(txtLargura.Text.Split(' ')[0]);
            double alturaUtil = Convert.ToDouble(txtAlturaUtil.Text.Split(' ')[0]);

            double cortante = Convert.ToDouble(txtCortante.Text.Split(' ')[0]);

            SecaoRetangular secao = new SecaoRetangular(largura, alturaUtil, 0, 0);

            RadioButton radio = tablePanelModelo.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

            CalculadoraCisalhamento calculadora = radio.Tag as CalculadoraCisalhamento;

            RespostaCisalhamento resposta = calculadora.Calcula(secao, cortante, fck, fyk, inclinacaoBiela, inclinacaoEstribo);

            labelAreaTracionada.Text = resposta.AreaTransversal.ToString("F2") + " cm²/m";
            lbVc.Text = resposta.Vc.ToString("F2") + " kN";
            lbVrd2.Text = resposta.VRd2.ToString("F2") + " kN";
        }
    }
}
