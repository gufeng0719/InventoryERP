using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory.BLL;
using Inventory.Model;

namespace Inventory.UI
{
    public partial class InventCharts : System.Web.UI.Page
    {
        private  readonly  InventBLL inventBLL = new InventBLL();
        private  readonly  GoodsBLL goodBLL = new GoodsBLL();
        public string sumNumber { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable goodTable = goodBLL.GetAllGood();
                DataTable queryDataTable = inventBLL.QueryCharts();
                StringBuilder strJson = new  StringBuilder();
                strJson.Append("[");
                for (int i = 0; i < queryDataTable.Rows.Count; i++)
                {
                    strJson.Append("{");
                    strJson.Append("name:\"" + goodTable.Rows[i]["gname"]+"\",");
                    strJson.Append("value:"+queryDataTable.Rows[i]["sumNumber"].ToString());
                    strJson.Append("},");
                }
                /*
                 * select g.gno,(case  when SUM(i.number) IS NULL  then 0 else SUM(i.number) end ) as sumNumber
                 * from goods g left join invent i on g.gno = i.gno group by g.gno 
                 */
                sumNumber = strJson.ToString().TrimEnd(',');
               sumNumber += "]";
            }
        }
    }
}