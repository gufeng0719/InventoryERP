using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.DBUnitily;
using Inventory.Model;

namespace Inventory.DAL
{
    /// <summary>
    /// 出库数据操作访类
    /// </summary>
   public class OutStoreDAL
    {
        /// <summary>
        /// 添加出库记录
        /// </summary>
        /// <param name="t">出库实体对象</param>
        /// <returns></returns>
        public int Insert(OutStore t)
        {
            string strSql = "proc_OutScoreRecord";
            SqlParameter[] parameters =
            {
                new SqlParameter("@gno", SqlDbType.Char, 6) {Value = t.gno},
                new SqlParameter("@stno", SqlDbType.Char, 3) {Value = t.stno},
                new SqlParameter("@mno", SqlDbType.Char, 3) {Value = t.mno},
                new SqlParameter("@number", SqlDbType.Int, 4) {Value = t.number}
            };
            int number = DBHelper.ExecuteProc(strSql, parameters);
            return number;
        }
             

    }
}
