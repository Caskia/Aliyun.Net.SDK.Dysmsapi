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
    public class QuerySendDetailsRequest : RpcAcsRequest<QuerySendDetailsResponse>
    {
        private string accessKeyId;

        private string action;

        private string bizId;

        private long? currentPage;

        private long? ownerId;

        private long? pageSize;

        private string phoneNumber;

        private string resourceOwnerAccount;

        private long? resourceOwnerId;

        private string sendDate;

        public QuerySendDetailsRequest()
                                                                                            : base("Dysmsapi", "2017-05-25", "QuerySendDetails")
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

        public string BizId
        {
            get
            {
                return bizId;
            }
            set
            {
                bizId = value;
                DictionaryUtil.Add(QueryParameters, "BizId", value);
            }
        }

        public long? CurrentPage
        {
            get
            {
                return currentPage;
            }
            set
            {
                currentPage = value;
                DictionaryUtil.Add(QueryParameters, "CurrentPage", value.ToString());
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

        public long? PageSize
        {
            get
            {
                return pageSize;
            }
            set
            {
                pageSize = value;
                DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
                DictionaryUtil.Add(QueryParameters, "PhoneNumber", value);
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

        public string SendDate
        {
            get
            {
                return sendDate;
            }
            set
            {
                sendDate = value;
                DictionaryUtil.Add(QueryParameters, "SendDate", value);
            }
        }

        public override QuerySendDetailsResponse GetResponse(Aliyun.Net.SDK.Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QuerySendDetailsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}