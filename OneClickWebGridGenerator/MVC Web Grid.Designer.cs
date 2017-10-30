namespace MVCWebGridScriptGenerator
{
    partial class frmMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtColumnName = new System.Windows.Forms.TextBox();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.chkPrimaryKey = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbColDataType = new System.Windows.Forms.ComboBox();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.chkCanSort = new System.Windows.Forms.CheckBox();
            this.chkDefaultSort = new System.Windows.Forms.CheckBox();
            this.chkHeader = new System.Windows.Forms.CheckBox();
            this.chkEditable = new System.Windows.Forms.CheckBox();
            this.lstbColumns = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numRowsPerPage = new System.Windows.Forms.NumericUpDown();
            this.chkPaging = new System.Windows.Forms.CheckBox();
            this.chkAddNewRowFunc = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPagingMode = new System.Windows.Forms.ComboBox();
            this.chkFillEmptyRows = new System.Windows.Forms.CheckBox();
            this.btnGenerateScript = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGridWidth = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRefreshForm = new System.Windows.Forms.Label();
            this.txtAltRowColor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRowColor = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.txtGridTextColor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFooterColor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHeaderColor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtColWidth = new System.Windows.Forms.TextBox();
            this.lblResetColumns = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numRowsPerPage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(52, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Column Name";
            // 
            // txtColumnName
            // 
            this.txtColumnName.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumnName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtColumnName.Location = new System.Drawing.Point(185, 42);
            this.txtColumnName.Name = "txtColumnName";
            this.txtColumnName.Size = new System.Drawing.Size(190, 22);
            this.txtColumnName.TabIndex = 10;
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddColumn.ForeColor = System.Drawing.Color.Black;
            this.btnAddColumn.Location = new System.Drawing.Point(411, 42);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(86, 24);
            this.btnAddColumn.TabIndex = 11;
            this.btnAddColumn.Text = "Add Column";
            this.btnAddColumn.UseVisualStyleBackColor = true;
            this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
            // 
            // chkPrimaryKey
            // 
            this.chkPrimaryKey.AutoSize = true;
            this.chkPrimaryKey.BackColor = System.Drawing.Color.Transparent;
            this.chkPrimaryKey.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrimaryKey.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chkPrimaryKey.Location = new System.Drawing.Point(369, 87);
            this.chkPrimaryKey.Name = "chkPrimaryKey";
            this.chkPrimaryKey.Size = new System.Drawing.Size(230, 20);
            this.chkPrimaryKey.TabIndex = 17;
            this.chkPrimaryKey.Text = "Set This Column as Priamary Key";
            this.chkPrimaryKey.UseVisualStyleBackColor = false;
            this.chkPrimaryKey.CheckedChanged += new System.EventHandler(this.chkPrimaryKey_CheckedChanged);
            this.chkPrimaryKey.Click += new System.EventHandler(this.chkPrimaryKey_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(366, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Column Data Type";
            // 
            // cmbColDataType
            // 
            this.cmbColDataType.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColDataType.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cmbColDataType.FormattingEnabled = true;
            this.cmbColDataType.Items.AddRange(new object[] {
            "int",
            "double",
            "bool",
            "string",
            "decimal"});
            this.cmbColDataType.Location = new System.Drawing.Point(499, 219);
            this.cmbColDataType.Name = "cmbColDataType";
            this.cmbColDataType.Size = new System.Drawing.Size(100, 24);
            this.cmbColDataType.TabIndex = 12;
            this.cmbColDataType.Text = "string";
            this.cmbColDataType.SelectedIndexChanged += new System.EventHandler(this.cmbColDataType_SelectedIndexChanged);
            // 
            // txtHeader
            // 
            this.txtHeader.Enabled = false;
            this.txtHeader.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeader.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtHeader.Location = new System.Drawing.Point(499, 191);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(157, 22);
            this.txtHeader.TabIndex = 13;
            this.txtHeader.TextChanged += new System.EventHandler(this.txtHeader_TextChanged);
            this.txtHeader.Leave += new System.EventHandler(this.txtHeader_Leave);
            // 
            // chkCanSort
            // 
            this.chkCanSort.AutoSize = true;
            this.chkCanSort.BackColor = System.Drawing.Color.Transparent;
            this.chkCanSort.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCanSort.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chkCanSort.Location = new System.Drawing.Point(370, 147);
            this.chkCanSort.Name = "chkCanSort";
            this.chkCanSort.Size = new System.Drawing.Size(130, 20);
            this.chkCanSort.TabIndex = 14;
            this.chkCanSort.Text = "Sortable Column";
            this.chkCanSort.UseVisualStyleBackColor = false;
            this.chkCanSort.Click += new System.EventHandler(this.chkCanSort_Click);
            // 
            // chkDefaultSort
            // 
            this.chkDefaultSort.AutoSize = true;
            this.chkDefaultSort.BackColor = System.Drawing.Color.Transparent;
            this.chkDefaultSort.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDefaultSort.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chkDefaultSort.Location = new System.Drawing.Point(370, 170);
            this.chkDefaultSort.Name = "chkDefaultSort";
            this.chkDefaultSort.Size = new System.Drawing.Size(215, 20);
            this.chkDefaultSort.TabIndex = 15;
            this.chkDefaultSort.Text = "Set this Column as Default Sort";
            this.chkDefaultSort.UseVisualStyleBackColor = false;
            this.chkDefaultSort.Click += new System.EventHandler(this.chkDefaultSort_Click);
            // 
            // chkHeader
            // 
            this.chkHeader.AutoSize = true;
            this.chkHeader.BackColor = System.Drawing.Color.Transparent;
            this.chkHeader.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHeader.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chkHeader.Location = new System.Drawing.Point(370, 193);
            this.chkHeader.Name = "chkHeader";
            this.chkHeader.Size = new System.Drawing.Size(123, 20);
            this.chkHeader.TabIndex = 16;
            this.chkHeader.Text = "Column Header";
            this.chkHeader.UseVisualStyleBackColor = false;
            this.chkHeader.Click += new System.EventHandler(this.chkHeader_Click);
            // 
            // chkEditable
            // 
            this.chkEditable.AutoSize = true;
            this.chkEditable.BackColor = System.Drawing.Color.Transparent;
            this.chkEditable.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEditable.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chkEditable.Location = new System.Drawing.Point(370, 124);
            this.chkEditable.Name = "chkEditable";
            this.chkEditable.Size = new System.Drawing.Size(126, 20);
            this.chkEditable.TabIndex = 13;
            this.chkEditable.Text = "Make it Editable";
            this.chkEditable.UseVisualStyleBackColor = false;
            this.chkEditable.Click += new System.EventHandler(this.chkEditable_Click);
            // 
            // lstbColumns
            // 
            this.lstbColumns.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbColumns.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lstbColumns.FormattingEnabled = true;
            this.lstbColumns.ItemHeight = 16;
            this.lstbColumns.Location = new System.Drawing.Point(55, 89);
            this.lstbColumns.Name = "lstbColumns";
            this.lstbColumns.Size = new System.Drawing.Size(269, 228);
            this.lstbColumns.TabIndex = 5;
            this.lstbColumns.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstbColumns_MouseClick);
            this.lstbColumns.SelectedIndexChanged += new System.EventHandler(this.lstbColumns_SelectedIndexChanged);
            this.lstbColumns.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstbColumns_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(524, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Rows Per Page";
            // 
            // numRowsPerPage
            // 
            this.numRowsPerPage.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRowsPerPage.ForeColor = System.Drawing.Color.DodgerBlue;
            this.numRowsPerPage.Location = new System.Drawing.Point(639, 42);
            this.numRowsPerPage.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numRowsPerPage.Name = "numRowsPerPage";
            this.numRowsPerPage.ReadOnly = true;
            this.numRowsPerPage.Size = new System.Drawing.Size(37, 22);
            this.numRowsPerPage.TabIndex = 5;
            this.numRowsPerPage.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRowsPerPage.ValueChanged += new System.EventHandler(this.numRowsPerPage_ValueChanged);
            // 
            // chkPaging
            // 
            this.chkPaging.AutoSize = true;
            this.chkPaging.BackColor = System.Drawing.Color.Transparent;
            this.chkPaging.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPaging.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chkPaging.Location = new System.Drawing.Point(51, 52);
            this.chkPaging.Name = "chkPaging";
            this.chkPaging.Size = new System.Drawing.Size(113, 20);
            this.chkPaging.TabIndex = 1;
            this.chkPaging.Text = "Enable Paging";
            this.chkPaging.UseVisualStyleBackColor = false;
            this.chkPaging.Click += new System.EventHandler(this.chkPaging_Click);
            // 
            // chkAddNewRowFunc
            // 
            this.chkAddNewRowFunc.AutoSize = true;
            this.chkAddNewRowFunc.BackColor = System.Drawing.Color.Transparent;
            this.chkAddNewRowFunc.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddNewRowFunc.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chkAddNewRowFunc.Location = new System.Drawing.Point(51, 129);
            this.chkAddNewRowFunc.Name = "chkAddNewRowFunc";
            this.chkAddNewRowFunc.Size = new System.Drawing.Size(244, 20);
            this.chkAddNewRowFunc.TabIndex = 3;
            this.chkAddNewRowFunc.Text = "I Want Add New Row Functionality";
            this.chkAddNewRowFunc.UseVisualStyleBackColor = false;
            this.chkAddNewRowFunc.Click += new System.EventHandler(this.chkAddNewRowFunc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(298, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Paging Mode";
            // 
            // cmbPagingMode
            // 
            this.cmbPagingMode.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPagingMode.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cmbPagingMode.FormattingEnabled = true;
            this.cmbPagingMode.Items.AddRange(new object[] {
            "All",
            "FirstLast",
            "NextPrevious",
            "Numeric"});
            this.cmbPagingMode.Location = new System.Drawing.Point(411, 44);
            this.cmbPagingMode.Name = "cmbPagingMode";
            this.cmbPagingMode.Size = new System.Drawing.Size(94, 24);
            this.cmbPagingMode.TabIndex = 4;
            this.cmbPagingMode.SelectedIndexChanged += new System.EventHandler(this.cmbPagingMode_SelectedIndexChanged);
            // 
            // chkFillEmptyRows
            // 
            this.chkFillEmptyRows.AutoSize = true;
            this.chkFillEmptyRows.BackColor = System.Drawing.Color.Transparent;
            this.chkFillEmptyRows.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFillEmptyRows.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chkFillEmptyRows.Location = new System.Drawing.Point(51, 86);
            this.chkFillEmptyRows.Name = "chkFillEmptyRows";
            this.chkFillEmptyRows.Size = new System.Drawing.Size(127, 20);
            this.chkFillEmptyRows.TabIndex = 2;
            this.chkFillEmptyRows.Text = "Fill Empty Rows";
            this.chkFillEmptyRows.UseVisualStyleBackColor = false;
            this.chkFillEmptyRows.Click += new System.EventHandler(this.chkFillEmptyRows_Click);
            // 
            // btnGenerateScript
            // 
            this.btnGenerateScript.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateScript.ForeColor = System.Drawing.Color.Black;
            this.btnGenerateScript.Location = new System.Drawing.Point(274, 593);
            this.btnGenerateScript.Name = "btnGenerateScript";
            this.btnGenerateScript.Size = new System.Drawing.Size(225, 39);
            this.btnGenerateScript.TabIndex = 18;
            this.btnGenerateScript.Text = "Generate MVC WebGrid";
            this.btnGenerateScript.UseVisualStyleBackColor = true;
            this.btnGenerateScript.Click += new System.EventHandler(this.btnGenerateScript_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.txtGridWidth);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.lblRefreshForm);
            this.panel1.Controls.Add(this.txtAltRowColor);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtRowColor);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.txtGridTextColor);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtFooterColor);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtHeaderColor);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.chkFillEmptyRows);
            this.panel1.Controls.Add(this.chkAddNewRowFunc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numRowsPerPage);
            this.panel1.Controls.Add(this.chkPaging);
            this.panel1.Controls.Add(this.cmbPagingMode);
            this.panel1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(12, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 203);
            this.panel1.TabIndex = 15;
            // 
            // txtGridWidth
            // 
            this.txtGridWidth.Location = new System.Drawing.Point(411, 169);
            this.txtGridWidth.Name = "txtGridWidth";
            this.txtGridWidth.Size = new System.Drawing.Size(100, 22);
            this.txtGridWidth.TabIndex = 33;
            this.txtGridWidth.TextChanged += new System.EventHandler(this.txtGridWidth_TextChanged);
            this.txtGridWidth.Leave += new System.EventHandler(this.txtGridWidth_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label13.Location = new System.Drawing.Point(298, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "Grid Width";
            // 
            // lblRefreshForm
            // 
            this.lblRefreshForm.AutoSize = true;
            this.lblRefreshForm.BackColor = System.Drawing.Color.Transparent;
            this.lblRefreshForm.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefreshForm.ForeColor = System.Drawing.Color.White;
            this.lblRefreshForm.Location = new System.Drawing.Point(572, 11);
            this.lblRefreshForm.Name = "lblRefreshForm";
            this.lblRefreshForm.Size = new System.Drawing.Size(155, 16);
            this.lblRefreshForm.TabIndex = 27;
            this.lblRefreshForm.Text = "Reset Following Section";
            this.lblRefreshForm.Click += new System.EventHandler(this.lblRefreshForm_Click);
            // 
            // txtAltRowColor
            // 
            this.txtAltRowColor.BackColor = System.Drawing.Color.White;
            this.txtAltRowColor.ForeColor = System.Drawing.Color.Black;
            this.txtAltRowColor.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtAltRowColor.Location = new System.Drawing.Point(610, 127);
            this.txtAltRowColor.MaxLength = 7;
            this.txtAltRowColor.Name = "txtAltRowColor";
            this.txtAltRowColor.Size = new System.Drawing.Size(94, 22);
            this.txtAltRowColor.TabIndex = 25;
            this.txtAltRowColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAltRowColor_MouseClick);
            this.txtAltRowColor.TextChanged += new System.EventHandler(this.txtAltRowColor_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label11.Location = new System.Drawing.Point(515, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Alt Row Color";
            // 
            // txtRowColor
            // 
            this.txtRowColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtRowColor.ForeColor = System.Drawing.Color.Black;
            this.txtRowColor.Location = new System.Drawing.Point(610, 84);
            this.txtRowColor.MaxLength = 7;
            this.txtRowColor.Name = "txtRowColor";
            this.txtRowColor.Size = new System.Drawing.Size(94, 22);
            this.txtRowColor.TabIndex = 24;
            this.txtRowColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRowColor_MouseClick);
            this.txtRowColor.TextChanged += new System.EventHandler(this.txtRowColor_TextChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(411, 175);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 23;
            // 
            // txtGridTextColor
            // 
            this.txtGridTextColor.BackColor = System.Drawing.Color.Black;
            this.txtGridTextColor.ForeColor = System.Drawing.Color.White;
            this.txtGridTextColor.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtGridTextColor.Location = new System.Drawing.Point(610, 163);
            this.txtGridTextColor.MaxLength = 7;
            this.txtGridTextColor.Name = "txtGridTextColor";
            this.txtGridTextColor.Size = new System.Drawing.Size(94, 22);
            this.txtGridTextColor.TabIndex = 9;
            this.txtGridTextColor.Text = "#000000";
            this.txtGridTextColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtGridTextColor_MouseClick);
            this.txtGridTextColor.TextChanged += new System.EventHandler(this.txtGridTextColor_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(523, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Text Color";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(524, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Row Color";
            // 
            // txtFooterColor
            // 
            this.txtFooterColor.BackColor = System.Drawing.Color.White;
            this.txtFooterColor.Location = new System.Drawing.Point(411, 127);
            this.txtFooterColor.MaxLength = 7;
            this.txtFooterColor.Name = "txtFooterColor";
            this.txtFooterColor.Size = new System.Drawing.Size(94, 22);
            this.txtFooterColor.TabIndex = 7;
            this.txtFooterColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFooterColor_MouseClick);
            this.txtFooterColor.TextChanged += new System.EventHandler(this.txtFooterColor_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(298, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Footer Color";
            // 
            // txtHeaderColor
            // 
            this.txtHeaderColor.BackColor = System.Drawing.Color.White;
            this.txtHeaderColor.ForeColor = System.Drawing.Color.Black;
            this.txtHeaderColor.Location = new System.Drawing.Point(411, 86);
            this.txtHeaderColor.MaxLength = 7;
            this.txtHeaderColor.Name = "txtHeaderColor";
            this.txtHeaderColor.Size = new System.Drawing.Size(94, 22);
            this.txtHeaderColor.TabIndex = 6;
            this.txtHeaderColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtHeaderColor_MouseClick);
            this.txtHeaderColor.TextChanged += new System.EventHandler(this.txtHeaderColor_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(298, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Header Color";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Grid Level Properties";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtSavePath);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.btnDown);
            this.panel2.Controls.Add(this.btnUp);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtColWidth);
            this.panel2.Controls.Add(this.lblResetColumns);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.chkCanSort);
            this.panel2.Controls.Add(this.chkPrimaryKey);
            this.panel2.Controls.Add(this.chkDefaultSort);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtColumnName);
            this.panel2.Controls.Add(this.chkHeader);
            this.panel2.Controls.Add(this.cmbColDataType);
            this.panel2.Controls.Add(this.chkEditable);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnAddColumn);
            this.panel2.Controls.Add(this.lstbColumns);
            this.panel2.Controls.Add(this.txtHeader);
            this.panel2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 381);
            this.panel2.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label15.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(54, 355);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(558, 14);
            this.label15.TabIndex = 35;
            this.label15.Text = "Download Sample Web Solution from https://github.com/suhasdhongade/MVCWebGridWebA" +
    "pp";
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(230, 327);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(452, 22);
            this.txtSavePath.TabIndex = 34;
            this.txtSavePath.Text = "C:\\MVCSampleGrid";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label14.Location = new System.Drawing.Point(52, 330);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 16);
            this.label14.TabIndex = 33;
            this.label14.Text = "Save Generated Files at =>";
            // 
            // btnDown
            // 
            this.btnDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDown.BackgroundImage")));
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.ForeColor = System.Drawing.Color.Transparent;
            this.btnDown.Location = new System.Drawing.Point(25, 189);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(24, 24);
            this.btnDown.TabIndex = 32;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Transparent;
            this.btnUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUp.BackgroundImage")));
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.ForeColor = System.Drawing.Color.Transparent;
            this.btnUp.Location = new System.Drawing.Point(25, 155);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(24, 24);
            this.btnUp.TabIndex = 31;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(367, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "Column Width";
            // 
            // txtColWidth
            // 
            this.txtColWidth.Enabled = false;
            this.txtColWidth.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColWidth.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtColWidth.Location = new System.Drawing.Point(499, 249);
            this.txtColWidth.Name = "txtColWidth";
            this.txtColWidth.Size = new System.Drawing.Size(100, 22);
            this.txtColWidth.TabIndex = 29;
            this.txtColWidth.Leave += new System.EventHandler(this.txtColWidth_Leave);
            // 
            // lblResetColumns
            // 
            this.lblResetColumns.AutoSize = true;
            this.lblResetColumns.BackColor = System.Drawing.Color.Transparent;
            this.lblResetColumns.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetColumns.ForeColor = System.Drawing.Color.White;
            this.lblResetColumns.Location = new System.Drawing.Point(572, 9);
            this.lblResetColumns.Name = "lblResetColumns";
            this.lblResetColumns.Size = new System.Drawing.Size(155, 16);
            this.lblResetColumns.TabIndex = 28;
            this.lblResetColumns.Text = "Reset Following Section";
            this.lblResetColumns.Click += new System.EventHandler(this.lblResetColumns_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Column Level Properties";
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(754, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGenerateScript);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "One Click WebGrid !                                                              " +
    "                                                                   by SuhasDhong" +
    "ade@gmail.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRowsPerPage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColumnName;
        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.ListBox lstbColumns;
        private System.Windows.Forms.CheckBox chkCanSort;
        private System.Windows.Forms.CheckBox chkDefaultSort;
        private System.Windows.Forms.CheckBox chkPaging;
        private System.Windows.Forms.CheckBox chkHeader;
        private System.Windows.Forms.CheckBox chkEditable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numRowsPerPage;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPagingMode;
        private System.Windows.Forms.CheckBox chkFillEmptyRows;
        private System.Windows.Forms.CheckBox chkAddNewRowFunc;
        private System.Windows.Forms.Button btnGenerateScript;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbColDataType;
        private System.Windows.Forms.CheckBox chkPrimaryKey;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHeaderColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtFooterColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGridTextColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtRowColor;
        private System.Windows.Forms.TextBox txtAltRowColor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblRefreshForm;
        private System.Windows.Forms.Label lblResetColumns;
        private System.Windows.Forms.TextBox txtColWidth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGridWidth;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

