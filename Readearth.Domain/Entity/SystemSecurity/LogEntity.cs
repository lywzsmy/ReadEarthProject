﻿/*******************************************************************************
 * Copyright © 2016 Readearth.Framework 版权所有
 * Author: Readearth
 * Description: 地听快速开发平台
 * Website：http://www.readearth.com
*********************************************************************************/
using System;

namespace Readearth.Domain.Entity.SystemSecurity
{
    public class LogEntity : IEntity<LogEntity>, ICreationAudited
    {
        public string F_Id { get; set; }
        public DateTime? F_Date { get; set; }
        public string F_Account { get; set; }
        public string F_NickName { get; set; }
        public string F_Type { get; set; }
        public string F_IPAddress { get; set; }
        public string F_IPAddressName { get; set; }
        public string F_ModuleId { get; set; }
        public string F_ModuleName { get; set; }
        public bool? F_Result { get; set; }
        public string F_Description { get; set; }
        public DateTime? F_CreatorTime { get; set; }
        public string F_CreatorUserId { get; set; }
    }
}