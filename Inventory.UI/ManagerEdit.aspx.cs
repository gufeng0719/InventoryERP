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
    public partial class ManagerEdit : System.Web.UI.Page
    {
        private  readonly  ManagerBLL managerBLL = new ManagerBLL();
        private  readonly  StoreBLL storeBLL = new StoreBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable storeTable = storeBLL.GetAllStore();
                stno.DataTextField = "stno";
                stno.DataValueField = "stno";
                stno.DataSource = storeTable;
                stno.DataBind();
                if (Request.QueryString.Count > 0)
                {
                    string strmno = Request.QueryString["mno"].ToString();
                    manager m = managerBLL.GetSingleByno(strmno);
                    if (m != null)
                    {
                        mno.Value = strmno;
                        mname.Value = m.mname;
                        sex.Value = m.sex;
                        birthday.Value = m.birthday.ToString("yyyy-MM-dd");
                        stno.SelectedValue = m.stno;
                    }
                }
                else
                {
                    Response.Redirect("ManagerList.aspx");
                }
            }
            
        }

        protected void btnSave_OnClick(object sender, EventArgs e)
        {
            manager newM = new manager();
            newM.mno = mno.Value;
            newM.mname = mname.Value;
            newM.sex = sex.Value;
            newM.birthday = DateTime.Parse(birthday.Value);
            newM.stno = stno.SelectedValue;
            int number = managerBLL.Update(newM);
            if (number > 0)
            {
                Response.Write("<script>alert('修改成功');window.location.href='ManagerList.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alter('修改失败');</script>");
            }

        }
    }
}