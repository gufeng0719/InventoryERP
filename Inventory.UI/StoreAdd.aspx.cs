using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory.BLL;
using Inventory.Model;

namespace Inventory.UI
{
    public partial class StoreAdd : System.Web.UI.Page
    {
        private  readonly  StoreBLL storeBLL = new StoreBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_OnClick(object sender, EventArgs e)
        {
            Store store = new Store();
            store.stno = Request.Form["stno"].ToString();
            store.address = Request.Form["address"].ToString();
            store.telephone = Request.Form["telephone"].ToString();
            store.capacity = int.Parse(Request.Form["capacity"].ToString());
            int number = storeBLL.Insert(store);
            if (number > 0)
            {
                Response.Write("<script>alert('仓库添加成功');window.location.href='StoreList.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('仓库添加失败');</script>");
            }
        }
    }
}