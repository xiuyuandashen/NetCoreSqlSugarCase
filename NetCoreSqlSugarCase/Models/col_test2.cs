using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace NetCoreSqlSugarCase.Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("col_test2")]
    public partial class col_test2
    {
           public col_test2(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string col1 {get;set;}

    }
}
