﻿/*
 * Copyright 2020 Huawei Technologies Co.,Ltd.
 * 
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

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.String;

namespace HuaweiCloud.SDK.Core.Auth
{
    public class GlobalCredentials : Credentials
    {
        private string Ak { set; get; }
        private string Sk { set; get; }
        private string DomainId { set; get; }
        private string SecurityToken { set; get; }

        public GlobalCredentials(string ak, string sk, string domainId)
        {
            if (IsNullOrEmpty(ak))
            {
                throw new ArgumentNullException(nameof(ak));
            }

            if (IsNullOrEmpty(sk))
            {
                throw new ArgumentNullException(nameof(sk));
            }

            if (IsNullOrEmpty(domainId))
            {
                throw new ArgumentNullException(nameof(domainId));
            }

            this.Ak = ak;
            this.Sk = sk;
            this.DomainId = domainId;
        }

        public GlobalCredentials WithSecurityToken(string token)
        {
            this.SecurityToken = token;
            return this;
        }

        public override Dictionary<string, string> GetPathParamDictionary()
        {
            var pathParamDictionary = new Dictionary<string, string>();

            if (DomainId != null)
            {
                pathParamDictionary.Add("domain_id", DomainId);
            }

            return pathParamDictionary;
        }

        public override Task<HttpRequest> SignAuthRequest(HttpRequest request)
        {
            Task<HttpRequest> httpRequestTask = Task<HttpRequest>.Factory.StartNew(() =>
            {
                request.Headers.Add("X-Domain-Id", DomainId);

                if (SecurityToken != null)
                {
                    request.Headers.Add("X-Security-Token", SecurityToken);
                }

                if (!IsNullOrEmpty(request.ContentType) && !request.ContentType.Contains("application/json"))
                {
                    request.Headers.Add("X-Sdk-Content-Sha256", "UNSIGNED-PAYLOAD");
                }

                var signer = new Signer {Key = Ak, Secret = Sk};
                signer.Sign(request);

                return request;
            });

            return httpRequestTask;
        }
    }
}