using SqlSugar;
using static System.Net.Mime.MediaTypeNames;

namespace NetCoreSqlSugarCase.config
{
    public static class SqlSugarConfiguration
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service">服务</param>
        /// <param name="configuration">配置文件</param>
        public static void AppSqlsugarSetup(this IServiceCollection service, IConfiguration configuration)
        {
            SqlSugarScope sqlSugar = new SqlSugarScope(
                new ConnectionConfig()
                {
                    DbType = SqlSugar.DbType.SqlServer,//数据库类型
                    ConnectionString = configuration["DbDataSource"],//配置文件中的数据库链接key值
                    IsAutoCloseConnection = true,//是否自动关闭连接
                },
                db => {

                    //单例参数配置，所有上下文生效
                    db.Aop.OnLogExecuting = (sql, pars) =>
                    {
                        Console.WriteLine("Sql语句:"+sql);//输出sql
                    };
                    //技巧：拿到非ORM注入对象
                    //services.GetService<注入对象>();
                }
            );
            
            service.AddSingleton<ISqlSugarClient>(sqlSugar);//这边是SqlSugarScope用AddSingleton
        } 

        /// <summary>
        /// SqlSugar生成实体类
        /// </summary>
        /// <param name="app"></param>
        public static void CreateMapper( this IApplicationBuilder app)
        {
            ISqlSugarClient dbClient;
            dbClient = app.ApplicationServices.GetService<ISqlSugarClient>();
            var tables = dbClient?.DbMaintenance.GetTableInfoList(false);//true 走缓存 false不走缓存
            foreach (var table in tables)
            {
                Console.WriteLine(table.Name);//输出表信息
            }
            //生成实体 在bin下Models生成实体类，实体类命名空间为NetCoreSqlSugarCase.Models
            dbClient.DbFirst.IsCreateAttribute().CreateClassFile(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory,"Models"), "NetCoreSqlSugarCase.Models");
            //参数1：路径  参数2：命名空间
            //IsCreateAttribute 代表生成SqlSugar特性
        }
    }
}
