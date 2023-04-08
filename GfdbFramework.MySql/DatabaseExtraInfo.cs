using System;
using System.Collections.Generic;
using System.Text;

namespace GfdbFramework.MySql
{
    /// <summary>
    /// MySql 数据库额外信息。
    /// </summary>
    public class DatabaseExtraInfo
    {
        /// <summary>
        /// 获取或设置数据库所使用的字符集。
        /// </summary>
        public string CharActer { get; set; }

        /// <summary>
        /// 获取或设置数据库的排序规则。
        /// </summary>
        public string Collate { get; set; }
    }
}
