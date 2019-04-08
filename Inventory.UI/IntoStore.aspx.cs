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
    public partial class IntoStore : System.Web.UI.Page
    {
        private  readonly  GoodsBLL goodBLL = new GoodsBLL();
        private  readonly  StoreBLL storeBLL = new StoreBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable goodsTable = goodBLL.GetAllGood();
                DataTable storebTable = storeBLL.GetAllStore();
                gno.DataSource = goodsTable;
                gno.DataTextField = "gname";
                gno.DataValueField = "gno";
                gno.DataBind();
                stno.DataSource = storebTable;
                stno.DataTextField = stno.DataValueField = "stno";
                stno.DataBind();
            }
        }

        /// <summary>
        /// 添加入库记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAdd_OnClick(object sender, EventArgs e)
        {
           
            Model.IntoStore intoStore = new Model.IntoStore(); 
           intoStore.gno = this.gno.SelectedValue;
            intoStore.stno = this.stno.SelectedValue;
            intoStore.number =int.Parse( txtNumber.Text.Trim());
            intoStore.mno = Session["mno"].ToString();
            int number = new IntoStoreBLL().Insert(intoStore);
            if (number > 0)
            {
                Response.Write("<script>alert('入库成功');</script>");
            }
            else
            {
                Response.Write("<script>alert('入库失败');</script>");
            }
            //string mno = // 缺登录功能，在登录成功时候保存当前登录者信息
            //往入库表中插入入库记录 缺入库表的模型层、数据访问层（添加、修改（权限） 删除不能开、查询需要些）、业务逻辑层
            //入库成功需要往库存表中写输入数据
        }
    }
}