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

        protected bool numberCheck()
        {
            if (string.IsNullOrWhiteSpace(Number1.Text) || string.IsNullOrWhiteSpace(Number2.Text))
            {
                Response.Write("Error!!! You cannot have empty fields. <br>");
                return false;
            }
            else
            {
                int number1;
                int number2;
                bool result1 = Int32.TryParse(Number1.Text, out number1);
                bool result2 = Int32.TryParse(Number2.Text, out number2);
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
                int number1 = Convert.ToInt32(Number1.Text);
                //get number2
                int number2 = Convert.ToInt32(Number2.Text);
                //add the numbers together
                int fresult = number1 + number2;
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
                int number1 = Convert.ToInt32(Number1.Text);
                //get number2
                int number2 = Convert.ToInt32(Number2.Text);
                //sub the numbers together
                int fresult = number1 - number2;
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
                int number1 = Convert.ToInt32(Number1.Text);
                //get number2
                int number2 = Convert.ToInt32(Number2.Text);
                //mul the numbers together
                int fresult = number1 * number2;
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
                if (Convert.ToInt32(Number2.Text) == 0)
                {
                    Response.Write("You cannot divide by zero.");
                }
                else
                {
                    decimal number1 = Convert.ToDecimal(Number1.Text);
                    //get number2
                    decimal number2 = Convert.ToDecimal(Number2.Text);
                    //div the numbers together
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