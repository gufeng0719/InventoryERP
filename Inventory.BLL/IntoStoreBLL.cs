using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.DAL;
using Inventory.Model;

namespace Inventory.BLL
{
    public class IntoStoreBLL
    {
        private  readonly  IntoStoreDAL intoStoreDal =new IntoStoreDAL();
        public int Insert(IntoStore intoStore)
        {
            return intoStoreDal.Insert(intoStore);
        }
    }
}
