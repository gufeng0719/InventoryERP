using System;
using System.Data;
using System.Web.UI.WebControls;
using Inventory.BLL;

namespace Inventory.UI
{
    public partial class GoodsList : System.Web.UI.Page
    {
        private  readonly  GoodsBLL goodsBLL = new GoodsBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = goodsBLL.GetAllGood();
                Repeater1.DataSource = dt;
                Repeater1.DataBind();

            }
        }


        protected void LinkButton1_OnClick(object sender, EventArgs e)
        {
            LinkButton link = (LinkButton) sender;
            var gno = link.CommandArgument.ToString();
            //if()
            if (goodsBLL.Delete(gno)>0)
            {
                Response.Write("<script>alert('删除成功');window.location.href='GoodsList.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alter('删除失败');</script>");
            }
        }
    }
}