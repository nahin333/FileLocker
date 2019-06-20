using System;
using System.IO;

namespace JarvisTheLocker
{
    public static class Config
    {
        public static string AppName = "Jarvis The Locker";
        public static string AppDataFileName = "user_pass.txt";
        public static int CryptoKeySize = 1024;
        public static byte XORKey = 19;

        private static string _userFileExt = ".txt";

        public static string AppDataFolderPath
        {
            get
            {
                return  Path.Combine(@"C:\", 
                    AppName);
            }
        }
        public static string AppDataFilePath
        {
            get
            {
                return Path.Combine(AppDataFolderPath,
                    AppDataFileName);
            }
        }

        public static string GetAppDataUserFile(string u)
        {
            return Path.Combine(AppDataFolderPath, u + _userFileExt);
        }
    }
}
