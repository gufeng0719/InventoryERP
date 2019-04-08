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
    public class IntoStoreDAL
    {


        #region 入库

        /// <summary>
        /// 入库记录操作
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Insert(IntoStore t)
        {
            /* string connstring = "";
             SqlConnection conn = new SqlConnection(connstring);
             conn.Open();
             SqlCommand cmd = new SqlCommand();
             SqlTransaction tran = conn.BeginTransaction(); //ADO.NET 进行事务操作
             cmd.Transaction = tran;
             string strSql = "insert into IntoStore values(@gno,@stno,@mno,@number,@intoTime) ;";
             SqlParameter[] parameters =
             {
                 new SqlParameter("@gno", SqlDbType.Char, 6) {Value = t.gno},
                 new SqlParameter("@stno", SqlDbType.Char, 3) {Value = t.stno},
                 new SqlParameter("@mno", SqlDbType.Char, 3) {Value = t.mno},
                 new SqlParameter("@number", SqlDbType.Int, 4) {Value = t.number},
                 new SqlParameter("@intoTime", SqlDbType.DateTime) {Value = t.intoTime}
             };

             invent invent1 = new InventDAL().GetSingleByno(t.stno, t.gno);
             if (invent1 != null)
             {
               strSql += "update invent set number+=@number where stno=@stno and gno=@gno";

             }
             else
             {
                 strSql += "insert into invent values(@stno,@gno,@number)";
             }

             cmd.CommandText = strSql;
             cmd.Parameters.AddRange(parameters);
             int number = cmd.ExecuteNonQuery();
             if (number ==2)
             {
                 tran.Commit();
             }
             else
             {
                 tran.Rollback();
             }

             return number;*/

            string strSql = "proc_IntoScoreRecord";
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

        #endregion


        #region 入库记录查询

        public DataTable Query(string strWhere)
        {
            throw new NotImplementedException();
        }

        #endregion







    }
}
