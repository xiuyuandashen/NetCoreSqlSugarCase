using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreSqlSugarCase.Models;
using Newtonsoft.Json;
using SqlSugar;
using System.Collections.Generic;

namespace NetCoreSqlSugarCase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public ISqlSugarClient _db { get; set; }

        public UserController(ISqlSugarClient db)
        {
            _db = db;
        }

        /// <summary>
        /// 根据创建时间分表查询数据
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        [HttpGet, Route("users")]
        public Dictionary<string, object> GetUsers([FromQuery(Name = "dateTime")] string dateTime)
        {
            var time = DateTime.Parse(dateTime);
            try
            {
                var name = _db.SplitHelper<User>().GetTableName(time);
                var list = _db.Queryable<User>().AS(name).ToList();
                return new Dictionary<string, object>
                {
                    {"data",list }
                };
            }
            catch (Exception ex)
            {
                return new Dictionary<string, object>
                {
                    {"success","error" },
                    {"message","无此表" }
                };
            }

        }

        /// <summary>
        /// 自动分表插入数据
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost, Route("users")]
        public Dictionary<string, object> insertUser([FromBody] User user)
        {
            long id = _db.Insertable(user).SplitTable().ExecuteReturnSnowflakeId();
            return new Dictionary<string, object>
                {
                    {"id",id }
                };
        }
        /// <summary>
        /// 全表查询
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("all/users")]
        public Dictionary<string, object> selects()
        {
            var list = _db.Queryable<User>().SplitTable(tabs => tabs).ToList();//没有条件就是全部表
            return new Dictionary<string, object>
                {
                    {"data",list }
                };
        }
    }
}
