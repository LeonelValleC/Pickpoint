using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BoxLabel
{
    public partial class Batch : Form
    {
        Inprocess inprocess = new Inprocess();


        public Batch()
        {
            InitializeComponent();
        }

        private void btn_Paste_Click(object sender, EventArgs e)
        {
            //dataGridView1

            //string a = DateTime.Now.ToString();
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.Text))
            {
                if (dataGridView1.RowCount > 0)
                    dataGridView1.Rows.Clear();

                if (dataGridView1.ColumnCount > 0)
                    dataGridView1.Columns.Clear();

                bool columnsAdded = false;
                string[] pastedRows = Regex.Split(o.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
                int j = 0;
                foreach (string pastedRow in pastedRows)
                {
                    string[] pastedRowCells = pastedRow.Split(new char[] { '\t' });

                    if (!columnsAdded)
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            dataGridView1.Columns.Add("col" + i, pastedRowCells[i]);

                        columnsAdded = true;
                        continue;
                    }

                    dataGridView1.Rows.Add();
                    int myRowIndex = dataGridView1.Rows.Count - 1;

                    using (DataGridViewRow myDataGridViewRow = dataGridView1.Rows[j])
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            myDataGridViewRow.Cells[i].Value = pastedRowCells[i];
                    }
                    j++;
                }
            }
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                inprocess.Crud("insert into test(pn, sn, date_end, date_start, status) values('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + Convert.ToDateTime(dataGridView1.Rows[i].Cells[2].Value.ToString()) + "','" + Convert.ToDateTime(dataGridView1.Rows[i].Cells[3].Value.ToString()) + "','" + dataGridView1.Rows[i].Cells[4].Value + "')");
            }
            MessageBox.Show("Done!");

        }

        private void btn_Claer_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void Batch_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "Part Number";
            dataGridView1.Columns[1].HeaderText = "Serial Number";
            dataGridView1.Columns[2].HeaderText = "Date Ended";
            dataGridView1.Columns[3].HeaderText = "Date Started";
            dataGridView1.Columns[4].HeaderText = "Status";

        }
    }
}
