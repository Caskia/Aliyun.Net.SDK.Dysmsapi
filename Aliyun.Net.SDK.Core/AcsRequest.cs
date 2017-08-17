/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using Aliyun.Net.SDK.Core.Auth;
using Aliyun.Net.SDK.Core.Http;
using Aliyun.Net.SDK.Core.Regions;
using Aliyun.Net.SDK.Core.Transform;
using Aliyun.Net.SDK.Core.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aliyun.Net.SDK.Core
{
    public abstract class AcsRequest<T> : HttpRequest
    {
        private FormatType acceptFormat;
        private ProtocolType protocol = ProtocolType.HTTP;
        private Dictionary<String, String> queryParameters = new Dictionary<String, String>();

        public AcsRequest(String product)
            : base(null)
        {
            DictionaryUtil.Add(Headers, "x-sdk-client", "Net/2.0.0");
            Product = product;
        }

        public AcsRequest(String product, String version)
            : base(null)
        {
            Product = product;
            Version = version;
        }

        public virtual FormatType AcceptFormat
        {
            get
            {
                return acceptFormat;
            }
            set
            {
                acceptFormat = value;
                DictionaryUtil.Add(Headers, "Accept", value.ToString());
            }
        }

        public virtual String ActionName { get; set; }
        public ISignatureComposer Composer { get; set; }
        public String LocationProduct { get; set; }
        public virtual String Product { get; set; }

        public ProtocolType Protocol
        {
            get
            {
                return protocol;
            }
            set
            {
                protocol = value;
            }
        }

        public Dictionary<String, String> QueryParameters
        {
            get
            {
                return queryParameters;
            }
            set
            {
                queryParameters = value;
            }
        }

        public virtual String RegionId { get; set; }
        public virtual String Version { get; set; }

        public static String ConcatQueryString(Dictionary<String, String> parameters)
        {
            if (null == parameters)
            {
                return null;
            }
            StringBuilder sb = new StringBuilder();

            foreach (var entry in parameters)
            {
                String key = entry.Key;
                String val = entry.Value;

                sb.Append(AcsURLEncoder.Encode(key));
                if (val != null)
                {
                    sb.Append("=").Append(AcsURLEncoder.Encode(val));
                }
                sb.Append("&");
            }

            int strIndex = sb.Length;
            if (parameters.Count > 0)
                sb.Remove(strIndex - 1, 1);

            return sb.ToString();
        }

        public abstract String ComposeUrl(String endpoint, Dictionary<String, String> queries);

        public abstract T GetResponse(UnmarshallerContext unmarshallerContext);

        public abstract HttpRequest SignRequest(ISigner signer, Credential credential,
                                FormatType? format, ProductDomain domain);
    }
}