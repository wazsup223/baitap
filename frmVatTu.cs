using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace baitap2
{
    public partial class frmVatTu : Form
    {
        public frmVatTu()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private Dictionary<string, CVatTu> dsVT;
        private void hienDSVatTu()
        {
            dgvVatTu.DataSource = dsVT.Values.ToList();
        }
        private CVatTu timVT(string ma)
        {
            try
            {
                return dsVT[ma];
            }
            catch
            {
                return null;
            }
        }
        private void frmVatTU_load(object sender, EventArgs e)
        {
            dsVT = new Dictionary<string, CVatTu>();
        }
    }
}
