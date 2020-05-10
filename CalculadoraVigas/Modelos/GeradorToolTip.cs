using System;
using System.Drawing;
using System.Windows.Forms;
using CalculadoraVigas.Apresentacao;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.Controls.Enums;

namespace CalculadoraVigas.Modelos
{
    public class GeradorToolTip
    {
        public SfToolTip SfToolTip { get; private set; }

        public GeradorToolTip(SfToolTip sfToolTip)
        {
            SfToolTip = sfToolTip ?? throw new ArgumentNullException(nameof(sfToolTip));
        }

        public void InsereToolTip(Bitmap imagem, string texto, Control controle)
        {
            ToolTipInfo toolTipInfo = new ToolTipInfo();
            toolTipInfo.MaxWidth = 1000;
            toolTipInfo.ToolTipStyle = ToolTipStyle.Balloon;
            toolTipInfo.BeakBackColor = ColorTranslator.FromHtml("#3D3D3D");
            toolTipInfo.BorderColor = ColorTranslator.FromHtml("#1E1E1E");
            ToolTipItem toolTipItem = new ToolTipItem();
            toolTipItem.Padding = new Padding(10);
            toolTipItem.Style.BackColor = ColorTranslator.FromHtml("#3D3D3D");

            ucInformacoes pictureBoxControl = new ucInformacoes();

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = imagem;
            pictureBox.Size = new Size(214, 292);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxControl.PictureBox = pictureBox;

            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Margin = new Padding(0);
            richTextBox.Location = new Point(239, 0);
            richTextBox.Size = new Size(315, 292);
            richTextBox.BackColor = ColorTranslator.FromHtml("#3D3D3D");
            richTextBox.Rtf = texto;
            richTextBox.BorderStyle = BorderStyle.None;
            pictureBoxControl.RichTextBox = richTextBox;

            pictureBoxControl.BackColor = ColorTranslator.FromHtml("#3D3D3D");
            pictureBoxControl.AdicionarControles();
            pictureBoxControl.Size = new Size(515, 292);
            toolTipItem.Control = pictureBoxControl;

            toolTipInfo.Items.Add(toolTipItem);

            SfToolTip.SetToolTipInfo(controle, toolTipInfo);
        }
    }
}
