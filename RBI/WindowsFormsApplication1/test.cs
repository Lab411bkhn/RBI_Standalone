using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using RBI.DAL.MSSQL_CAL;
using System.Diagnostics;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Design;
using DevExpress.XtraTreeList.Menu;
using DevExpress.XtraTreeList.Nodes;
using System.Net;
using RBI.BUS.BUSExcel;
using RBI.Object.ObjectMSSQL;
using DevExpress.XtraCharts;

namespace RBI
{
    
    public partial class test : Form
    {
        private int [] a = new int[3];
        public int[] I
        {
            set
            {
                a = value;
            }
            get
            {
                return a;
            }
        }
        public test()
        {
            InitializeComponent();
            a[0] = 1; a[1] = 2; a[2] = 3;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("skdjksdj " + I[i]);
            }
            //ChartControl barChart = new ChartControl();
            //Series series1 = new Series("Bar Series", ViewType.Spline);
            ////series1.Points.Add(new SeriesPoint("A", new double[] { 2 }));
            ////series1.Points.Add(new SeriesPoint("B", new double[] { 12 }));
            ////series1.Points.Add(new SeriesPoint("C", new double[] { 14 }));
            ////series1.Points.Add(new SeriesPoint("D", new double[] { 17 }));
            //for (int i = 1; i < 15; i++ )
            //{
            //    series1.Points.Add(new SeriesPoint(i.ToString(), new double[] { i + 10 }));
            //}
            //    //RegressionLine myLine = new RegressionLine(ValueLevel.Value);
            //    //((SideBySideBarSeriesView)series1.View).Indicators.Add(myLine);

            //    // Add the series to the chart.
            //barChart.Series.Add(series1);

            //// Define the chart's appearance and palette.
            //barChart.AppearanceName = "Light";
            //barChart.PaletteName = "Opulent";
            //barChart.PaletteBaseColorNumber = 5;

            //// Define a separate palette for the chart's indicators.
            //barChart.IndicatorsPaletteName = "Default";

            //// Add the chart to the form.
            //barChart.Dock = DockStyle.Fill;
            //this.Controls.Add(barChart);
        }

    }
}
