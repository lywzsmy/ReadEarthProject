/*******************************************************************************
 * Copyright © 2016 Readearth.Framework 版权所有
 * Author: Readearth
 * Description: 地听快速开发平台
 * Website：http://www.readearth.com
*********************************************************************************/

namespace Readearth.Code
{
    public class TreeGridModel
    {
        public string id { get; set; }
        public string parentId { get; set; }
        public string text { get; set; }
        public bool isLeaf { get; set; }
        public bool expanded { get; set; }
        public bool loaded { get; set; }
        public string entityJson { get; set; }
    }
}
