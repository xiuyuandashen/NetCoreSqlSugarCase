using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace NetCoreSqlSugarCase.Models
{
    ///<summary>
    ///
    ///</summary>
    [SplitTable(SplitType.Month)] //按月分表 （自带分表支持 年、季、月、周、日）
    [SugarTable("User_{year}{month}{day}")]
    public partial class User
    {
        public User()
        {


        }
        /// <summary>
        /// Desc:雪花ID
        /// Default:
        /// Nullable:False
        /// </summary>           
        [SugarColumn(IsPrimaryKey = true)]
        public long ID { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Name { get; set; }

        /// <summary>
        /// Desc:创建时间，根据这个分表
        /// Default:
        /// Nullable:True
        /// </summary>  
        [SplitField] //分表字段
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Desc:更新时间
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? UpdateTime { get; set; }

    }
}
