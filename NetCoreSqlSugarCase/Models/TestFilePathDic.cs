using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace NetCoreSqlSugarCase.Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("TestFilePathDic")]
    public partial class TestFilePathDic
    {
           public TestFilePathDic(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public long ID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string POBatchCode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FileName {get;set;}

    }
}
