using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT.ReportForm
{
    public partial class FormNhapXuatTongHop : Form
    {
        public FormNhapXuatTongHop()
        {
            InitializeComponent();
        }

        private void FormTongHopNhapXuat_Load(object sender, EventArgs e)
        {
            /*Step 2*/
            cmbCHINHANH.DataSource = Program.bindingSource;/*sao chep bingding source tu form dang nhap*/
            cmbCHINHANH.DisplayMember = "TENCN";
            cmbCHINHANH.ValueMember = "TENSERVER";
            cmbCHINHANH.SelectedIndex = Program.brand;

            dteTuNgay.EditValue = "01-05-2000";
            dteToiNgay.EditValue = DateTime.Today.ToString("dd-MM-yyyy");

            if (Program.role == "CONGTY")
            {
                cmbCHINHANH.Enabled = true;
            }    
        }

        private void cmbCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            /*Neu combobox khong co so lieu thi ket thuc luon*/
            if (cmbCHINHANH.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.serverName = cmbCHINHANH.SelectedValue.ToString();

            /*Neu chon sang chi nhanh khac voi chi nhanh hien tai*/
            if (cmbCHINHANH.SelectedIndex != Program.brand)
            {
                Program.loginName = Program.remoteLogin;
                Program.loginPassword = Program.remotePassword;
            }
            /*Neu chon trung voi chi nhanh dang dang nhap o formDangNhap*/
            else
            {
                Program.loginName = Program.currentLogin;
                Program.loginPassword = Program.currentPassword;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fromDate = (DateTime)dteTuNgay.DateTime;
            DateTime toDate = (DateTime)dteToiNgay.DateTime;
            string chiNhanh = cmbCHINHANH.SelectedValue.ToString().Contains("1") ? "Helsinki" : "Lisbon";

            
            ReportNhapXuatTongHop report = new ReportNhapXuatTongHop(fromDate, toDate);
            report.txtTuNgay.Text = dteTuNgay.EditValue.ToString();
            report.txtToiNgay.Text = dteToiNgay.EditValue.ToString();
            report.txtChiNhanh.Text = chiNhanh;

            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime fromDate = (DateTime)dteTuNgay.DateTime;
            DateTime toDate = (DateTime)dteToiNgay.DateTime;
            string chiNhanh = cmbCHINHANH.SelectedValue.ToString().Contains("1") ? "Helsinki" : "Lisbon";

            try
            {

                ReportNhapXuatTongHop report = new ReportNhapXuatTongHop(fromDate, toDate);
               
                report.txtTuNgay.Text = dteTuNgay.EditValue.ToString();
                report.txtToiNgay.Text = dteToiNgay.EditValue.ToString();
                report.txtChiNhanh.Text = chiNhanh.ToUpper();


                if (File.Exists(@"D:\ReportNhapXuatTongHop.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File ReportNhapXuatTongHop.pdf tại ổ D đã có!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        report.ExportToPdf(@"D:\ReportNhapXuatTongHop.pdf");
                        MessageBox.Show("File ReportChiTietSoLuongTriGiaHangHoaNhapXuat.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    report.ExportToPdf(@"D:\ReportNhapXuatTongHop.pdf");
                    MessageBox.Show("File ReportNhapXuatTongHop.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file ReportNhapXuatTongHop.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
