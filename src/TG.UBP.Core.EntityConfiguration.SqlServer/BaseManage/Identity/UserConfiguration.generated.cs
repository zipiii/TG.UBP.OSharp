﻿// <autogenerated>
//   This file was generated by T4 code generator ModelCodeScript.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;

using OSharp.Data.Entity;

using TG.UBP.Core.Entity.BaseManage.Identity;


namespace TG.UBP.Core.EntityConfiguration.SqlServer.BaseManage.Identity
{
    /// <summary>
    /// 实体类-数据表映射——User
    /// </summary> 
	public partial class UserConfiguration : EntityConfigurationBase<User, Int32>
    { 
        /// <summary>
        /// 初始化一个<see cref="UserConfiguration"/>类型的新实例
        /// </summary>
        public UserConfiguration()
        {
            UserConfigurationAppend();
        }

        /// <summary>
        /// 额外的数据映射
        /// </summary>
        partial void UserConfigurationAppend();
    }
}
