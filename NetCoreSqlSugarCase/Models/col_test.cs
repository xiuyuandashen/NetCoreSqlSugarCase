using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace NetCoreSqlSugarCase.Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("col_test")]
    public partial class col_test
    {
           public col_test(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string col1 {get;set;}

    }
}
