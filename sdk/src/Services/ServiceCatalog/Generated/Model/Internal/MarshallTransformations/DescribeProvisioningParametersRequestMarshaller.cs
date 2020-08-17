/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServiceCatalog.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ServiceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeProvisioningParameters Request Marshaller
    /// </summary>       
    public class DescribeProvisioningParametersRequestMarshaller : IMarshaller<IRequest, DescribeProvisioningParametersRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeProvisioningParametersRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeProvisioningParametersRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ServiceCatalog");
            string target = "AWS242ServiceCatalogService.DescribeProvisioningParameters";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-12-10";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAcceptLanguage())
                {
                    context.Writer.WritePropertyName("AcceptLanguage");
                    context.Writer.Write(publicRequest.AcceptLanguage);
                }

                if(publicRequest.IsSetPathId())
                {
                    context.Writer.WritePropertyName("PathId");
                    context.Writer.Write(publicRequest.PathId);
                }

                if(publicRequest.IsSetPathName())
                {
                    context.Writer.WritePropertyName("PathName");
                    context.Writer.Write(publicRequest.PathName);
                }

                if(publicRequest.IsSetProductId())
                {
                    context.Writer.WritePropertyName("ProductId");
                    context.Writer.Write(publicRequest.ProductId);
                }

                if(publicRequest.IsSetProductName())
                {
                    context.Writer.WritePropertyName("ProductName");
                    context.Writer.Write(publicRequest.ProductName);
                }

                if(publicRequest.IsSetProvisioningArtifactId())
                {
                    context.Writer.WritePropertyName("ProvisioningArtifactId");
                    context.Writer.Write(publicRequest.ProvisioningArtifactId);
                }

                if(publicRequest.IsSetProvisioningArtifactName())
                {
                    context.Writer.WritePropertyName("ProvisioningArtifactName");
                    context.Writer.Write(publicRequest.ProvisioningArtifactName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static DescribeProvisioningParametersRequestMarshaller _instance = new DescribeProvisioningParametersRequestMarshaller();        

        internal static DescribeProvisioningParametersRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeProvisioningParametersRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}