using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voyager_SN
{
    public partial class Mantenimiento : Form
    {
        Conexion con = new Conexion();
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Printer.Text))
            {
                con.Crud("update tb_Config set printer = '" + txt_Printer.Text.Trim() + "'");
                MessageBox.Show("Done!");
            }
            else
                MessageBox.Show("Empty Field!");
        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {
            txt_Printer.Text = con.ReturnValue("select printer from tb_Config");
        }
    }
}
