using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace NetCoreSqlSugarCase.Models
{
    ///<summary>
    ///测试
    ///</summary>
    [SugarTable("abc")]
    public partial class abc
    {
           public abc(){


           }
           /// <summary>
           /// Desc:ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int STATE {get;set;}

           /// <summary>
           /// Desc:TaskID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int TaskID {get;set;}

           /// <summary>
           /// Desc:单号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string APPNO {get;set;}

           /// <summary>
           /// Desc:说明
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string DESC {get;set;}

           /// <summary>
           /// Desc:流程名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ProcessName {get;set;}

           /// <summary>
           /// Desc:节点名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string NodeName {get;set;}

           /// <summary>
           /// Desc:操作
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string SelAction {get;set;}

           /// <summary>
           /// Desc:异常标识
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ExID {get;set;}

           /// <summary>
           /// Desc:异常标识字段
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ExIDField {get;set;}

           /// <summary>
           /// Desc:处理状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int OPState {get;set;}

           /// <summary>
           /// Desc:处理备注
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string OPRemark {get;set;}

           /// <summary>
           /// Desc:处理人工号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string OPUserAcc {get;set;}

           /// <summary>
           /// Desc:处理人姓名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string OPUserName {get;set;}

           /// <summary>
           /// Desc:处理时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime OPDate {get;set;}

           /// <summary>
           /// Desc:创建人工号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CUserAcc {get;set;}

           /// <summary>
           /// Desc:创建人姓名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CUserName {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime CDate {get;set;}

    }
}
