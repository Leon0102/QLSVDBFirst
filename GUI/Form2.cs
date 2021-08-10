using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.BLL;
using WindowsFormsApp5.DTO;

namespace WindowsFormsApp5.GUI
{
    public partial class Form2 : Form
    {
        public delegate void MyDel(int id);
        public MyDel d { get; set; }
        private string MSSV;
        public Form2(string ms)
        {
            InitializeComponent();
            SetCBB();
            if (ms != null)
            {
                MSSV = ms;
                txbMSSV.Enabled = false;
                SetGUI();
            }
        }
        public Form2()
        {
            InitializeComponent();
        }
        private void SetGUI()
        {
            if (BLL_QLSV.Instance.GetSVbyID_BLL(MSSV) != null)
            {
                txbMSSV.Enabled = false;
                SV s = BLL_QLSV.Instance.GetSVbyID_BLL(MSSV);
                txbMSSV.Text = s.MSSV;
                txbName.Text = s.NameSV;
                dtNgaySinh.Value = s.NS;
                if (s.Gender==true)
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }
                cbbLopSH.SelectedItem = cbbLopSH.Items[Convert.ToInt32(s.ID_Lop) - 1];
            }
        }
        public void SetCBB(int id =1)
        {
            foreach (LopSH i in BLL_QLSV.Instance.GetListLSH_BLL())
            {
                cbbLopSH.Items.Add(new CBBItem
                {
                    Value = i.ID_Lop,
                    Text = i.NameLop,
                });
            }
            cbbLopSH.SelectedIndex = 1;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            SV s = new SV();
            s.MSSV = txbMSSV.Text;
            s.NameSV = txbName.Text;
            s.ID_Lop = ((CBBItem)cbbLopSH.SelectedItem).Value;
            s.NS = dtNgaySinh.Value;
            s.Gender = rbMale.Checked;
            if (BLL_QLSV.Instance.SaveSV_BLL(s))
            {
                MessageBox.Show("Saved successfully!", "Information", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Failed to save", "Information", MessageBoxButtons.OK);
            }
            d(Form1.id);
            this.Dispose();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            d(Form1.id);
            this.Dispose();
        }
    }
}
