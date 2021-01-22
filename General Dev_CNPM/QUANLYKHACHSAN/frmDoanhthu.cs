using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace QUANLYKHACHSAN
{
    public partial class frmDoanhthu : DevExpress.XtraEditors.XtraUserControl
    {
        public frmDoanhthu()
        {
            InitializeComponent();
            loadCBO();
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }
        private void loadCBO()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("", "---Chọn---");
            dic.Add("Month", "Tháng");
            dic.Add("Quarter", "Quý");
            dic.Add("Year", "Năm");
            cboLuaChon.DataSource = new BindingSource(dic, null);
            cboLuaChon.DisplayMember = "Value";
            cboLuaChon.ValueMember = "Key";
            cboLuaChon.SelectedIndex = 0;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmdText = "";
            if (cboLuaChon.SelectedValue.Equals("Month"))
                cmdText = "select MONTH(NgayLap) as colname, sum(TongTien) as TongTien From HOA_DON group by(MONTH(NgayLap))";
            if (cboLuaChon.SelectedValue.Equals("Quarter"))
                cmdText = "select datepart(QUARTER,NgayLap) as colname, sum(TongTien) as TongTien From HOA_DON group by(datepart(QUARTER,NgayLap))";
            if (cboLuaChon.SelectedValue.Equals("Year"))
                cmdText = "select YEAR(NgayLap) as colname, sum(TongTien) as TongTien From HOA_DON group by(YEAR(NgayLap))";
            DataSet ds = GetData(cmdText);
            LoadCharProduct(ds); 
        }
        private DataSet GetData(string cmdText)
        {
            if (!cmdText.Equals(string.Empty))
            {
                string constr = ConfigurationManager.ConnectionStrings["QLKS_DB"].ConnectionString;
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds, "Data");
                return ds;
            }
            return null;
        }
        private void LoadCharProduct(DataSet ds)
        {
            if(ds!=null)
            {
                chartControl1.DataSource = ds.Tables["Data"];
                chartControl1.Series["SrChart"].ArgumentDataMember = "colname";
                chartControl1.Series["SrChart"].ValueDataMembers.AddRange(new string[] { "TongTien" });
                chartControl1.Series["SrChart"].LegendTextPattern = "  {A}";
                chartControl1.Series["SrChart"].Label.TextPattern = "{V:c2}";
                PieSeriesView myView = (PieSeriesView)chartControl1.Series["SrChart"].View;
                myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Value_1,
                DataFilterCondition.GreaterThanOrEqual, 9));
                myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Argument,
                    DataFilterCondition.NotEqual, "Others"));
                myView.ExplodeMode = PieExplodeMode.UseFilters;
                myView.ExplodedDistancePercentage = 5;
                myView.RuntimeExploding = true;
            }    
        }

        private void icoBtnPrint_Click(object sender, EventArgs e)
        {
            var cmdText = "";
            var unit = "";
            if (cboLuaChon.SelectedValue.Equals("Month"))
            {
                cmdText = "select MONTH(NgayLap) as Unit, sum(TongTien) as Value From HOA_DON group by(MONTH(NgayLap))";
                unit = "Tháng";
            }    
            if (cboLuaChon.SelectedValue.Equals("Quarter"))
            {
                cmdText = "select datepart(QUARTER,NgayLap) as Unit, sum(TongTien) as Value From HOA_DON group by(datepart(QUARTER,NgayLap))";
                unit = "Quý";
            }    
            if (cboLuaChon.SelectedValue.Equals("Year"))
            {
                cmdText = "select YEAR(NgayLap) as Unit, sum(TongTien) as Value From HOA_DON group by(YEAR(NgayLap))";
                unit = "Năm";
            }    
            DataSet ds = GetData(cmdText);
            ClassReport.ReportDataDoanhThu dt = new ClassReport.ReportDataDoanhThu();
            FormReport.ReportDoanhThu Frm = new FormReport.ReportDoanhThu(unit);
            Frm.DataSource = ds.Tables["Data"];
            frmReportViewer Rpv = new frmReportViewer(Frm);
            Rpv.ShowDialog();
        }
    }
}
