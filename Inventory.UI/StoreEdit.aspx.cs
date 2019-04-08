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
    public partial class StoreEdit : System.Web.UI.Page
    {
        private  readonly  StoreBLL storeBLL = new StoreBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString.Count > 0)
                {
                    string strstno = Request.QueryString["stno"].ToString();
                    Store store = storeBLL.GetSingleByno(strstno);
                    stno.Value = strstno;
                    address.Value = store.address;
                    telephone.Value = store.telephone;
                    capacity.Value = store.capacity.ToString();
                }
            }

        }

        protected void btnSave_OnClick(object sender, EventArgs e)
        {
            Store store = new Store();
            store.stno = stno.Value;
            store.address = address.Value;
            store.telephone = telephone.Value;
            store.capacity = int.Parse(capacity.Value);
            int number = storeBLL.Update(store);
            if (number > 0)
            {
                Response.Write("<script>alert('仓库修改成功');window.location.href='StoreList.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('仓库修改失败');</script>");
            }

        }
    }
}