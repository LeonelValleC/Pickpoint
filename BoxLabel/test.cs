using System;
using System.Windows.Forms;
using MaintainableTest.API.Models.TestReport;


namespace BoxLabel
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            Report report = new Report();
            string xml = report.ToXml();

        }
    }
}
