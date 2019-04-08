using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.DAL;
using Inventory.Model;

namespace Inventory.BLL
{
  public  class OutStoreBLL
    {
        private  readonly  OutStoreDAL outStoreDAL = new OutStoreDAL();

        /// <summary>
        /// 出库记录
        /// </summary>
        /// <param name="t">出库实体对象</param>
        /// <returns></returns>
        public int Insert(OutStore t)
        {
            return outStoreDAL.Insert(t);
        }
    }
}
