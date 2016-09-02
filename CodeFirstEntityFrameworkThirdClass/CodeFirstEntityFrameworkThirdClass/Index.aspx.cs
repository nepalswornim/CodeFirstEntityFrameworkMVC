using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using BusinessLogicLayer.Entity;

namespace CodeFirstEntityFrameworkThirdClass
{
    public partial class Index : System.Web.UI.Page
    {
        BLLUser blu = new BLLUser();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Loadgrid();

            }

        }

        private void Loadgrid()
        {
            List<UserDetails> lst = blu.GetallUser();
            GridView1.DataSource = lst;
            GridView1.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSubmit.Text != "Submit")
            {






                UserDetails ud = new UserDetails();
                ud.UserId = Convert.ToInt32(HiddenField1.Value);
                ud.Name = txtName.Text;
                ud.Gender = ddlGender.Text;

                ud.Username = txtUsername.Text;
                ud.Password = txtPasword.Text;
                blu.EditUSer(ud);
                lblMessage.Text = "Updated Successfully";
                Clear();
                btnSubmit.Text = "Submit";
                Loadgrid();

            }
            else
            {
                UserDetails ud = new UserDetails();
                ud.Name = txtName.Text;
                ud.Gender = ddlGender.Text;
                ud.Username = txtUsername.Text;
                ud.Password = txtPasword.Text;
                blu.CreateUser(ud);
                lblMessage.Text = "Submitted Successfully";


                Loadgrid();
                Clear();

            }


        }

        private void Clear()
        {
            txtName.Text = "";
            ddlGender.Text = "Choose Gender";
            txtUsername.Text = "";
            txtPasword.Text = "";
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HiddenField1.Value = GridView1.SelectedRow.Cells[1].Text.ToString();
            txtName.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            ddlGender.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            txtUsername.Text = GridView1.SelectedRow.Cells[4].Text.ToString();
            txtPasword.Text = GridView1.SelectedRow.Cells[5].Text.ToString();
            btnSubmit.Text = "Update";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            lblMessage.Text = "";
            btnSubmit.Text = "Submit";

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnSubmit.Text != "Submit")
            {
                blu.DeletUser(Convert.ToInt32(HiddenField1.Value));
                lblMessage.Text = "Deleted Successfully";
                Clear();
                Loadgrid();
            }
            else
            {

                lblMessage.Text = "Select an Item first";
            }



        }

   
    }
}