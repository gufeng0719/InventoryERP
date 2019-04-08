using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory.BLL;
using Inventory.Model;

namespace Inventory.UI
{
    public partial class OutStoreRecord : System.Web.UI.Page
    {
        private readonly OutStoreBLL outStoreBLL = new OutStoreBLL();
        private readonly GoodsBLL goodBLL = new GoodsBLL();
        private readonly StoreBLL storeBLL = new StoreBLL();
        private readonly InventBLL inventBLL = new InventBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable storeTable = storeBLL.GetAllStore();
                stno.DataSource = storeTable;
                stno.DataTextField = stno.DataValueField = "stno";
                stno.DataBind();
                stno_OnSelectedIndexChanged(sender,e);
            }
        }

        protected void btnAdd_OnClick(object sender, EventArgs e)
        {
            OutStore t = new OutStore();
            t.stno = stno.SelectedValue;
            t.gno = gno.SelectedValue;
            t.number = int.Parse(txtNumber.Text.Trim());
            t.mno = Session["mno"].ToString();
            int number = outStoreBLL.Insert(t);
            if (number > 0)
            {
                Response.Write("<script>alert('出库成功');</script>");
            }
            else
            {
                Response.Write("<script>alert('出库失败');</script>");
            }
        }

        protected void stno_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string stno = this.stno.SelectedValue;
            DataTable goodTable = inventBLL.GetGoodInfoByStno(stno);
            gno.DataSource = goodTable;
            gno.DataTextField = "gname";
            gno.DataValueField = "gno";
            gno.DataBind();
            gno_OnSelectedIndexChanged(sender, e);
        }

        protected void gno_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string gno = this.gno.SelectedValue;
            string stno = this.stno.SelectedValue;
            invent invent1 = inventBLL.GetSingleByno(stno, gno);
            txtNumber.Attributes["placeholder"] = "当前库存总数:"+invent1.number;
        }
    }
}