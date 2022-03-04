using Seagull.BarTender.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MaintainableTest;

namespace BoxLabel
{
    public partial class Form1 : Form
    {
        int CountSN = 0;
        Inprocess inp = new Inprocess();
        Box box = new Box();


        public Form1()
        {
            InitializeComponent();
        }

        private void cb_Model_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Model.Text == "32-010109-20" || cb_Model.Text == "32-010109-21")
            {
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;

                txt_SN2.Visible = false;
                txt_SN3.Visible = false;
                txt_SN4.Visible = false;
                txt_SN5.Visible = false;
                txt_SN6.Visible = false;
                txt_SN7.Visible = false;
                txt_SN8.Visible = false;
                txt_SN9.Visible = false;
                txt_SN10.Visible = false;
                txt_SN11.Visible = false;
                txt_SN12.Visible = false;

            }
            else if (cb_Model.Text == "32-010181-05-24")
            {
                txt_SN13.Visible = true;
                txt_SN14.Visible = true;
                txt_SN15.Visible = true;
                txt_SN16.Visible = true;
                txt_SN17.Visible = true;
                txt_SN18.Visible = true;
                txt_SN19.Visible = true;
                txt_SN20.Visible = true;
                txt_SN21.Visible = true;
                txt_SN22.Visible = true;
                txt_SN23.Visible = true;
                txt_SN24.Visible = true;

                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
                label22.Visible = true;
                label23.Visible = true;
                label24.Visible = true;
                label25.Visible = true;
            }
            else if (cb_Model.Text == "40-08238")
            {
                txt_SN13.Visible = true;
                txt_SN14.Visible = true;
                txt_SN15.Visible = true;
                txt_SN16.Visible = true;
                txt_SN17.Visible = true;
                txt_SN18.Visible = true;
                txt_SN19.Visible = true;
                txt_SN20.Visible = true;
                txt_SN21.Visible = true;
                txt_SN22.Visible = true;
                txt_SN23.Visible = true;
                txt_SN24.Visible = true;

                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
                label22.Visible = true;
                label23.Visible = true;
                label24.Visible = true;
                label25.Visible = true;
            }
            else
            {
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;

                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;

                txt_SN2.Visible = true;
                txt_SN3.Visible = true;
                txt_SN4.Visible = true;
                txt_SN5.Visible = true;
                txt_SN6.Visible = true;
                txt_SN7.Visible = true;
                txt_SN8.Visible = true;
                txt_SN9.Visible = true;
                txt_SN10.Visible = true;
                txt_SN11.Visible = true;
                txt_SN12.Visible = true;

                txt_SN13.Visible = false;
                txt_SN14.Visible = false;
                txt_SN15.Visible = false;
                txt_SN16.Visible = false;
                txt_SN17.Visible = false;
                txt_SN18.Visible = false;
                txt_SN19.Visible = false;
                txt_SN20.Visible = false;
                txt_SN21.Visible = false;
                txt_SN22.Visible = false;
                txt_SN23.Visible = false;
                txt_SN24.Visible = false;
            }
        }

        private bool CheckModel()
        {
            bool isCorrect = true;


            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control.Text != "32-010126-07")
                    {
                        isCorrect = true;

                    }
                    else if (control.Text != "32-010127-06")
                    {
                        isCorrect = true;

                    }
                    else if (control.Text != "32-010181-05")
                    {
                        isCorrect = true;

                    }
                    else
                        isCorrect = false;
            };

            func(Controls);



            return isCorrect;
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            CountTextBox();

            //string a = txt_SN1.Text.Substring(13,txt_SN1.Text.IndexOf(','));

            if (cb_Model.Text == "32-010109-20")
            {
                //if (SaveRecords() == true)
                //{
                if (CheckTest() == true)
                {

                    if (txt_SN1.Text.Trim() != "")
                    {

                        Print1();
                        ClearTextBoxes();
                    }
                    else
                        MessageBox.Show("Empty Field!");
                }


                //}
                //else
                //    MessageBox.Show("Serial Number Not exist OR is not for this model!");

            }
            else if (cb_Model.Text == "32-010109-21")
            {
                if (CheckTest() == true)
                {

                    if (SaveRecords() == true)
                    {
                        if (txt_SN1.Text.Trim() != "")
                        {

                            Print1();
                            ClearTextBoxes();
                        }
                        else
                            MessageBox.Show("Empty Field!");

                    }
                    else
                        MessageBox.Show("Serial Number Not exist OR is not for this model!");
                }


            }
            else if (cb_Model.Text == "32-010126-07-12")
            {
                if (CheckTest() == true)
                {

                    if (SaveRecords() == true)
                    {
                        if (Duplicates() == true)
                        {
                            Print126();
                            ClearTextBoxes();
                        }
                        else
                            MessageBox.Show("Duplicate values");
                    }
                    else
                        MessageBox.Show("Serial Number Not exist!");
                }

            }
            else if (cb_Model.Text == "32-010127-06-12")
            {
                if (CheckTest() == true)
                {

                    if (SaveRecords() == true)
                    {
                        if (Duplicates() == true)
                        {
                            Print127();
                            ClearTextBoxes();
                        }
                        else
                            MessageBox.Show("Duplicate values");
                    }
                    else
                        MessageBox.Show("Serial Number Not exist!");

                }
            }
            else if (cb_Model.Text == "32-010181-05-24")
            {
                if (CheckTest() == true)
                {
                    if (SaveRecords() == true)
                    {
                        if (Duplicates() == true)
                        {
                            Print24();
                            ClearTextBoxes();
                        }
                        else
                            MessageBox.Show("Duplicate values");
                    }
                    else
                        MessageBox.Show("Serial Number Not exist!");

                }


            }
            else if (cb_Model.Text == "40-08238")
            {
                if (CheckTest() == true)
                {

                    if (Duplicates() == true)
                    {

                        Print24();
                        ClearTextBoxes();
                    }
                    else
                        MessageBox.Show("Duplicate values");



                }
            }

            //ClearTextBoxes();


        }

        public bool CheckTextBox()
        {
            //bool res = false;
            List<TextBox> myTextBoxes = new List<TextBox>();
            //Add your textboxes to the list here...

            //Collect all your TextBox objects in a new list...  
            List<TextBox> textBoxes = new List<TextBox>
             {
                txt_SN1, txt_SN2, txt_SN3, txt_SN4, txt_SN5, txt_SN6, txt_SN7, txt_SN8, txt_SN9, txt_SN10, txt_SN11,txt_SN12,
                txt_SN13, txt_SN14, txt_SN15, txt_SN16, txt_SN17, txt_SN18, txt_SN19, txt_SN20, txt_SN21, txt_SN22, txt_SN23, txt_SN24
             };

            //Use LINQ to count duplicates in the list...
            int dupes = textBoxes.GroupBy(x => (x.Text))
                                 .Where(x => x.Any())
                                 .Where(g => g.Count() > 1)
                                 .Count();

            //true if duplicates found, otherwise false
            return dupes < 1;

        }

        public bool SNExists()
        {
            bool exist = true;

            List<TextBox> textBoxes = new List<TextBox>
             {
                txt_SN1, txt_SN2, txt_SN3, txt_SN4, txt_SN5, txt_SN6, txt_SN7, txt_SN8, txt_SN9, txt_SN10, txt_SN11,txt_SN12,
                txt_SN13, txt_SN14, txt_SN15, txt_SN16, txt_SN17, txt_SN18, txt_SN19, txt_SN20, txt_SN21, txt_SN22, txt_SN23, txt_SN24
             };

            foreach (var item in textBoxes)
            {
                if (item.Visible == true && !inp.Existe("select count(*) from tb_Inprocess where SerialNumber = '" + item.Text + "'"))
                {
                    item.BackColor = System.Drawing.Color.LightCoral;
                    exist = false;
                }
            }


            //true if duplicates found, otherwise false
            return exist;

        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        public bool SaveRecords()
        {
            bool exist = true;

            List<TextBox> textBoxes = new List<TextBox>
             {
                txt_SN1, txt_SN2, txt_SN3, txt_SN4, txt_SN5, txt_SN6, txt_SN7, txt_SN8, txt_SN9, txt_SN10, txt_SN11,txt_SN12,
                txt_SN13, txt_SN14, txt_SN15, txt_SN16, txt_SN17, txt_SN18, txt_SN19, txt_SN20, txt_SN21, txt_SN22, txt_SN23, txt_SN24
             };

            if (cb_Model.Text != "40-08238")
            {
                foreach (var item in textBoxes)
                {
                    if (item.Text != "")
                        if (item.Visible == true && inp.Existe("select count(*) from tb_Inprocess where SerialNumber = '" + item.Text.Substring(0, item.Text.IndexOf(',')) + "'"))
                        {
                            inp.Id_inprocess = int.Parse(inp.ReturnID("select id_inprocess from tb_Inprocess where SerialNumber = '" + item.Text.Substring(0, item.Text.IndexOf(',')) + "'"));
                            //inp.Crud("insert into tbU_BoxSn values('" + box.Id_box + "','" + inp.Id_inprocess + "','" + DateTime.Now + "')");

                        }
                        else
                        {
                            exist = false;
                        }
                }

            }
            else
            {
                foreach (var item in textBoxes)
                {
                    if (item.Text != "")
                        if (item.Visible == true && inp.Existe("select count(*) from tb_Inprocess where SerialNumber = '" + item.Text.Trim() + "'"))
                        {
                            inp.Id_inprocess = int.Parse(inp.ReturnID("select id_inprocess from tb_Inprocess where SerialNumber = '" + item.Text.Trim() + "'"));
                            //inp.Crud("insert into tbU_BoxSn values('" + box.Id_box + "','" + inp.Id_inprocess + "','" + DateTime.Now + "')");

                        }
                        else
                        {
                            exist = false;
                        }
                }
            }



            //true if duplicates found, otherwise false
            return exist;

        }

        private void Print126()
        {
            using (Engine engine = new Engine())
            {
                engine.Start();
                LabelFormatDocument format = engine.Documents.Open(@"\\mex-fss-001\labels$\Rocket\Box Labels\32-010126-07-12.btw");

                format.PrintSetup.PrinterName = @"DeskPrinter24";
                //format.PrintSetup.PrinterName = @"Microsoft Print to PDF";



                format.SubStrings["WO"].Value = txt_WO.Text.Trim();

                // int Toprint = int.Parse(txt_Qty.Text);
                format.PrintSetup.NumberOfSerializedLabels = 1;
                format.SubStrings["sn1"].Value = txt_SN1.Text;
                format.SubStrings["sn2"].Value = txt_SN2.Text;
                format.SubStrings["sn3"].Value = txt_SN3.Text;
                format.SubStrings["sn4"].Value = txt_SN4.Text;
                format.SubStrings["sn5"].Value = txt_SN5.Text;
                format.SubStrings["sn6"].Value = txt_SN6.Text;
                format.SubStrings["sn7"].Value = txt_SN7.Text;
                format.SubStrings["sn8"].Value = txt_SN8.Text;
                format.SubStrings["sn9"].Value = txt_SN9.Text;
                format.SubStrings["sn10"].Value = txt_SN10.Text;
                format.SubStrings["sn11"].Value = txt_SN11.Text;
                format.SubStrings["sn12"].Value = txt_SN12.Text;
                format.SubStrings["QTY"].Value = CountSN.ToString();

                format.Print();


                //Result result = format.Print();

                //format.Print();
                engine.Stop();

            }
        }
        private void Print127()
        {
            using (Engine engine = new Engine())
            {
                engine.Start();
                LabelFormatDocument format = engine.Documents.Open(@"\\mex-fss-001\labels$\Rocket\Box Labels\32-010127-06-12.btw");

                //format.PrintSetup.PrinterName = @"Microsoft Print to PDF";

                format.PrintSetup.PrinterName = @"DeskPrinter24";


                format.SubStrings["WO"].Value = txt_WO.Text.Trim();

                // int Toprint = int.Parse(txt_Qty.Text);
                format.PrintSetup.NumberOfSerializedLabels = 1;
                format.SubStrings["sn1"].Value = txt_SN1.Text;
                format.SubStrings["sn2"].Value = txt_SN2.Text;
                format.SubStrings["sn3"].Value = txt_SN3.Text;
                format.SubStrings["sn4"].Value = txt_SN4.Text;
                format.SubStrings["sn5"].Value = txt_SN5.Text;
                format.SubStrings["sn6"].Value = txt_SN6.Text;
                format.SubStrings["sn7"].Value = txt_SN7.Text;
                format.SubStrings["sn8"].Value = txt_SN8.Text;
                format.SubStrings["sn9"].Value = txt_SN9.Text;
                format.SubStrings["sn10"].Value = txt_SN10.Text;
                format.SubStrings["sn11"].Value = txt_SN11.Text;
                format.SubStrings["sn12"].Value = txt_SN12.Text;
                format.SubStrings["QTY"].Value = CountSN.ToString();

                format.Print();
                //Result result = format.Print();

                //format.Print();
                engine.Stop();

            }
        }
        private void Print24()
        {
            using (Engine engine = new Engine())
            {
                engine.Start();
                LabelFormatDocument format = engine.ActiveDocument;

                if (cb_Model.Text == "32-010181-05-24")
                {
                    format = engine.Documents.Open(@"\\mex-fss-001\labels$\Rocket\Box Labels\32-010181-05-24.btw");

                }
                else
                {
                    format = engine.Documents.Open(@"\\mex-fss-001\labels$\Rocket\Box Labels\40-08238.btw");

                }

                //format.PrintSetup.PrinterName = @"Microsoft Print to PDF";
                format.PrintSetup.PrinterName = @"DeskPrinter24";


                format.SubStrings["WO"].Value = txt_WO.Text.Trim();


                // int Toprint = int.Parse(txt_Qty.Text);
                format.PrintSetup.NumberOfSerializedLabels = 1;
                format.SubStrings["sn1"].Value = txt_SN1.Text;
                format.SubStrings["sn2"].Value = txt_SN2.Text;
                format.SubStrings["sn3"].Value = txt_SN3.Text;
                format.SubStrings["sn4"].Value = txt_SN4.Text;
                format.SubStrings["sn5"].Value = txt_SN5.Text;
                format.SubStrings["sn6"].Value = txt_SN6.Text;
                format.SubStrings["sn7"].Value = txt_SN7.Text;
                format.SubStrings["sn8"].Value = txt_SN8.Text;
                format.SubStrings["sn9"].Value = txt_SN9.Text;
                format.SubStrings["sn10"].Value = txt_SN10.Text;
                format.SubStrings["sn11"].Value = txt_SN11.Text;
                format.SubStrings["sn12"].Value = txt_SN12.Text;
                format.SubStrings["sn13"].Value = txt_SN13.Text;
                format.SubStrings["sn14"].Value = txt_SN14.Text;
                format.SubStrings["sn15"].Value = txt_SN15.Text;
                format.SubStrings["sn16"].Value = txt_SN16.Text;
                format.SubStrings["sn17"].Value = txt_SN17.Text;
                format.SubStrings["sn18"].Value = txt_SN18.Text;
                format.SubStrings["sn19"].Value = txt_SN19.Text;
                format.SubStrings["sn20"].Value = txt_SN20.Text;
                format.SubStrings["sn21"].Value = txt_SN21.Text;
                format.SubStrings["sn22"].Value = txt_SN22.Text;
                format.SubStrings["sn23"].Value = txt_SN23.Text;
                format.SubStrings["sn24"].Value = txt_SN24.Text;
                format.SubStrings["QTY"].Value = CountSN.ToString();

                format.Print();
                //Result result = format.Print();

                //format.Print();
                engine.Stop();

            }
        }
        private void Print1()
        {
            using (Engine engine = new Engine())
            {
                engine.Start();
                LabelFormatDocument format = engine.Documents.Open(@"\\mex-fss-001\labels$\Rocket\Box Labels\32-010109-20.btw");

                if (cb_Model.Text == "32-010109-21")
                {
                    format = engine.Documents.Open(@"\\mex-fss-001\labels$\Rocket\Box Labels\32-010109-21.btw");
                }
                //format.PrintSetup.PrinterName = @"Microsoft Print to PDF";
                format.PrintSetup.PrinterName = @"DeskPrinter24";


                // int Toprint = int.Parse(txt_Qty.Text);
                format.PrintSetup.NumberOfSerializedLabels = 1;
                format.SubStrings["SN"].Value = txt_SN1.Text;
                format.SubStrings["WO"].Value = txt_WO.Text;
                format.SubStrings["QTY"].Value = CountSN.ToString();

                format.Print();
                //Result result = format.Print();

                //format.Print();
                engine.Stop();

            }
        }

        public bool Duplicates()
        {

            //List<TextBox> myTextBoxes = new List<TextBox>();

            //Add your textboxes to the list here...

            //Collect all your TextBox objects in a new list...  
            List<TextBox> textBoxes = new List<TextBox>
             {
                txt_SN1, txt_SN2, txt_SN3, txt_SN4, txt_SN5, txt_SN6, txt_SN7, txt_SN8, txt_SN9, txt_SN10, txt_SN11,txt_SN12,
                txt_SN13, txt_SN14, txt_SN15, txt_SN16, txt_SN17, txt_SN18, txt_SN19, txt_SN20, txt_SN21, txt_SN22, txt_SN23, txt_SN24
             };

            //Use LINQ to count duplicates in the list...
            int dupes = textBoxes.GroupBy(x => (x.Text.Trim()))
                                 .Where(x => x.Any())
                                 .Where(g => g.Count() > 1)
                                 .Count();

            //true if duplicates found, otherwise false
            return dupes <= 1;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //box.Boxes = DateTime.Now.ToString("yyMMdd") + box.CountBox.ToString().PadLeft(5,'0');

            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).BackColor = System.Drawing.Color.White;
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void CountTextBox()
        {
            CountSN = 0;
            //Add your textboxes to the list here...

            //Collect all your TextBox objects in a new list...  
            List<TextBox> textBoxes = new List<TextBox>
             {
                txt_SN1, txt_SN2, txt_SN3, txt_SN4, txt_SN5, txt_SN6, txt_SN7, txt_SN8, txt_SN9, txt_SN10, txt_SN11, txt_SN12,
                txt_SN13, txt_SN14, txt_SN15, txt_SN16, txt_SN17, txt_SN18, txt_SN19, txt_SN20, txt_SN21, txt_SN22, txt_SN23, txt_SN24
             };

            //Use LINQ to count duplicates in the list...
            //int dupes = textBoxes.Where(textBoxes.)
            //                     .Count();

            foreach (var item in textBoxes)
            {
                if (!string.IsNullOrEmpty(item.Text.Trim()))
                    CountSN++;
            }


            //true if duplicates found, otherwise false
            //return dupes < 1;
            //MessageBox.Show(CountSN.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).BackColor = System.Drawing.Color.White;
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Batch b = new Batch();
            b.Show();

        }

        private bool CheckTest()
        {
            bool isTested = false;

            //Collect all your TextBox objects in a new list...  
            List<TextBox> textBoxes = new List<TextBox>
             {
                txt_SN1, txt_SN2, txt_SN3, txt_SN4, txt_SN5, txt_SN6, txt_SN7, txt_SN8, txt_SN9, txt_SN10, txt_SN11,txt_SN12,
                txt_SN13, txt_SN14, txt_SN15, txt_SN16, txt_SN17, txt_SN18, txt_SN19, txt_SN20, txt_SN21, txt_SN22, txt_SN23, txt_SN24
             };

            //Use LINQ to count duplicates in the list...


            foreach (var seriales in textBoxes)
            {
                try
                {

                    inp.Tested = inp.ReturnValue("select top 1 status from test where sn = '" + seriales.Text.Trim().Substring(0, seriales.Text.LastIndexOf(',')) + "' order by date_end asc");
                    if (inp.Tested == "Failed")
                    {

                        seriales.BackColor = System.Drawing.Color.Red;
                        MessageBox.Show("Items test failed!");
                    }
                    else
                        isTested = true;
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    break;
                }

            }



            return isTested;
        }
    }

}
