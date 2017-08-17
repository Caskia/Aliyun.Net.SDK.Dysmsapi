﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aliyun.Net.SDK.Core.Profile;

namespace Aliyun.Net.SDK.Core.Utils
{
    public static class CacheTime
    {
        private static DateTime lastClearTime = DateTime.Now;
        private static readonly object syncRoot = new object();

        public static bool CheckCacheIsExpire()
        {

            lock (syncRoot)
            {
                TimeSpan ts = DateTime.Now - lastClearTime;
                if (600 < ts.TotalSeconds)
                {
                    DefaultProfile.ClearLocationEndPoints();
                    lastClearTime = DateTime.Now;
                    return true;
                }

                return false;
            }
        }
    }
}
