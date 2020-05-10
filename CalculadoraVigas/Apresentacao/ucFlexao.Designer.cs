namespace CalculadoraVigas.Apresentacao
{
    partial class ucFlexao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucFlexao));
            this.tablePanelMateriais = new System.Windows.Forms.TableLayoutPanel();
            this.lbAco = new System.Windows.Forms.Label();
            this.lbFck = new System.Windows.Forms.Label();
            this.txtFck = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.sfComboBoxAco = new Syncfusion.WinForms.ListView.SfComboBox();
            this.tablePanelRetangular = new System.Windows.Forms.TableLayoutPanel();
            this.lbFormatoSecao = new System.Windows.Forms.Label();
            this.btnSecaoRetangular = new Syncfusion.WinForms.Controls.SfButton();
            this.btnSecaoT = new Syncfusion.WinForms.Controls.SfButton();
            this.lbSecaoRetangular = new System.Windows.Forms.Label();
            this.lbSecaoT = new System.Windows.Forms.Label();
            this.tablePanelSecaoRetangular = new System.Windows.Forms.TableLayoutPanel();
            this.lbLargura = new System.Windows.Forms.Label();
            this.lbAltura = new System.Windows.Forms.Label();
            this.lbDLinhaSuperior = new System.Windows.Forms.Label();
            this.lbDLinhaInferior = new System.Windows.Forms.Label();
            this.txtLargura = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.txtAltura = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.txtDLinhaInferior = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.txtDLinhaSuperior = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.tablePanelSecaoT = new System.Windows.Forms.TableLayoutPanel();
            this.lbLarguraColaborante = new System.Windows.Forms.Label();
            this.lbEspessuraMesa = new System.Windows.Forms.Label();
            this.txtLarguraColaborante = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.txtEspessuraMesa = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.tablePanelMdAs = new System.Windows.Forms.TableLayoutPanel();
            this.btnCalculaAs = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCalculaMd = new Syncfusion.WinForms.Controls.SfButton();
            this.tableLayoutPanelResults = new System.Windows.Forms.TableLayoutPanel();
            this.lbAreaComprimida = new System.Windows.Forms.Label();
            this.lbRazaoLNTitulo = new System.Windows.Forms.Label();
            this.lbAreaComprimidaTitulo = new System.Windows.Forms.Label();
            this.lbRazaoLN = new System.Windows.Forms.Label();
            this.lbLinhaNeutraTitulo = new System.Windows.Forms.Label();
            this.lbLinhaNeutra = new System.Windows.Forms.Label();
            this.sfToolTip1 = new Syncfusion.Windows.Forms.SfToolTip(this.components);
            this.txtMomento = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.txtAreaTracionada = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.tablePanelSolucao = new System.Windows.Forms.TableLayoutPanel();
            this.lbMomento = new System.Windows.Forms.Label();
            this.lbAreaTracionada = new System.Windows.Forms.Label();
            this.lbArmaduraMinima = new System.Windows.Forms.Label();
            this.tablePanelMateriais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBoxAco)).BeginInit();
            this.tablePanelRetangular.SuspendLayout();
            this.tablePanelSecaoRetangular.SuspendLayout();
            this.tablePanelSecaoT.SuspendLayout();
            this.tablePanelMdAs.SuspendLayout();
            this.tableLayoutPanelResults.SuspendLayout();
            this.tablePanelSolucao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanelMateriais
            // 
            this.tablePanelMateriais.ColumnCount = 2;
            this.tablePanelMateriais.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tablePanelMateriais.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tablePanelMateriais.Controls.Add(this.lbAco, 1, 0);
            this.tablePanelMateriais.Controls.Add(this.lbFck, 0, 0);
            this.tablePanelMateriais.Controls.Add(this.txtFck, 0, 1);
            this.tablePanelMateriais.Controls.Add(this.sfComboBoxAco, 1, 1);
            this.tablePanelMateriais.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanelMateriais.Location = new System.Drawing.Point(0, 0);
            this.tablePanelMateriais.Margin = new System.Windows.Forms.Padding(5);
            this.tablePanelMateriais.Name = "tablePanelMateriais";
            this.tablePanelMateriais.Padding = new System.Windows.Forms.Padding(5);
            this.tablePanelMateriais.RowCount = 2;
            this.tablePanelMateriais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tablePanelMateriais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tablePanelMateriais.Size = new System.Drawing.Size(555, 76);
            this.tablePanelMateriais.TabIndex = 0;
            // 
            // lbAco
            // 
            this.lbAco.AutoSize = true;
            this.lbAco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAco.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbAco.ForeColor = System.Drawing.Color.DimGray;
            this.lbAco.Location = new System.Drawing.Point(388, 5);
            this.lbAco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAco.Name = "lbAco";
            this.lbAco.Size = new System.Drawing.Size(160, 30);
            this.lbAco.TabIndex = 38;
            this.lbAco.Text = "Aço";
            this.lbAco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFck
            // 
            this.lbFck.AutoSize = true;
            this.lbFck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFck.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbFck.ForeColor = System.Drawing.Color.DimGray;
            this.lbFck.Location = new System.Drawing.Point(7, 5);
            this.lbFck.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFck.Name = "lbFck";
            this.lbFck.Size = new System.Drawing.Size(377, 30);
            this.lbFck.TabIndex = 38;
            this.lbFck.Text = "Resistência Característica do Concreto";
            this.lbFck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txtFck.Size = new System.Drawing.Size(341, 32);
            this.txtFck.Suffix = "MPa";
            this.txtFck.TabIndex = 0;
            this.txtFck.Text = "0 MPa";
            this.txtFck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sfToolTip1.SetToolTip(this.txtFck, "Resistência característica do concreto (fck na literatura).");
            this.txtFck.WatermarkText = "MPa";
            this.txtFck.TextChanged += new System.EventHandler(this.txtFck_Changed);
            // 
            // sfComboBoxAco
            // 
            this.sfComboBoxAco.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sfComboBoxAco.BackColor = System.Drawing.Color.White;
            this.sfComboBoxAco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sfComboBoxAco.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.sfComboBoxAco.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.sfComboBoxAco.ForeColor = System.Drawing.Color.White;
            this.sfComboBoxAco.Location = new System.Drawing.Point(406, 39);
            this.sfComboBoxAco.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.sfComboBoxAco.Name = "sfComboBoxAco";
            this.sfComboBoxAco.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.sfComboBoxAco.Size = new System.Drawing.Size(124, 32);
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
            this.sfComboBoxAco.TabIndex = 1;
            this.sfToolTip1.SetToolTip(this.sfComboBoxAco, "Tipo de aço utilizado.");
            // 
            // tablePanelRetangular
            // 
            this.tablePanelRetangular.ColumnCount = 5;
            this.tablePanelRetangular.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.04587F));
            this.tablePanelRetangular.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.21101F));
            this.tablePanelRetangular.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.89908F));
            this.tablePanelRetangular.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.37615F));
            this.tablePanelRetangular.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.2844F));
            this.tablePanelRetangular.Controls.Add(this.lbFormatoSecao, 0, 0);
            this.tablePanelRetangular.Controls.Add(this.btnSecaoRetangular, 1, 0);
            this.tablePanelRetangular.Controls.Add(this.btnSecaoT, 3, 0);
            this.tablePanelRetangular.Controls.Add(this.lbSecaoRetangular, 2, 0);
            this.tablePanelRetangular.Controls.Add(this.lbSecaoT, 4, 0);
            this.tablePanelRetangular.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanelRetangular.Location = new System.Drawing.Point(0, 76);
            this.tablePanelRetangular.Margin = new System.Windows.Forms.Padding(5);
            this.tablePanelRetangular.Name = "tablePanelRetangular";
            this.tablePanelRetangular.Padding = new System.Windows.Forms.Padding(5);
            this.tablePanelRetangular.RowCount = 1;
            this.tablePanelRetangular.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelRetangular.Size = new System.Drawing.Size(555, 70);
            this.tablePanelRetangular.TabIndex = 1;
            // 
            // lbFormatoSecao
            // 
            this.lbFormatoSecao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFormatoSecao.AutoSize = true;
            this.lbFormatoSecao.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbFormatoSecao.ForeColor = System.Drawing.Color.DimGray;
            this.lbFormatoSecao.Location = new System.Drawing.Point(29, 25);
            this.lbFormatoSecao.Margin = new System.Windows.Forms.Padding(0);
            this.lbFormatoSecao.Name = "lbFormatoSecao";
            this.lbFormatoSecao.Size = new System.Drawing.Size(143, 20);
            this.lbFormatoSecao.TabIndex = 4;
            this.lbFormatoSecao.Text = "Formato da seção";
            this.lbFormatoSecao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSecaoRetangular
            // 
            this.btnSecaoRetangular.AccessibleName = "Button";
            this.btnSecaoRetangular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSecaoRetangular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecaoRetangular.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnSecaoRetangular.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnSecaoRetangular.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSecaoRetangular.Location = new System.Drawing.Point(207, 10);
            this.btnSecaoRetangular.Margin = new System.Windows.Forms.Padding(0);
            this.btnSecaoRetangular.Name = "btnSecaoRetangular";
            this.btnSecaoRetangular.Size = new System.Drawing.Size(50, 50);
            this.btnSecaoRetangular.Style.BackColor = System.Drawing.Color.White;
            this.btnSecaoRetangular.Style.DisabledBackColor = System.Drawing.Color.Empty;
            this.btnSecaoRetangular.Style.DisabledForeColor = System.Drawing.Color.Empty;
            this.btnSecaoRetangular.Style.FocusedBackColor = System.Drawing.Color.Empty;
            this.btnSecaoRetangular.Style.FocusedForeColor = System.Drawing.Color.Empty;
            this.btnSecaoRetangular.Style.ForeColor = System.Drawing.Color.Empty;
            this.btnSecaoRetangular.Style.HoverBackColor = System.Drawing.Color.Empty;
            this.btnSecaoRetangular.Style.HoverForeColor = System.Drawing.Color.Empty;
            this.btnSecaoRetangular.Style.HoverImage = ((System.Drawing.Image)(resources.GetObject("resource.HoverImage")));
            this.btnSecaoRetangular.Style.HoverImageForeColor = System.Drawing.Color.Empty;
            this.btnSecaoRetangular.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnSecaoRetangular.Style.PressedBackColor = System.Drawing.Color.Empty;
            this.btnSecaoRetangular.Style.PressedForeColor = System.Drawing.Color.Empty;
            this.btnSecaoRetangular.Style.PressedImage = ((System.Drawing.Image)(resources.GetObject("resource.PressedImage")));
            this.btnSecaoRetangular.TabIndex = 0;
            this.sfToolTip1.SetToolTip(this.btnSecaoRetangular, "Selecione para calcular uma seção retangular.");
            this.btnSecaoRetangular.Click += new System.EventHandler(this.btnSecaoRetangular_Click);
            // 
            // btnSecaoT
            // 
            this.btnSecaoT.AccessibleName = "Button";
            this.btnSecaoT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSecaoT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecaoT.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnSecaoT.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnSecaoT.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSecaoT.Location = new System.Drawing.Point(377, 10);
            this.btnSecaoT.Margin = new System.Windows.Forms.Padding(0);
            this.btnSecaoT.Name = "btnSecaoT";
            this.btnSecaoT.Size = new System.Drawing.Size(50, 50);
            this.btnSecaoT.Style.BackColor = System.Drawing.Color.White;
            this.btnSecaoT.Style.DisabledBackColor = System.Drawing.Color.Empty;
            this.btnSecaoT.Style.DisabledForeColor = System.Drawing.Color.Empty;
            this.btnSecaoT.Style.FocusedBackColor = System.Drawing.Color.Empty;
            this.btnSecaoT.Style.FocusedForeColor = System.Drawing.Color.Empty;
            this.btnSecaoT.Style.ForeColor = System.Drawing.Color.Empty;
            this.btnSecaoT.Style.HoverBackColor = System.Drawing.Color.Empty;
            this.btnSecaoT.Style.HoverForeColor = System.Drawing.Color.Empty;
            this.btnSecaoT.Style.HoverImage = global::CalculadoraVigas.Properties.Resources.t_hover;
            this.btnSecaoT.Style.Image = global::CalculadoraVigas.Properties.Resources.t_normal;
            this.btnSecaoT.Style.PressedBackColor = System.Drawing.Color.Empty;
            this.btnSecaoT.Style.PressedForeColor = System.Drawing.Color.Empty;
            this.btnSecaoT.Style.PressedImage = global::CalculadoraVigas.Properties.Resources.t_clique;
            this.btnSecaoT.TabIndex = 1;
            this.sfToolTip1.SetToolTip(this.btnSecaoT, "Selecione para calcular uma seção T.");
            this.btnSecaoT.Click += new System.EventHandler(this.btnSecaoT_Click);
            // 
            // lbSecaoRetangular
            // 
            this.lbSecaoRetangular.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbSecaoRetangular.AutoSize = true;
            this.lbSecaoRetangular.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbSecaoRetangular.ForeColor = System.Drawing.Color.Black;
            this.lbSecaoRetangular.Location = new System.Drawing.Point(268, 25);
            this.lbSecaoRetangular.Margin = new System.Windows.Forms.Padding(0);
            this.lbSecaoRetangular.Name = "lbSecaoRetangular";
            this.lbSecaoRetangular.Size = new System.Drawing.Size(89, 20);
            this.lbSecaoRetangular.TabIndex = 4;
            this.lbSecaoRetangular.Text = "Retangular";
            this.lbSecaoRetangular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSecaoT
            // 
            this.lbSecaoT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbSecaoT.AutoSize = true;
            this.lbSecaoT.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbSecaoT.ForeColor = System.Drawing.Color.Black;
            this.lbSecaoT.Location = new System.Drawing.Point(433, 25);
            this.lbSecaoT.Margin = new System.Windows.Forms.Padding(0);
            this.lbSecaoT.Name = "lbSecaoT";
            this.lbSecaoT.Size = new System.Drawing.Size(65, 20);
            this.lbSecaoT.TabIndex = 4;
            this.lbSecaoT.Text = "Seção T";
            this.lbSecaoT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablePanelSecaoRetangular
            // 
            this.tablePanelSecaoRetangular.ColumnCount = 4;
            this.tablePanelSecaoRetangular.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanelSecaoRetangular.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanelSecaoRetangular.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanelSecaoRetangular.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanelSecaoRetangular.Controls.Add(this.lbLargura, 0, 0);
            this.tablePanelSecaoRetangular.Controls.Add(this.lbAltura, 1, 0);
            this.tablePanelSecaoRetangular.Controls.Add(this.lbDLinhaSuperior, 3, 0);
            this.tablePanelSecaoRetangular.Controls.Add(this.lbDLinhaInferior, 2, 0);
            this.tablePanelSecaoRetangular.Controls.Add(this.txtLargura, 0, 1);
            this.tablePanelSecaoRetangular.Controls.Add(this.txtAltura, 1, 1);
            this.tablePanelSecaoRetangular.Controls.Add(this.txtDLinhaInferior, 2, 1);
            this.tablePanelSecaoRetangular.Controls.Add(this.txtDLinhaSuperior, 3, 1);
            this.tablePanelSecaoRetangular.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanelSecaoRetangular.Location = new System.Drawing.Point(0, 146);
            this.tablePanelSecaoRetangular.Margin = new System.Windows.Forms.Padding(5);
            this.tablePanelSecaoRetangular.Name = "tablePanelSecaoRetangular";
            this.tablePanelSecaoRetangular.Padding = new System.Windows.Forms.Padding(5);
            this.tablePanelSecaoRetangular.RowCount = 2;
            this.tablePanelSecaoRetangular.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelSecaoRetangular.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelSecaoRetangular.Size = new System.Drawing.Size(555, 64);
            this.tablePanelSecaoRetangular.TabIndex = 2;
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
            this.lbLargura.Size = new System.Drawing.Size(132, 27);
            this.lbLargura.TabIndex = 38;
            this.lbLargura.Text = "Largura";
            this.lbLargura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAltura.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbAltura.ForeColor = System.Drawing.Color.DimGray;
            this.lbAltura.Location = new System.Drawing.Point(143, 5);
            this.lbAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(132, 27);
            this.lbAltura.TabIndex = 38;
            this.lbAltura.Text = "Altura";
            this.lbAltura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbDLinhaSuperior
            // 
            this.lbDLinhaSuperior.AutoSize = true;
            this.lbDLinhaSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDLinhaSuperior.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbDLinhaSuperior.ForeColor = System.Drawing.Color.DimGray;
            this.lbDLinhaSuperior.Location = new System.Drawing.Point(415, 5);
            this.lbDLinhaSuperior.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDLinhaSuperior.Name = "lbDLinhaSuperior";
            this.lbDLinhaSuperior.Size = new System.Drawing.Size(133, 27);
            this.lbDLinhaSuperior.TabIndex = 38;
            this.lbDLinhaSuperior.Text = "ds\'";
            this.lbDLinhaSuperior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbDLinhaInferior
            // 
            this.lbDLinhaInferior.AutoSize = true;
            this.lbDLinhaInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDLinhaInferior.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbDLinhaInferior.ForeColor = System.Drawing.Color.DimGray;
            this.lbDLinhaInferior.Location = new System.Drawing.Point(279, 5);
            this.lbDLinhaInferior.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDLinhaInferior.Name = "lbDLinhaInferior";
            this.lbDLinhaInferior.Size = new System.Drawing.Size(132, 27);
            this.lbDLinhaInferior.TabIndex = 38;
            this.lbDLinhaInferior.Text = "di\'";
            this.lbDLinhaInferior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtLargura
            // 
            this.txtLargura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLargura.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtLargura.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLargura.HideTrailingZeros = true;
            this.txtLargura.Location = new System.Drawing.Point(25, 32);
            this.txtLargura.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtLargura.MinValue = 0D;
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(96, 32);
            this.txtLargura.Suffix = "cm";
            this.txtLargura.TabIndex = 0;
            this.txtLargura.Text = "0 cm";
            this.txtLargura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sfToolTip1.SetToolTip(this.txtLargura, "Largura da nervura (bw na literatura).");
            this.txtLargura.WatermarkText = "cm";
            // 
            // txtAltura
            // 
            this.txtAltura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAltura.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAltura.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAltura.HideTrailingZeros = true;
            this.txtAltura.Location = new System.Drawing.Point(161, 32);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtAltura.MinValue = 0D;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(96, 32);
            this.txtAltura.Suffix = "cm";
            this.txtAltura.TabIndex = 1;
            this.txtAltura.Text = "0 cm";
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sfToolTip1.SetToolTip(this.txtAltura, "");
            this.txtAltura.WatermarkText = "cm";
            // 
            // txtDLinhaInferior
            // 
            this.txtDLinhaInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDLinhaInferior.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDLinhaInferior.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDLinhaInferior.Location = new System.Drawing.Point(297, 32);
            this.txtDLinhaInferior.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtDLinhaInferior.MinValue = 0D;
            this.txtDLinhaInferior.Name = "txtDLinhaInferior";
            this.txtDLinhaInferior.Size = new System.Drawing.Size(96, 32);
            this.txtDLinhaInferior.Suffix = "cm";
            this.txtDLinhaInferior.TabIndex = 2;
            this.txtDLinhaInferior.Text = "0,00 cm";
            this.txtDLinhaInferior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sfToolTip1.SetToolTip(this.txtDLinhaInferior, "");
            this.txtDLinhaInferior.WatermarkText = "cm";
            // 
            // txtDLinhaSuperior
            // 
            this.txtDLinhaSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDLinhaSuperior.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDLinhaSuperior.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDLinhaSuperior.Location = new System.Drawing.Point(433, 32);
            this.txtDLinhaSuperior.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtDLinhaSuperior.MinValue = 0D;
            this.txtDLinhaSuperior.Name = "txtDLinhaSuperior";
            this.txtDLinhaSuperior.Size = new System.Drawing.Size(97, 32);
            this.txtDLinhaSuperior.Suffix = "cm";
            this.txtDLinhaSuperior.TabIndex = 3;
            this.txtDLinhaSuperior.Text = "0,00 cm";
            this.txtDLinhaSuperior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sfToolTip1.SetToolTip(this.txtDLinhaSuperior, "Distância do centro das armações comprimidas para borda comprimida.");
            this.txtDLinhaSuperior.WatermarkText = "cm";
            // 
            // tablePanelSecaoT
            // 
            this.tablePanelSecaoT.ColumnCount = 2;
            this.tablePanelSecaoT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelSecaoT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelSecaoT.Controls.Add(this.lbLarguraColaborante, 0, 0);
            this.tablePanelSecaoT.Controls.Add(this.lbEspessuraMesa, 1, 0);
            this.tablePanelSecaoT.Controls.Add(this.txtLarguraColaborante, 0, 1);
            this.tablePanelSecaoT.Controls.Add(this.txtEspessuraMesa, 1, 1);
            this.tablePanelSecaoT.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanelSecaoT.Location = new System.Drawing.Point(0, 210);
            this.tablePanelSecaoT.Margin = new System.Windows.Forms.Padding(5);
            this.tablePanelSecaoT.Name = "tablePanelSecaoT";
            this.tablePanelSecaoT.Padding = new System.Windows.Forms.Padding(5);
            this.tablePanelSecaoT.RowCount = 2;
            this.tablePanelSecaoT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelSecaoT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelSecaoT.Size = new System.Drawing.Size(555, 68);
            this.tablePanelSecaoT.TabIndex = 3;
            this.tablePanelSecaoT.Visible = false;
            // 
            // lbLarguraColaborante
            // 
            this.lbLarguraColaborante.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbLarguraColaborante.AutoSize = true;
            this.lbLarguraColaborante.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbLarguraColaborante.ForeColor = System.Drawing.Color.DimGray;
            this.lbLarguraColaborante.Location = new System.Drawing.Point(59, 14);
            this.lbLarguraColaborante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLarguraColaborante.Name = "lbLarguraColaborante";
            this.lbLarguraColaborante.Size = new System.Drawing.Size(163, 20);
            this.lbLarguraColaborante.TabIndex = 38;
            this.lbLarguraColaborante.Text = "Largura Colaborante";
            this.lbLarguraColaborante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbEspessuraMesa
            // 
            this.lbEspessuraMesa.AutoSize = true;
            this.lbEspessuraMesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbEspessuraMesa.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbEspessuraMesa.ForeColor = System.Drawing.Color.DimGray;
            this.lbEspessuraMesa.Location = new System.Drawing.Point(279, 5);
            this.lbEspessuraMesa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEspessuraMesa.Name = "lbEspessuraMesa";
            this.lbEspessuraMesa.Size = new System.Drawing.Size(269, 29);
            this.lbEspessuraMesa.TabIndex = 38;
            this.lbEspessuraMesa.Text = "Espessura da Mesa";
            this.lbEspessuraMesa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtLarguraColaborante
            // 
            this.txtLarguraColaborante.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLarguraColaborante.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtLarguraColaborante.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLarguraColaborante.HideTrailingZeros = true;
            this.txtLarguraColaborante.Location = new System.Drawing.Point(25, 34);
            this.txtLarguraColaborante.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtLarguraColaborante.MinValue = 0D;
            this.txtLarguraColaborante.Name = "txtLarguraColaborante";
            this.txtLarguraColaborante.Size = new System.Drawing.Size(232, 32);
            this.txtLarguraColaborante.Suffix = "cm";
            this.txtLarguraColaborante.TabIndex = 0;
            this.txtLarguraColaborante.Text = "0 cm";
            this.txtLarguraColaborante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLarguraColaborante.WatermarkText = "cm";
            // 
            // txtEspessuraMesa
            // 
            this.txtEspessuraMesa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtEspessuraMesa.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtEspessuraMesa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEspessuraMesa.HideTrailingZeros = true;
            this.txtEspessuraMesa.Location = new System.Drawing.Point(297, 34);
            this.txtEspessuraMesa.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtEspessuraMesa.MinValue = 0D;
            this.txtEspessuraMesa.Name = "txtEspessuraMesa";
            this.txtEspessuraMesa.Size = new System.Drawing.Size(233, 32);
            this.txtEspessuraMesa.Suffix = "cm";
            this.txtEspessuraMesa.TabIndex = 1;
            this.txtEspessuraMesa.Text = "0 cm";
            this.txtEspessuraMesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEspessuraMesa.WatermarkText = "cm";
            // 
            // tablePanelMdAs
            // 
            this.tablePanelMdAs.ColumnCount = 2;
            this.tablePanelMdAs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelMdAs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelMdAs.Controls.Add(this.btnCalculaAs, 1, 0);
            this.tablePanelMdAs.Controls.Add(this.btnCalculaMd, 0, 0);
            this.tablePanelMdAs.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanelMdAs.Location = new System.Drawing.Point(0, 369);
            this.tablePanelMdAs.Margin = new System.Windows.Forms.Padding(5);
            this.tablePanelMdAs.Name = "tablePanelMdAs";
            this.tablePanelMdAs.Padding = new System.Windows.Forms.Padding(5);
            this.tablePanelMdAs.RowCount = 1;
            this.tablePanelMdAs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelMdAs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tablePanelMdAs.Size = new System.Drawing.Size(555, 76);
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
            this.btnCalculaAs.Location = new System.Drawing.Point(388, 13);
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
            this.sfToolTip1.SetToolTip(this.btnCalculaAs, "Selecione essa opção para calcular a área de aço necessária para determinado mome" +
        "nto de cálculo.");
            this.btnCalculaAs.UseVisualStyleBackColor = false;
            this.btnCalculaAs.Click += new System.EventHandler(this.btnCalculaAs_Click);
            // 
            // btnCalculaMd
            // 
            this.btnCalculaMd.AccessibleName = "Button";
            this.btnCalculaMd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalculaMd.BackColor = System.Drawing.Color.White;
            this.btnCalculaMd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnCalculaMd.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnCalculaMd.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCalculaMd.Location = new System.Drawing.Point(116, 13);
            this.btnCalculaMd.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalculaMd.Name = "btnCalculaMd";
            this.btnCalculaMd.Size = new System.Drawing.Size(50, 50);
            this.btnCalculaMd.Style.BackColor = System.Drawing.Color.White;
            this.btnCalculaMd.Style.DisabledBackColor = System.Drawing.Color.Empty;
            this.btnCalculaMd.Style.DisabledForeColor = System.Drawing.Color.Empty;
            this.btnCalculaMd.Style.FocusedBackColor = System.Drawing.Color.Empty;
            this.btnCalculaMd.Style.FocusedForeColor = System.Drawing.Color.Empty;
            this.btnCalculaMd.Style.ForeColor = System.Drawing.Color.Empty;
            this.btnCalculaMd.Style.HoverBackColor = System.Drawing.Color.Empty;
            this.btnCalculaMd.Style.HoverForeColor = System.Drawing.Color.Empty;
            this.btnCalculaMd.Style.HoverImage = global::CalculadoraVigas.Properties.Resources.md_hover;
            this.btnCalculaMd.Style.Image = global::CalculadoraVigas.Properties.Resources.md_normal;
            this.btnCalculaMd.Style.PressedBackColor = System.Drawing.Color.Empty;
            this.btnCalculaMd.Style.PressedForeColor = System.Drawing.Color.Empty;
            this.btnCalculaMd.Style.PressedImage = global::CalculadoraVigas.Properties.Resources.md_normal;
            this.btnCalculaMd.TabIndex = 0;
            this.btnCalculaMd.TextMargin = new System.Windows.Forms.Padding(0);
            this.sfToolTip1.SetToolTip(this.btnCalculaMd, "Selecione essa opção para calcular o momento resistente de cálculo para determina" +
        "da área de aço.");
            this.btnCalculaMd.UseVisualStyleBackColor = false;
            this.btnCalculaMd.Click += new System.EventHandler(this.btnCalculaMd_Click);
            // 
            // tableLayoutPanelResults
            // 
            this.tableLayoutPanelResults.ColumnCount = 3;
            this.tableLayoutPanelResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelResults.Controls.Add(this.lbAreaComprimida, 0, 1);
            this.tableLayoutPanelResults.Controls.Add(this.lbRazaoLNTitulo, 2, 0);
            this.tableLayoutPanelResults.Controls.Add(this.lbAreaComprimidaTitulo, 0, 0);
            this.tableLayoutPanelResults.Controls.Add(this.lbRazaoLN, 2, 1);
            this.tableLayoutPanelResults.Controls.Add(this.lbLinhaNeutraTitulo, 1, 0);
            this.tableLayoutPanelResults.Controls.Add(this.lbLinhaNeutra, 1, 1);
            this.tableLayoutPanelResults.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelResults.Location = new System.Drawing.Point(0, 452);
            this.tableLayoutPanelResults.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanelResults.Name = "tableLayoutPanelResults";
            this.tableLayoutPanelResults.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanelResults.RowCount = 2;
            this.tableLayoutPanelResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelResults.Size = new System.Drawing.Size(555, 98);
            this.tableLayoutPanelResults.TabIndex = 48;
            // 
            // lbAreaComprimida
            // 
            this.lbAreaComprimida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAreaComprimida.AutoSize = true;
            this.lbAreaComprimida.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbAreaComprimida.ForeColor = System.Drawing.Color.Black;
            this.lbAreaComprimida.Location = new System.Drawing.Point(49, 59);
            this.lbAreaComprimida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAreaComprimida.Name = "lbAreaComprimida";
            this.lbAreaComprimida.Size = new System.Drawing.Size(93, 23);
            this.lbAreaComprimida.TabIndex = 0;
            this.lbAreaComprimida.Text = "0,00 cm²";
            this.lbAreaComprimida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRazaoLNTitulo
            // 
            this.lbRazaoLNTitulo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbRazaoLNTitulo.AutoSize = true;
            this.lbRazaoLNTitulo.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbRazaoLNTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lbRazaoLNTitulo.Location = new System.Drawing.Point(409, 29);
            this.lbRazaoLNTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRazaoLNTitulo.Name = "lbRazaoLNTitulo";
            this.lbRazaoLNTitulo.Size = new System.Drawing.Size(99, 20);
            this.lbRazaoLNTitulo.TabIndex = 36;
            this.lbRazaoLNTitulo.Text = "Relação x/d";
            this.lbRazaoLNTitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbAreaComprimidaTitulo
            // 
            this.lbAreaComprimidaTitulo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbAreaComprimidaTitulo.AutoSize = true;
            this.lbAreaComprimidaTitulo.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbAreaComprimidaTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lbAreaComprimidaTitulo.Location = new System.Drawing.Point(37, 29);
            this.lbAreaComprimidaTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAreaComprimidaTitulo.Name = "lbAreaComprimidaTitulo";
            this.lbAreaComprimidaTitulo.Size = new System.Drawing.Size(117, 20);
            this.lbAreaComprimidaTitulo.TabIndex = 36;
            this.lbAreaComprimidaTitulo.Text = "As,comprimida";
            this.lbAreaComprimidaTitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbRazaoLN
            // 
            this.lbRazaoLN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRazaoLN.AutoSize = true;
            this.lbRazaoLN.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbRazaoLN.ForeColor = System.Drawing.Color.Black;
            this.lbRazaoLN.Location = new System.Drawing.Point(434, 59);
            this.lbRazaoLN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRazaoLN.Name = "lbRazaoLN";
            this.lbRazaoLN.Size = new System.Drawing.Size(48, 23);
            this.lbRazaoLN.TabIndex = 0;
            this.lbRazaoLN.Text = "0,00";
            this.lbRazaoLN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLinhaNeutraTitulo
            // 
            this.lbLinhaNeutraTitulo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbLinhaNeutraTitulo.AutoSize = true;
            this.lbLinhaNeutraTitulo.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbLinhaNeutraTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lbLinhaNeutraTitulo.Location = new System.Drawing.Point(226, 29);
            this.lbLinhaNeutraTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLinhaNeutraTitulo.Name = "lbLinhaNeutraTitulo";
            this.lbLinhaNeutraTitulo.Size = new System.Drawing.Size(101, 20);
            this.lbLinhaNeutraTitulo.TabIndex = 36;
            this.lbLinhaNeutraTitulo.Text = "Linha Neutra";
            this.lbLinhaNeutraTitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbLinhaNeutra
            // 
            this.lbLinhaNeutra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbLinhaNeutra.AutoSize = true;
            this.lbLinhaNeutra.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbLinhaNeutra.ForeColor = System.Drawing.Color.Black;
            this.lbLinhaNeutra.Location = new System.Drawing.Point(233, 59);
            this.lbLinhaNeutra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLinhaNeutra.Name = "lbLinhaNeutra";
            this.lbLinhaNeutra.Size = new System.Drawing.Size(86, 23);
            this.lbLinhaNeutra.TabIndex = 0;
            this.lbLinhaNeutra.Text = "0,00 cm";
            this.lbLinhaNeutra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMomento
            // 
            this.txtMomento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMomento.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtMomento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMomento.HideTrailingZeros = true;
            this.txtMomento.Location = new System.Drawing.Point(25, 35);
            this.txtMomento.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtMomento.MinValue = 0D;
            this.txtMomento.Name = "txtMomento";
            this.txtMomento.Size = new System.Drawing.Size(232, 32);
            this.txtMomento.Suffix = "kN.cm";
            this.txtMomento.TabIndex = 0;
            this.txtMomento.Text = "0 kN.cm";
            this.txtMomento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sfToolTip1.SetToolTip(this.txtMomento, "Momento de cálculo da seção (MSd da literatura).");
            this.txtMomento.WatermarkText = "kN.cm";
            // 
            // txtAreaTracionada
            // 
            this.txtAreaTracionada.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtAreaTracionada.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAreaTracionada.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAreaTracionada.HideTrailingZeros = true;
            this.txtAreaTracionada.Location = new System.Drawing.Point(297, 35);
            this.txtAreaTracionada.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.txtAreaTracionada.MinValue = 0D;
            this.txtAreaTracionada.Name = "txtAreaTracionada";
            this.txtAreaTracionada.Size = new System.Drawing.Size(233, 32);
            this.txtAreaTracionada.Suffix = "cm²";
            this.txtAreaTracionada.TabIndex = 1;
            this.txtAreaTracionada.Text = "0 cm²";
            this.txtAreaTracionada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sfToolTip1.SetToolTip(this.txtAreaTracionada, "Área de aço tracionada a ser informada ou solicitada.");
            this.txtAreaTracionada.WatermarkText = "cm²";
            // 
            // tablePanelSolucao
            // 
            this.tablePanelSolucao.ColumnCount = 2;
            this.tablePanelSolucao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelSolucao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelSolucao.Controls.Add(this.lbMomento, 0, 0);
            this.tablePanelSolucao.Controls.Add(this.lbAreaTracionada, 1, 0);
            this.tablePanelSolucao.Controls.Add(this.txtMomento, 0, 1);
            this.tablePanelSolucao.Controls.Add(this.txtAreaTracionada, 1, 1);
            this.tablePanelSolucao.Controls.Add(this.lbArmaduraMinima, 1, 2);
            this.tablePanelSolucao.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanelSolucao.Location = new System.Drawing.Point(0, 278);
            this.tablePanelSolucao.Margin = new System.Windows.Forms.Padding(5);
            this.tablePanelSolucao.Name = "tablePanelSolucao";
            this.tablePanelSolucao.Padding = new System.Windows.Forms.Padding(5);
            this.tablePanelSolucao.RowCount = 3;
            this.tablePanelSolucao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelSolucao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelSolucao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelSolucao.Size = new System.Drawing.Size(555, 91);
            this.tablePanelSolucao.TabIndex = 4;
            // 
            // lbMomento
            // 
            this.lbMomento.AutoSize = true;
            this.lbMomento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMomento.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbMomento.ForeColor = System.Drawing.Color.DimGray;
            this.lbMomento.Location = new System.Drawing.Point(7, 5);
            this.lbMomento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMomento.Name = "lbMomento";
            this.lbMomento.Size = new System.Drawing.Size(268, 30);
            this.lbMomento.TabIndex = 38;
            this.lbMomento.Text = "Momento de cálculo";
            this.lbMomento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbAreaTracionada
            // 
            this.lbAreaTracionada.AutoSize = true;
            this.lbAreaTracionada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAreaTracionada.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbAreaTracionada.ForeColor = System.Drawing.Color.DimGray;
            this.lbAreaTracionada.Location = new System.Drawing.Point(279, 5);
            this.lbAreaTracionada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAreaTracionada.Name = "lbAreaTracionada";
            this.lbAreaTracionada.Size = new System.Drawing.Size(269, 30);
            this.lbAreaTracionada.TabIndex = 38;
            this.lbAreaTracionada.Text = "As,tracionada";
            this.lbAreaTracionada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbArmaduraMinima
            // 
            this.lbArmaduraMinima.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbArmaduraMinima.AutoSize = true;
            this.lbArmaduraMinima.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.lbArmaduraMinima.ForeColor = System.Drawing.Color.Red;
            this.lbArmaduraMinima.Location = new System.Drawing.Point(305, 65);
            this.lbArmaduraMinima.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbArmaduraMinima.Name = "lbArmaduraMinima";
            this.lbArmaduraMinima.Size = new System.Drawing.Size(217, 17);
            this.lbArmaduraMinima.TabIndex = 40;
            this.lbArmaduraMinima.Text = "Armadura mínima não considerada";
            this.lbArmaduraMinima.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ucFlexao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanelResults);
            this.Controls.Add(this.tablePanelMdAs);
            this.Controls.Add(this.tablePanelSolucao);
            this.Controls.Add(this.tablePanelSecaoT);
            this.Controls.Add(this.tablePanelSecaoRetangular);
            this.Controls.Add(this.tablePanelRetangular);
            this.Controls.Add(this.tablePanelMateriais);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(555, 550);
            this.MinimumSize = new System.Drawing.Size(555, 550);
            this.Name = "ucFlexao";
            this.Size = new System.Drawing.Size(555, 550);
            this.tablePanelMateriais.ResumeLayout(false);
            this.tablePanelMateriais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBoxAco)).EndInit();
            this.tablePanelRetangular.ResumeLayout(false);
            this.tablePanelRetangular.PerformLayout();
            this.tablePanelSecaoRetangular.ResumeLayout(false);
            this.tablePanelSecaoRetangular.PerformLayout();
            this.tablePanelSecaoT.ResumeLayout(false);
            this.tablePanelSecaoT.PerformLayout();
            this.tablePanelMdAs.ResumeLayout(false);
            this.tableLayoutPanelResults.ResumeLayout(false);
            this.tableLayoutPanelResults.PerformLayout();
            this.tablePanelSolucao.ResumeLayout(false);
            this.tablePanelSolucao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablePanelMateriais;
        private System.Windows.Forms.Label lbAco;
        private System.Windows.Forms.Label lbFck;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtFck;
        private Syncfusion.WinForms.ListView.SfComboBox sfComboBoxAco;
        private System.Windows.Forms.TableLayoutPanel tablePanelRetangular;
        private System.Windows.Forms.Label lbFormatoSecao;
        private Syncfusion.WinForms.Controls.SfButton btnSecaoT;
        private Syncfusion.WinForms.Controls.SfButton btnSecaoRetangular;
        private System.Windows.Forms.TableLayoutPanel tablePanelSecaoRetangular;
        private System.Windows.Forms.Label lbLargura;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.Label lbDLinhaSuperior;
        private System.Windows.Forms.Label lbDLinhaInferior;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtLargura;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtAltura;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtDLinhaInferior;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtDLinhaSuperior;
        private System.Windows.Forms.TableLayoutPanel tablePanelSecaoT;
        private System.Windows.Forms.Label lbLarguraColaborante;
        private System.Windows.Forms.Label lbEspessuraMesa;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtLarguraColaborante;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtEspessuraMesa;
        private System.Windows.Forms.TableLayoutPanel tablePanelMdAs;
        private Syncfusion.WinForms.Controls.SfButton btnCalculaAs;
        private Syncfusion.WinForms.Controls.SfButton btnCalculaMd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelResults;
        private System.Windows.Forms.Label lbAreaComprimidaTitulo;
        private System.Windows.Forms.Label lbAreaComprimida;
        private System.Windows.Forms.Label lbLinhaNeutra;
        private System.Windows.Forms.Label lbLinhaNeutraTitulo;
        private System.Windows.Forms.Label lbRazaoLNTitulo;
        private Syncfusion.Windows.Forms.SfToolTip sfToolTip1;
        private System.Windows.Forms.TableLayoutPanel tablePanelSolucao;
        private System.Windows.Forms.Label lbMomento;
        private System.Windows.Forms.Label lbAreaTracionada;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtMomento;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtAreaTracionada;
        private System.Windows.Forms.Label lbSecaoRetangular;
        private System.Windows.Forms.Label lbSecaoT;
        private System.Windows.Forms.Label lbRazaoLN;
        private System.Windows.Forms.Label lbArmaduraMinima;
    }
}
