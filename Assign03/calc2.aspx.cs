using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assign03
{
    public partial class calc2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void StoreDisplay(string fromDisplay)
        {
            Session["operand"] = fromDisplay.ToString();     // store the value of the button into the session variable
        }

        protected void BtnClicked(object sender, EventArgs e)
        {
            System.Web.UI.WebControls.Button myBtn;             // declare button to be used in the C# code
            myBtn = (System.Web.UI.WebControls.Button)sender;   // cast the sender as a button

            display.Text = myBtn.Text.ToString();       
            StoreDisplay(myBtn.Text.ToString());
        }

        protected void OperationClicked(object sender, EventArgs e)
        {
            System.Web.UI.WebControls.Button myBtn;             // declare button to be used in the C# code
            myBtn = (System.Web.UI.WebControls.Button)sender;   // cast the sender as a button

            Session["operand1"] = Session["operand"];           // store the value of the button into the session variable
            Session["operation"] = myBtn.Text.ToString();       // store the value of the button into the session variable
        }

        protected void BtnEquals_Click(object sender, EventArgs e)
        {
            Session["operand2"] = Session["operand"];     // store the value of the button into the session variable

            if (Session["operation"].ToString() == "+")        // if the operation is add
                display.Text = ((Convert.ToInt32(Session["operand1"].ToString())) + (Convert.ToInt32(Session["operand2"].ToString()))).ToString();     // add the two operands
            else if (Session["operation"].ToString() == "-")      // if the operation is subtract
                display.Text = ((Convert.ToInt32(Session["operand1"].ToString())) - (Convert.ToInt32(Session["operand2"].ToString()))).ToString();     // subtract the two operands
            else if (Session["operation"].ToString() == "*")      // if the operation is multiply
                display.Text = ((Convert.ToInt32(Session["operand1"].ToString())) * (Convert.ToInt32(Session["operand2"].ToString()))).ToString();     // multiply the two operands
            else if (Session["operation"].ToString() == "/")        // if the operation is divide
                display.Text = ((Convert.ToInt32(Session["operand1"].ToString())) / (Convert.ToInt32(Session["operand2"].ToString()))).ToString();     // divide the two operands
        
            StoreDisplay(display.Text.ToString());
        }

        protected void BtnClear_Click(object sender, EventArgs e)
        {
            display.Text = "";
            Session["operation"] = "";
            Session["operand1"] = "";
            Session["operand2"] = "";
            Session["operand"] = "";
        }
    }
}