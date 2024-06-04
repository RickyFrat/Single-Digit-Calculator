using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assign03
{
    public partial class calc1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void StoreDisplay(string fromDisplay)
        {
            Session["displayedValue"] = fromDisplay.ToString();     // store the value of the button into the session variable
        }

        protected void Btn0_Click(object sender, EventArgs e)
        {
            display.Text = Btn0.Text.ToString();        // display the button value in the text box
            StoreDisplay(Btn0.Text.ToString());         // store the button value into StoreDisplay
        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            display.Text = Btn1.Text.ToString();        // display the button value in the text box
            StoreDisplay(Btn1.Text.ToString());         // store the button value into StoreDisplay
        }

        protected void Btn2_Click(object sender, EventArgs e)
        {
            display.Text = Btn2.Text.ToString();        // display the button value in the text box
            StoreDisplay(Btn2.Text.ToString());         // store the button value into StoreDisplay
        }

        protected void Btn3_Click(object sender, EventArgs e)
        {
            display.Text = Btn3.Text.ToString();        // display the button value in the text box
            StoreDisplay(Btn3.Text.ToString());         // store the button value into StoreDisplay
        }

        protected void Btn4_Click(object sender, EventArgs e)
        {
            display.Text = Btn4.Text.ToString();        // display the button value in the text box
            StoreDisplay(Btn4.Text.ToString());         // store the button value into StoreDisplay
        }

        protected void Btn5_Click(object sender, EventArgs e)
        {
            display.Text = Btn5.Text.ToString();        // display the button value in the text box
            StoreDisplay(Btn5.Text.ToString());         // store the button value into StoreDisplay
        }

        protected void Btn6_Click(object sender, EventArgs e)
        {
            display.Text = Btn6.Text.ToString();        // display the button value in the text box
            StoreDisplay(Btn6.Text.ToString());         // store the button value into StoreDisplay
        }

        protected void Btn7_Click(object sender, EventArgs e)
        {
            display.Text = Btn7.Text.ToString();        // display the button value in the text box
            StoreDisplay(Btn7.Text.ToString());         // store the button value into StoreDisplay
        }

        protected void Btn8_Click(object sender, EventArgs e)
        {
            display.Text = Btn8.Text.ToString();        // display the button value in the text box
            StoreDisplay(Btn8.Text.ToString());         // store the button value into StoreDisplay
        }

        protected void Btn9_Click(object sender, EventArgs e)
        {
            display.Text = Btn9.Text.ToString();        // display the button value in the text box
            StoreDisplay(Btn9.Text.ToString());         // store the button value into StoreDisplay
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            Session["operand1"] = Session["displayedValue"];     
            Session["operation"] = "add";                        
        }

        protected void BtnSubtract_Click(object sender, EventArgs e)
        {
            Session["operand1"] = Session["displayedValue"];
            Session["operation"] = "subtract";
        }

        protected void BtnMult_Click(object sender, EventArgs e)
        {
            Session["operand1"] = Session["displayedValue"];
            Session["operation"] = "multiply";
        }

        protected void BtnDiv_Click(object sender, EventArgs e)
        {
            Session["operand1"] = Session["displayedValue"];
            Session["operation"] = "divide";
        }

        protected void BtnEquals_Click(object sender, EventArgs e)
        {
            Session["operand2"] = Session["displayedValue"];     // store the value of the button into the session variable

            if (Session["operation"].ToString() == "add")        // if the operation is add
                display.Text = ((Convert.ToInt32( Session["operand1"].ToString() )) + (Convert.ToInt32(Session["operand2"].ToString() ))).ToString();     // add the two operands
            else if (Session["operation"].ToString() == "subtract")      // if the operation is subtract
                display.Text = ((Convert.ToInt32(Session["operand1"].ToString())) - (Convert.ToInt32(Session["operand2"].ToString()))).ToString();     // subtract the two operands
            else if (Session["operation"].ToString() == "multiply")      // if the operation is multiply
                display.Text = ((Convert.ToInt32(Session["operand1"].ToString())) * (Convert.ToInt32(Session["operand2"].ToString()))).ToString();     // multiply the two operands
            else if (Session["operation"].ToString() == "divide")        // if the operation is divide
                display.Text = ((Convert.ToInt32(Session["operand1"].ToString())) / (Convert.ToInt32(Session["operand2"].ToString()))).ToString();     // divide the two operands
        }

        protected void BtnClear_Click(object sender, EventArgs e)
        {
            display.Text = "";
            Session["operation"] = "";
            Session["operand1"] = "";
            Session["operand2"] = "";
            Session["displayedValue"] = "";
        }
    }
}