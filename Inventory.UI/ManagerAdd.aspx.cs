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
    public partial class ManagerAdd : System.Web.UI.Page
    {
        private  readonly  ManagerBLL managerBLL = new ManagerBLL();
        private  readonly  StoreBLL storeBLL = new StoreBLL();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //获取所有仓库列表
                DataTable storeTable = storeBLL.GetAllStore();
                stno.DataSource = storeTable;
                stno.DataTextField = "stno";
                stno.DataValueField = "stno";
                stno.DataBind();
            }
        }

        protected void btnAdd_OnClick(object sender, EventArgs e)
        {
            manager m = new manager();
            m.mno = Request.Form["mno"].ToString();
            m.mname = Request.Form["mname"].ToString();
            m.sex = Request.Form["sex"].ToString();
            m.birthday = DateTime.Parse(Request.Form["birthday"].ToString());
            m.stno = stno.SelectedValue;
            int number = managerBLL.Insert(m);
            if (number > 0)
            {
                Response.Write("<script>alert('添加成功');window.location.href='ManagerList.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alter('添加失败');</script>");
            }
        }
    }
}