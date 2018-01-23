/*******************************************************************************
 * Copyright © 2016 Readearth.Framework 版权所有
 * Author: Readearth
 * Description: 地听快速开发平台
 * Website：http://www.readearth.com
*********************************************************************************/
using Readearth.Data;
using Readearth.Domain.Entity.SystemManage;
using Readearth.Domain.IRepository.SystemManage;
using Readearth.Repository.SystemManage;
using System.Collections.Generic;

namespace Readearth.Repository.SystemManage
{
    public class RoleRepository : RepositoryBase<RoleEntity>, IRoleRepository
    {
        public void DeleteForm(string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                db.Delete<RoleEntity>(t => t.F_Id == keyValue);
                db.Delete<RoleAuthorizeEntity>(t => t.F_ObjectId == keyValue);
                db.Commit();
            }
        }
        public void SubmitForm(RoleEntity roleEntity, List<RoleAuthorizeEntity> roleAuthorizeEntitys, string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                if (!string.IsNullOrEmpty(keyValue))
                {
                    db.Update(roleEntity);
                }
                else
                {
                    roleEntity.F_Category = 1;
                    db.Insert(roleEntity);
                }
                db.Delete<RoleAuthorizeEntity>(t => t.F_ObjectId == roleEntity.F_Id);
                db.Insert(roleAuthorizeEntitys);
                db.Commit();
            }
        }
    }
}
