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
    public partial class FrmDetails : Form
    {
        public Member member;

        public FrmDetails(Models.Member selectedMember)
        {
            InitializeComponent();
            member = selectedMember;
            txtFirstName.Text = member.Ime;
            txtCardNumber.Text = member.BrojKartice.ToString();
            txtLastName.Text = member.Prezime;
            txtLivingPlace.Text = member.MjestoStanovanja;
            txtPhoneNumber.Text = member.BrojMobitela;
        }

        private void FrmDetails_Load(object sender, EventArgs e)
        {
            string statusZlatniClan = member.StatusZlatniClan;

            if (statusZlatniClan == "DA")
            {
                rdbYes.Checked = true;
            }
            else if (statusZlatniClan == "NE")
            {
                rdbNo.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rdbYes.Checked == true)
            {
                MemberRepository.UpdateStatus("DA", member.BrojKartice);
                FrmBenefits frmBenefits = new FrmBenefits(member.BrojKartice);
                frmBenefits.ShowDialog();
                DialogResult = DialogResult.OK;
                Close();
            }
            else if(rdbNo.Checked == true)
            {
                MemberRepository.UpdateStatus("NE", member.BrojKartice);
                MemberRepository.UpdateBenefit(null, member.BrojKartice);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
