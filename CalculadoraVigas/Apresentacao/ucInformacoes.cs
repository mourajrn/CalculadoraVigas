using System.Windows.Forms;

namespace CalculadoraVigas.Apresentacao
{
    public partial class ucInformacoes : UserControl
    {
        public ucInformacoes()
        {
            InitializeComponent();
        }

        public void AdicionarControles()
        {
            this.Controls.Add(PictureBox);
            this.Controls.Add(RichTextBox);
        }

        public PictureBox PictureBox { get; set; }

        public RichTextBox RichTextBox { get; set; }
    }
}
