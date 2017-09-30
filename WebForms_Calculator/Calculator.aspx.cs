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

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //you'll need to handle the error if they enter nothing... see resources for exception handling

            int number1 = Convert.ToInt32(Number1.Text);
            //get number2
            //add the numbers together

            //output to the result label
        }

        //implement the rest of the on-click methods
    }
}