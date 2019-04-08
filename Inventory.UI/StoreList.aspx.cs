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
    public partial class StoreList : System.Web.UI.Page
    {
        private  readonly  StoreBLL storeBLL = new StoreBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable storeTable = storeBLL.GetAllStore();
                Repeater1.DataSource = storeTable;
                Repeater1.DataBind();
            }

        }

        protected void LinkButton1_OnClick(object sender, EventArgs e)
        {
            LinkButton link = (LinkButton)sender;
            string stno = link.CommandArgument.ToString();
            if (!string.IsNullOrEmpty(stno))
            {
                int number = storeBLL.Delete(stno);
                if (number > 0)
                {
                    Response.Write("<script>alert('删除成功');window.location.href='StoreList.aspx';</script>");
                }
                else
                {
                    Response.Write("<script>alert('删除失败');</script>");
                }
            }

        }
    }
}