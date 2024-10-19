﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLTVT.ReportForm
{
    public partial class ReportNhanVienChiTiet : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportNhanVienChiTiet()
        {
            InitializeComponent();
        }

        public ReportNhanVienChiTiet(String maNhanVien, String loaiPhieu, DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maNhanVien;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = loaiPhieu;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = fromDate;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = toDate;

            this.sqlDataSource1.Fill();
        }
    }
}