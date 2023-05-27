using GymVertical.Models;
using GymVertical.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymVertical
{
    public partial class FrmMembers : Form
    {
        public FrmMembers()
        {
            InitializeComponent();
        }

        private void FrmMembers_Load(object sender, EventArgs e)
        {
            ShowMembers();
        }

        private void ShowMembers()
        {
            List<Member> members = MemberRepository.GetMembers();
            dgvMembers.DataSource = members;
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            Member selectedMember = dgvMembers.CurrentRow.DataBoundItem as Member;
            if (selectedMember != null)
            {
                FrmDetails frmDetails = new FrmDetails(selectedMember);
                DialogResult result = frmDetails.ShowDialog();

                if (result == DialogResult.OK)
                {
                    OsvjeziDataGridView();
                }
            }

        }

        private void btnInsertMember_Click(object sender, EventArgs e)
        {
            FrmInsert frmInsert = new FrmInsert();
            DialogResult result = frmInsert.ShowDialog();

            if (result == DialogResult.OK)
            {
                OsvjeziDataGridView();
            }
        }

        private void OsvjeziDataGridView()
        {
            ShowMembers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Member selectedMember = dgvMembers.CurrentRow.DataBoundItem as Member;
            MemberRepository.DeleteMember(selectedMember.BrojKartice);
            OsvjeziDataGridView();
        }

        private void SearchRows(string parametar)
        {
            dgvMembers.ClearSelection();

            foreach (DataGridViewRow row in dgvMembers.Rows)
            {

                if (row.Cells["Ime"].Value.ToString() == parametar)
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchRows(txtSearch.Text);
        }
    }
}
