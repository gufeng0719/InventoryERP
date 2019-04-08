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
    public partial class GoodAdd : System.Web.UI.Page
    {
        private  readonly  GoodsBLL goodBLL = new GoodsBLL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_OnClick(object sender, EventArgs e)
        {
            var good = new goods();
            
            good.gno = Request.Form["gno"].ToString();
            good.gname = Request.Form["gname"].ToString();
            try
            {
                good.price = decimal.Parse(Request.Form["price"].ToString());
            }
            catch (Exception)
            {

                return;
            }
           good.producer = Request.Form["producer"].ToString();
           int number = goodBLL.Insert(good);
           if (number > 0)
           {
               Response.Write("<script>alert('添加成功');window.location.href='GoodsList.aspx';</script>");
            }
           else
           {
               Response.Write("<script>alter('添加失败');</script>");
           }
        }
    }
}