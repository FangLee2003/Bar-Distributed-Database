﻿
namespace QLTVT
{
    partial class FormVatTu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label sOLUONGTONLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVatTu));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTHEM = new DevExpress.XtraBars.BarButtonItem();
            this.btnXOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnGHI = new DevExpress.XtraBars.BarButtonItem();
            this.btnHOANTAC = new DevExpress.XtraBars.BarButtonItem();
            this.btnLAMMOI = new DevExpress.XtraBars.BarButtonItem();
            this.btnTHOAT = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnCHUYENCHINHANH = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbCHINHANH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet = new QLTVT.DataSet();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QLTVT.DataSetTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLTVT.DataSetTableAdapters.TableAdapterManager();
            this.gcVATTU = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapLieu = new DevExpress.XtraEditors.GroupControl();
            this.txtSOLUONGTON = new DevExpress.XtraEditors.SpinEdit();
            this.txtDONVIVATTU = new DevExpress.XtraEditors.TextEdit();
            this.txtTENVT = new DevExpress.XtraEditors.TextEdit();
            this.txtMAVT = new DevExpress.XtraEditors.TextEdit();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.ctpxTableAdapter = new QLTVT.DataSetTableAdapters.CTPXTableAdapter();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.ctpnTableAdapter = new QLTVT.DataSetTableAdapters.CTPNTableAdapter();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.ctddhTableAdapter = new QLTVT.DataSetTableAdapters.CTDDHTableAdapter();
            mAVTLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            sOLUONGTONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVATTU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).BeginInit();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOLUONGTON.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDONVIVATTU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            this.SuspendLayout();
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(22, 63);
            mAVTLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(45, 13);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "Wine ID";
            mAVTLabel.Click += new System.EventHandler(this.mAVTLabel_Click);
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(200, 63);
            tENVTLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(34, 13);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "Name";
            tENVTLabel.Click += new System.EventHandler(this.tENVTLabel_Click);
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(367, 63);
            dVTLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(26, 13);
            dVTLabel.TabIndex = 4;
            dVTLabel.Text = "Unit";
            dVTLabel.Click += new System.EventHandler(this.dVTLabel_Click);
            // 
            // sOLUONGTONLabel
            // 
            sOLUONGTONLabel.AutoSize = true;
            sOLUONGTONLabel.Location = new System.Drawing.Point(526, 63);
            sOLUONGTONLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sOLUONGTONLabel.Name = "sOLUONGTONLabel";
            sOLUONGTONLabel.Size = new System.Drawing.Size(49, 13);
            sOLUONGTONLabel.TabIndex = 6;
            sOLUONGTONLabel.Text = "Quantity";
            sOLUONGTONLabel.Click += new System.EventHandler(this.sOLUONGTONLabel_Click);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTHEM,
            this.btnXOA,
            this.btnGHI,
            this.btnHOANTAC,
            this.btnLAMMOI,
            this.btnCHUYENCHINHANH,
            this.btnTHOAT});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHEM, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXOA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGHI, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHOANTAC, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLAMMOI, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHOAT, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnTHEM
            // 
            this.btnTHEM.Caption = "Add";
            this.btnTHEM.Id = 0;
            this.btnTHEM.ImageOptions.SvgImage = global::QLTVT.Properties.Resources.weather_sunny1;
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(60, 0);
            this.btnTHEM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHEM_ItemClick);
            // 
            // btnXOA
            // 
            this.btnXOA.Caption = "Delete";
            this.btnXOA.Id = 1;
            this.btnXOA.ImageOptions.SvgImage = global::QLTVT.Properties.Resources.removedataitems1;
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(70, 0);
            this.btnXOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXOA_ItemClick);
            // 
            // btnGHI
            // 
            this.btnGHI.Caption = "Save";
            this.btnGHI.Id = 2;
            this.btnGHI.ImageOptions.Image = global::QLTVT.Properties.Resources.save;
            this.btnGHI.Name = "btnGHI";
            this.btnGHI.Size = new System.Drawing.Size(60, 0);
            this.btnGHI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGHI_ItemClick);
            // 
            // btnHOANTAC
            // 
            this.btnHOANTAC.Caption = "Undo";
            this.btnHOANTAC.Id = 3;
            this.btnHOANTAC.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHOANTAC.ImageOptions.SvgImage")));
            this.btnHOANTAC.Name = "btnHOANTAC";
            this.btnHOANTAC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHOANTAC_ItemClick);
            // 
            // btnLAMMOI
            // 
            this.btnLAMMOI.Caption = "Refresh";
            this.btnLAMMOI.Id = 4;
            this.btnLAMMOI.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLAMMOI.ImageOptions.SvgImage")));
            this.btnLAMMOI.Name = "btnLAMMOI";
            this.btnLAMMOI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLAMMOI_ItemClick);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Caption = "Exit";
            this.btnTHOAT.Id = 6;
            this.btnTHOAT.ImageOptions.SvgImage = global::QLTVT.Properties.Resources.delete1;
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnTHOAT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHOAT_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            this.bar3.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(714, 39);
            this.barDockControlTop.Click += new System.EventHandler(this.barDockControlTop_Click);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 481);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(714, 27);
            this.barDockControlBottom.Click += new System.EventHandler(this.barDockControlBottom_Click);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 442);
            this.barDockControlLeft.Click += new System.EventHandler(this.barDockControlLeft_Click);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(714, 39);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 442);
            this.barDockControlRight.Click += new System.EventHandler(this.barDockControlRight_Click);
            // 
            // btnCHUYENCHINHANH
            // 
            this.btnCHUYENCHINHANH.Caption = "Chuyển Chi Nhánh";
            this.btnCHUYENCHINHANH.Id = 5;
            this.btnCHUYENCHINHANH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCHUYENCHINHANH.ImageOptions.SvgImage")));
            this.btnCHUYENCHINHANH.Name = "btnCHUYENCHINHANH";
            this.btnCHUYENCHINHANH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCHUYENCHINHANH_ItemClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbCHINHANH);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 39);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(714, 60);
            this.panelControl1.TabIndex = 5;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // cmbCHINHANH
            // 
            this.cmbCHINHANH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCHINHANH.Enabled = false;
            this.cmbCHINHANH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCHINHANH.FormattingEnabled = true;
            this.cmbCHINHANH.Location = new System.Drawing.Point(313, 19);
            this.cmbCHINHANH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCHINHANH.MinimumSize = new System.Drawing.Size(151, 0);
            this.cmbCHINHANH.Name = "cmbCHINHANH";
            this.cmbCHINHANH.Size = new System.Drawing.Size(151, 25);
            this.cmbCHINHANH.TabIndex = 1;
            this.cmbCHINHANH.SelectedIndexChanged += new System.EventHandler(this.cmbCHINHANH_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(252, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branch";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "Vattu";
            this.bdsVatTu.DataSource = this.dataSet;
            this.bdsVatTu.CurrentChanged += new System.EventHandler(this.bdsVatTu_CurrentChanged);
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTVT.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // gcVATTU
            // 
            this.gcVATTU.DataSource = this.bdsVatTu;
            this.gcVATTU.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcVATTU.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gcVATTU.Location = new System.Drawing.Point(0, 99);
            this.gcVATTU.MainView = this.gridView1;
            this.gcVATTU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gcVATTU.MenuManager = this.barManager1;
            this.gcVATTU.Name = "gcVATTU";
            this.gcVATTU.Size = new System.Drawing.Size(714, 277);
            this.gcVATTU.TabIndex = 16;
            this.gcVATTU.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcVATTU.Click += new System.EventHandler(this.gcVATTU_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gridView1.DetailHeight = 284;
            gridFormatRule1.Description = null;
            gridFormatRule1.Name = "Format0";
            gridFormatRule1.Rule = null;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.GridControl = this.gcVATTU;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 600;
            // 
            // colMAVT
            // 
            this.colMAVT.AppearanceHeader.BackColor = System.Drawing.Color.DarkRed;
            this.colMAVT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAVT.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colMAVT.AppearanceHeader.Options.UseBackColor = true;
            this.colMAVT.AppearanceHeader.Options.UseFont = true;
            this.colMAVT.AppearanceHeader.Options.UseForeColor = true;
            this.colMAVT.AppearanceHeader.Options.UseTextOptions = true;
            this.colMAVT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAVT.Caption = "Wine ID";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 19;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.AllowEdit = false;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            this.colMAVT.Width = 70;
            // 
            // colTENVT
            // 
            this.colTENVT.AppearanceHeader.BackColor = System.Drawing.Color.DarkRed;
            this.colTENVT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENVT.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colTENVT.AppearanceHeader.Options.UseBackColor = true;
            this.colTENVT.AppearanceHeader.Options.UseFont = true;
            this.colTENVT.AppearanceHeader.Options.UseForeColor = true;
            this.colTENVT.AppearanceHeader.Options.UseTextOptions = true;
            this.colTENVT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTENVT.Caption = "Name";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.MinWidth = 19;
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.OptionsColumn.AllowEdit = false;
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            this.colTENVT.Width = 70;
            // 
            // colDVT
            // 
            this.colDVT.AppearanceHeader.BackColor = System.Drawing.Color.DarkRed;
            this.colDVT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDVT.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colDVT.AppearanceHeader.Options.UseBackColor = true;
            this.colDVT.AppearanceHeader.Options.UseFont = true;
            this.colDVT.AppearanceHeader.Options.UseForeColor = true;
            this.colDVT.AppearanceHeader.Options.UseTextOptions = true;
            this.colDVT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDVT.Caption = "Unit";
            this.colDVT.FieldName = "DVT";
            this.colDVT.MinWidth = 19;
            this.colDVT.Name = "colDVT";
            this.colDVT.OptionsColumn.AllowEdit = false;
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            this.colDVT.Width = 70;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.AppearanceHeader.BackColor = System.Drawing.Color.DarkRed;
            this.colSOLUONGTON.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOLUONGTON.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colSOLUONGTON.AppearanceHeader.Options.UseBackColor = true;
            this.colSOLUONGTON.AppearanceHeader.Options.UseFont = true;
            this.colSOLUONGTON.AppearanceHeader.Options.UseForeColor = true;
            this.colSOLUONGTON.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOLUONGTON.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOLUONGTON.Caption = "Quantity";
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.MinWidth = 19;
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.OptionsColumn.AllowEdit = false;
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            this.colSOLUONGTON.Width = 70;
            // 
            // panelNhapLieu
            // 
            this.panelNhapLieu.AppearanceCaption.BorderColor = System.Drawing.Color.IndianRed;
            this.panelNhapLieu.AppearanceCaption.Options.UseBorderColor = true;
            this.panelNhapLieu.Controls.Add(sOLUONGTONLabel);
            this.panelNhapLieu.Controls.Add(this.txtSOLUONGTON);
            this.panelNhapLieu.Controls.Add(dVTLabel);
            this.panelNhapLieu.Controls.Add(this.txtDONVIVATTU);
            this.panelNhapLieu.Controls.Add(tENVTLabel);
            this.panelNhapLieu.Controls.Add(this.txtTENVT);
            this.panelNhapLieu.Controls.Add(mAVTLabel);
            this.panelNhapLieu.Controls.Add(this.txtMAVT);
            this.panelNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapLieu.Location = new System.Drawing.Point(0, 376);
            this.panelNhapLieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(714, 105);
            this.panelNhapLieu.TabIndex = 21;
            this.panelNhapLieu.Text = "Thông tin";
            this.panelNhapLieu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNhapLieu_Paint);
            // 
            // txtSOLUONGTON
            // 
            this.txtSOLUONGTON.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVatTu, "SOLUONGTON", true));
            this.txtSOLUONGTON.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSOLUONGTON.Location = new System.Drawing.Point(576, 55);
            this.txtSOLUONGTON.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSOLUONGTON.MenuManager = this.barManager1;
            this.txtSOLUONGTON.MinimumSize = new System.Drawing.Size(101, 28);
            this.txtSOLUONGTON.Name = "txtSOLUONGTON";
            this.txtSOLUONGTON.Properties.AutoHeight = false;
            this.txtSOLUONGTON.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSOLUONGTON.Properties.DisplayFormat.FormatString = "n0";
            this.txtSOLUONGTON.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSOLUONGTON.Properties.EditFormat.FormatString = "n0";
            this.txtSOLUONGTON.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSOLUONGTON.Properties.MaxValue = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.txtSOLUONGTON.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSOLUONGTON.Size = new System.Drawing.Size(101, 28);
            this.txtSOLUONGTON.TabIndex = 7;
            this.txtSOLUONGTON.EditValueChanged += new System.EventHandler(this.txtSOLUONGTON_EditValueChanged);
            // 
            // txtDONVIVATTU
            // 
            this.txtDONVIVATTU.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVatTu, "DVT", true));
            this.txtDONVIVATTU.Location = new System.Drawing.Point(395, 55);
            this.txtDONVIVATTU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDONVIVATTU.MenuManager = this.barManager1;
            this.txtDONVIVATTU.MinimumSize = new System.Drawing.Size(101, 28);
            this.txtDONVIVATTU.Name = "txtDONVIVATTU";
            this.txtDONVIVATTU.Properties.AutoHeight = false;
            this.txtDONVIVATTU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDONVIVATTU.Size = new System.Drawing.Size(101, 28);
            this.txtDONVIVATTU.TabIndex = 5;
            this.txtDONVIVATTU.EditValueChanged += new System.EventHandler(this.txtDONVIVATTU_EditValueChanged);
            // 
            // txtTENVT
            // 
            this.txtTENVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVatTu, "TENVT", true));
            this.txtTENVT.Location = new System.Drawing.Point(236, 55);
            this.txtTENVT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTENVT.MenuManager = this.barManager1;
            this.txtTENVT.MinimumSize = new System.Drawing.Size(101, 28);
            this.txtTENVT.Name = "txtTENVT";
            this.txtTENVT.Properties.AutoHeight = false;
            this.txtTENVT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTENVT.Size = new System.Drawing.Size(101, 28);
            this.txtTENVT.TabIndex = 3;
            this.txtTENVT.EditValueChanged += new System.EventHandler(this.txtTENVT_EditValueChanged);
            // 
            // txtMAVT
            // 
            this.txtMAVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVatTu, "MAVT", true));
            this.txtMAVT.Location = new System.Drawing.Point(69, 55);
            this.txtMAVT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMAVT.MenuManager = this.barManager1;
            this.txtMAVT.MinimumSize = new System.Drawing.Size(101, 28);
            this.txtMAVT.Name = "txtMAVT";
            this.txtMAVT.Properties.AutoHeight = false;
            this.txtMAVT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMAVT.Size = new System.Drawing.Size(101, 28);
            this.txtMAVT.TabIndex = 1;
            this.txtMAVT.EditValueChanged += new System.EventHandler(this.txtMAVT_EditValueChanged);
            // 
            // bdsCTPX
            // 
            this.bdsCTPX.DataMember = "FK_CTPX_VatTu";
            this.bdsCTPX.DataSource = this.bdsVatTu;
            this.bdsCTPX.CurrentChanged += new System.EventHandler(this.bdsCTPX_CurrentChanged);
            // 
            // ctpxTableAdapter
            // 
            this.ctpxTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_CTPN_VatTu";
            this.bdsCTPN.DataSource = this.bdsVatTu;
            this.bdsCTPN.CurrentChanged += new System.EventHandler(this.bdsCTPN_CurrentChanged);
            // 
            // ctpnTableAdapter
            // 
            this.ctpnTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "FK_CTDDH_VatTu";
            this.bdsCTDDH.DataSource = this.bdsVatTu;
            this.bdsCTDDH.CurrentChanged += new System.EventHandler(this.bdsCTDDH_CurrentChanged);
            // 
            // ctddhTableAdapter
            // 
            this.ctddhTableAdapter.ClearBeforeFill = true;
            // 
            // FormVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 508);
            this.Controls.Add(this.panelNhapLieu);
            this.Controls.Add(this.gcVATTU);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormVatTu";
            this.Text = "Wine";
            this.Load += new System.EventHandler(this.FormVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVATTU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).EndInit();
            this.panelNhapLieu.ResumeLayout(false);
            this.panelNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOLUONGTON.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDONVIVATTU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnTHEM;
        private DevExpress.XtraBars.BarButtonItem btnXOA;
        private DevExpress.XtraBars.BarButtonItem btnGHI;
        private DevExpress.XtraBars.BarButtonItem btnHOANTAC;
        private DevExpress.XtraBars.BarButtonItem btnLAMMOI;
        private DevExpress.XtraBars.BarButtonItem btnCHUYENCHINHANH;
        private DevExpress.XtraBars.BarButtonItem btnTHOAT;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbCHINHANH;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private DataSet dataSet;
        private DataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcVATTU;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private DevExpress.XtraEditors.GroupControl panelNhapLieu;
        private DevExpress.XtraEditors.SpinEdit txtSOLUONGTON;
        private DevExpress.XtraEditors.TextEdit txtDONVIVATTU;
        private DevExpress.XtraEditors.TextEdit txtTENVT;
        private DevExpress.XtraEditors.TextEdit txtMAVT;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private DataSetTableAdapters.CTPXTableAdapter ctpxTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private DataSetTableAdapters.CTPNTableAdapter ctpnTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private DataSetTableAdapters.CTDDHTableAdapter ctddhTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}