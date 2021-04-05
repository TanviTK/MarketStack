namespace MarketstackUI
{
    partial class FrmMarketStack
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
            this.RtxtTickers = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblPlaceHolder = new System.Windows.Forms.Label();
            this.BtnEndOfDay = new System.Windows.Forms.Button();
            this.BtnIntraDayData = new System.Windows.Forms.Button();
            this.DtStartDate = new System.Windows.Forms.DateTimePicker();
            this.DtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnHistoricalData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RtxtTickers
            // 
            this.RtxtTickers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RtxtTickers.Location = new System.Drawing.Point(40, 43);
            this.RtxtTickers.Name = "RtxtTickers";
            this.RtxtTickers.Size = new System.Drawing.Size(415, 117);
            this.RtxtTickers.TabIndex = 0;
            this.RtxtTickers.Text = "";
            this.RtxtTickers.TextChanged += new System.EventHandler(this.RtxtTickers_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tickers";
            // 
            // LblPlaceHolder
            // 
            this.LblPlaceHolder.AutoSize = true;
            this.LblPlaceHolder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPlaceHolder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblPlaceHolder.Location = new System.Drawing.Point(54, 56);
            this.LblPlaceHolder.Name = "LblPlaceHolder";
            this.LblPlaceHolder.Size = new System.Drawing.Size(295, 13);
            this.LblPlaceHolder.TabIndex = 2;
            this.LblPlaceHolder.Text = "please enter comma separated tickers. Example: AAPL,TSLA";
            // 
            // BtnEndOfDay
            // 
            this.BtnEndOfDay.Location = new System.Drawing.Point(40, 167);
            this.BtnEndOfDay.Name = "BtnEndOfDay";
            this.BtnEndOfDay.Size = new System.Drawing.Size(415, 23);
            this.BtnEndOfDay.TabIndex = 3;
            this.BtnEndOfDay.Text = "End-Of-Day Data";
            this.BtnEndOfDay.UseVisualStyleBackColor = true;
            this.BtnEndOfDay.Click += new System.EventHandler(this.BtnEndOfDay_Click);
            // 
            // BtnIntraDayData
            // 
            this.BtnIntraDayData.Location = new System.Drawing.Point(40, 201);
            this.BtnIntraDayData.Name = "BtnIntraDayData";
            this.BtnIntraDayData.Size = new System.Drawing.Size(415, 22);
            this.BtnIntraDayData.TabIndex = 4;
            this.BtnIntraDayData.Text = "IntraDay Data";
            this.BtnIntraDayData.UseVisualStyleBackColor = true;
            this.BtnIntraDayData.Click += new System.EventHandler(this.BtnIntraDayData_Click);
            // 
            // DtStartDate
            // 
            this.DtStartDate.Location = new System.Drawing.Point(116, 239);
            this.DtStartDate.Name = "DtStartDate";
            this.DtStartDate.Size = new System.Drawing.Size(339, 20);
            this.DtStartDate.TabIndex = 5;
            // 
            // DtEndDate
            // 
            this.DtEndDate.Location = new System.Drawing.Point(116, 266);
            this.DtEndDate.Name = "DtEndDate";
            this.DtEndDate.Size = new System.Drawing.Size(339, 20);
            this.DtEndDate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "End Date";
            // 
            // BtnHistoricalData
            // 
            this.BtnHistoricalData.Location = new System.Drawing.Point(40, 298);
            this.BtnHistoricalData.Name = "BtnHistoricalData";
            this.BtnHistoricalData.Size = new System.Drawing.Size(415, 23);
            this.BtnHistoricalData.TabIndex = 9;
            this.BtnHistoricalData.Text = "Historical Data";
            this.BtnHistoricalData.UseVisualStyleBackColor = true;
            this.BtnHistoricalData.Click += new System.EventHandler(this.BtnHistoricalData_Click);
            // 
            // FrmMarketStack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 351);
            this.Controls.Add(this.BtnHistoricalData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtEndDate);
            this.Controls.Add(this.DtStartDate);
            this.Controls.Add(this.BtnIntraDayData);
            this.Controls.Add(this.BtnEndOfDay);
            this.Controls.Add(this.LblPlaceHolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RtxtTickers);
            this.Name = "FrmMarketStack";
            this.Text = "MarketStack";
            this.Load += new System.EventHandler(this.FrmMarketStack_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RtxtTickers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblPlaceHolder;
        private System.Windows.Forms.Button BtnEndOfDay;
        private System.Windows.Forms.Button BtnIntraDayData;
        private System.Windows.Forms.DateTimePicker DtStartDate;
        private System.Windows.Forms.DateTimePicker DtEndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnHistoricalData;
    }
}

