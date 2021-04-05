using MarketStackLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketstackUI
{
    public partial class FrmMarketStack : Form
    {
        public MarksetStackManager marksetStackManager;
        public FrmMarketStack()
        {
            InitializeComponent();
            marksetStackManager = new MarksetStackManager();
        }

        private void FrmMarketStack_Load(object sender, EventArgs e)
        {
            LblPlaceHolder.BringToFront();
        }

        private void RtxtTickers_TextChanged(object sender, EventArgs e)
        {
            if (RtxtTickers.Text != "")
            {
                LblPlaceHolder.SendToBack();
            }
            else
            {
                LblPlaceHolder.BringToFront();
            }
        }

        private void BtnEndOfDay_Click(object sender, EventArgs e)
        {
            try
            {
                if (RtxtTickers.Text != "")
                {
                    string tickers = RtxtTickers.Text;
                    DataTable dtEOD = marksetStackManager.ReadEndOfTheDayData(tickers);
                    int rows = dtEOD.Rows.Count;
                }
                else
                {
                    throw new Exception("Enter atleast one ticker");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnIntraDayData_Click(object sender, EventArgs e)
        {
            try
            {
                if (RtxtTickers.Text != "")
                {
                    string tickers = RtxtTickers.Text;
                    DataTable dtIntraday = marksetStackManager.ReadIntraData(tickers);
                    int rows = dtIntraday.Rows.Count;
                }
                else
                {
                    throw new Exception("Enter atleast one ticker");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnHistoricalData_Click(object sender, EventArgs e)
        {

            try
            {
                if (RtxtTickers.Text != "")
                {
                    string tickers = RtxtTickers.Text;
                    DateTime fromDate = DtStartDate.Value;
                    DateTime toDate = DtEndDate.Value;
                    DataTable dthistoric = marksetStackManager.ReadHistoricData(tickers, fromDate, toDate);
                    int rows = dthistoric.Rows.Count;
                }
                else
                {
                    throw new Exception("Enter atleast one ticker");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
