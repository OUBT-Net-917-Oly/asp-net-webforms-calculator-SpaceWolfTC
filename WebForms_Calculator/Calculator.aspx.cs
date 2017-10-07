using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1_empty
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static decimal number1=0;
        public static decimal number2=0;


        protected bool numberCheck()
        {
            if (string.IsNullOrWhiteSpace(Number1.Text) || string.IsNullOrWhiteSpace(Number2.Text))
            {
                Response.Write("Error!!! You cannot have empty fields. <br>");
                return false;
            }
            else
            {

                bool result1 = Decimal.TryParse(Number1.Text, out number1);
                bool result2 = Decimal.TryParse(Number2.Text, out number2);
                if (!(result1 && result2))
                {
                    Response.Write("You can only use numbers! <br>");
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }
        
        protected void btnAdd_Click(object sender, EventArgs e)
        {

            bool numCheck = numberCheck();
            if (numCheck == true)
            {

                decimal fresult = number1 + number2;
                String sresult = Convert.ToString(fresult);

                //output to the result label
                result.Text = (sresult);
            }
            else
            {
                Response.Write("Error received");
            }
            //}
   

        }
        protected void btnSub_Click(object sender, EventArgs e)
        {
            //you'll need to handle the error if they enter nothing... see resources for exception handling
            bool numCheck = numberCheck();
            if (numCheck==true)
            {

                decimal fresult = number1 - number2;
                String sresult = Convert.ToString(fresult);

                //output to the result label
                result.Text = (sresult);
            }
            else
            {
                Response.Write("Error received");
            }
        }


        protected void btnMul_Click(object sender, EventArgs e)
        {
            //you'll need to handle the error if they enter nothing... see resources for exception handling
            bool numCheck = numberCheck();
            if (numCheck == true)
            {

                decimal fresult = number1 * number2;
                String sresult = Convert.ToString(fresult);

                //output to the result label
                result.Text = (sresult);
            }
            else
            {
                Response.Write("Error received");
            }
        }
        protected void btnDiv_Click(object sender, EventArgs e)
        {
            //you'll need to handle the error if they enter nothing or if second number is zero... see resources for exception handling
            bool numCheck = numberCheck();
            if (numCheck == true)
            {
                if (number2 == 0)
                {
                    Response.Write("You cannot divide by zero.");
                }
                else
                {

                    decimal fresult = number1 / number2;
                    String sresult = Convert.ToString(fresult);
                    String qresult = string.Format("{0:0.00}", fresult);
                    

                    //output to the result label
                    result.Text = (qresult);
                }
            }
            else
            {
                Response.Write("Error received");
            }
        }
    
        
    }
}