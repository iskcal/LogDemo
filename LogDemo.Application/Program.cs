using System;

namespace LogDemo.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string logFileName = "./log.txt";

            LogHelper.LogToConsoleAndFiles("尝试登录...", true, new[] { logFileName });

            // 验证验证码逻辑
            LogHelper.LogToConsoleAndFiles("验证码正确", true, new[] { logFileName });

            LogHelper.LogToConsoleAndFiles("尝试连接数据库...", true, new[] { logFileName });
            // 连接数据库逻辑
            LogHelper.LogToConsoleAndFiles("连接数据库成功...", true, new[] { logFileName });

            LogHelper.LogToConsoleAndFiles("匹配用户名和密码中...", true, new[] { logFileName });
            // 匹配用户名和密码逻辑
            LogHelper.LogToConsoleAndFiles("用户名和密码匹配正确", true, new[] { logFileName });

            LogHelper.LogToConsoleAndFiles("检测用户权限中...", true, new[] { logFileName });
            // 验证用户权限
            LogHelper.LogToConsoleAndFiles("用户登录成功", true, new[] { logFileName });
        }
    }
}
