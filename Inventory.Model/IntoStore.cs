using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    /// <summary>
    /// 入库记录实体类
    /// </summary>
    [Serializable]
    public class IntoStore
    {
        /// <summary>
        /// 入库编号
        /// </summary>
        public  int intoID { get; set; }
        /// <summary>
        /// 商品编号
        /// </summary>
        public  string gno { get; set; }
        /// <summary>
        /// 仓库编号
        /// </summary>
        public  string stno { get; set; }
        /// <summary>
        /// 入库操作者
        /// </summary>
        public string mno { get; set; }
        /// <summary>
        /// 入库数量
        /// </summary>
        public  int number { get; set; }
        /// <summary>
        /// 入库时间
        /// </summary>
        public  DateTime intoTime { get; set; }
    }
}
