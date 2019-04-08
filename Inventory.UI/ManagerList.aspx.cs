using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory.BLL;

namespace Inventory.UI
{
    public partial class ManagerList : System.Web.UI.Page
    {
        private readonly ManagerBLL managerBLL = new ManagerBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable manageTable = managerBLL.GetAllManager();
                Repeater1.DataSource = manageTable;
                Repeater1.DataBind();
            }

        }

        protected void LinkButton1_OnClick(object sender, EventArgs e)
        {
            LinkButton link = (LinkButton)sender;
            string mno = link.CommandArgument.ToString();
            if (!string.IsNullOrEmpty(mno))
            {
                int number = managerBLL.Delete(mno);
                if (number > 0)
                {
                    Response.Write("<script>alert('删除成功');window.location.href='ManagerList.aspx';</script>");
                }
                else
                {
                    Response.Write("<script>alter('修改失败');</script>");
                }
            }
        }
    }
}