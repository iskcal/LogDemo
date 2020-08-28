using System;

namespace LogDemo.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            LogHelper.LogToConsole("尝试登录...");

            // 验证验证码逻辑
            LogHelper.LogToConsole("验证码正确");

            LogHelper.LogToConsole("尝试连接数据库...");
            // 连接数据库逻辑
            LogHelper.LogToConsole("连接数据库成功...");

            LogHelper.LogToConsole("匹配用户名和密码中...");
            // 匹配用户名和密码逻辑
            LogHelper.LogToConsole("用户名和密码匹配正确");

            LogHelper.LogToConsole("检测用户权限中...");
            // 验证用户权限
            LogHelper.LogToConsole("用户登录成功");
        }
    }
}
