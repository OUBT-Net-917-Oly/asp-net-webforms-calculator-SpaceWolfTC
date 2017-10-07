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
        public static decimal fresult = 0;
        public static string sresult = "";
        public static string btn = "";

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

        protected void doMath(object sender, EventArgs e)
        {
            bool numCheck = numberCheck();
            if (numCheck == true)
            {

                btn = (sender as Button).ID;
                switch (btn)
                {
                    case "btnAdd":
                        fresult = number1 + number2;
                        sresult = Convert.ToString(fresult);

                        //output to the result label
                        result.Text = (sresult);
                        break;
                    case "btnSub":
                        fresult = number1 - number2;
                        sresult = Convert.ToString(fresult);

                        //output to the result label
                        result.Text = (sresult);
                        break;
                    case "btnMul":
                        fresult = number1 * number2;
                        sresult = Convert.ToString(fresult);

                        //output to the result label
                        result.Text = (sresult);
                        break;
                    case "btnDiv":
                        if (number2 == 0)
                        {
                            Response.Write("You cannot divide by zero.");
                            Number1.Text = String.Empty;
                            Number2.Text = String.Empty;
                            result.Text = String.Empty;
                        }
                        else
                        {

                            fresult = number1 / number2;
                            sresult = Convert.ToString(fresult);
                            String qresult = string.Format("{0:0.00}", fresult);
                       
                            result.Text = (qresult);
                        }
                        break;
                }


            }
            else
            {
                Response.Write("Error received");
                Number1.Text = String.Empty;
                Number2.Text = String.Empty;
                result.Text = String.Empty;
            }

        }
        
       
    
        
    }
}