namespace RBI.PRE.subForm.OutputDataForm
{
    partial class UCDrawGraph
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chartRisk = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartRisk)).BeginInit();
            this.SuspendLayout();
            // 
            // chartRisk
            // 
            this.chartRisk.DataBindings = null;
            this.chartRisk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartRisk.Legend.Name = "Default Legend";
            this.chartRisk.Location = new System.Drawing.Point(0, 0);
            this.chartRisk.Name = "chartRisk";
            this.chartRisk.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartRisk.Size = new System.Drawing.Size(577, 433);
            this.chartRisk.TabIndex = 0;
            // 
            // UCDrawGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartRisk);
            this.Name = "UCDrawGraph";
            this.Size = new System.Drawing.Size(577, 433);
            ((System.ComponentModel.ISupportInitialize)(this.chartRisk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartRisk;

    }
}
