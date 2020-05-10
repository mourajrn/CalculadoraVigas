using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculadoraVigas.Apresentacao
{
    public partial class frmInicial : Form
    {
        static frmInicial _obj;
        public static frmInicial Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new frmInicial();
                }
                return _obj;
            }
        }

        public Panel PContainer
        {
            get
            {
                return panelContainer;
            }
            set
            {
                panelContainer = value;
            }
        }

        public ucFlexao UCFlexao;
        public ucCisalhamento UCCisalhamento;

        public frmInicial()
        {
            InitializeComponent();
        }

        private Point pontoInicialFormulario;
        private Point pontoInicialCursor;

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            pontoInicialFormulario = this.Location;
            pontoInicialCursor = Cursor.Position;
        }

        private void panelSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var diferenca = Point.Subtract(Cursor.Position, new Size(pontoInicialCursor));
                this.Location = Point.Add(pontoInicialFormulario, new Size(diferenca));
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicial_Load(object sender, EventArgs e)
        {
            _obj = this;
            UCFlexao = CreateUserControl(new ucFlexao()) as ucFlexao;
            UCCisalhamento = CreateUserControl(new ucCisalhamento()) as ucCisalhamento;
        }

        private UserControl CreateUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PContainer.Controls.Add(userControl);
            return userControl;
        }

        private void btnFlexao_Click(object sender, EventArgs e)
        {
            UCFlexao.BringToFront();
            btnCisalhamento.Image = CalculadoraVigas.Properties.Resources.cisalhamento_normal;
            btnFlexao.Image = CalculadoraVigas.Properties.Resources.md_clique;
        }

        private void btnCisalhamento_Click(object sender, EventArgs e)
        {
            UCCisalhamento.BringToFront();
            btnCisalhamento.Image = CalculadoraVigas.Properties.Resources.cisalhamento_clique;
            btnFlexao.Image = CalculadoraVigas.Properties.Resources.md_normal;
        }
    }
}
