//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
//     author MEIAM
// </auto-generated>
//------------------------------------------------------------------------------
using Meiam.System.Model;
using Meiam.System.Model.Dto;
using Meiam.System.Model.View;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Meiam.System.Interfaces
{
    public interface ISysUsersService : IBaseService<Sys_Users>
    {

        #region CustomInterface 

        /// <summary>
        /// 获取用户权限标识
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        List<string> GetUserPowers(string userId);

        /// <summary>
        /// 获取用户拥有的数据权限列表
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        List<Sys_UserRelation> GetUserRelation(string userId);

        #endregion

    }
}
