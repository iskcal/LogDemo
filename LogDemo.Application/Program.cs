using System;

namespace LogDemo.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string logFileName = "./log.txt";

            LogHelper.LogToFile("尝试登录...", logFileName);

            // 验证验证码逻辑
            LogHelper.LogToFile("验证码正确", logFileName);

            LogHelper.LogToFile("尝试连接数据库...", logFileName);
            // 连接数据库逻辑
            LogHelper.LogToFile("连接数据库成功...", logFileName);

            LogHelper.LogToFile("匹配用户名和密码中...", logFileName);
            // 匹配用户名和密码逻辑
            LogHelper.LogToFile("用户名和密码匹配正确", logFileName);

            LogHelper.LogToFile("检测用户权限中...", logFileName);
            // 验证用户权限
            LogHelper.LogToFile("用户登录成功", logFileName);
        }
    }
}
