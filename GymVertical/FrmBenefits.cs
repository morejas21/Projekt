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
    public partial class FrmBenefits : Form
    {
        int selectedStudent;
        public FrmBenefits(int brojKartice)
        {
            selectedStudent = brojKartice;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(rdbMembershipDuration.Checked)
            {
                MemberRepository.UpdateBenefit("Trening", selectedStudent);
            }
            else if (rdbProteinSale.Checked)
            {
                MemberRepository.UpdateBenefit("Trajanje", selectedStudent);
            }
            else if (rdbTreningNumber.Checked)
            {
                MemberRepository.UpdateBenefit("Popust", selectedStudent);
            }
            Close();
        }
    }
}
