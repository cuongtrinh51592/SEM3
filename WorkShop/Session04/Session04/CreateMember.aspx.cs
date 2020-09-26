using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Session04.DAL;
using Session04.Models;

namespace Session04
{
    public partial class CreateMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ClubMemberDbManagement objclubMemberDbManager = new ClubMemberDbManagement();
            Member memberModel = new Member();
            memberModel.Name = txtName.Text;
            memberModel.Gender = drpGender.SelectedItem.Text;
            memberModel.MemberFee = Convert.ToDouble(txtMFree.Text);
            memberModel = objclubMemberDbManager.CreateMember(memberModel);
            lblMessage.Text = "Member Created Successfully";
        }
    }
}