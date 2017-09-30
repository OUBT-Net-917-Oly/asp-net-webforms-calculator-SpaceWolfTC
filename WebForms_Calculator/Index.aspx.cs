using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1_empty
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page_Load() event <br/>");
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page_PreInit() event <br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page_Init() event <br/>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page_PreRender() event <br/>");
        }
        protected void Page_Unload(object sender, EventArgs e)
        {
            //cleanup tasks
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Hello Name!
            lblName.Text = string.Format("Hello {0}!", txtName.Text);
        }
    }
}