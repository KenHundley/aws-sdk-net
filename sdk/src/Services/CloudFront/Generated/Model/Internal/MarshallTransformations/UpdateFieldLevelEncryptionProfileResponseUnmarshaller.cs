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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for UpdateFieldLevelEncryptionProfile operation
    /// </summary>  
    public class UpdateFieldLevelEncryptionProfileResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            UpdateFieldLevelEncryptionProfileResponse response = new UpdateFieldLevelEncryptionProfileResponse();
            UnmarshallResult(context,response);
            if (context.ResponseData.IsHeaderPresent("ETag"))
                response.ETag = context.ResponseData.GetHeaderValue("ETag");
            
            return response;
        }        

        private static void UnmarshallResult(XmlUnmarshallerContext context, UpdateFieldLevelEncryptionProfileResponse response)
        {
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("FieldLevelEncryptionProfile", targetDepth))
                    {
                        var unmarshaller = FieldLevelEncryptionProfileUnmarshaller.Instance;
                        response.FieldLevelEncryptionProfile = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }
          
            return;
        }
  

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDenied"))
                {
                    return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("FieldLevelEncryptionProfileAlreadyExists"))
                {
                    return FieldLevelEncryptionProfileAlreadyExistsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("FieldLevelEncryptionProfileSizeExceeded"))
                {
                    return FieldLevelEncryptionProfileSizeExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("IllegalUpdate"))
                {
                    return IllegalUpdateExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InconsistentQuantities"))
                {
                    return InconsistentQuantitiesExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidArgument"))
                {
                    return InvalidArgumentExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidIfMatchVersion"))
                {
                    return InvalidIfMatchVersionExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("NoSuchFieldLevelEncryptionProfile"))
                {
                    return NoSuchFieldLevelEncryptionProfileExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("NoSuchPublicKey"))
                {
                    return NoSuchPublicKeyExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("PreconditionFailed"))
                {
                    return PreconditionFailedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyFieldLevelEncryptionEncryptionEntities"))
                {
                    return TooManyFieldLevelEncryptionEncryptionEntitiesExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyFieldLevelEncryptionFieldPatterns"))
                {
                    return TooManyFieldLevelEncryptionFieldPatternsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonCloudFrontException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static UpdateFieldLevelEncryptionProfileResponseUnmarshaller _instance = new UpdateFieldLevelEncryptionProfileResponseUnmarshaller();        

        internal static UpdateFieldLevelEncryptionProfileResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFieldLevelEncryptionProfileResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}