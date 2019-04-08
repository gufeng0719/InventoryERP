using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    /// <summary>
    /// 出库记录实体类
    /// </summary>
    [Serializable]
    public class OutStore
    {
        /// <summary>
        /// 出库编号
        /// </summary>
        public  int outId { get; set; }
        /// <summary>
        /// 商品编号
        /// </summary>
        public  string gno { get; set; }
        /// <summary>
        /// 库位编号
        /// </summary>
        public  string stno { get; set; }
        /// <summary>
        /// 出库操作者
        /// </summary>
        public  string mno { get; set; }
        /// <summary>
        /// 出库数量
        /// </summary>
        public  int number { get; set; }
        /// <summary>
        /// 出库时间
        /// </summary>
        public  DateTime outTime { get; set; }
    }
}
