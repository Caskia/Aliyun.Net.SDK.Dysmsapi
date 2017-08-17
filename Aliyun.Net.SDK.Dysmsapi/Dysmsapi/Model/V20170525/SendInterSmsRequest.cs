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

using Aliyun.Net.SDK.Core;
using Aliyun.Net.SDK.Core.Http;
using Aliyun.Net.SDK.Core.Transform;
using Aliyun.Net.SDK.Core.Utils;
using Aliyun.Acs.Dysmsapi.Transform;
using Aliyun.Acs.Dysmsapi.Transform.V20170525;
using System.Collections.Generic;

namespace Aliyun.Acs.Dysmsapi.Model.V20170525
{
    public class SendInterSmsRequest : RpcAcsRequest<SendInterSmsResponse>
    {
        private string accessKeyId;

        private string action;

        private string countryCode;

        private string outId;

        private long? ownerId;

        private string phoneNumbers;

        private string resourceOwnerAccount;

        private long? resourceOwnerId;

        private string signName;

        private string templateCode;

        private string templateParam;

        public SendInterSmsRequest()
                                                                                                    : base("Dysmsapi", "2017-05-25", "SendInterSms")
        {
        }

        public string AccessKeyId
        {
            get
            {
                return accessKeyId;
            }
            set
            {
                accessKeyId = value;
                DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
            }
        }

        public string Action
        {
            get
            {
                return action;
            }
            set
            {
                action = value;
                DictionaryUtil.Add(QueryParameters, "Action", value);
            }
        }

        public string CountryCode
        {
            get
            {
                return countryCode;
            }
            set
            {
                countryCode = value;
                DictionaryUtil.Add(QueryParameters, "CountryCode", value);
            }
        }

        public string OutId
        {
            get
            {
                return outId;
            }
            set
            {
                outId = value;
                DictionaryUtil.Add(QueryParameters, "OutId", value);
            }
        }

        public long? OwnerId
        {
            get
            {
                return ownerId;
            }
            set
            {
                ownerId = value;
                DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
            }
        }

        public string PhoneNumbers
        {
            get
            {
                return phoneNumbers;
            }
            set
            {
                phoneNumbers = value;
                DictionaryUtil.Add(QueryParameters, "PhoneNumbers", value);
            }
        }

        public string ResourceOwnerAccount
        {
            get
            {
                return resourceOwnerAccount;
            }
            set
            {
                resourceOwnerAccount = value;
                DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
            }
        }

        public long? ResourceOwnerId
        {
            get
            {
                return resourceOwnerId;
            }
            set
            {
                resourceOwnerId = value;
                DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
            }
        }

        public string SignName
        {
            get
            {
                return signName;
            }
            set
            {
                signName = value;
                DictionaryUtil.Add(QueryParameters, "SignName", value);
            }
        }

        public string TemplateCode
        {
            get
            {
                return templateCode;
            }
            set
            {
                templateCode = value;
                DictionaryUtil.Add(QueryParameters, "TemplateCode", value);
            }
        }

        public string TemplateParam
        {
            get
            {
                return templateParam;
            }
            set
            {
                templateParam = value;
                DictionaryUtil.Add(QueryParameters, "TemplateParam", value);
            }
        }

        public override SendInterSmsResponse GetResponse(Aliyun.Net.SDK.Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SendInterSmsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}