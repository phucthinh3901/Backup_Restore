using System;

namespace backup_restore
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSaoluu = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhuchoi = new DevExpress.XtraBars.BarButtonItem();
            this.chk_Thamsotg = new DevExpress.XtraBars.BarCheckItem();
            this.btnTaodevice = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaBk = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnThamsophuchoi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem2 = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bK_RSDataSet = new backup_restore.BK_RSDataSet();
            this.databasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databasesTableAdapter = new backup_restore.BK_RSDataSetTableAdapters.databasesTableAdapter();
            this.tableAdapterManager = new backup_restore.BK_RSDataSetTableAdapters.TableAdapterManager();
            this.databasesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bK_RSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bK_RSTableAdapter = new backup_restore.BK_RSDataSetTableAdapters.BK_RSTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.dBNAMEToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.hideNAME = new System.Windows.Forms.ToolStripTextBox();
            this.Vesion_BK = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.vesionBk = new System.Windows.Forms.ToolStripTextBox();
            this.bK_RSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_XoaBK = new System.Windows.Forms.CheckBox();
            this.dateEdit = new System.Windows.Forms.DateTimePicker();
            this.HidePanal_EditEtime = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bK_RSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bK_RSBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bK_RSDataGridView)).BeginInit();
            this.HidePanal_EditEtime.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSaoluu,
            this.barButtonItem2,
            this.btnPhuchoi,
            this.btnThamsophuchoi,
            this.btnTaodevice,
            this.barButtonItem1,
            this.barCheckItem1,
            this.barCheckItem2,
            this.barButtonItem3,
            this.chk_Thamsotg,
            this.btnXoaBk});
            this.barManager1.MaxItemId = 11;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSaoluu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhuchoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.chk_Thamsotg, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTaodevice, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaBk, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnSaoluu
            // 
            this.btnSaoluu.Caption = "Sao lưu";
            this.btnSaoluu.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSaoluu.Glyph")));
            this.btnSaoluu.Id = 0;
            this.btnSaoluu.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSaoluu.LargeGlyph")));
            this.btnSaoluu.Name = "btnSaoluu";
            this.btnSaoluu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaoluu_ItemClick);
            // 
            // btnPhuchoi
            // 
            this.btnPhuchoi.Caption = "Phục hồi";
            this.btnPhuchoi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPhuchoi.Glyph")));
            this.btnPhuchoi.Id = 2;
            this.btnPhuchoi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPhuchoi.LargeGlyph")));
            this.btnPhuchoi.Name = "btnPhuchoi";
            this.btnPhuchoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhuchoi_ItemClick);
            // 
            // chk_Thamsotg
            // 
            this.chk_Thamsotg.Caption = "Tham số thời gian";
            this.chk_Thamsotg.Id = 9;
            this.chk_Thamsotg.ImageUri.Uri = "Today";
            this.chk_Thamsotg.Name = "chk_Thamsotg";
            this.chk_Thamsotg.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime;
            this.chk_Thamsotg.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chk_Thamsotg_CheckedChanged);
            // 
            // btnTaodevice
            // 
            this.btnTaodevice.Caption = "Tạo Device sao lưu";
            this.btnTaodevice.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTaodevice.Glyph")));
            this.btnTaodevice.Id = 4;
            this.btnTaodevice.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTaodevice.LargeGlyph")));
            this.btnTaodevice.Name = "btnTaodevice";
            this.btnTaodevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoDevice_ItemClick);
            // 
            // btnXoaBk
            // 
            this.btnXoaBk.Caption = "Xoá";
            this.btnXoaBk.Id = 10;
            this.btnXoaBk.ImageUri.Uri = "Cancel";
            this.btnXoaBk.Name = "btnXoaBk";
            this.btnXoaBk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaBk_ItemClick);
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
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1262, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 648);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1262, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 609);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1262, 39);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 609);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnThamsophuchoi
            // 
            this.btnThamsophuchoi.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnThamsophuchoi.Caption = "Tham số phục hồi theo thời gian";
            this.btnThamsophuchoi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThamsophuchoi.Glyph")));
            this.btnThamsophuchoi.Id = 3;
            this.btnThamsophuchoi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThamsophuchoi.LargeGlyph")));
            this.btnThamsophuchoi.Name = "btnThamsophuchoi";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.ImageUri.Uri = "MonthView";
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 6;
            this.barCheckItem1.ImageUri.Uri = "MonthView";
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // barCheckItem2
            // 
            this.barCheckItem2.Caption = "Tham số thời gian";
            this.barCheckItem2.Id = 7;
            this.barCheckItem2.ImageUri.Uri = "Today";
            this.barCheckItem2.Name = "barCheckItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 8;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // bK_RSDataSet
            // 
            this.bK_RSDataSet.DataSetName = "BK_RSDataSet";
            this.bK_RSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databasesBindingSource
            // 
            this.databasesBindingSource.DataMember = "databases";
            this.databasesBindingSource.DataSource = this.bK_RSDataSet;
            // 
            // databasesTableAdapter
            // 
            this.databasesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = backup_restore.BK_RSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // databasesDataGridView
            // 
            this.databasesDataGridView.AllowUserToAddRows = false;
            this.databasesDataGridView.AllowUserToDeleteRows = false;
            this.databasesDataGridView.AutoGenerateColumns = false;
            this.databasesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databasesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.databasesDataGridView.DataSource = this.databasesBindingSource;
            this.databasesDataGridView.Location = new System.Drawing.Point(0, 69);
            this.databasesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.databasesDataGridView.Name = "databasesDataGridView";
            this.databasesDataGridView.ReadOnly = true;
            this.databasesDataGridView.RowTemplate.Height = 24;
            this.databasesDataGridView.Size = new System.Drawing.Size(190, 348);
            this.databasesDataGridView.TabIndex = 5;
            this.databasesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.databasesDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cơ sở dữ liệu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // bK_RSBindingSource
            // 
            this.bK_RSBindingSource.DataMember = "BK_RS";
            this.bK_RSBindingSource.DataSource = this.bK_RSDataSet;
            // 
            // bK_RSTableAdapter
            // 
            this.bK_RSTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBNAMEToolStripLabel,
            this.hideNAME,
            this.Vesion_BK,
            this.toolStripLabel1,
            this.vesionBk});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 39);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1262, 27);
            this.fillToolStrip.TabIndex = 6;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // dBNAMEToolStripLabel
            // 
            this.dBNAMEToolStripLabel.Name = "dBNAMEToolStripLabel";
            this.dBNAMEToolStripLabel.Size = new System.Drawing.Size(74, 24);
            this.dBNAMEToolStripLabel.Text = "DBNAME:";
            // 
            // hideNAME
            // 
            this.hideNAME.Name = "hideNAME";
            this.hideNAME.Size = new System.Drawing.Size(142, 27);
            // 
            // Vesion_BK
            // 
            this.Vesion_BK.Name = "Vesion_BK";
            this.Vesion_BK.Size = new System.Drawing.Size(0, 24);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(102, 24);
            this.toolStripLabel1.Text = "Tên phiên bản";
            // 
            // vesionBk
            // 
            this.vesionBk.Name = "vesionBk";
            this.vesionBk.Size = new System.Drawing.Size(100, 27);
            // 
            // bK_RSDataGridView
            // 
            this.bK_RSDataGridView.AllowUserToAddRows = false;
            this.bK_RSDataGridView.AutoGenerateColumns = false;
            this.bK_RSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bK_RSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.bK_RSDataGridView.DataSource = this.bK_RSBindingSource;
            this.bK_RSDataGridView.Location = new System.Drawing.Point(196, 69);
            this.bK_RSDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.bK_RSDataGridView.Name = "bK_RSDataGridView";
            this.bK_RSDataGridView.RowTemplate.Height = 24;
            this.bK_RSDataGridView.Size = new System.Drawing.Size(1066, 348);
            this.bK_RSDataGridView.TabIndex = 7;
            this.bK_RSDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bK_RSDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "position";
            this.dataGridViewTextBoxColumn3.HeaderText = "    Vị trí";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Diễn giải";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 400;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "backup_start_date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ngày giờ sao lưu";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 300;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "user_name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Người dùng";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 300;
            // 
            // chk_XoaBK
            // 
            this.chk_XoaBK.AutoSize = true;
            this.chk_XoaBK.Location = new System.Drawing.Point(434, 434);
            this.chk_XoaBK.Name = "chk_XoaBK";
            this.chk_XoaBK.Size = new System.Drawing.Size(449, 25);
            this.chk_XoaBK.TabIndex = 12;
            this.chk_XoaBK.Text = "Xoá tất cả các bản sao lưu cũ trước khi sao lưu bản mới";
            this.chk_XoaBK.UseVisualStyleBackColor = true;
            this.chk_XoaBK.CheckedChanged += new System.EventHandler(this.chk_XoaBK_CheckedChanged);
            // 
            // dateEdit
            // 
            this.dateEdit.CustomFormat = "dd/MM/yy hh:mm:ss tt";
            this.dateEdit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEdit.Location = new System.Drawing.Point(252, 12);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Size = new System.Drawing.Size(285, 28);
            this.dateEdit.TabIndex = 45;
            this.dateEdit.Value = new System.DateTime(2022, 4, 22, 0, 13, 19, 0);
            // 
            // HidePanal_EditEtime
            // 
            this.HidePanal_EditEtime.Controls.Add(this.label1);
            this.HidePanal_EditEtime.Controls.Add(this.dateEdit);
            this.HidePanal_EditEtime.Location = new System.Drawing.Point(196, 465);
            this.HidePanal_EditEtime.Name = "HidePanal_EditEtime";
            this.HidePanal_EditEtime.Size = new System.Drawing.Size(922, 128);
            this.HidePanal_EditEtime.TabIndex = 50;
            this.HidePanal_EditEtime.Visible = false;
            this.HidePanal_EditEtime.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(823, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.HidePanal_EditEtime);
            this.Controls.Add(this.chk_XoaBK);
            this.Controls.Add(this.bK_RSDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.databasesDataGridView);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bK_RSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bK_RSBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bK_RSDataGridView)).EndInit();
            this.HidePanal_EditEtime.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnSaoluu;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnPhuchoi;
        private DevExpress.XtraBars.BarButtonItem btnThamsophuchoi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.BindingSource databasesBindingSource;
        private BK_RSDataSet bK_RSDataSet;
        private BK_RSDataSetTableAdapters.databasesTableAdapter databasesTableAdapter;
        private BK_RSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel dBNAMEToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox hideNAME;
        private System.Windows.Forms.DataGridView databasesDataGridView;
        private System.Windows.Forms.BindingSource bK_RSBindingSource;
        private BK_RSDataSetTableAdapters.BK_RSTableAdapter bK_RSTableAdapter;
        private System.Windows.Forms.DataGridView bK_RSDataGridView;
        private DevExpress.XtraBars.BarButtonItem btnTaodevice;
        private System.Windows.Forms.CheckBox chk_XoaBK;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarCheckItem chk_Thamsotg;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem2;
        private DevExpress.XtraBars.BarButtonItem btnXoaBk;
        private System.Windows.Forms.DateTimePicker dateEdit;
        private System.Windows.Forms.ToolStripLabel Vesion_BK;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox vesionBk;
        private System.Windows.Forms.Panel HidePanal_EditEtime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

