using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExerciseBase
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //if (!IsPostBack)
                //{
                //    this.lblPostBack.Text = "First Visit!";
                //}
                //else
                //{
                //    this.lblPostBack.Text = "Postback had just happen!";
                //}                    

                ViewState["TestValue"] = "RockAndRoll";

            }
            catch(Exception ex)
            {
                this.litDisplay.Text = ex.Message;
            }
        }

        protected void btnClickMe_Click(object sender, EventArgs e)
        {
            try
            {
                this.litDisplay.Text = ViewState["TestValue"].ToString();
                ViewState["TestValue"] = "<b>Country&Western</b>";
                this.lblDisplay.Text = ViewState["TestValue"].ToString();
            }
            catch (Exception ex)
            {
                this.litDisplay.Text = ex.Message;
            }

            
        }
    }
}