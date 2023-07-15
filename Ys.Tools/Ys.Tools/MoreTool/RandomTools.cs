using System;
using System.Collections.Generic;
using System.Text;

namespace Ys.Tools.MoreTool
{
    public   class RandomTools
    {
        /// <summary>
        /// 获取6位随机数
        /// </summary>
        /// <returns></returns>
        public static int GenerateSix()
        {
            Random generator = new Random();
            int r = generator.Next(100000, 1000000);
            return r;
        }

        /// <summary>
        /// 获取5位随机数
        /// </summary>
        /// <returns></returns>
        public static int GenerateFive()
        {
            Random generator = new Random();
            int r = generator.Next(10000, 100000);
            return r;
        }
        /// <summary>
        /// 获取5位随机数
        /// </summary>
        /// <returns></returns>
        public static int GenerateFour()
        {
            Random generator = new Random();
            int r = generator.Next(1000, 10000);
            return r;
        }

    }
}
