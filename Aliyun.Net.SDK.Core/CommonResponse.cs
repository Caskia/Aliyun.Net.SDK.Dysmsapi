using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aliyun.Net.SDK.Core.Http;

namespace Aliyun.Net.SDK.Core
{
    public class CommonResponse : AcsResponse
    {
        public string Data { get; set; }
    }
}
