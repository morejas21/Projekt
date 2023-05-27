using GymVertical.Repositories;
using GymVertical.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GymVertical
{
    public partial class FrmInsert : Form
    {
        public FrmInsert()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MemberRepository.InsertMember(txtFirstName.Text, txtLastName.Text, txtLivingPlace.Text, txtPhoneNumber.Text, txtStatusGoldMember.Text, txtBenefit.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
