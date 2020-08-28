using System;

namespace LogDemo.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger(true, new[] { "./log.txt" });

            logger.LogToTarget(LogLevel.Information, "尝试登录...");

            // 验证验证码逻辑
            logger.LogInformation("验证码正确");

            logger.LogInformation("尝试连接数据库...");
            // 连接数据库逻辑
            logger.LogInformation("连接数据库成功...");

            logger.LogInformation("匹配用户名和密码中...");
            // 匹配用户名和密码逻辑
            logger.LogInformation("用户名和密码匹配正确");

            logger.LogInformation("检测用户权限中...");
            // 验证用户权限
            logger.LogInformation("用户登录成功");
        }
    }
}
