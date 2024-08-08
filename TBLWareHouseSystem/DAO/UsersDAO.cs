using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBLWareHouseSystem.Models;

namespace TBLWareHouseSystem.DAO
{
    internal class UsersDAO
    {
        public List<Account> getAllAccountList()
        {
            TBLWareHouseSystemEntities entities = new TBLWareHouseSystemEntities();
            List<Account> list = entities.Accounts.ToList();
            return list;
        }

    }
}
