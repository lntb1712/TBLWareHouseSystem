using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBLWareHouseSystem.Models;

namespace TBLWareHouseSystem.DAO
{
    internal class UserGroupsDAO
    {
        public List<GroupManagement> getAllGroupManagement()
        {
            TBLWareHouseSystemEntities entities = new TBLWareHouseSystemEntities();
            List<GroupManagement> list = entities.GroupManagements.ToList();
            return list;
        }
        public int InsertGroupManagement(GroupManagement groupManagement)
        {
            int result = 0;
            TBLWareHouseSystemEntities entity = new TBLWareHouseSystemEntities();

            foreach (var item in entity.GroupManagements.ToList())
            {
                if (item.GroupID.Equals(groupManagement.GroupID))
                {
                    return 0;
                }
            }
            result = entity.InsertGroupManagement(groupManagement.GroupID, groupManagement.GroupName, groupManagement.GroupDescription, groupManagement.UpdateBy);
            return result;
        }
        public int DeleteGroupManagement(string GroupID)
        {
            int result = 0;
            TBLWareHouseSystemEntities entity = new TBLWareHouseSystemEntities();
            result = entity.DeleteGroupManagement(GroupID);
            if (result < 0)
            {
                return 0;
            }

            return result;

        }

        public int UpdateGroupManagement(GroupManagement groupManagement) 
        {
        
            int result = 0;
            TBLWareHouseSystemEntities entities = new TBLWareHouseSystemEntities();
            foreach (var item in entities.GroupManagements.ToList())
            {
                if(item.GroupID.Equals(groupManagement.GroupID))
                {
                    result = entities.UpdateGroupManagement(groupManagement.GroupID, groupManagement.GroupName, groupManagement.GroupDescription, groupManagement.UpdateBy);
                    return result;
                }
            }
            return 0;
        } 
    }
}
