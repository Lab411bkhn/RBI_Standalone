using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using RBI.BUS.BUSMSSQL;

namespace RBI.PRE.subForm.OutputDataForm
{
    public partial class UCDrawGraph : UserControl
    {
        public UCDrawGraph(int ID)
        {
            InitializeComponent();
            DrawGraph(ID);
        }

        private void DrawGraph(int ID)
        {
            RW_RISK_GRAPH_BUS busRiskGraph = new RW_RISK_GRAPH_BUS();
            try
            {
                List<float> data = busRiskGraph.GetData(ID);
                Series riskTarget = new Series("Risk Target", ViewType.Spline);
                Series risk = new Series("Risk", ViewType.Spline);
                for (int i = 0; i < data.Count; i++)
                {
                    risk.Points.Add(new SeriesPoint(2000 + i, new double[] { data[i] }));
                    riskTarget.Points.Add(new SeriesPoint(2000 + i, new double[] { 12000000 }));
                }
                
                chartRisk.Series.Add(risk);
                chartRisk.Series.Add(riskTarget);
                // Define the chart's appearance and palette.
                chartRisk.AppearanceName = "Light";
                chartRisk.PaletteName = "Opulent";
                chartRisk.PaletteBaseColorNumber = 5;

                // Define a separate palette for the chart's indicators.
                chartRisk.IndicatorsPaletteName = "Default";

                // Add the chart to the form.
                chartRisk.Dock = DockStyle.Fill;
                this.Controls.Add(chartRisk);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error------>" + ex.ToString(), "Error");
            }
        }
    }
}
