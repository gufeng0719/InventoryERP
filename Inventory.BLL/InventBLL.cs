using System;
using System.Data;
using Inventory.DAL;
using Inventory.Model;

namespace Inventory.BLL
{
    public class InventBLL : IDataService<invent>
    {
        private  readonly  InventDAL inventDAL = new InventDAL();

        #region 添加

        /// <summary>
        /// 添加库存信息
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Insert(invent t)
        {
            return inventDAL.Insert(t);
        }
        #endregion

        #region 修改
        /// <summary>
        /// 修改库存信息
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Update(invent t)
        {
            return inventDAL.Update(t);
        }
        #endregion

        #region 删除
        /// <summary>
        /// 根据商品编号，删除该商品所有库存信息
        /// </summary>
        /// <param name="gno">商品编号</param>
        /// <returns></returns>
        public int Delete(string gno)
        {
            return inventDAL.Delete(gno);
        }
        /// <summary>
        /// 根据商品编号与库位编号，删除该库存信息
        /// </summary>
        /// <param name="stno">库位编号</param>
        /// <param name="gno">商品编号</param>
        /// <returns></returns>
        public int Delete( string stno,string gno)
        {
            return inventDAL.Delete(stno, gno);
        }

        #endregion

        #region 查询
        /// <summary>
        /// 根据商品编号查询库存信息
        /// </summary>
        /// <param name="gno">商品编号</param>
        /// <returns></returns>
        public invent GetSingleByno(string gno)
        {
            return inventDAL.GetSingleByno(gno);
        }
        /// <summary>
        /// 根据库位编号，商品编号查询该库存信息
        /// </summary>
        /// <param name="stno">库位编号</param>
        /// <param name="gno">商品编号</param>
        /// <returns></returns>
        public invent GetSingleByno(string stno, string gno)
        {
            return inventDAL.GetSingleByno(stno, gno);
        }

        /// <summary>
        /// 根据仓库编号，查询该库存储的商品信息
        /// </summary>
        /// <param name="stno">仓库编号</param>
        /// <returns></returns>
        public DataTable GetGoodInfoByStno(string stno)
        {
            return inventDAL.GetGoodInfoByStno(stno);
        }

        /// <summary>
        /// 查询所有库存信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllInvent()
        {
            return Query("");
        }

        /// <summary>
        /// 根据查询条件查询库存信息
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <returns></returns>
        public DataTable Query(string strWhere)
        {
            return inventDAL.Query(strWhere);
        }

        public DataTable QueryCharts()
        {
            return inventDAL.QueryCharts();
        }

        #endregion
    }
}