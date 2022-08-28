using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDiExample
{
    public partial class Form1 : Form
    {
        private readonly IReportFactory<string,MyReport> mFactory;
        private MyReport mMyReport;
        public Form1(IReportFactory<string,MyReport> factory)
        {
            mFactory = factory;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 can hold report instance until whenever you want.
            mMyReport?.Dispose();
            
            mMyReport = mFactory.Create("sheet 123");
            mMyReport.LogReport();
        }
    }
}