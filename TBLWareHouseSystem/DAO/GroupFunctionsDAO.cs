using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBLWareHouseSystem.Models;

namespace TBLWareHouseSystem.DAO
{
    internal class GroupFunctionsDAO
    {
        public List<GetGroupFunctionsList_Result> getAllGroupFunction(string ProductID)
        {
            TBLWareHouseSystemEntities entities = new TBLWareHouseSystemEntities();
            List<GetGroupFunctionsList_Result> list = entities.GetGroupFunctionsList(ProductID).ToList();
            return list;
        }
        public int InsertGroupFuncTion(GroupFunction groupFunction)
        {
            int resultInsert = 0;
            TBLWareHouseSystemEntities entity = new TBLWareHouseSystemEntities();
            foreach (var item in entity.GroupFunctions.ToList())
            {
                if (item.FunctionID.Equals(groupFunction.FunctionID))
                {
                    return 0;
                }
            }
            resultInsert = entity.InsertAndUpdateGroupFunctionsList(groupFunction.GroupID, groupFunction.FunctionID, groupFunction.isEnable, groupFunction.UpdateBy);
            return resultInsert;

        }
        public int DeleteGroupFunction(string GroupID)
        {
            int resultDelete = 0;
            TBLWareHouseSystemEntities entities = new TBLWareHouseSystemEntities();
            resultDelete = entities.DeleteGroupFunctionList(GroupID);
            if (resultDelete < 0)
            {
                return 0;
            }
            return resultDelete;
        }
        public int UpdateGroupFunction(GroupFunction groupFunction)
        {
            int resultUpdate = 0;
            TBLWareHouseSystemEntities entity = new TBLWareHouseSystemEntities();
            foreach (var item in entity.GroupFunctions.ToList())
            {
                if (item.FunctionID.Equals(groupFunction.FunctionID))
                {
                    resultUpdate = entity.InsertAndUpdateGroupFunctionsList(groupFunction.GroupID, groupFunction.FunctionID, groupFunction.isEnable, groupFunction.UpdateBy);
                }
            }
            return resultUpdate;
        } 
    }
}
