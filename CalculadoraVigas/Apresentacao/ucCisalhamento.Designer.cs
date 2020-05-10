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
            this.btnCalculaAs = new Syncfusion.WinForms.Controls.SfButton();
            this.tableLayoutPanelResults = new System.Windows.Forms.TableLayoutPanel();
            this.lbVRd2Titulo = new System.Windows.Forms.Label();
            this.lbVrd2 = new System.Windows.Forms.Label();
            this.lbVc = new System.Windows.Forms.Label();
            this.lbVcTitulo = new System.Windows.Forms.Label();
            this.txtCortante = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.sfToolTip1 = new Syncfusion.Windows.Forms.SfToolTip(this.components);
            this.sfComboBoxAco = new Syncfusion.WinForms.ListView.SfComboBox();
            this.txtAreaTracionada = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.txtLargura = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.txtAlturaUtil = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.txtFck = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.rbModeloII = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.rbModeloI = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.txtInclinacaoBiela = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.txtInclinacaoEstribo = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.tablePanelSolucao = new System.Windows.Forms.TableLayoutPanel();
            this.lbCortante = new System.Windows.Forms.Label();
            this.lbAreaAco = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tablePanelSecaoRetangular = new System.Windows.Forms.TableLayoutPanel();
            this.lbLargura = new System.Windows.Forms.Label();
            this.lbAlturaUtil = new System.Windows.Forms.Label();
            this.lbAco = new System.Windows.Forms.Label();
            this.lbResistenciaCaracteristica = new System.Windows.Forms.Label();
            this.tablePanelMateriais = new System.Windows.Forms.TableLayoutPanel();
            this.tablePanelModelo = new System.Windows.Forms.TableLayoutPanel();
            this.lbModelo = new System.Windows.Forms.Label();
            this.tablePanelAngulos = new System.Windows.Forms.TableLayoutPanel();
            this.lbEstribo = new System.Windows.Forms.Label();
            this.lbBiela = new System.Windows.Forms.Label();
            this.tablePanelMdAs.SuspendLayout();
            this.tableLayoutPanelResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBoxAco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbModeloII)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbModeloI)).BeginInit();
            this.tablePanelSolucao.SuspendLayout();
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
            this.tablePanelMdAs.Controls.Add(this.btnCalculaAs, 1, 0);
            this.tablePanelMdAs.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanelMdAs.Location = new System.Drawing.Point(0, 377);
            this.tablePanelMdAs.Margin = new System.Windows.Forms.Padding(5);
            this.tablePanelMdAs.Name = "tablePanelMdAs";
            this.tablePanelMdAs.Padding = new System.Windows.Forms.Padding(5);
            this.tablePanelMdAs.RowCount = 1;
            this.tablePanelMdAs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelMdAs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tablePanelMdAs.Size = new System.Drawing.Size(550, 62);
            this.tablePanelMdAs.TabIndex = 5;
            // 
            // btnCalculaAs
            // 
            this.btnCalculaAs.AccessibleName = "Button";
            this.btnCalculaAs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalculaAs.BackColor = System.Drawing.Color.White;
            this.btnCalculaAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculaAs.FocusRectangleVisible = true;
            this.btnCalculaAs.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnCalculaAs.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnCalculaAs.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCalculaAs.Location = new System.Drawing.Point(384, 6);
            this.btnCalculaAs.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalculaAs.Name = "btnCalculaAs";
            this.btnCalculaAs.Size = new System.Drawing.Size(50, 50);
            this.btnCalculaAs.Style.BackColor = System.Drawing.Color.White;
            this.btnCalculaAs.Style.DisabledBackColor = System.Drawing.Color.Empty;
            this.btnCalculaAs.Style.DisabledForeColor = System.Drawing.Color.Empty;
            this.btnCalculaAs.Style.FocusedBackColor = System.Drawing.Color.Empty;
            this.btnCalculaAs.Style.FocusedForeColor = System.Drawing.Color.Empty;
            this.btnCalculaAs.Style.ForeColor = System.Drawing.Color.Empty;
            this.btnCalculaAs.Style.HoverBackColor = System.Drawing.Color.Empty;
            this.btnCalculaAs.Style.HoverForeColor = System.Drawing.Color.Empty;
            this.btnCalculaAs.Style.HoverImage = global::CalculadoraVigas.Properties.Resources.as_hover;
            this.btnCalculaAs.Style.Image = global::CalculadoraVigas.Properties.Resources.as_normal;
            this.btnCalculaAs.Style.PressedBackColor = System.Drawing.Color.Empty;
            this.btnCalculaAs.Style.PressedImage = global::CalculadoraVigas.Properties.Resources.as_clique;
            this.btnCalculaAs.TabIndex = 1;
            this.btnCalculaAs.TextMargin = new System.Windows.Forms.Padding(0);
            this.sfToolTip1.SetToolTip(this.btnCalculaAs, "Selecione essa opção para calcular a área de aço necessária para determinado cort" +
        "ante de cálculo.");
            this.btnCalculaAs.UseVisualStyleBackColor = false;
            this.btnCalculaAs.Click += new System.EventHandler(this.btnCalculaAs_Click);
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
            this.tableLayoutPanelResults.Location = new System.Drawing.Point(0, 439);
            this.tableLayoutPanelResults.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanelResults.Name = "tableLayoutPanelResults";
            this.tableLayoutPanelResults.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanelResults.RowCount = 2;
            this.tableLayoutPanelResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.5098F));
            this.tableLayoutPanelResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.4902F));
            this.tableLayoutPanelResults.Size = new System.Drawing.Size(550, 111);
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
            this.lbVRd2Titulo.Size = new System.Drawing.Size(47, 20);
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
            this.lbVrd2.Location = new System.Drawing.Point(7, 29);
            this.lbVrd2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVrd2.Name = "lbVrd2";
            this.lbVrd2.Size = new System.Drawing.Size(266, 77);
            this.lbVrd2.TabIndex = 0;
            this.lbVrd2.Text = "0,00 kN";
            this.lbVrd2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbVc
            // 
            this.lbVc.AutoSize = true;
            this.lbVc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbVc.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbVc.ForeColor = System.Drawing.Color.Black;
            this.lbVc.Location = new System.Drawing.Point(277, 29);
            this.lbVc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVc.Name = "lbVc";
            this.lbVc.Size = new System.Drawing.Size(266, 77);
            this.lbVc.TabIndex = 0;
            this.lbVc.Text = "0,00 kN";
            this.lbVc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lbVcTitulo.Size = new System.Drawing.Size(30, 20);
            this.lbVcTitulo.TabIndex = 36;
            this.lbVcTitulo.Text = "Vc";
            this.lbVcTitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtCortante
            // 
            this.txtCortante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCortante.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtCortante.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCortante.HideTrailingZeros = true;
            this.txtCortante.Location = new System.Drawing.Point(60, 32);
            this.txtCortante.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtCortante.MinValue = 0D;
            this.txtCortante.Name = "txtCortante";
            this.txtCortante.Size = new System.Drawing.Size(160, 32);
            this.txtCortante.Suffix = "kN";
            this.txtCortante.TabIndex = 0;
            this.txtCortante.Text = "0 kN";
            this.txtCortante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sfToolTip1.SetToolTip(this.txtCortante, "Valor cortante de cálculo.");
            this.txtCortante.WatermarkText = "kN";
            // 
            // sfComboBoxAco
            // 
            this.sfComboBoxAco.BackColor = System.Drawing.Color.White;
            this.sfComboBoxAco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sfComboBoxAco.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sfComboBoxAco.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.sfComboBoxAco.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.sfComboBoxAco.ForeColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Location = new System.Drawing.Point(403, 39);
            this.sfComboBoxAco.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.sfComboBoxAco.Name = "sfComboBoxAco";
            this.sfComboBoxAco.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.sfComboBoxAco.Size = new System.Drawing.Size(122, 32);
            this.sfComboBoxAco.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sfComboBoxAco.Style.DropDownButtonStyle.BackColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.DropDownButtonStyle.DisabledBackColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.DropDownButtonStyle.DisabledForeColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.DropDownButtonStyle.FocusedBackColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.DropDownButtonStyle.FocusedForeColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.DropDownButtonStyle.ForeColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.DropDownButtonStyle.HoverBackColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.DropDownButtonStyle.HoverForeColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.DropDownButtonStyle.PressedBackColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.DropDownButtonStyle.PressedForeColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.DropDownStyle.BorderColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.DropDownStyle.GripperForeColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.EditorStyle.BorderColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.EditorStyle.DisabledBackColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.EditorStyle.DisabledBorderColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.EditorStyle.DisabledForeColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.EditorStyle.DisabledWatermarkForeColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.EditorStyle.FocusedBorderColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.EditorStyle.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.sfComboBoxAco.Style.EditorStyle.ForeColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.ReadOnlyEditorStyle.BackColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.ReadOnlyEditorStyle.BorderColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.ReadOnlyEditorStyle.DisabledBackColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.ReadOnlyEditorStyle.DisabledBorderColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.sfComboBoxAco.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfComboBoxAco.Style.TokenStyle.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.sfComboBoxAco.TabIndex = 2;
            this.sfToolTip1.SetToolTip(this.sfComboBoxAco, "Tipo de aço utilizado.");
            // 
            // txtAreaTracionada
            // 
            this.txtAreaTracionada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAreaTracionada.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAreaTracionada.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAreaTracionada.HideTrailingZeros = true;
            this.txtAreaTracionada.Location = new System.Drawing.Point(330, 32);
            this.txtAreaTracionada.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtAreaTracionada.Name = "txtAreaTracionada";
            this.txtAreaTracionada.ReadOnly = true;
            this.txtAreaTracionada.Size = new System.Drawing.Size(160, 32);
            this.txtAreaTracionada.Suffix = "cm²/m";
            this.txtAreaTracionada.TabIndex = 1;
            this.txtAreaTracionada.Text = "0 cm²/m";
            this.txtAreaTracionada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sfToolTip1.SetToolTip(this.txtAreaTracionada, "Área de aço transversal a ser calculada. Resultado indica a área total em cm²/m (" +
        "ex: para estribos de dois ramos, dividir a área por 2 antes de entrar na tabela)" +
        ".");
            this.txtAreaTracionada.WatermarkText = "cm²/m";
            // 
            // txtLargura
            // 
            this.txtLargura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLargura.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtLargura.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLargura.HideTrailingZeros = true;
            this.txtLargura.Location = new System.Drawing.Point(60, 48);
            this.txtLargura.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtLargura.MinValue = 0D;
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(160, 32);
            this.txtLargura.Suffix = "cm";
            this.txtLargura.TabIndex = 0;
            this.txtLargura.Text = "0 cm";
            this.txtLargura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sfToolTip1.SetToolTip(this.txtLargura, "Largura da nervura (bw na literatura).");
            this.txtLargura.WatermarkText = "cm";
            // 
            // txtAlturaUtil
            // 
            this.txtAlturaUtil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlturaUtil.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAlturaUtil.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAlturaUtil.HideTrailingZeros = true;
            this.txtAlturaUtil.Location = new System.Drawing.Point(330, 48);
            this.txtAlturaUtil.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtAlturaUtil.MinValue = 0D;
            this.txtAlturaUtil.Name = "txtAlturaUtil";
            this.txtAlturaUtil.Size = new System.Drawing.Size(160, 32);
            this.txtAlturaUtil.Suffix = "cm";
            this.txtAlturaUtil.TabIndex = 1;
            this.txtAlturaUtil.Text = "0 cm";
            this.txtAlturaUtil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sfToolTip1.SetToolTip(this.txtAlturaUtil, "Altura útil da seção (denominada como d na literatura).");
            this.txtAlturaUtil.WatermarkText = "cm";
            // 
            // txtFck
            // 
            this.txtFck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtFck.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtFck.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFck.HideTrailingZeros = true;
            this.txtFck.Location = new System.Drawing.Point(25, 39);
            this.txtFck.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtFck.MaxValue = 50D;
            this.txtFck.MinValue = 0D;
            this.txtFck.Name = "txtFck";
            this.txtFck.Prefix = "";
            this.txtFck.Size = new System.Drawing.Size(338, 32);
            this.txtFck.Suffix = "MPa";
            this.txtFck.TabIndex = 0;
            this.txtFck.Text = "0 MPa";
            this.txtFck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sfToolTip1.SetToolTip(this.txtFck, "Resistência característica do concreto (fck na literatura).");
            this.txtFck.WatermarkText = "MPa";
            // 
            // rbModeloII
            // 
            this.rbModeloII.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbModeloII.AutoSize = true;
            this.rbModeloII.BeforeTouchSize = new System.Drawing.Size(38, 26);
            this.rbModeloII.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rbModeloII.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.rbModeloII.Location = new System.Drawing.Point(470, 14);
            this.rbModeloII.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.rbModeloII.Name = "rbModeloII";
            this.rbModeloII.Size = new System.Drawing.Size(38, 26);
            this.rbModeloII.TabIndex = 44;
            this.rbModeloII.TabStop = false;
            this.rbModeloII.Text = "II";
            this.sfToolTip1.SetToolTip(this.rbModeloII, "Selecione para considerar o Modelo II da norma brasileira.");
            this.rbModeloII.CheckChanged += new System.EventHandler(this.rbModeloII_CheckChanged);
            // 
            // rbModeloI
            // 
            this.rbModeloI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbModeloI.AutoSize = true;
            this.rbModeloI.BeforeTouchSize = new System.Drawing.Size(33, 26);
            this.rbModeloI.Checked = true;
            this.rbModeloI.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rbModeloI.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.rbModeloI.Location = new System.Drawing.Point(409, 14);
            this.rbModeloI.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.rbModeloI.Name = "rbModeloI";
            this.rbModeloI.Size = new System.Drawing.Size(33, 26);
            this.rbModeloI.TabIndex = 43;
            this.rbModeloI.Text = "I";
            this.sfToolTip1.SetToolTip(this.rbModeloI, "Selecione para considerar o Modelo I da norma brasileira.");
            // 
            // txtInclinacaoBiela
            // 
            this.txtInclinacaoBiela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInclinacaoBiela.Enabled = false;
            this.txtInclinacaoBiela.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtInclinacaoBiela.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInclinacaoBiela.HideTrailingZeros = true;
            this.txtInclinacaoBiela.Location = new System.Drawing.Point(57, 33);
            this.txtInclinacaoBiela.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtInclinacaoBiela.MaxValue = 45D;
            this.txtInclinacaoBiela.MinValue = 30D;
            this.txtInclinacaoBiela.Name = "txtInclinacaoBiela";
            this.txtInclinacaoBiela.Size = new System.Drawing.Size(160, 32);
            this.txtInclinacaoBiela.Suffix = "º";
            this.txtInclinacaoBiela.TabIndex = 0;
            this.txtInclinacaoBiela.Text = "45 º";
            this.txtInclinacaoBiela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sfToolTip1.SetToolTip(this.txtInclinacaoBiela, "Inclinação das bielas. Deve ser de 30º a 45º.");
            this.txtInclinacaoBiela.Value = 45D;
            this.txtInclinacaoBiela.WatermarkText = "º";
            // 
            // txtInclinacaoEstribo
            // 
            this.txtInclinacaoEstribo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInclinacaoEstribo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtInclinacaoEstribo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInclinacaoEstribo.HideTrailingZeros = true;
            this.txtInclinacaoEstribo.Location = new System.Drawing.Point(332, 33);
            this.txtInclinacaoEstribo.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtInclinacaoEstribo.MaxValue = 90D;
            this.txtInclinacaoEstribo.MinValue = 45D;
            this.txtInclinacaoEstribo.Name = "txtInclinacaoEstribo";
            this.txtInclinacaoEstribo.Size = new System.Drawing.Size(160, 32);
            this.txtInclinacaoEstribo.Suffix = "º";
            this.txtInclinacaoEstribo.TabIndex = 1;
            this.txtInclinacaoEstribo.Text = "90 º";
            this.txtInclinacaoEstribo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sfToolTip1.SetToolTip(this.txtInclinacaoEstribo, "Inclinação dos estribos. Deve ser de 45º a 90º.");
            this.txtInclinacaoEstribo.Value = 90D;
            this.txtInclinacaoEstribo.WatermarkText = "º";
            // 
            // tablePanelSolucao
            // 
            this.tablePanelSolucao.ColumnCount = 2;
            this.tablePanelSolucao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelSolucao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelSolucao.Controls.Add(this.lbCortante, 0, 0);
            this.tablePanelSolucao.Controls.Add(this.lbAreaAco, 1, 0);
            this.tablePanelSolucao.Controls.Add(this.txtCortante, 0, 1);
            this.tablePanelSolucao.Controls.Add(this.txtAreaTracionada, 1, 1);
            this.tablePanelSolucao.Controls.Add(this.label2, 1, 2);
            this.tablePanelSolucao.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanelSolucao.Location = new System.Drawing.Point(0, 285);
            this.tablePanelSolucao.Margin = new System.Windows.Forms.Padding(5);
            this.tablePanelSolucao.Name = "tablePanelSolucao";
            this.tablePanelSolucao.Padding = new System.Windows.Forms.Padding(5);
            this.tablePanelSolucao.RowCount = 3;
            this.tablePanelSolucao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.96386F));
            this.tablePanelSolucao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.03614F));
            this.tablePanelSolucao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelSolucao.Size = new System.Drawing.Size(550, 92);
            this.tablePanelSolucao.TabIndex = 4;
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
            this.tablePanelMateriais.Controls.Add(this.sfComboBoxAco);
            this.tablePanelMateriais.Controls.Add(this.lbAco, 1, 0);
            this.tablePanelMateriais.Controls.Add(this.lbResistenciaCaracteristica, 0, 0);
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
            // tablePanelModelo
            // 
            this.tablePanelModelo.ColumnCount = 3;
            this.tablePanelModelo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tablePanelModelo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tablePanelModelo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tablePanelModelo.Controls.Add(this.rbModeloII, 2, 0);
            this.tablePanelModelo.Controls.Add(this.lbModelo, 0, 0);
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
            // tablePanelAngulos
            // 
            this.tablePanelAngulos.ColumnCount = 2;
            this.tablePanelAngulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelAngulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelAngulos.Controls.Add(this.lbEstribo, 1, 0);
            this.tablePanelAngulos.Controls.Add(this.txtInclinacaoBiela, 0, 1);
            this.tablePanelAngulos.Controls.Add(this.lbBiela, 0, 0);
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
            // ucCisalhamento
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanelResults);
            this.Controls.Add(this.tablePanelMdAs);
            this.Controls.Add(this.tablePanelSolucao);
            this.Controls.Add(this.tablePanelSecaoRetangular);
            this.Controls.Add(this.tablePanelAngulos);
            this.Controls.Add(this.tablePanelModelo);
            this.Controls.Add(this.tablePanelMateriais);
            this.MaximumSize = new System.Drawing.Size(550, 550);
            this.MinimumSize = new System.Drawing.Size(550, 550);
            this.Name = "ucCisalhamento";
            this.Size = new System.Drawing.Size(550, 550);
            this.tablePanelMdAs.ResumeLayout(false);
            this.tableLayoutPanelResults.ResumeLayout(false);
            this.tableLayoutPanelResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBoxAco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbModeloII)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbModeloI)).EndInit();
            this.tablePanelSolucao.ResumeLayout(false);
            this.tablePanelSolucao.PerformLayout();
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
        private Syncfusion.WinForms.Controls.SfButton btnCalculaAs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelResults;
        private System.Windows.Forms.Label lbVRd2Titulo;
        private System.Windows.Forms.Label lbVrd2;
        private System.Windows.Forms.Label lbVc;
        private System.Windows.Forms.Label lbVcTitulo;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtCortante;
        private Syncfusion.Windows.Forms.SfToolTip sfToolTip1;
        private System.Windows.Forms.TableLayoutPanel tablePanelSolucao;
        private System.Windows.Forms.Label lbCortante;
        private System.Windows.Forms.Label lbAreaAco;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtAreaTracionada;
        private System.Windows.Forms.TableLayoutPanel tablePanelSecaoRetangular;
        private System.Windows.Forms.Label lbLargura;
        private System.Windows.Forms.Label lbAlturaUtil;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtLargura;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtAlturaUtil;
        private System.Windows.Forms.Label lbAco;
        private System.Windows.Forms.Label lbResistenciaCaracteristica;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtFck;
        private System.Windows.Forms.TableLayoutPanel tablePanelMateriais;
        private System.Windows.Forms.TableLayoutPanel tablePanelModelo;
        private Syncfusion.WinForms.ListView.SfComboBox sfComboBoxAco;
        private System.Windows.Forms.Label lbModelo;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbModeloII;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv rbModeloI;
        private System.Windows.Forms.TableLayoutPanel tablePanelAngulos;
        private System.Windows.Forms.Label lbEstribo;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtInclinacaoBiela;
        private System.Windows.Forms.Label lbBiela;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtInclinacaoEstribo;
        private System.Windows.Forms.Label label2;
    }
}
