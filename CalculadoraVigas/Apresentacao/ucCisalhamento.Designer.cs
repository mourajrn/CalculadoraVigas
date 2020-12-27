namespace CalculadoraVigas.Apresentacao
{
    partial class ucCisalhamento
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tablePanelMdAs = new System.Windows.Forms.TableLayoutPanel();
            this.txtCortante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAreaTracionada = new System.Windows.Forms.Label();
            this.btnCalculaAs = new System.Windows.Forms.Button();
            this.lbArmaduraMinima = new System.Windows.Forms.Label();
            this.tableLayoutPanelResults = new System.Windows.Forms.TableLayoutPanel();
            this.lbVRd2Titulo = new System.Windows.Forms.Label();
            this.lbVrd2 = new System.Windows.Forms.Label();
            this.lbVc = new System.Windows.Forms.Label();
            this.lbVcTitulo = new System.Windows.Forms.Label();
            this.lbCortante = new System.Windows.Forms.Label();
            this.lbAreaAco = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tablePanelSecaoRetangular = new System.Windows.Forms.TableLayoutPanel();
            this.lbLargura = new System.Windows.Forms.Label();
            this.lbAlturaUtil = new System.Windows.Forms.Label();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.txtAlturaUtil = new System.Windows.Forms.TextBox();
            this.lbAco = new System.Windows.Forms.Label();
            this.lbResistenciaCaracteristica = new System.Windows.Forms.Label();
            this.tablePanelMateriais = new System.Windows.Forms.TableLayoutPanel();
            this.ComboBoxAco = new System.Windows.Forms.ComboBox();
            this.txtFck = new System.Windows.Forms.TextBox();
            this.tablePanelModelo = new System.Windows.Forms.TableLayoutPanel();
            this.lbModelo = new System.Windows.Forms.Label();
            this.rbModeloII = new System.Windows.Forms.RadioButton();
            this.rbModeloI = new System.Windows.Forms.RadioButton();
            this.tablePanelAngulos = new System.Windows.Forms.TableLayoutPanel();
            this.lbEstribo = new System.Windows.Forms.Label();
            this.lbBiela = new System.Windows.Forms.Label();
            this.txtInclinacaoBiela = new System.Windows.Forms.TextBox();
            this.txtInclinacaoEstribo = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tablePanelMdAs.SuspendLayout();
            this.tableLayoutPanelResults.SuspendLayout();
            this.tablePanelSecaoRetangular.SuspendLayout();
            this.tablePanelMateriais.SuspendLayout();
            this.tablePanelModelo.SuspendLayout();
            this.tablePanelAngulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanelMdAs
            // 
            this.tablePanelMdAs.ColumnCount = 2;
            this.tablePanelMdAs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.81482F));
            this.tablePanelMdAs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.18518F));
            this.tablePanelMdAs.Controls.Add(this.txtCortante, 0, 1);
            this.tablePanelMdAs.Controls.Add(this.label1, 0, 0);
            this.tablePanelMdAs.Controls.Add(this.label3, 1, 0);
            this.tablePanelMdAs.Controls.Add(this.labelAreaTracionada, 1, 1);
            this.tablePanelMdAs.Controls.Add(this.btnCalculaAs, 1, 3);
            this.tablePanelMdAs.Controls.Add(this.lbArmaduraMinima, 1, 2);
            this.tablePanelMdAs.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanelMdAs.Location = new System.Drawing.Point(0, 285);
            this.tablePanelMdAs.Margin = new System.Windows.Forms.Padding(5);
            this.tablePanelMdAs.Name = "tablePanelMdAs";
            this.tablePanelMdAs.Padding = new System.Windows.Forms.Padding(5);
            this.tablePanelMdAs.RowCount = 4;
            this.tablePanelMdAs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelMdAs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tablePanelMdAs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tablePanelMdAs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tablePanelMdAs.Size = new System.Drawing.Size(550, 175);
            this.tablePanelMdAs.TabIndex = 5;
            // 
            // txtCortante
            // 
            this.txtCortante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCortante.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtCortante.Location = new System.Drawing.Point(25, 34);
            this.txtCortante.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtCortante.Name = "txtCortante";
            this.txtCortante.Size = new System.Drawing.Size(229, 32);
            this.txtCortante.TabIndex = 0;
            this.txtCortante.Tag = "kN";
            this.txtCortante.Text = "0 kN";
            this.txtCortante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtCortante, "Cortante já majorado em kN");
            this.txtCortante.Click += new System.EventHandler(this.textBoxSelectAllOnEnter);
            this.txtCortante.Enter += new System.EventHandler(this.textBoxSelectAllOnEnter);
            this.txtCortante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAllowNumericOnly);
            this.txtCortante.Leave += new System.EventHandler(this.textBoxSplitOnLeave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(59, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cortante de Cálculo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(355, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "As,transversal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelAreaTracionada
            // 
            this.labelAreaTracionada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAreaTracionada.AutoSize = true;
            this.labelAreaTracionada.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelAreaTracionada.ForeColor = System.Drawing.Color.Black;
            this.labelAreaTracionada.Location = new System.Drawing.Point(362, 38);
            this.labelAreaTracionada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAreaTracionada.Name = "labelAreaTracionada";
            this.labelAreaTracionada.Size = new System.Drawing.Size(94, 23);
            this.labelAreaTracionada.TabIndex = 36;
            this.labelAreaTracionada.Text = "0 cm²/m";
            this.labelAreaTracionada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.labelAreaTracionada, "Área de aço transversal para cada metro. É necessário dividir pela quantidade de " +
        "ramos da armação");
            // 
            // btnCalculaAs
            // 
            this.btnCalculaAs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalculaAs.FlatAppearance.BorderSize = 0;
            this.btnCalculaAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculaAs.Image = global::CalculadoraVigas.Properties.Resources.as_normal;
            this.btnCalculaAs.Location = new System.Drawing.Point(382, 112);
            this.btnCalculaAs.Name = "btnCalculaAs";
            this.btnCalculaAs.Size = new System.Drawing.Size(55, 46);
            this.btnCalculaAs.TabIndex = 37;
            this.toolTip1.SetToolTip(this.btnCalculaAs, "Calcular a área de aço dado o cortante de cálculo");
            this.btnCalculaAs.UseVisualStyleBackColor = true;
            this.btnCalculaAs.Click += new System.EventHandler(this.btnCalculaAs_Click);
            // 
            // lbArmaduraMinima
            // 
            this.lbArmaduraMinima.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbArmaduraMinima.AutoSize = true;
            this.lbArmaduraMinima.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.lbArmaduraMinima.ForeColor = System.Drawing.Color.Red;
            this.lbArmaduraMinima.Location = new System.Drawing.Point(301, 74);
            this.lbArmaduraMinima.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbArmaduraMinima.Name = "lbArmaduraMinima";
            this.lbArmaduraMinima.Size = new System.Drawing.Size(217, 17);
            this.lbArmaduraMinima.TabIndex = 41;
            this.lbArmaduraMinima.Text = "Armadura mínima não considerada";
            this.lbArmaduraMinima.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanelResults
            // 
            this.tableLayoutPanelResults.ColumnCount = 2;
            this.tableLayoutPanelResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelResults.Controls.Add(this.lbVRd2Titulo, 0, 0);
            this.tableLayoutPanelResults.Controls.Add(this.lbVrd2, 0, 1);
            this.tableLayoutPanelResults.Controls.Add(this.lbVc, 1, 1);
            this.tableLayoutPanelResults.Controls.Add(this.lbVcTitulo, 1, 0);
            this.tableLayoutPanelResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelResults.Location = new System.Drawing.Point(0, 460);
            this.tableLayoutPanelResults.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanelResults.Name = "tableLayoutPanelResults";
            this.tableLayoutPanelResults.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanelResults.RowCount = 2;
            this.tableLayoutPanelResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.5098F));
            this.tableLayoutPanelResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.4902F));
            this.tableLayoutPanelResults.Size = new System.Drawing.Size(550, 90);
            this.tableLayoutPanelResults.TabIndex = 55;
            // 
            // lbVRd2Titulo
            // 
            this.lbVRd2Titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbVRd2Titulo.AutoSize = true;
            this.lbVRd2Titulo.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbVRd2Titulo.ForeColor = System.Drawing.Color.DimGray;
            this.lbVRd2Titulo.Location = new System.Drawing.Point(116, 5);
            this.lbVRd2Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVRd2Titulo.Name = "lbVRd2Titulo";
            this.lbVRd2Titulo.Size = new System.Drawing.Size(47, 19);
            this.lbVRd2Titulo.TabIndex = 36;
            this.lbVRd2Titulo.Text = "VRd2";
            this.lbVRd2Titulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbVrd2
            // 
            this.lbVrd2.AutoSize = true;
            this.lbVrd2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbVrd2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbVrd2.ForeColor = System.Drawing.Color.Black;
            this.lbVrd2.Location = new System.Drawing.Point(7, 24);
            this.lbVrd2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVrd2.Name = "lbVrd2";
            this.lbVrd2.Size = new System.Drawing.Size(266, 61);
            this.lbVrd2.TabIndex = 0;
            this.lbVrd2.Text = "0,00 kN";
            this.lbVrd2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lbVrd2, "Parcela VRd2 em kN");
            // 
            // lbVc
            // 
            this.lbVc.AutoSize = true;
            this.lbVc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbVc.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbVc.ForeColor = System.Drawing.Color.Black;
            this.lbVc.Location = new System.Drawing.Point(277, 24);
            this.lbVc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVc.Name = "lbVc";
            this.lbVc.Size = new System.Drawing.Size(266, 61);
            this.lbVc.TabIndex = 0;
            this.lbVc.Text = "0,00 kN";
            this.lbVc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lbVc, "Parcela Vc em kN");
            // 
            // lbVcTitulo
            // 
            this.lbVcTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbVcTitulo.AutoSize = true;
            this.lbVcTitulo.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbVcTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lbVcTitulo.Location = new System.Drawing.Point(395, 5);
            this.lbVcTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVcTitulo.Name = "lbVcTitulo";
            this.lbVcTitulo.Size = new System.Drawing.Size(30, 19);
            this.lbVcTitulo.TabIndex = 36;
            this.lbVcTitulo.Text = "Vc";
            this.lbVcTitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbCortante
            // 
            this.lbCortante.AutoSize = true;
            this.lbCortante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCortante.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbCortante.ForeColor = System.Drawing.Color.DimGray;
            this.lbCortante.Location = new System.Drawing.Point(7, 5);
            this.lbCortante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCortante.Name = "lbCortante";
            this.lbCortante.Size = new System.Drawing.Size(266, 25);
            this.lbCortante.TabIndex = 38;
            this.lbCortante.Text = "Cortante de cálculo";
            this.lbCortante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbAreaAco
            // 
            this.lbAreaAco.AutoSize = true;
            this.lbAreaAco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAreaAco.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbAreaAco.ForeColor = System.Drawing.Color.DimGray;
            this.lbAreaAco.Location = new System.Drawing.Point(277, 5);
            this.lbAreaAco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAreaAco.Name = "lbAreaAco";
            this.lbAreaAco.Size = new System.Drawing.Size(266, 25);
            this.lbAreaAco.TabIndex = 38;
            this.lbAreaAco.Text = "As,transversal";
            this.lbAreaAco.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(301, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Armadura mínima não considerada";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tablePanelSecaoRetangular
            // 
            this.tablePanelSecaoRetangular.ColumnCount = 2;
            this.tablePanelSecaoRetangular.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelSecaoRetangular.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelSecaoRetangular.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelSecaoRetangular.Controls.Add(this.lbLargura, 0, 0);
            this.tablePanelSecaoRetangular.Controls.Add(this.lbAlturaUtil, 1, 0);
            this.tablePanelSecaoRetangular.Controls.Add(this.txtLargura, 0, 1);
            this.tablePanelSecaoRetangular.Controls.Add(this.txtAlturaUtil, 1, 1);
            this.tablePanelSecaoRetangular.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanelSecaoRetangular.Location = new System.Drawing.Point(0, 196);
            this.tablePanelSecaoRetangular.Margin = new System.Windows.Forms.Padding(5);
            this.tablePanelSecaoRetangular.Name = "tablePanelSecaoRetangular";
            this.tablePanelSecaoRetangular.Padding = new System.Windows.Forms.Padding(5);
            this.tablePanelSecaoRetangular.RowCount = 2;
            this.tablePanelSecaoRetangular.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelSecaoRetangular.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelSecaoRetangular.Size = new System.Drawing.Size(550, 89);
            this.tablePanelSecaoRetangular.TabIndex = 3;
            // 
            // lbLargura
            // 
            this.lbLargura.AutoSize = true;
            this.lbLargura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLargura.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbLargura.ForeColor = System.Drawing.Color.DimGray;
            this.lbLargura.Location = new System.Drawing.Point(7, 5);
            this.lbLargura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLargura.Name = "lbLargura";
            this.lbLargura.Size = new System.Drawing.Size(266, 39);
            this.lbLargura.TabIndex = 38;
            this.lbLargura.Text = "Largura";
            this.lbLargura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbAlturaUtil
            // 
            this.lbAlturaUtil.AutoSize = true;
            this.lbAlturaUtil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAlturaUtil.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbAlturaUtil.ForeColor = System.Drawing.Color.DimGray;
            this.lbAlturaUtil.Location = new System.Drawing.Point(277, 5);
            this.lbAlturaUtil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAlturaUtil.Name = "lbAlturaUtil";
            this.lbAlturaUtil.Size = new System.Drawing.Size(266, 39);
            this.lbAlturaUtil.TabIndex = 38;
            this.lbAlturaUtil.Text = "Altura útil";
            this.lbAlturaUtil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtLargura
            // 
            this.txtLargura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLargura.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtLargura.Location = new System.Drawing.Point(15, 48);
            this.txtLargura.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(250, 32);
            this.txtLargura.TabIndex = 0;
            this.txtLargura.Tag = "cm";
            this.txtLargura.Text = "0 cm";
            this.txtLargura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtLargura, "Largura da nervura em cm");
            this.txtLargura.Click += new System.EventHandler(this.textBoxSelectAllOnEnter);
            this.txtLargura.Enter += new System.EventHandler(this.textBoxSelectAllOnEnter);
            this.txtLargura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAllowNumericOnly);
            this.txtLargura.Leave += new System.EventHandler(this.textBoxSplitOnLeave);
            // 
            // txtAlturaUtil
            // 
            this.txtAlturaUtil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlturaUtil.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAlturaUtil.Location = new System.Drawing.Point(285, 48);
            this.txtAlturaUtil.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtAlturaUtil.Name = "txtAlturaUtil";
            this.txtAlturaUtil.Size = new System.Drawing.Size(250, 32);
            this.txtAlturaUtil.TabIndex = 1;
            this.txtAlturaUtil.Tag = "cm";
            this.txtAlturaUtil.Text = "0 cm";
            this.txtAlturaUtil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtAlturaUtil, "Altura útil da seção em cm");
            this.txtAlturaUtil.Click += new System.EventHandler(this.textBoxSelectAllOnEnter);
            this.txtAlturaUtil.Enter += new System.EventHandler(this.textBoxSelectAllOnEnter);
            this.txtAlturaUtil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAllowNumericOnly);
            this.txtAlturaUtil.Leave += new System.EventHandler(this.textBoxSplitOnLeave);
            // 
            // lbAco
            // 
            this.lbAco.AutoSize = true;
            this.lbAco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAco.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbAco.ForeColor = System.Drawing.Color.DimGray;
            this.lbAco.Location = new System.Drawing.Point(385, 5);
            this.lbAco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAco.Name = "lbAco";
            this.lbAco.Size = new System.Drawing.Size(158, 30);
            this.lbAco.TabIndex = 38;
            this.lbAco.Text = "Aço";
            this.lbAco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResistenciaCaracteristica
            // 
            this.lbResistenciaCaracteristica.AutoSize = true;
            this.lbResistenciaCaracteristica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResistenciaCaracteristica.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbResistenciaCaracteristica.ForeColor = System.Drawing.Color.DimGray;
            this.lbResistenciaCaracteristica.Location = new System.Drawing.Point(7, 5);
            this.lbResistenciaCaracteristica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbResistenciaCaracteristica.Name = "lbResistenciaCaracteristica";
            this.lbResistenciaCaracteristica.Size = new System.Drawing.Size(374, 30);
            this.lbResistenciaCaracteristica.TabIndex = 38;
            this.lbResistenciaCaracteristica.Text = "Resistência Característica do Concreto";
            this.lbResistenciaCaracteristica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablePanelMateriais
            // 
            this.tablePanelMateriais.ColumnCount = 2;
            this.tablePanelMateriais.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tablePanelMateriais.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tablePanelMateriais.Controls.Add(this.lbAco, 1, 0);
            this.tablePanelMateriais.Controls.Add(this.lbResistenciaCaracteristica, 0, 0);
            this.tablePanelMateriais.Controls.Add(this.ComboBoxAco, 1, 1);
            this.tablePanelMateriais.Controls.Add(this.txtFck, 0, 1);
            this.tablePanelMateriais.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanelMateriais.Location = new System.Drawing.Point(0, 0);
            this.tablePanelMateriais.Margin = new System.Windows.Forms.Padding(5);
            this.tablePanelMateriais.Name = "tablePanelMateriais";
            this.tablePanelMateriais.Padding = new System.Windows.Forms.Padding(5);
            this.tablePanelMateriais.RowCount = 2;
            this.tablePanelMateriais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tablePanelMateriais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tablePanelMateriais.Size = new System.Drawing.Size(550, 76);
            this.tablePanelMateriais.TabIndex = 0;
            // 
            // ComboBoxAco
            // 
            this.ComboBoxAco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBoxAco.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ComboBoxAco.FormattingEnabled = true;
            this.ComboBoxAco.Location = new System.Drawing.Point(393, 37);
            this.ComboBoxAco.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ComboBoxAco.Name = "ComboBoxAco";
            this.ComboBoxAco.Size = new System.Drawing.Size(142, 31);
            this.ComboBoxAco.TabIndex = 1;
            this.toolTip1.SetToolTip(this.ComboBoxAco, "Aço utilizado para as armaduras");
            // 
            // txtFck
            // 
            this.txtFck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFck.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtFck.Location = new System.Drawing.Point(15, 37);
            this.txtFck.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtFck.Name = "txtFck";
            this.txtFck.Size = new System.Drawing.Size(358, 32);
            this.txtFck.TabIndex = 0;
            this.txtFck.Tag = "MPa";
            this.txtFck.Text = "0 MPa";
            this.txtFck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtFck, "Resistência característica do concreto em MPa");
            this.txtFck.Click += new System.EventHandler(this.textBoxSelectAllOnEnter);
            this.txtFck.Enter += new System.EventHandler(this.textBoxSelectAllOnEnter);
            this.txtFck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAllowNumericOnly);
            this.txtFck.Leave += new System.EventHandler(this.textBoxSplitOnLeave);
            // 
            // tablePanelModelo
            // 
            this.tablePanelModelo.ColumnCount = 3;
            this.tablePanelModelo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tablePanelModelo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tablePanelModelo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tablePanelModelo.Controls.Add(this.lbModelo, 0, 0);
            this.tablePanelModelo.Controls.Add(this.rbModeloII, 2, 0);
            this.tablePanelModelo.Controls.Add(this.rbModeloI, 1, 0);
            this.tablePanelModelo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanelModelo.Location = new System.Drawing.Point(0, 76);
            this.tablePanelModelo.Name = "tablePanelModelo";
            this.tablePanelModelo.RowCount = 1;
            this.tablePanelModelo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelModelo.Size = new System.Drawing.Size(550, 54);
            this.tablePanelModelo.TabIndex = 1;
            // 
            // lbModelo
            // 
            this.lbModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbModelo.AutoSize = true;
            this.lbModelo.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbModelo.ForeColor = System.Drawing.Color.DimGray;
            this.lbModelo.Location = new System.Drawing.Point(116, 17);
            this.lbModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(152, 20);
            this.lbModelo.TabIndex = 41;
            this.lbModelo.Text = "Modelo de Cálculo";
            this.lbModelo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // rbModeloII
            // 
            this.rbModeloII.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbModeloII.AutoSize = true;
            this.rbModeloII.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rbModeloII.Location = new System.Drawing.Point(488, 13);
            this.rbModeloII.Margin = new System.Windows.Forms.Padding(0);
            this.rbModeloII.Name = "rbModeloII";
            this.rbModeloII.Size = new System.Drawing.Size(41, 27);
            this.rbModeloII.TabIndex = 1;
            this.rbModeloII.Text = "II";
            this.toolTip1.SetToolTip(this.rbModeloII, "Utilizar o modelo de cálculo II");
            this.rbModeloII.UseVisualStyleBackColor = true;
            this.rbModeloII.CheckedChanged += new System.EventHandler(this.rbModeloII_CheckChanged);
            // 
            // rbModeloI
            // 
            this.rbModeloI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbModeloI.AutoSize = true;
            this.rbModeloI.Checked = true;
            this.rbModeloI.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rbModeloI.Location = new System.Drawing.Point(408, 13);
            this.rbModeloI.Margin = new System.Windows.Forms.Padding(0);
            this.rbModeloI.Name = "rbModeloI";
            this.rbModeloI.Size = new System.Drawing.Size(36, 27);
            this.rbModeloI.TabIndex = 0;
            this.rbModeloI.TabStop = true;
            this.rbModeloI.Text = "I";
            this.toolTip1.SetToolTip(this.rbModeloI, "Utilizar o modelo de cálculo I");
            this.rbModeloI.UseVisualStyleBackColor = true;
            // 
            // tablePanelAngulos
            // 
            this.tablePanelAngulos.ColumnCount = 2;
            this.tablePanelAngulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelAngulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelAngulos.Controls.Add(this.lbEstribo, 1, 0);
            this.tablePanelAngulos.Controls.Add(this.lbBiela, 0, 0);
            this.tablePanelAngulos.Controls.Add(this.txtInclinacaoBiela, 0, 1);
            this.tablePanelAngulos.Controls.Add(this.txtInclinacaoEstribo, 1, 1);
            this.tablePanelAngulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanelAngulos.Location = new System.Drawing.Point(0, 130);
            this.tablePanelAngulos.Name = "tablePanelAngulos";
            this.tablePanelAngulos.RowCount = 2;
            this.tablePanelAngulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelAngulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelAngulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelAngulos.Size = new System.Drawing.Size(550, 66);
            this.tablePanelAngulos.TabIndex = 2;
            // 
            // lbEstribo
            // 
            this.lbEstribo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbEstribo.AutoSize = true;
            this.lbEstribo.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbEstribo.ForeColor = System.Drawing.Color.DimGray;
            this.lbEstribo.Location = new System.Drawing.Point(330, 13);
            this.lbEstribo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEstribo.Name = "lbEstribo";
            this.lbEstribo.Size = new System.Drawing.Size(165, 20);
            this.lbEstribo.TabIndex = 38;
            this.lbEstribo.Text = "Inclinação do estribo";
            this.lbEstribo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbBiela
            // 
            this.lbBiela.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbBiela.AutoSize = true;
            this.lbBiela.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbBiela.ForeColor = System.Drawing.Color.DimGray;
            this.lbBiela.Location = new System.Drawing.Point(61, 13);
            this.lbBiela.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBiela.Name = "lbBiela";
            this.lbBiela.Size = new System.Drawing.Size(152, 20);
            this.lbBiela.TabIndex = 38;
            this.lbBiela.Text = "Inclinação da biela";
            this.lbBiela.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtInclinacaoBiela
            // 
            this.txtInclinacaoBiela.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtInclinacaoBiela.Enabled = false;
            this.txtInclinacaoBiela.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtInclinacaoBiela.Location = new System.Drawing.Point(37, 33);
            this.txtInclinacaoBiela.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtInclinacaoBiela.Name = "txtInclinacaoBiela";
            this.txtInclinacaoBiela.Size = new System.Drawing.Size(200, 32);
            this.txtInclinacaoBiela.TabIndex = 0;
            this.txtInclinacaoBiela.Tag = "º";
            this.txtInclinacaoBiela.Text = "45 º";
            this.txtInclinacaoBiela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtInclinacaoBiela, "Inclinação das bielas");
            this.txtInclinacaoBiela.Click += new System.EventHandler(this.textBoxSelectAllOnEnter);
            this.txtInclinacaoBiela.Enter += new System.EventHandler(this.textBoxSelectAllOnEnter);
            this.txtInclinacaoBiela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAllowNumericOnly);
            this.txtInclinacaoBiela.Leave += new System.EventHandler(this.textBoxSplitOnLeave);
            // 
            // txtInclinacaoEstribo
            // 
            this.txtInclinacaoEstribo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInclinacaoEstribo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtInclinacaoEstribo.Location = new System.Drawing.Point(285, 33);
            this.txtInclinacaoEstribo.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtInclinacaoEstribo.Name = "txtInclinacaoEstribo";
            this.txtInclinacaoEstribo.Size = new System.Drawing.Size(255, 32);
            this.txtInclinacaoEstribo.TabIndex = 1;
            this.txtInclinacaoEstribo.Tag = "º";
            this.txtInclinacaoEstribo.Text = "90 º";
            this.txtInclinacaoEstribo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtInclinacaoEstribo, "Inclinação dos estribos");
            this.txtInclinacaoEstribo.Click += new System.EventHandler(this.textBoxSelectAllOnEnter);
            this.txtInclinacaoEstribo.Enter += new System.EventHandler(this.textBoxSelectAllOnEnter);
            this.txtInclinacaoEstribo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAllowNumericOnly);
            this.txtInclinacaoEstribo.Leave += new System.EventHandler(this.textBoxSplitOnLeave);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // ucCisalhamento
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanelResults);
            this.Controls.Add(this.tablePanelMdAs);
            this.Controls.Add(this.tablePanelSecaoRetangular);
            this.Controls.Add(this.tablePanelAngulos);
            this.Controls.Add(this.tablePanelModelo);
            this.Controls.Add(this.tablePanelMateriais);
            this.MaximumSize = new System.Drawing.Size(550, 550);
            this.MinimumSize = new System.Drawing.Size(550, 550);
            this.Name = "ucCisalhamento";
            this.Size = new System.Drawing.Size(550, 550);
            this.tablePanelMdAs.ResumeLayout(false);
            this.tablePanelMdAs.PerformLayout();
            this.tableLayoutPanelResults.ResumeLayout(false);
            this.tableLayoutPanelResults.PerformLayout();
            this.tablePanelSecaoRetangular.ResumeLayout(false);
            this.tablePanelSecaoRetangular.PerformLayout();
            this.tablePanelMateriais.ResumeLayout(false);
            this.tablePanelMateriais.PerformLayout();
            this.tablePanelModelo.ResumeLayout(false);
            this.tablePanelModelo.PerformLayout();
            this.tablePanelAngulos.ResumeLayout(false);
            this.tablePanelAngulos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablePanelMdAs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelResults;
        private System.Windows.Forms.Label lbVRd2Titulo;
        private System.Windows.Forms.Label lbVrd2;
        private System.Windows.Forms.Label lbVc;
        private System.Windows.Forms.Label lbVcTitulo;
        private System.Windows.Forms.Label lbCortante;
        private System.Windows.Forms.Label lbAreaAco;
        private System.Windows.Forms.TableLayoutPanel tablePanelSecaoRetangular;
        private System.Windows.Forms.Label lbLargura;
        private System.Windows.Forms.Label lbAlturaUtil;
        private System.Windows.Forms.Label lbAco;
        private System.Windows.Forms.Label lbResistenciaCaracteristica;
        private System.Windows.Forms.TableLayoutPanel tablePanelMateriais;
        private System.Windows.Forms.TableLayoutPanel tablePanelModelo;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.TableLayoutPanel tablePanelAngulos;
        private System.Windows.Forms.Label lbEstribo;
        private System.Windows.Forms.Label lbBiela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCortante;
        private System.Windows.Forms.TextBox txtLargura;
        private System.Windows.Forms.TextBox txtAlturaUtil;
        private System.Windows.Forms.ComboBox ComboBoxAco;
        private System.Windows.Forms.TextBox txtInclinacaoBiela;
        private System.Windows.Forms.TextBox txtInclinacaoEstribo;
        private System.Windows.Forms.RadioButton rbModeloI;
        private System.Windows.Forms.RadioButton rbModeloII;
        private System.Windows.Forms.TextBox txtFck;
        private System.Windows.Forms.Label labelAreaTracionada;
        private System.Windows.Forms.Button btnCalculaAs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbArmaduraMinima;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
