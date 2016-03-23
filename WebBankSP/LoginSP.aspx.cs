using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBankSP
{
    public partial class LoginSP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //this.Message.Text = @"Account No. and Password not matched";

            //Response.Redirect("IndexSP.aspx");

            var id = this.txtAccountNo.Text.Trim();
            var password = this.txtPassword.Text;

            var authentication = new Authentication();
            bool isValid = authentication.Verify(id, password);

            if (isValid==true)
            {
                LoginSucceeded();
            }
            else
            {
                LoginFailed();
            }

        }

        private void LoginFailed()
        {
            this.Message.Text = @"Account No. and Password not matched.";
        }

        private void LoginSucceeded()
        {
            Response.Redirect("IndexSP.aspx");
        }

    }
}