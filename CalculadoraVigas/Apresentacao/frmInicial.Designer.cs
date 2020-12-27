namespace CalculadoraVigas.Apresentacao
{
    partial class frmInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicial));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lbSuperiorCabecalho = new System.Windows.Forms.Label();
            this.lbEsquerdaCabecalho = new System.Windows.Forms.Label();
            this.lbDireitaCabecalho = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.lbEsquerdaContainer = new System.Windows.Forms.Label();
            this.lbInferiorConteiner = new System.Windows.Forms.Label();
            this.lbDireitaContainer = new System.Windows.Forms.Label();
            this.panelFerramentas = new System.Windows.Forms.Panel();
            this.lbCisalhamento = new System.Windows.Forms.Label();
            this.lbFlexao = new System.Windows.Forms.Label();
            this.lbFerramenta = new System.Windows.Forms.Label();
            this.btnCisalhamento = new System.Windows.Forms.Button();
            this.btnFlexao = new System.Windows.Forms.Button();
            this.lbEsquerdaFerramentas = new System.Windows.Forms.Label();
            this.lbDireitaFerramentas = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.panelFerramentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelSuperior.Controls.Add(this.lbSuperiorCabecalho);
            this.panelSuperior.Controls.Add(this.lbEsquerdaCabecalho);
            this.panelSuperior.Controls.Add(this.lbDireitaCabecalho);
            this.panelSuperior.Controls.Add(this.btnFechar);
            this.panelSuperior.Controls.Add(this.pictureBoxLogo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(555, 60);
            this.panelSuperior.TabIndex = 2;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            this.panelSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseMove);
            // 
            // lbSuperiorCabecalho
            // 
            this.lbSuperiorCabecalho.BackColor = System.Drawing.Color.Black;
            this.lbSuperiorCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSuperiorCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSuperiorCabecalho.ForeColor = System.Drawing.Color.Black;
            this.lbSuperiorCabecalho.Location = new System.Drawing.Point(2, 0);
            this.lbSuperiorCabecalho.Margin = new System.Windows.Forms.Padding(0);
            this.lbSuperiorCabecalho.Name = "lbSuperiorCabecalho";
            this.lbSuperiorCabecalho.Size = new System.Drawing.Size(551, 2);
            this.lbSuperiorCabecalho.TabIndex = 55;
            // 
            // lbEsquerdaCabecalho
            // 
            this.lbEsquerdaCabecalho.BackColor = System.Drawing.Color.Black;
            this.lbEsquerdaCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEsquerdaCabecalho.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbEsquerdaCabecalho.ForeColor = System.Drawing.Color.Black;
            this.lbEsquerdaCabecalho.Location = new System.Drawing.Point(0, 0);
            this.lbEsquerdaCabecalho.Margin = new System.Windows.Forms.Padding(0);
            this.lbEsquerdaCabecalho.Name = "lbEsquerdaCabecalho";
            this.lbEsquerdaCabecalho.Size = new System.Drawing.Size(2, 60);
            this.lbEsquerdaCabecalho.TabIndex = 54;
            // 
            // lbDireitaCabecalho
            // 
            this.lbDireitaCabecalho.BackColor = System.Drawing.Color.Black;
            this.lbDireitaCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDireitaCabecalho.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbDireitaCabecalho.ForeColor = System.Drawing.Color.Black;
            this.lbDireitaCabecalho.Location = new System.Drawing.Point(553, 0);
            this.lbDireitaCabecalho.Margin = new System.Windows.Forms.Padding(0);
            this.lbDireitaCabecalho.Name = "lbDireitaCabecalho";
            this.lbDireitaCabecalho.Size = new System.Drawing.Size(2, 60);
            this.lbDireitaCabecalho.TabIndex = 53;
            // 
            // btnFechar
            // 
            this.btnFechar.AccessibleName = "Button";
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(504, 15);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(30, 30);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "X";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 5);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(223, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            this.pictureBoxLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseMove);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.lbEsquerdaContainer);
            this.panelContainer.Controls.Add(this.lbInferiorConteiner);
            this.panelContainer.Controls.Add(this.lbDireitaContainer);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 120);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(555, 550);
            this.panelContainer.TabIndex = 1;
            // 
            // lbEsquerdaContainer
            // 
            this.lbEsquerdaContainer.BackColor = System.Drawing.Color.Black;
            this.lbEsquerdaContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEsquerdaContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbEsquerdaContainer.ForeColor = System.Drawing.Color.Black;
            this.lbEsquerdaContainer.Location = new System.Drawing.Point(0, 0);
            this.lbEsquerdaContainer.Margin = new System.Windows.Forms.Padding(0);
            this.lbEsquerdaContainer.Name = "lbEsquerdaContainer";
            this.lbEsquerdaContainer.Size = new System.Drawing.Size(2, 548);
            this.lbEsquerdaContainer.TabIndex = 56;
            // 
            // lbInferiorConteiner
            // 
            this.lbInferiorConteiner.BackColor = System.Drawing.Color.Black;
            this.lbInferiorConteiner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInferiorConteiner.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbInferiorConteiner.ForeColor = System.Drawing.Color.Black;
            this.lbInferiorConteiner.Location = new System.Drawing.Point(0, 548);
            this.lbInferiorConteiner.Margin = new System.Windows.Forms.Padding(0);
            this.lbInferiorConteiner.Name = "lbInferiorConteiner";
            this.lbInferiorConteiner.Size = new System.Drawing.Size(553, 2);
            this.lbInferiorConteiner.TabIndex = 55;
            // 
            // lbDireitaContainer
            // 
            this.lbDireitaContainer.BackColor = System.Drawing.Color.Black;
            this.lbDireitaContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDireitaContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbDireitaContainer.ForeColor = System.Drawing.Color.Black;
            this.lbDireitaContainer.Location = new System.Drawing.Point(553, 0);
            this.lbDireitaContainer.Margin = new System.Windows.Forms.Padding(0);
            this.lbDireitaContainer.Name = "lbDireitaContainer";
            this.lbDireitaContainer.Size = new System.Drawing.Size(2, 550);
            this.lbDireitaContainer.TabIndex = 52;
            // 
            // panelFerramentas
            // 
            this.panelFerramentas.Controls.Add(this.lbCisalhamento);
            this.panelFerramentas.Controls.Add(this.lbFlexao);
            this.panelFerramentas.Controls.Add(this.lbFerramenta);
            this.panelFerramentas.Controls.Add(this.btnCisalhamento);
            this.panelFerramentas.Controls.Add(this.btnFlexao);
            this.panelFerramentas.Controls.Add(this.lbEsquerdaFerramentas);
            this.panelFerramentas.Controls.Add(this.lbDireitaFerramentas);
            this.panelFerramentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFerramentas.Location = new System.Drawing.Point(0, 60);
            this.panelFerramentas.Margin = new System.Windows.Forms.Padding(0);
            this.panelFerramentas.Name = "panelFerramentas";
            this.panelFerramentas.Size = new System.Drawing.Size(555, 60);
            this.panelFerramentas.TabIndex = 0;
            // 
            // lbCisalhamento
            // 
            this.lbCisalhamento.AutoSize = true;
            this.lbCisalhamento.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbCisalhamento.ForeColor = System.Drawing.Color.Black;
            this.lbCisalhamento.Location = new System.Drawing.Point(310, 20);
            this.lbCisalhamento.Name = "lbCisalhamento";
            this.lbCisalhamento.Size = new System.Drawing.Size(109, 20);
            this.lbCisalhamento.TabIndex = 4;
            this.lbCisalhamento.Text = "Cisalhamento";
            // 
            // lbFlexao
            // 
            this.lbFlexao.AutoSize = true;
            this.lbFlexao.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbFlexao.ForeColor = System.Drawing.Color.Black;
            this.lbFlexao.Location = new System.Drawing.Point(184, 20);
            this.lbFlexao.Name = "lbFlexao";
            this.lbFlexao.Size = new System.Drawing.Size(56, 20);
            this.lbFlexao.TabIndex = 2;
            this.lbFlexao.Text = "Flexão";
            // 
            // lbFerramenta
            // 
            this.lbFerramenta.AutoSize = true;
            this.lbFerramenta.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbFerramenta.ForeColor = System.Drawing.Color.DimGray;
            this.lbFerramenta.Location = new System.Drawing.Point(25, 20);
            this.lbFerramenta.Name = "lbFerramenta";
            this.lbFerramenta.Size = new System.Drawing.Size(97, 20);
            this.lbFerramenta.TabIndex = 0;
            this.lbFerramenta.Text = "Ferramenta:";
            // 
            // btnCisalhamento
            // 
            this.btnCisalhamento.AccessibleName = "Button";
            this.btnCisalhamento.FlatAppearance.BorderSize = 0;
            this.btnCisalhamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCisalhamento.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnCisalhamento.Location = new System.Drawing.Point(257, 5);
            this.btnCisalhamento.Margin = new System.Windows.Forms.Padding(0);
            this.btnCisalhamento.Name = "btnCisalhamento";
            this.btnCisalhamento.Size = new System.Drawing.Size(50, 50);
            this.btnCisalhamento.TabIndex = 3;
            this.btnCisalhamento.Click += new System.EventHandler(this.btnCisalhamento_Click);
            // 
            // btnFlexao
            // 
            this.btnFlexao.AccessibleName = "Button";
            this.btnFlexao.FlatAppearance.BorderSize = 0;
            this.btnFlexao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlexao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnFlexao.Location = new System.Drawing.Point(128, 5);
            this.btnFlexao.Name = "btnFlexao";
            this.btnFlexao.Size = new System.Drawing.Size(50, 50);
            this.btnFlexao.TabIndex = 1;
            this.btnFlexao.Click += new System.EventHandler(this.btnFlexao_Click);
            // 
            // lbEsquerdaFerramentas
            // 
            this.lbEsquerdaFerramentas.BackColor = System.Drawing.Color.Black;
            this.lbEsquerdaFerramentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEsquerdaFerramentas.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbEsquerdaFerramentas.ForeColor = System.Drawing.Color.Black;
            this.lbEsquerdaFerramentas.Location = new System.Drawing.Point(0, 0);
            this.lbEsquerdaFerramentas.Margin = new System.Windows.Forms.Padding(0);
            this.lbEsquerdaFerramentas.Name = "lbEsquerdaFerramentas";
            this.lbEsquerdaFerramentas.Size = new System.Drawing.Size(2, 60);
            this.lbEsquerdaFerramentas.TabIndex = 54;
            // 
            // lbDireitaFerramentas
            // 
            this.lbDireitaFerramentas.BackColor = System.Drawing.Color.Black;
            this.lbDireitaFerramentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDireitaFerramentas.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbDireitaFerramentas.ForeColor = System.Drawing.Color.Black;
            this.lbDireitaFerramentas.Location = new System.Drawing.Point(553, 0);
            this.lbDireitaFerramentas.Margin = new System.Windows.Forms.Padding(0);
            this.lbDireitaFerramentas.Name = "lbDireitaFerramentas";
            this.lbDireitaFerramentas.Size = new System.Drawing.Size(2, 60);
            this.lbDireitaFerramentas.TabIndex = 53;
            // 
            // frmInicial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 670);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelFerramentas);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(555, 670);
            this.MinimumSize = new System.Drawing.Size(555, 670);
            this.Name = "frmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Inicial_Load);
            this.panelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelFerramentas.ResumeLayout(false);
            this.panelFerramentas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lbDireitaContainer;
        private System.Windows.Forms.Label lbDireitaCabecalho;
        private System.Windows.Forms.Label lbEsquerdaContainer;
        private System.Windows.Forms.Label lbInferiorConteiner;
        private System.Windows.Forms.Panel panelFerramentas;
        private System.Windows.Forms.Label lbEsquerdaFerramentas;
        private System.Windows.Forms.Label lbDireitaFerramentas;
        private System.Windows.Forms.Label lbSuperiorCabecalho;
        private System.Windows.Forms.Label lbEsquerdaCabecalho;
        private System.Windows.Forms.Button btnCisalhamento;
        private System.Windows.Forms.Button btnFlexao;
        //private Syncfusion.Windows.Forms.SfToolTip sfToolTip1;
        private System.Windows.Forms.Label lbFerramenta;
        private System.Windows.Forms.Label lbCisalhamento;
        private System.Windows.Forms.Label lbFlexao;
    }
}

