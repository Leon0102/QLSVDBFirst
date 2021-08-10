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
using WindowsFormsApp5.GUI;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            ShowCBB();
            LoadData();
        }
        public static int id { get; set; }
        public void ShowCBB()
        {
            cbbLSH.Items.Add(new CBBItem { Value = 0, Text = "All" });
            foreach (LopSH i in BLL_QLSV.Instance.GetListLSH_BLL())
            {
                cbbLSH.Items.Add(new CBBItem
                {
                    Value = i.ID_Lop,
                    Text = i.NameLop
                });
            }
            cbbLSH.SelectedIndex = 0;
            id = ((CBBItem)cbbLSH.SelectedItem).Value;
        }
        public void LoadData(int id=0)
        {
            if (id == 0)
            {
                dgvSV.DataSource = BLL_QLSV.Instance.GetListSV_BLL();
                dgvSV.Columns["LopSH"].Visible = false;
            }
            else
            {
                dgvSV.DataSource = BLL_QLSV.Instance.GetListSVbyID_BLL(id);
                dgvSV.Columns["LopSH"].Visible = false;
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((CBBItem)cbbLSH.SelectedItem).Value;
            LoadData(id);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvSV.DataSource = BLL_QLSV.Instance.Search_BLL(txbSearch.Text);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
           string mssv = dgvSV.SelectedCells[0].OwningRow.Cells["MSSV"].Value.ToString();
                //DataGridViewSelectedRowCollection data = dgvSV.SelectedRows;
                //string mssv = data[0].Cells["MSSV"].Value.ToString();
            BLL_QLSV.Instance.DelSVBLL(BLL_QLSV.Instance.GetSVbyID_BLL(mssv));
            LoadData(((CBBItem)cbbLSH.SelectedItem).Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(null);
            f.d = new Form2.MyDel(this.LoadData);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int b_id = Convert.ToInt32(dgvSV.CurrentRow.Cells[0].Value);
            Form2 f = new Form2(b_id.ToString());
            f.d = new Form2.MyDel(LoadData);
            f.ShowDialog();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            switch (cbbSort.SelectedIndex)
            {
                case 0:
                    dgvSV.DataSource = BLL_QLSV.Instance.SortMSSVUp_BLL();
                    break;
                case 1:
                    dgvSV.DataSource = BLL_QLSV.Instance.SortMSSVDown_BLL();
                    break;
                case 2:
                    dgvSV.DataSource = BLL_QLSV.Instance.SortNameDown_BLL();
                    break;
                case 3:
                    dgvSV.DataSource = BLL_QLSV.Instance.SortNameUp_BLL();
                    break;
                default:
                    break;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
