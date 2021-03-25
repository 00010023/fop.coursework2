using System;
using CW.DAL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW
{
    public partial class ApplicantListForm : Form
    {
        public ApplicantListForm()
        {
            InitializeComponent();
        }

        private void ApplicantListForm_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new ApplicantList().GetAllApplicants();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cbxSort.SelectedIndex < 0)
                MessageBox.Show("Select an attribute to sort by");
            else
            {
                ByAttribute selectedAttribute;
                if (cbxSort.SelectedIndex == 0)
                    selectedAttribute = ByAttribute.ap_name_10023;
                else if (cbxSort.SelectedIndex == 1)
                    selectedAttribute = ByAttribute.ap_score_10023;
                else selectedAttribute = ByAttribute.ap_tests_taken_10023;

                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new ApplicantList().Sort(selectedAttribute);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbxSearch.SelectedIndex < 0)
                MessageBox.Show("Select an attribute to search by");
            else if (string.IsNullOrWhiteSpace(tbxSearch.Text))
                MessageBox.Show("Provide the search term");
            else
            {
                var selectedAttribute = cbxSearch.SelectedIndex == 0 ? ByAttribute.ap_name_10023 : ByAttribute.ap_tests_taken_10023;

                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new ApplicantList().Search(tbxSearch.Text, selectedAttribute);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select an applicant");
            else
            {
                var a = (Applicant)dgv.SelectedRows[0].DataBoundItem;
                new ApplicantManager().Delete(a.ap_id_10023);
                LoadData();
            }
        }
    }
}
