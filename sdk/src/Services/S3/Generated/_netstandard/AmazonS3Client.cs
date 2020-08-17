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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.S3.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3
{
    /// <summary>
    /// Implementation for accessing S3
    ///
    /// 
    /// </summary>
    public partial class AmazonS3Client : AmazonServiceClient, IAmazonS3
    {
        private static IServiceMetadata serviceMetadata = new AmazonS3Metadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonS3Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonS3Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonS3Config()) { }

        /// <summary>
        /// Constructs AmazonS3Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonS3Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonS3Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonS3Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(AmazonS3Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonS3Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonS3Client(AWSCredentials credentials)
            : this(credentials, new AmazonS3Config())
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonS3Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Credentials and an
        /// AmazonS3Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(AWSCredentials credentials, AmazonS3Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonS3Config())
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonS3Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonS3Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonS3Config())
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonS3Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonS3Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new Amazon.S3.Internal.S3Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.S3.Internal.AmazonS3PreMarshallHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.S3.Internal.AmazonS3PostMarshallHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.EndpointResolver>(new Amazon.S3.Internal.AmazonS3KmsHandler());
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Unmarshaller>(new Amazon.S3.Internal.AmazonS3ResponseHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.ErrorCallbackHandler>(new Amazon.S3.Internal.AmazonS3ExceptionHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Unmarshaller>(new Amazon.S3.Internal.AmazonS3RedirectHandler());
            if(this.Config.RetryMode == RequestRetryMode.Legacy)
            {
                pipeline.ReplaceHandler<Amazon.Runtime.Internal.RetryHandler>(new Amazon.Runtime.Internal.RetryHandler(new Amazon.S3.Internal.AmazonS3RetryPolicy(this.Config)));
            }
            if(this.Config.RetryMode == RequestRetryMode.Standard)
            {
                pipeline.ReplaceHandler<Amazon.Runtime.Internal.RetryHandler>(new Amazon.Runtime.Internal.RetryHandler(new Amazon.S3.Internal.AmazonS3StandardRetryPolicy(this.Config)));
            }
            if(this.Config.RetryMode == RequestRetryMode.Adaptive)
            {
                pipeline.ReplaceHandler<Amazon.Runtime.Internal.RetryHandler>(new Amazon.Runtime.Internal.RetryHandler(new Amazon.S3.Internal.AmazonS3AdaptiveRetryPolicy(this.Config)));
            }
        }
        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AbortMultipartUpload

        internal virtual AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AbortMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AbortMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<AbortMultipartUploadResponse>(request, options);
        }


        /// <summary>
        /// This operation aborts a multipart upload. After a multipart upload is aborted, no
        /// additional parts can be uploaded using that upload ID. The storage consumed by any
        /// previously uploaded parts will be freed. However, if any part uploads are currently
        /// in progress, those part uploads might or might not succeed. As a result, it might
        /// be necessary to abort a given multipart upload multiple times in order to completely
        /// free all storage consumed by all parts. 
        /// 
        ///  
        /// <para>
        /// To verify that all parts have been removed, so you don't get charged for the part
        /// storage, you should call the <a>ListParts</a> operation and ensure that the parts
        /// list is empty.
        /// </para>
        ///  
        /// <para>
        /// For information about permissions required to use the multipart upload API, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
        /// Upload API and Permissions</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>AbortMultipartUpload</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UploadPart</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CompleteMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListParts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListMultipartUploads</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name to which the upload was taking place.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="key">Key of the object for which the multipart upload was initiated.</param>
        /// <param name="uploadId">Upload ID that identifies the multipart upload.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AbortMultipartUpload service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/AbortMultipartUpload">REST API Reference for AbortMultipartUpload Operation</seealso>
        public virtual Task<AbortMultipartUploadResponse> AbortMultipartUploadAsync(string bucketName, string key, string uploadId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new AbortMultipartUploadRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.UploadId = uploadId;
            return AbortMultipartUploadAsync(request, cancellationToken);
        }



        /// <summary>
        /// This operation aborts a multipart upload. After a multipart upload is aborted, no
        /// additional parts can be uploaded using that upload ID. The storage consumed by any
        /// previously uploaded parts will be freed. However, if any part uploads are currently
        /// in progress, those part uploads might or might not succeed. As a result, it might
        /// be necessary to abort a given multipart upload multiple times in order to completely
        /// free all storage consumed by all parts. 
        /// 
        ///  
        /// <para>
        /// To verify that all parts have been removed, so you don't get charged for the part
        /// storage, you should call the <a>ListParts</a> operation and ensure that the parts
        /// list is empty.
        /// </para>
        ///  
        /// <para>
        /// For information about permissions required to use the multipart upload API, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
        /// Upload API and Permissions</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>AbortMultipartUpload</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UploadPart</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CompleteMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListParts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListMultipartUploads</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AbortMultipartUpload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AbortMultipartUpload service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/AbortMultipartUpload">REST API Reference for AbortMultipartUpload Operation</seealso>
        public virtual Task<AbortMultipartUploadResponse> AbortMultipartUploadAsync(AbortMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AbortMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AbortMultipartUploadResponseUnmarshaller.Instance;

            return InvokeAsync<AbortMultipartUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CompleteMultipartUpload

        internal virtual CompleteMultipartUploadResponse CompleteMultipartUpload(CompleteMultipartUploadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<CompleteMultipartUploadResponse>(request, options);
        }



        /// <summary>
        /// Completes a multipart upload by assembling previously uploaded parts.
        /// 
        ///  
        /// <para>
        /// You first initiate the multipart upload and then upload all parts using the <a>UploadPart</a>
        /// operation. After successfully uploading all relevant parts of an upload, you call
        /// this operation to complete the upload. Upon receiving this request, Amazon S3 concatenates
        /// all the parts in ascending order by part number to create a new object. In the Complete
        /// Multipart Upload request, you must provide the parts list. You must ensure that the
        /// parts list is complete. This operation concatenates the parts that you provide in
        /// the list. For each part in the list, you must provide the part number and the <code>ETag</code>
        /// value, returned after that part was uploaded.
        /// </para>
        ///  
        /// <para>
        /// Processing of a Complete Multipart Upload request could take several minutes to complete.
        /// After Amazon S3 begins processing the request, it sends an HTTP response header that
        /// specifies a 200 OK response. While processing is in progress, Amazon S3 periodically
        /// sends white space characters to keep the connection from timing out. Because a request
        /// could fail after the initial 200 OK response has been sent, it is important that you
        /// check the response body to determine whether the request succeeded.
        /// </para>
        ///  
        /// <para>
        /// Note that if <code>CompleteMultipartUpload</code> fails, applications should be prepared
        /// to retry the failed requests. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ErrorBestPractices.html">Amazon
        /// S3 Error Best Practices</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/uploadobjusingmpu.html">Uploading
        /// Objects Using Multipart Upload</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about permissions required to use the multipart upload API, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
        /// Upload API and Permissions</a>.
        /// </para>
        ///  
        /// <para>
        ///  <code>CompleteMultipartUpload</code> has the following special errors:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Error code: <code>EntityTooSmall</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: Your proposed upload is smaller than the minimum allowed object size.
        /// Each part must be at least 5 MB in size, except the last part.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 400 Bad Request
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Error code: <code>InvalidPart</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: One or more of the specified parts could not be found. The part might
        /// not have been uploaded, or the specified entity tag might not have matched the part's
        /// entity tag.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 400 Bad Request
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Error code: <code>InvalidPartOrder</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The list of parts was not in ascending order. The parts list must be
        /// specified in order by part number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 400 Bad Request
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Error code: <code>NoSuchUpload</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The specified multipart upload does not exist. The upload ID might be
        /// invalid, or the multipart upload might have been aborted or completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 404 Not Found
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// The following operations are related to <code>CompleteMultipartUpload</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UploadPart</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AbortMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListParts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListMultipartUploads</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteMultipartUpload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CompleteMultipartUpload service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/CompleteMultipartUpload">REST API Reference for CompleteMultipartUpload Operation</seealso>
        public virtual Task<CompleteMultipartUploadResponse> CompleteMultipartUploadAsync(CompleteMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteMultipartUploadResponseUnmarshaller.Instance;

            return InvokeAsync<CompleteMultipartUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyObject

        internal virtual CopyObjectResponse CopyObject(CopyObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyObjectResponseUnmarshaller.Instance;

            return Invoke<CopyObjectResponse>(request, options);
        }


        /// <summary>
        /// Creates a copy of an object that is already stored in Amazon S3.
        /// 
        ///  <note> 
        /// <para>
        /// You can store individual objects of up to 5 TB in Amazon S3. You create a copy of
        /// your object up to 5 GB in size in a single atomic operation using this API. However,
        /// to copy an object greater than 5 GB, you must use the multipart upload Upload Part
        /// - Copy API. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/CopyingObjctsUsingRESTMPUapi.html">Copy
        /// Object Using the REST Multipart Upload API</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// All copy requests must be authenticated. Additionally, you must have <i>read</i> access
        /// to the source object and <i>write</i> access to the destination bucket. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RESTAuthentication.html">REST
        /// Authentication</a>. Both the Region that you want to copy the object from and the
        /// Region that you want to copy the object to must be enabled for your account.
        /// </para>
        ///  
        /// <para>
        /// A copy request might return an error when Amazon S3 receives the copy request or while
        /// Amazon S3 is copying the files. If the error occurs before the copy operation starts,
        /// you receive a standard Amazon S3 error. If the error occurs during the copy operation,
        /// the error response is embedded in the <code>200 OK</code> response. This means that
        /// a <code>200 OK</code> response can contain either a success or an error. Design your
        /// application to parse the contents of the response and handle it appropriately.
        /// </para>
        ///  
        /// <para>
        /// If the copy is successful, you receive a response with information about the copied
        /// object.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the request is an HTTP 1.1 request, the response is chunk encoded. If it were not,
        /// it would not contain the content-length, and you would need to read the entire body.
        /// </para>
        ///  </note> 
        /// <para>
        /// The copy request charge is based on the storage class and Region that you specify
        /// for the destination object. For pricing information, see <a href="https://aws.amazon.com/s3/pricing/">Amazon
        /// S3 pricing</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Amazon S3 transfer acceleration does not support cross-Region copies. If you request
        /// a cross-Region copy using a transfer acceleration endpoint, you get a 400 <code>Bad
        /// Request</code> error. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/transfer-acceleration.html">Transfer
        /// Acceleration</a>.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Metadata</b> 
        /// </para>
        ///  
        /// <para>
        /// When copying an object, you can preserve all metadata (default) or specify new metadata.
        /// However, the ACL is not preserved and is set to private for the user making the request.
        /// To override the default ACL setting, specify a new ACL when generating a copy request.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Using
        /// ACLs</a>. 
        /// </para>
        ///  
        /// <para>
        /// To specify whether you want the object metadata copied from the source object or replaced
        /// with metadata provided in the request, you can optionally add the <code>x-amz-metadata-directive</code>
        /// header. When you grant permissions, you can use the <code>s3:x-amz-metadata-directive</code>
        /// condition key to enforce certain metadata behavior when objects are uploaded. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/amazon-s3-policy-keys.html">Specifying
        /// Conditions in a Policy</a> in the <i>Amazon S3 Developer Guide</i>. For a complete
        /// list of Amazon S3-specific condition keys, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/list_amazons3.html">Actions,
        /// Resources, and Condition Keys for Amazon S3</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b> <code>x-amz-copy-source-if</code> Headers</b> 
        /// </para>
        ///  
        /// <para>
        /// To only copy an object under certain conditions, such as whether the <code>Etag</code>
        /// matches or whether the object was modified before or after a specified date, use the
        /// following request parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-match</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-none-match</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-unmodified-since</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-modified-since</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If both the <code>x-amz-copy-source-if-match</code> and <code>x-amz-copy-source-if-unmodified-since</code>
        /// headers are present in the request and evaluate as follows, Amazon S3 returns <code>200
        /// OK</code> and copies the data:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-match</code> condition evaluates to true
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-unmodified-since</code> condition evaluates to false
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If both the <code>x-amz-copy-source-if-none-match</code> and <code>x-amz-copy-source-if-modified-since</code>
        /// headers are present in the request and evaluate as follows, Amazon S3 returns the
        /// <code>412 Precondition Failed</code> response code:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-none-match</code> condition evaluates to false
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-modified-since</code> condition evaluates to true
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// All headers with the <code>x-amz-</code> prefix, including <code>x-amz-copy-source</code>,
        /// must be signed.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Encryption</b> 
        /// </para>
        ///  
        /// <para>
        /// The source object that you are copying can be encrypted or unencrypted. The source
        /// object can be encrypted with server-side encryption using AWS managed encryption keys
        /// (SSE-S3 or SSE-KMS) or by using a customer-provided encryption key. With server-side
        /// encryption, Amazon S3 encrypts your data as it writes it to disks in its data centers
        /// and decrypts the data when you access it. 
        /// </para>
        ///  
        /// <para>
        /// You can optionally use the appropriate encryption-related headers to request server-side
        /// encryption for the target object. You have the option to provide your own encryption
        /// key or use SSE-S3 or SSE-KMS, regardless of the form of server-side encryption that
        /// was used to encrypt the source object. You can even request encryption if the source
        /// object was not encrypted. For more information about server-side encryption, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">Using
        /// Server-Side Encryption</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access Control List (ACL)-Specific Request Headers</b> 
        /// </para>
        ///  
        /// <para>
        /// When copying an object, you can optionally use headers to grant ACL-based permissions.
        /// By default, all objects are private. Only the owner has full access control. When
        /// adding a new object, you can grant permissions to individual AWS accounts or to predefined
        /// groups defined by Amazon S3. These permissions are then added to the ACL on the object.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
        /// Control List (ACL) Overview</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-using-rest-api.html">Managing
        /// ACLs Using the REST API</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Storage Class Options</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>CopyObject</code> operation to change the storage class of an
        /// object that is already stored in Amazon S3 using the <code>StorageClass</code> parameter.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage-class-intro.html">Storage
        /// Classes</a> in the <i>Amazon S3 Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Versioning</b> 
        /// </para>
        ///  
        /// <para>
        /// By default, <code>x-amz-copy-source</code> identifies the current version of an object
        /// to copy. If the current version is a delete marker, Amazon S3 behaves as if the object
        /// was deleted. To copy a different version, use the <code>versionId</code> subresource.
        /// </para>
        ///  
        /// <para>
        /// If you enable versioning on the target bucket, Amazon S3 generates a unique version
        /// ID for the object being copied. This version ID is different from the version ID of
        /// the source object. Amazon S3 returns the version ID of the copied object in the <code>x-amz-version-id</code>
        /// response header in the response.
        /// </para>
        ///  
        /// <para>
        /// If you do not enable versioning or suspend it on the target bucket, the version ID
        /// that Amazon S3 generates is always null.
        /// </para>
        ///  
        /// <para>
        /// If the source object's storage class is GLACIER, you must restore a copy of this object
        /// before you can use it as a source object for the copy operation. For more information,
        /// see .
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>CopyObject</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/CopyingObjectsExamples.html">Copying
        /// Objects</a>.
        /// </para>
        /// </summary>
        /// <param name="sourceBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="sourceKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/CopyObject">REST API Reference for CopyObject Operation</seealso>
        public virtual Task<CopyObjectResponse> CopyObjectAsync(string sourceBucket, string sourceKey, string destinationBucket, string destinationKey, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CopyObjectRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            return CopyObjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Creates a copy of an object that is already stored in Amazon S3.
        /// 
        ///  <note> 
        /// <para>
        /// You can store individual objects of up to 5 TB in Amazon S3. You create a copy of
        /// your object up to 5 GB in size in a single atomic operation using this API. However,
        /// to copy an object greater than 5 GB, you must use the multipart upload Upload Part
        /// - Copy API. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/CopyingObjctsUsingRESTMPUapi.html">Copy
        /// Object Using the REST Multipart Upload API</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// All copy requests must be authenticated. Additionally, you must have <i>read</i> access
        /// to the source object and <i>write</i> access to the destination bucket. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RESTAuthentication.html">REST
        /// Authentication</a>. Both the Region that you want to copy the object from and the
        /// Region that you want to copy the object to must be enabled for your account.
        /// </para>
        ///  
        /// <para>
        /// A copy request might return an error when Amazon S3 receives the copy request or while
        /// Amazon S3 is copying the files. If the error occurs before the copy operation starts,
        /// you receive a standard Amazon S3 error. If the error occurs during the copy operation,
        /// the error response is embedded in the <code>200 OK</code> response. This means that
        /// a <code>200 OK</code> response can contain either a success or an error. Design your
        /// application to parse the contents of the response and handle it appropriately.
        /// </para>
        ///  
        /// <para>
        /// If the copy is successful, you receive a response with information about the copied
        /// object.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the request is an HTTP 1.1 request, the response is chunk encoded. If it were not,
        /// it would not contain the content-length, and you would need to read the entire body.
        /// </para>
        ///  </note> 
        /// <para>
        /// The copy request charge is based on the storage class and Region that you specify
        /// for the destination object. For pricing information, see <a href="https://aws.amazon.com/s3/pricing/">Amazon
        /// S3 pricing</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Amazon S3 transfer acceleration does not support cross-Region copies. If you request
        /// a cross-Region copy using a transfer acceleration endpoint, you get a 400 <code>Bad
        /// Request</code> error. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/transfer-acceleration.html">Transfer
        /// Acceleration</a>.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Metadata</b> 
        /// </para>
        ///  
        /// <para>
        /// When copying an object, you can preserve all metadata (default) or specify new metadata.
        /// However, the ACL is not preserved and is set to private for the user making the request.
        /// To override the default ACL setting, specify a new ACL when generating a copy request.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Using
        /// ACLs</a>. 
        /// </para>
        ///  
        /// <para>
        /// To specify whether you want the object metadata copied from the source object or replaced
        /// with metadata provided in the request, you can optionally add the <code>x-amz-metadata-directive</code>
        /// header. When you grant permissions, you can use the <code>s3:x-amz-metadata-directive</code>
        /// condition key to enforce certain metadata behavior when objects are uploaded. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/amazon-s3-policy-keys.html">Specifying
        /// Conditions in a Policy</a> in the <i>Amazon S3 Developer Guide</i>. For a complete
        /// list of Amazon S3-specific condition keys, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/list_amazons3.html">Actions,
        /// Resources, and Condition Keys for Amazon S3</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b> <code>x-amz-copy-source-if</code> Headers</b> 
        /// </para>
        ///  
        /// <para>
        /// To only copy an object under certain conditions, such as whether the <code>Etag</code>
        /// matches or whether the object was modified before or after a specified date, use the
        /// following request parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-match</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-none-match</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-unmodified-since</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-modified-since</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If both the <code>x-amz-copy-source-if-match</code> and <code>x-amz-copy-source-if-unmodified-since</code>
        /// headers are present in the request and evaluate as follows, Amazon S3 returns <code>200
        /// OK</code> and copies the data:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-match</code> condition evaluates to true
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-unmodified-since</code> condition evaluates to false
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If both the <code>x-amz-copy-source-if-none-match</code> and <code>x-amz-copy-source-if-modified-since</code>
        /// headers are present in the request and evaluate as follows, Amazon S3 returns the
        /// <code>412 Precondition Failed</code> response code:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-none-match</code> condition evaluates to false
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-modified-since</code> condition evaluates to true
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// All headers with the <code>x-amz-</code> prefix, including <code>x-amz-copy-source</code>,
        /// must be signed.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Encryption</b> 
        /// </para>
        ///  
        /// <para>
        /// The source object that you are copying can be encrypted or unencrypted. The source
        /// object can be encrypted with server-side encryption using AWS managed encryption keys
        /// (SSE-S3 or SSE-KMS) or by using a customer-provided encryption key. With server-side
        /// encryption, Amazon S3 encrypts your data as it writes it to disks in its data centers
        /// and decrypts the data when you access it. 
        /// </para>
        ///  
        /// <para>
        /// You can optionally use the appropriate encryption-related headers to request server-side
        /// encryption for the target object. You have the option to provide your own encryption
        /// key or use SSE-S3 or SSE-KMS, regardless of the form of server-side encryption that
        /// was used to encrypt the source object. You can even request encryption if the source
        /// object was not encrypted. For more information about server-side encryption, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">Using
        /// Server-Side Encryption</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access Control List (ACL)-Specific Request Headers</b> 
        /// </para>
        ///  
        /// <para>
        /// When copying an object, you can optionally use headers to grant ACL-based permissions.
        /// By default, all objects are private. Only the owner has full access control. When
        /// adding a new object, you can grant permissions to individual AWS accounts or to predefined
        /// groups defined by Amazon S3. These permissions are then added to the ACL on the object.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
        /// Control List (ACL) Overview</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-using-rest-api.html">Managing
        /// ACLs Using the REST API</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Storage Class Options</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>CopyObject</code> operation to change the storage class of an
        /// object that is already stored in Amazon S3 using the <code>StorageClass</code> parameter.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage-class-intro.html">Storage
        /// Classes</a> in the <i>Amazon S3 Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Versioning</b> 
        /// </para>
        ///  
        /// <para>
        /// By default, <code>x-amz-copy-source</code> identifies the current version of an object
        /// to copy. If the current version is a delete marker, Amazon S3 behaves as if the object
        /// was deleted. To copy a different version, use the <code>versionId</code> subresource.
        /// </para>
        ///  
        /// <para>
        /// If you enable versioning on the target bucket, Amazon S3 generates a unique version
        /// ID for the object being copied. This version ID is different from the version ID of
        /// the source object. Amazon S3 returns the version ID of the copied object in the <code>x-amz-version-id</code>
        /// response header in the response.
        /// </para>
        ///  
        /// <para>
        /// If you do not enable versioning or suspend it on the target bucket, the version ID
        /// that Amazon S3 generates is always null.
        /// </para>
        ///  
        /// <para>
        /// If the source object's storage class is GLACIER, you must restore a copy of this object
        /// before you can use it as a source object for the copy operation. For more information,
        /// see .
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>CopyObject</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/CopyingObjectsExamples.html">Copying
        /// Objects</a>.
        /// </para>
        /// </summary>
        /// <param name="sourceBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="sourceKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="sourceVersionId">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/CopyObject">REST API Reference for CopyObject Operation</seealso>
        public virtual Task<CopyObjectResponse> CopyObjectAsync(string sourceBucket, string sourceKey, string sourceVersionId, string destinationBucket, string destinationKey, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CopyObjectRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.SourceVersionId = sourceVersionId;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            return CopyObjectAsync(request, cancellationToken);
        }



        /// <summary>
        /// Creates a copy of an object that is already stored in Amazon S3.
        /// 
        ///  <note> 
        /// <para>
        /// You can store individual objects of up to 5 TB in Amazon S3. You create a copy of
        /// your object up to 5 GB in size in a single atomic operation using this API. However,
        /// to copy an object greater than 5 GB, you must use the multipart upload Upload Part
        /// - Copy API. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/CopyingObjctsUsingRESTMPUapi.html">Copy
        /// Object Using the REST Multipart Upload API</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// All copy requests must be authenticated. Additionally, you must have <i>read</i> access
        /// to the source object and <i>write</i> access to the destination bucket. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RESTAuthentication.html">REST
        /// Authentication</a>. Both the Region that you want to copy the object from and the
        /// Region that you want to copy the object to must be enabled for your account.
        /// </para>
        ///  
        /// <para>
        /// A copy request might return an error when Amazon S3 receives the copy request or while
        /// Amazon S3 is copying the files. If the error occurs before the copy operation starts,
        /// you receive a standard Amazon S3 error. If the error occurs during the copy operation,
        /// the error response is embedded in the <code>200 OK</code> response. This means that
        /// a <code>200 OK</code> response can contain either a success or an error. Design your
        /// application to parse the contents of the response and handle it appropriately.
        /// </para>
        ///  
        /// <para>
        /// If the copy is successful, you receive a response with information about the copied
        /// object.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the request is an HTTP 1.1 request, the response is chunk encoded. If it were not,
        /// it would not contain the content-length, and you would need to read the entire body.
        /// </para>
        ///  </note> 
        /// <para>
        /// The copy request charge is based on the storage class and Region that you specify
        /// for the destination object. For pricing information, see <a href="https://aws.amazon.com/s3/pricing/">Amazon
        /// S3 pricing</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Amazon S3 transfer acceleration does not support cross-Region copies. If you request
        /// a cross-Region copy using a transfer acceleration endpoint, you get a 400 <code>Bad
        /// Request</code> error. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/transfer-acceleration.html">Transfer
        /// Acceleration</a>.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Metadata</b> 
        /// </para>
        ///  
        /// <para>
        /// When copying an object, you can preserve all metadata (default) or specify new metadata.
        /// However, the ACL is not preserved and is set to private for the user making the request.
        /// To override the default ACL setting, specify a new ACL when generating a copy request.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Using
        /// ACLs</a>. 
        /// </para>
        ///  
        /// <para>
        /// To specify whether you want the object metadata copied from the source object or replaced
        /// with metadata provided in the request, you can optionally add the <code>x-amz-metadata-directive</code>
        /// header. When you grant permissions, you can use the <code>s3:x-amz-metadata-directive</code>
        /// condition key to enforce certain metadata behavior when objects are uploaded. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/amazon-s3-policy-keys.html">Specifying
        /// Conditions in a Policy</a> in the <i>Amazon S3 Developer Guide</i>. For a complete
        /// list of Amazon S3-specific condition keys, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/list_amazons3.html">Actions,
        /// Resources, and Condition Keys for Amazon S3</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b> <code>x-amz-copy-source-if</code> Headers</b> 
        /// </para>
        ///  
        /// <para>
        /// To only copy an object under certain conditions, such as whether the <code>Etag</code>
        /// matches or whether the object was modified before or after a specified date, use the
        /// following request parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-match</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-none-match</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-unmodified-since</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-modified-since</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If both the <code>x-amz-copy-source-if-match</code> and <code>x-amz-copy-source-if-unmodified-since</code>
        /// headers are present in the request and evaluate as follows, Amazon S3 returns <code>200
        /// OK</code> and copies the data:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-match</code> condition evaluates to true
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-unmodified-since</code> condition evaluates to false
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If both the <code>x-amz-copy-source-if-none-match</code> and <code>x-amz-copy-source-if-modified-since</code>
        /// headers are present in the request and evaluate as follows, Amazon S3 returns the
        /// <code>412 Precondition Failed</code> response code:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-none-match</code> condition evaluates to false
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-modified-since</code> condition evaluates to true
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// All headers with the <code>x-amz-</code> prefix, including <code>x-amz-copy-source</code>,
        /// must be signed.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Encryption</b> 
        /// </para>
        ///  
        /// <para>
        /// The source object that you are copying can be encrypted or unencrypted. The source
        /// object can be encrypted with server-side encryption using AWS managed encryption keys
        /// (SSE-S3 or SSE-KMS) or by using a customer-provided encryption key. With server-side
        /// encryption, Amazon S3 encrypts your data as it writes it to disks in its data centers
        /// and decrypts the data when you access it. 
        /// </para>
        ///  
        /// <para>
        /// You can optionally use the appropriate encryption-related headers to request server-side
        /// encryption for the target object. You have the option to provide your own encryption
        /// key or use SSE-S3 or SSE-KMS, regardless of the form of server-side encryption that
        /// was used to encrypt the source object. You can even request encryption if the source
        /// object was not encrypted. For more information about server-side encryption, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">Using
        /// Server-Side Encryption</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access Control List (ACL)-Specific Request Headers</b> 
        /// </para>
        ///  
        /// <para>
        /// When copying an object, you can optionally use headers to grant ACL-based permissions.
        /// By default, all objects are private. Only the owner has full access control. When
        /// adding a new object, you can grant permissions to individual AWS accounts or to predefined
        /// groups defined by Amazon S3. These permissions are then added to the ACL on the object.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
        /// Control List (ACL) Overview</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-using-rest-api.html">Managing
        /// ACLs Using the REST API</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Storage Class Options</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>CopyObject</code> operation to change the storage class of an
        /// object that is already stored in Amazon S3 using the <code>StorageClass</code> parameter.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage-class-intro.html">Storage
        /// Classes</a> in the <i>Amazon S3 Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Versioning</b> 
        /// </para>
        ///  
        /// <para>
        /// By default, <code>x-amz-copy-source</code> identifies the current version of an object
        /// to copy. If the current version is a delete marker, Amazon S3 behaves as if the object
        /// was deleted. To copy a different version, use the <code>versionId</code> subresource.
        /// </para>
        ///  
        /// <para>
        /// If you enable versioning on the target bucket, Amazon S3 generates a unique version
        /// ID for the object being copied. This version ID is different from the version ID of
        /// the source object. Amazon S3 returns the version ID of the copied object in the <code>x-amz-version-id</code>
        /// response header in the response.
        /// </para>
        ///  
        /// <para>
        /// If you do not enable versioning or suspend it on the target bucket, the version ID
        /// that Amazon S3 generates is always null.
        /// </para>
        ///  
        /// <para>
        /// If the source object's storage class is GLACIER, you must restore a copy of this object
        /// before you can use it as a source object for the copy operation. For more information,
        /// see .
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>CopyObject</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/CopyingObjectsExamples.html">Copying
        /// Objects</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/CopyObject">REST API Reference for CopyObject Operation</seealso>
        public virtual Task<CopyObjectResponse> CopyObjectAsync(CopyObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyObjectResponseUnmarshaller.Instance;

            return InvokeAsync<CopyObjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyPart

        internal virtual CopyPartResponse CopyPart(CopyPartRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyPartResponseUnmarshaller.Instance;

            return Invoke<CopyPartResponse>(request, options);
        }


        /// <summary>
        /// Uploads a part by copying data from an existing object as data source. You specify
        /// the data source by adding the request header <code>x-amz-copy-source</code> in your
        /// request and a byte range by adding the request header <code>x-amz-copy-source-range</code>
        /// in your request. 
        /// 
        ///  
        /// <para>
        /// The minimum allowable part size for a multipart upload is 5 MB. For more information
        /// about multipart upload limits, go to <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/qfacts.html">Quick
        /// Facts</a> in the <i>Amazon Simple Storage Service Developer Guide</i>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Instead of using an existing object as part data, you might use the <a>UploadPart</a>
        /// operation and provide data in your request.
        /// </para>
        ///  </note> 
        /// <para>
        /// You must initiate a multipart upload before you can upload any part. In response to
        /// your initiate request. Amazon S3 returns a unique identifier, the upload ID, that
        /// you must include in your upload part request.
        /// </para>
        ///  
        /// <para>
        /// For more information about using the <code>UploadPartCopy</code> operation, see the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For conceptual information about multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/uploadobjusingmpu.html">Uploading
        /// Objects Using Multipart Upload</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about permissions required to use the multipart upload API, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
        /// Upload API and Permissions</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about copying objects using a single atomic operation vs. the multipart
        /// upload, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ObjectOperations.html">Operations
        /// on Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about using server-side encryption with customer-provided encryption
        /// keys with the UploadPartCopy operation, see <a>CopyObject</a> and <a>UploadPart</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note the following additional considerations about the request headers <code>x-amz-copy-source-if-match</code>,
        /// <code>x-amz-copy-source-if-none-match</code>, <code>x-amz-copy-source-if-unmodified-since</code>,
        /// and <code>x-amz-copy-source-if-modified-since</code>:
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Consideration 1</b> - If both of the <code>x-amz-copy-source-if-match</code> and
        /// <code>x-amz-copy-source-if-unmodified-since</code> headers are present in the request
        /// as follows:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source-if-match</code> condition evaluates to <code>true</code>,
        /// and;
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source-if-unmodified-since</code> condition evaluates to <code>false</code>;
        /// </para>
        ///  
        /// <para>
        /// Amazon S3 returns <code>200 OK</code> and copies the data. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Consideration 2</b> - If both of the <code>x-amz-copy-source-if-none-match</code>
        /// and <code>x-amz-copy-source-if-modified-since</code> headers are present in the request
        /// as follows:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source-if-none-match</code> condition evaluates to <code>false</code>,
        /// and;
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source-if-modified-since</code> condition evaluates to <code>true</code>;
        /// </para>
        ///  
        /// <para>
        /// Amazon S3 returns <code>412 Precondition Failed</code> response code. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Versioning</b> 
        /// </para>
        ///  
        /// <para>
        /// If your bucket has versioning enabled, you could have multiple versions of the same
        /// object. By default, <code>x-amz-copy-source</code> identifies the current version
        /// of the object to copy. If the current version is a delete marker and you don't specify
        /// a versionId in the <code>x-amz-copy-source</code>, Amazon S3 returns a 404 error,
        /// because the object does not exist. If you specify versionId in the <code>x-amz-copy-source</code>
        /// and the versionId is a delete marker, Amazon S3 returns an HTTP 400 error, because
        /// you are not allowed to specify a delete marker as a version for the <code>x-amz-copy-source</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify a specific version of the source object to copy by adding
        /// the <code>versionId</code> subresource as shown in the following example:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source: /bucket/object?versionId=version id</code> 
        /// </para>
        ///  <p class="title"> <b>Special Errors</b> 
        /// </para>
        ///  <ul> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: NoSuchUpload</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: The specified multipart upload does not exist. The upload ID might be invalid,
        /// or the multipart upload might have been aborted or completed.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 404 Not Found</i> 
        /// </para>
        ///  </li> </ul> </li> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: InvalidRequest</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: The specified copy source is not supported as a byte-range copy source.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 400 Bad Request</i> 
        /// </para>
        ///  </li> </ul> </li> </ul> <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UploadPart</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CompleteMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AbortMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListParts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListMultipartUploads</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="sourceBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="sourceKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="uploadId">Upload ID identifying the multipart upload whose part is being copied.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyPart service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/UploadPartCopy">REST API Reference for CopyPart Operation</seealso>
        public virtual Task<CopyPartResponse> CopyPartAsync(string sourceBucket, string sourceKey, string destinationBucket, string destinationKey, string uploadId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CopyPartRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            request.UploadId = uploadId;
            return CopyPartAsync(request, cancellationToken);
        }


        /// <summary>
        /// Uploads a part by copying data from an existing object as data source. You specify
        /// the data source by adding the request header <code>x-amz-copy-source</code> in your
        /// request and a byte range by adding the request header <code>x-amz-copy-source-range</code>
        /// in your request. 
        /// 
        ///  
        /// <para>
        /// The minimum allowable part size for a multipart upload is 5 MB. For more information
        /// about multipart upload limits, go to <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/qfacts.html">Quick
        /// Facts</a> in the <i>Amazon Simple Storage Service Developer Guide</i>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Instead of using an existing object as part data, you might use the <a>UploadPart</a>
        /// operation and provide data in your request.
        /// </para>
        ///  </note> 
        /// <para>
        /// You must initiate a multipart upload before you can upload any part. In response to
        /// your initiate request. Amazon S3 returns a unique identifier, the upload ID, that
        /// you must include in your upload part request.
        /// </para>
        ///  
        /// <para>
        /// For more information about using the <code>UploadPartCopy</code> operation, see the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For conceptual information about multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/uploadobjusingmpu.html">Uploading
        /// Objects Using Multipart Upload</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about permissions required to use the multipart upload API, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
        /// Upload API and Permissions</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about copying objects using a single atomic operation vs. the multipart
        /// upload, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ObjectOperations.html">Operations
        /// on Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about using server-side encryption with customer-provided encryption
        /// keys with the UploadPartCopy operation, see <a>CopyObject</a> and <a>UploadPart</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note the following additional considerations about the request headers <code>x-amz-copy-source-if-match</code>,
        /// <code>x-amz-copy-source-if-none-match</code>, <code>x-amz-copy-source-if-unmodified-since</code>,
        /// and <code>x-amz-copy-source-if-modified-since</code>:
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Consideration 1</b> - If both of the <code>x-amz-copy-source-if-match</code> and
        /// <code>x-amz-copy-source-if-unmodified-since</code> headers are present in the request
        /// as follows:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source-if-match</code> condition evaluates to <code>true</code>,
        /// and;
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source-if-unmodified-since</code> condition evaluates to <code>false</code>;
        /// </para>
        ///  
        /// <para>
        /// Amazon S3 returns <code>200 OK</code> and copies the data. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Consideration 2</b> - If both of the <code>x-amz-copy-source-if-none-match</code>
        /// and <code>x-amz-copy-source-if-modified-since</code> headers are present in the request
        /// as follows:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source-if-none-match</code> condition evaluates to <code>false</code>,
        /// and;
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source-if-modified-since</code> condition evaluates to <code>true</code>;
        /// </para>
        ///  
        /// <para>
        /// Amazon S3 returns <code>412 Precondition Failed</code> response code. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Versioning</b> 
        /// </para>
        ///  
        /// <para>
        /// If your bucket has versioning enabled, you could have multiple versions of the same
        /// object. By default, <code>x-amz-copy-source</code> identifies the current version
        /// of the object to copy. If the current version is a delete marker and you don't specify
        /// a versionId in the <code>x-amz-copy-source</code>, Amazon S3 returns a 404 error,
        /// because the object does not exist. If you specify versionId in the <code>x-amz-copy-source</code>
        /// and the versionId is a delete marker, Amazon S3 returns an HTTP 400 error, because
        /// you are not allowed to specify a delete marker as a version for the <code>x-amz-copy-source</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify a specific version of the source object to copy by adding
        /// the <code>versionId</code> subresource as shown in the following example:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source: /bucket/object?versionId=version id</code> 
        /// </para>
        ///  <p class="title"> <b>Special Errors</b> 
        /// </para>
        ///  <ul> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: NoSuchUpload</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: The specified multipart upload does not exist. The upload ID might be invalid,
        /// or the multipart upload might have been aborted or completed.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 404 Not Found</i> 
        /// </para>
        ///  </li> </ul> </li> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: InvalidRequest</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: The specified copy source is not supported as a byte-range copy source.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 400 Bad Request</i> 
        /// </para>
        ///  </li> </ul> </li> </ul> <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UploadPart</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CompleteMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AbortMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListParts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListMultipartUploads</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="sourceBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="sourceKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="sourceVersionId">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="uploadId">Upload ID identifying the multipart upload whose part is being copied.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyPart service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/UploadPartCopy">REST API Reference for CopyPart Operation</seealso>
        public virtual Task<CopyPartResponse> CopyPartAsync(string sourceBucket, string sourceKey, string sourceVersionId, string destinationBucket, string destinationKey, string uploadId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CopyPartRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.SourceVersionId = sourceVersionId;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            request.UploadId = uploadId;
            return CopyPartAsync(request, cancellationToken);
        }



        /// <summary>
        /// Uploads a part by copying data from an existing object as data source. You specify
        /// the data source by adding the request header <code>x-amz-copy-source</code> in your
        /// request and a byte range by adding the request header <code>x-amz-copy-source-range</code>
        /// in your request. 
        /// 
        ///  
        /// <para>
        /// The minimum allowable part size for a multipart upload is 5 MB. For more information
        /// about multipart upload limits, go to <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/qfacts.html">Quick
        /// Facts</a> in the <i>Amazon Simple Storage Service Developer Guide</i>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Instead of using an existing object as part data, you might use the <a>UploadPart</a>
        /// operation and provide data in your request.
        /// </para>
        ///  </note> 
        /// <para>
        /// You must initiate a multipart upload before you can upload any part. In response to
        /// your initiate request. Amazon S3 returns a unique identifier, the upload ID, that
        /// you must include in your upload part request.
        /// </para>
        ///  
        /// <para>
        /// For more information about using the <code>UploadPartCopy</code> operation, see the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For conceptual information about multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/uploadobjusingmpu.html">Uploading
        /// Objects Using Multipart Upload</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about permissions required to use the multipart upload API, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
        /// Upload API and Permissions</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about copying objects using a single atomic operation vs. the multipart
        /// upload, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ObjectOperations.html">Operations
        /// on Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about using server-side encryption with customer-provided encryption
        /// keys with the UploadPartCopy operation, see <a>CopyObject</a> and <a>UploadPart</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note the following additional considerations about the request headers <code>x-amz-copy-source-if-match</code>,
        /// <code>x-amz-copy-source-if-none-match</code>, <code>x-amz-copy-source-if-unmodified-since</code>,
        /// and <code>x-amz-copy-source-if-modified-since</code>:
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Consideration 1</b> - If both of the <code>x-amz-copy-source-if-match</code> and
        /// <code>x-amz-copy-source-if-unmodified-since</code> headers are present in the request
        /// as follows:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source-if-match</code> condition evaluates to <code>true</code>,
        /// and;
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source-if-unmodified-since</code> condition evaluates to <code>false</code>;
        /// </para>
        ///  
        /// <para>
        /// Amazon S3 returns <code>200 OK</code> and copies the data. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Consideration 2</b> - If both of the <code>x-amz-copy-source-if-none-match</code>
        /// and <code>x-amz-copy-source-if-modified-since</code> headers are present in the request
        /// as follows:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source-if-none-match</code> condition evaluates to <code>false</code>,
        /// and;
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source-if-modified-since</code> condition evaluates to <code>true</code>;
        /// </para>
        ///  
        /// <para>
        /// Amazon S3 returns <code>412 Precondition Failed</code> response code. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Versioning</b> 
        /// </para>
        ///  
        /// <para>
        /// If your bucket has versioning enabled, you could have multiple versions of the same
        /// object. By default, <code>x-amz-copy-source</code> identifies the current version
        /// of the object to copy. If the current version is a delete marker and you don't specify
        /// a versionId in the <code>x-amz-copy-source</code>, Amazon S3 returns a 404 error,
        /// because the object does not exist. If you specify versionId in the <code>x-amz-copy-source</code>
        /// and the versionId is a delete marker, Amazon S3 returns an HTTP 400 error, because
        /// you are not allowed to specify a delete marker as a version for the <code>x-amz-copy-source</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify a specific version of the source object to copy by adding
        /// the <code>versionId</code> subresource as shown in the following example:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source: /bucket/object?versionId=version id</code> 
        /// </para>
        ///  <p class="title"> <b>Special Errors</b> 
        /// </para>
        ///  <ul> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: NoSuchUpload</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: The specified multipart upload does not exist. The upload ID might be invalid,
        /// or the multipart upload might have been aborted or completed.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 404 Not Found</i> 
        /// </para>
        ///  </li> </ul> </li> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: InvalidRequest</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: The specified copy source is not supported as a byte-range copy source.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 400 Bad Request</i> 
        /// </para>
        ///  </li> </ul> </li> </ul> <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UploadPart</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CompleteMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AbortMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListParts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListMultipartUploads</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyPart service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyPart service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/UploadPartCopy">REST API Reference for CopyPart Operation</seealso>
        public virtual Task<CopyPartResponse> CopyPartAsync(CopyPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyPartResponseUnmarshaller.Instance;

            return InvokeAsync<CopyPartResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucket

        internal virtual DeleteBucketResponse DeleteBucket(DeleteBucketRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketResponse>(request, options);
        }


        /// <summary>
        /// Deletes the bucket. All objects (including all object versions and delete markers)
        /// in the bucket must be deleted before the bucket itself can be deleted.
        /// 
        ///  <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">Specifies the bucket being deleted.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucket service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/DeleteBucket">REST API Reference for DeleteBucket Operation</seealso>
        public virtual Task<DeleteBucketResponse> DeleteBucketAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteBucketRequest();
            request.BucketName = bucketName;
            return DeleteBucketAsync(request, cancellationToken);
        }



        /// <summary>
        /// Deletes the bucket. All objects (including all object versions and delete markers)
        /// in the bucket must be deleted before the bucket itself can be deleted.
        /// 
        ///  <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucket service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucket service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/DeleteBucket">REST API Reference for DeleteBucket Operation</seealso>
        public virtual Task<DeleteBucketResponse> DeleteBucketAsync(DeleteBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketAnalyticsConfiguration

        internal virtual DeleteBucketAnalyticsConfigurationResponse DeleteBucketAnalyticsConfiguration(DeleteBucketAnalyticsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketAnalyticsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketAnalyticsConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes an analytics configuration for the bucket (specified by the analytics configuration
        /// ID).
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:PutAnalyticsConfiguration</code>
        /// action. The bucket owner has this permission by default. The bucket owner can grant
        /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about the Amazon S3 analytics feature, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/analytics-storage-class.html">Amazon
        /// S3 Analytics – Storage Class Analysis</a>. 
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>DeleteBucketAnalyticsConfiguration</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketAnalyticsConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketAnalyticsConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/DeleteBucketAnalyticsConfiguration">REST API Reference for DeleteBucketAnalyticsConfiguration Operation</seealso>
        public virtual Task<DeleteBucketAnalyticsConfigurationResponse> DeleteBucketAnalyticsConfigurationAsync(DeleteBucketAnalyticsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketAnalyticsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketAnalyticsConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketEncryption

        internal virtual DeleteBucketEncryptionResponse DeleteBucketEncryption(DeleteBucketEncryptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketEncryptionResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketEncryptionResponse>(request, options);
        }



        /// <summary>
        /// This implementation of the DELETE operation removes default encryption from the bucket.
        /// For information about the Amazon S3 default encryption feature, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/bucket-encryption.html">Amazon
        /// S3 Default Bucket Encryption</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i>.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:PutEncryptionConfiguration</code>
        /// action. The bucket owner has this permission by default. The bucket owner can grant
        /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to your Amazon S3 Resources</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>.
        /// </para>
        ///  <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketEncryption</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketEncryption</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketEncryption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketEncryption service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/DeleteBucketEncryption">REST API Reference for DeleteBucketEncryption Operation</seealso>
        public virtual Task<DeleteBucketEncryptionResponse> DeleteBucketEncryptionAsync(DeleteBucketEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketEncryptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketEncryptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketInventoryConfiguration

        internal virtual DeleteBucketInventoryConfigurationResponse DeleteBucketInventoryConfiguration(DeleteBucketInventoryConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketInventoryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketInventoryConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes an inventory configuration (identified by the inventory ID) from the bucket.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:PutInventoryConfiguration</code>
        /// action. The bucket owner has this permission by default. The bucket owner can grant
        /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about the Amazon S3 inventory feature, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage-inventory.html">Amazon
        /// S3 Inventory</a>.
        /// </para>
        ///  
        /// <para>
        /// Operations related to <code>DeleteBucketInventoryConfiguration</code> include: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketInventoryConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutBucketInventoryConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBucketInventoryConfigurations</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketInventoryConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketInventoryConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/DeleteBucketInventoryConfiguration">REST API Reference for DeleteBucketInventoryConfiguration Operation</seealso>
        public virtual Task<DeleteBucketInventoryConfigurationResponse> DeleteBucketInventoryConfigurationAsync(DeleteBucketInventoryConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketInventoryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketInventoryConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketMetricsConfiguration

        internal virtual DeleteBucketMetricsConfigurationResponse DeleteBucketMetricsConfiguration(DeleteBucketMetricsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketMetricsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketMetricsConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes a metrics configuration for the Amazon CloudWatch request metrics (specified
        /// by the metrics configuration ID) from the bucket. Note that this doesn't include the
        /// daily storage metrics.
        /// 
        ///  
        /// <para>
        ///  To use this operation, you must have permissions to perform the <code>s3:PutMetricsConfiguration</code>
        /// action. The bucket owner has this permission by default. The bucket owner can grant
        /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about CloudWatch request metrics for Amazon S3, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/cloudwatch-monitoring.html">Monitoring
        /// Metrics with Amazon CloudWatch</a>. 
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>DeleteBucketMetricsConfiguration</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketMetricsConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutBucketMetricsConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBucketMetricsConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/cloudwatch-monitoring.html">Monitoring
        /// Metrics with Amazon CloudWatch</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketMetricsConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketMetricsConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/DeleteBucketMetricsConfiguration">REST API Reference for DeleteBucketMetricsConfiguration Operation</seealso>
        public virtual Task<DeleteBucketMetricsConfigurationResponse> DeleteBucketMetricsConfigurationAsync(DeleteBucketMetricsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketMetricsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketMetricsConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketPolicy

        internal virtual DeleteBucketPolicyResponse DeleteBucketPolicy(DeleteBucketPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketPolicyResponse>(request, options);
        }


        /// <summary>
        /// This implementation of the DELETE operation uses the policy subresource to delete
        /// the policy of a specified bucket. If you are using an identity other than the root
        /// user of the AWS account that owns the bucket, the calling identity must have the <code>DeleteBucketPolicy</code>
        /// permissions on the specified bucket and belong to the bucket owner's account to use
        /// this operation. 
        /// 
        ///  
        /// <para>
        /// If you don't have <code>DeleteBucketPolicy</code> permissions, Amazon S3 returns a
        /// <code>403 Access Denied</code> error. If you have the correct permissions, but you're
        /// not using an identity that belongs to the bucket owner's account, Amazon S3 returns
        /// a <code>405 Method Not Allowed</code> error. 
        /// </para>
        ///  <important> 
        /// <para>
        /// As a security precaution, the root user of the AWS account that owns a bucket can
        /// always use this operation, even if the policy explicitly denies the root user the
        /// ability to perform this action.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about bucket policies, see <a href=" https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
        /// Bucket Policies and UserPolicies</a>. 
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>DeleteBucketPolicy</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteObject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketPolicy service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/DeleteBucketPolicy">REST API Reference for DeleteBucketPolicy Operation</seealso>
        public virtual Task<DeleteBucketPolicyResponse> DeleteBucketPolicyAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteBucketPolicyRequest();
            request.BucketName = bucketName;
            return DeleteBucketPolicyAsync(request, cancellationToken);
        }



        /// <summary>
        /// This implementation of the DELETE operation uses the policy subresource to delete
        /// the policy of a specified bucket. If you are using an identity other than the root
        /// user of the AWS account that owns the bucket, the calling identity must have the <code>DeleteBucketPolicy</code>
        /// permissions on the specified bucket and belong to the bucket owner's account to use
        /// this operation. 
        /// 
        ///  
        /// <para>
        /// If you don't have <code>DeleteBucketPolicy</code> permissions, Amazon S3 returns a
        /// <code>403 Access Denied</code> error. If you have the correct permissions, but you're
        /// not using an identity that belongs to the bucket owner's account, Amazon S3 returns
        /// a <code>405 Method Not Allowed</code> error. 
        /// </para>
        ///  <important> 
        /// <para>
        /// As a security precaution, the root user of the AWS account that owns a bucket can
        /// always use this operation, even if the policy explicitly denies the root user the
        /// ability to perform this action.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about bucket policies, see <a href=" https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
        /// Bucket Policies and UserPolicies</a>. 
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>DeleteBucketPolicy</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteObject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketPolicy service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/DeleteBucketPolicy">REST API Reference for DeleteBucketPolicy Operation</seealso>
        public virtual Task<DeleteBucketPolicyResponse> DeleteBucketPolicyAsync(DeleteBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketReplication

        internal virtual DeleteBucketReplicationResponse DeleteBucketReplication(DeleteBucketReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketReplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketReplicationResponse>(request, options);
        }



        /// <summary>
        /// Deletes the replication configuration from the bucket.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:PutReplicationConfiguration</code>
        /// action. The bucket owner has these permissions by default and can grant it to others.
        /// For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// It can take a while for the deletion of a replication configuration to fully propagate.
        /// </para>
        ///  </note> 
        /// <para>
        ///  For information about replication configuration, see <a href=" https://docs.aws.amazon.com/AmazonS3/latest/dev/replication.html">Replication</a>
        /// in the <i>Amazon S3 Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>DeleteBucketReplication</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketReplication</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketReplication</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketReplication service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/DeleteBucketReplication">REST API Reference for DeleteBucketReplication Operation</seealso>
        public virtual Task<DeleteBucketReplicationResponse> DeleteBucketReplicationAsync(DeleteBucketReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketReplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketReplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketTagging

        internal virtual DeleteBucketTaggingResponse DeleteBucketTagging(DeleteBucketTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketTaggingResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketTaggingResponse>(request, options);
        }


        /// <summary>
        /// Deletes the tags from the bucket.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <code>s3:PutBucketTagging</code>
        /// action. By default, the bucket owner has this permission and can grant this permission
        /// to others. 
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>DeleteBucketTagging</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketTagging</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutBucketTagging</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket that has the tag set to be removed.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketTagging service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/DeleteBucketTagging">REST API Reference for DeleteBucketTagging Operation</seealso>
        public virtual Task<DeleteBucketTaggingResponse> DeleteBucketTaggingAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteBucketTaggingRequest();
            request.BucketName = bucketName;
            return DeleteBucketTaggingAsync(request, cancellationToken);
        }



        /// <summary>
        /// Deletes the tags from the bucket.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <code>s3:PutBucketTagging</code>
        /// action. By default, the bucket owner has this permission and can grant this permission
        /// to others. 
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>DeleteBucketTagging</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketTagging</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutBucketTagging</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketTagging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketTagging service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/DeleteBucketTagging">REST API Reference for DeleteBucketTagging Operation</seealso>
        public virtual Task<DeleteBucketTaggingResponse> DeleteBucketTaggingAsync(DeleteBucketTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketTaggingResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketTaggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketWebsite

        internal virtual DeleteBucketWebsiteResponse DeleteBucketWebsite(DeleteBucketWebsiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketWebsiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketWebsiteResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketWebsiteResponse>(request, options);
        }


        /// <summary>
        /// This operation removes the website configuration for a bucket. Amazon S3 returns a
        /// <code>200 OK</code> response upon successfully deleting a website configuration on
        /// the specified bucket. You will get a <code>200 OK</code> response if the website configuration
        /// you are trying to delete does not exist on the bucket. Amazon S3 returns a <code>404</code>
        /// response if the bucket specified in the request does not exist.
        /// 
        ///  
        /// <para>
        /// This DELETE operation requires the <code>S3:DeleteBucketWebsite</code> permission.
        /// By default, only the bucket owner can delete the website configuration attached to
        /// a bucket. However, bucket owners can grant other users permission to delete the website
        /// configuration by writing a bucket policy granting them the <code>S3:DeleteBucketWebsite</code>
        /// permission. 
        /// </para>
        ///  
        /// <para>
        /// For more information about hosting websites, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/WebsiteHosting.html">Hosting
        /// Websites on Amazon S3</a>. 
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>DeleteBucketWebsite</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketWebsite</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutBucketWebsite</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name for which you want to remove the website configuration. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketWebsite service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/DeleteBucketWebsite">REST API Reference for DeleteBucketWebsite Operation</seealso>
        public virtual Task<DeleteBucketWebsiteResponse> DeleteBucketWebsiteAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteBucketWebsiteRequest();
            request.BucketName = bucketName;
            return DeleteBucketWebsiteAsync(request, cancellationToken);
        }



        /// <summary>
        /// This operation removes the website configuration for a bucket. Amazon S3 returns a
        /// <code>200 OK</code> response upon successfully deleting a website configuration on
        /// the specified bucket. You will get a <code>200 OK</code> response if the website configuration
        /// you are trying to delete does not exist on the bucket. Amazon S3 returns a <code>404</code>
        /// response if the bucket specified in the request does not exist.
        /// 
        ///  
        /// <para>
        /// This DELETE operation requires the <code>S3:DeleteBucketWebsite</code> permission.
        /// By default, only the bucket owner can delete the website configuration attached to
        /// a bucket. However, bucket owners can grant other users permission to delete the website
        /// configuration by writing a bucket policy granting them the <code>S3:DeleteBucketWebsite</code>
        /// permission. 
        /// </para>
        ///  
        /// <para>
        /// For more information about hosting websites, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/WebsiteHosting.html">Hosting
        /// Websites on Amazon S3</a>. 
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>DeleteBucketWebsite</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketWebsite</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutBucketWebsite</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketWebsite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketWebsite service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/DeleteBucketWebsite">REST API Reference for DeleteBucketWebsite Operation</seealso>
        public virtual Task<DeleteBucketWebsiteResponse> DeleteBucketWebsiteAsync(DeleteBucketWebsiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketWebsiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketWebsiteResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketWebsiteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCORSConfiguration

        internal virtual DeleteCORSConfigurationResponse DeleteCORSConfiguration(DeleteCORSConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCORSConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCORSConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteCORSConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes the <code>cors</code> configuration information set for the bucket.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <code>s3:PutBucketCORS</code>
        /// action. The bucket owner has this permission by default and can grant this permission
        /// to others. 
        /// </para>
        ///  
        /// <para>
        /// For information about <code>cors</code>, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/cors.html">Enabling
        /// Cross-Origin Resource Sharing</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i>.
        /// </para>
        ///  <p class="title"> <b>Related Resources:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RESTOPTIONSobject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">Specifies the bucket whose <code>cors</code> configuration is being deleted.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCORSConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/DeleteBucketCors">REST API Reference for DeleteCORSConfiguration Operation</seealso>
        public virtual Task<DeleteCORSConfigurationResponse> DeleteCORSConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteCORSConfigurationRequest();
            request.BucketName = bucketName;
            return DeleteCORSConfigurationAsync(request, cancellationToken);
        }



        /// <summary>
        /// Deletes the <code>cors</code> configuration information set for the bucket.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <code>s3:PutBucketCORS</code>
        /// action. The bucket owner has this permission by default and can grant this permission
        /// to others. 
        /// </para>
        ///  
        /// <para>
        /// For information about <code>cors</code>, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/cors.html">Enabling
        /// Cross-Origin Resource Sharing</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i>.
        /// </para>
        ///  <p class="title"> <b>Related Resources:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RESTOPTIONSobject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCORSConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCORSConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/DeleteBucketCors">REST API Reference for DeleteCORSConfiguration Operation</seealso>
        public virtual Task<DeleteCORSConfigurationResponse> DeleteCORSConfigurationAsync(DeleteCORSConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCORSConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCORSConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCORSConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLifecycleConfiguration

        internal virtual DeleteLifecycleConfigurationResponse DeleteLifecycleConfiguration(DeleteLifecycleConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecycleConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteLifecycleConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes the lifecycle configuration from the specified bucket. Amazon S3 removes all
        /// the lifecycle configuration rules in the lifecycle subresource associated with the
        /// bucket. Your objects never expire, and Amazon S3 no longer automatically deletes any
        /// objects on the basis of rules contained in the deleted lifecycle configuration.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <code>s3:PutLifecycleConfiguration</code>
        /// action. By default, the bucket owner has this permission and the bucket owner can
        /// grant this permission to others.
        /// </para>
        ///  
        /// <para>
        /// There is usually some time lag before lifecycle configuration deletion is fully propagated
        /// to all the Amazon S3 systems.
        /// </para>
        ///  
        /// <para>
        /// For more information about the object expiration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/intro-lifecycle-rules.html#intro-lifecycle-rules-actions">Elements
        /// to Describe Lifecycle Actions</a>.
        /// </para>
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketLifecycleConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketLifecycleConfiguration</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name of the lifecycle to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLifecycleConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/DeleteBucketLifecycle">REST API Reference for DeleteLifecycleConfiguration Operation</seealso>
        public virtual Task<DeleteLifecycleConfigurationResponse> DeleteLifecycleConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteLifecycleConfigurationRequest();
            request.BucketName = bucketName;
            return DeleteLifecycleConfigurationAsync(request, cancellationToken);
        }



        /// <summary>
        /// Deletes the lifecycle configuration from the specified bucket. Amazon S3 removes all
        /// the lifecycle configuration rules in the lifecycle subresource associated with the
        /// bucket. Your objects never expire, and Amazon S3 no longer automatically deletes any
        /// objects on the basis of rules contained in the deleted lifecycle configuration.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <code>s3:PutLifecycleConfiguration</code>
        /// action. By default, the bucket owner has this permission and the bucket owner can
        /// grant this permission to others.
        /// </para>
        ///  
        /// <para>
        /// There is usually some time lag before lifecycle configuration deletion is fully propagated
        /// to all the Amazon S3 systems.
        /// </para>
        ///  
        /// <para>
        /// For more information about the object expiration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/intro-lifecycle-rules.html#intro-lifecycle-rules-actions">Elements
        /// to Describe Lifecycle Actions</a>.
        /// </para>
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketLifecycleConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketLifecycleConfiguration</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLifecycleConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/DeleteBucketLifecycle">REST API Reference for DeleteLifecycleConfiguration Operation</seealso>
        public virtual Task<DeleteLifecycleConfigurationResponse> DeleteLifecycleConfigurationAsync(DeleteLifecycleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecycleConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLifecycleConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteObject

        internal virtual DeleteObjectResponse DeleteObject(DeleteObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectResponse>(request, options);
        }


        /// <summary>
        /// Removes the null version (if there is one) of an object and inserts a delete marker,
        /// which becomes the latest version of the object. If there isn't a null version, Amazon
        /// S3 does not remove any objects.
        /// 
        ///  
        /// <para>
        /// To remove a specific version, you must be the bucket owner and you must use the version
        /// Id subresource. Using this subresource permanently deletes the version. If the object
        /// deleted is a delete marker, Amazon S3 sets the response header, <code>x-amz-delete-marker</code>,
        /// to true. 
        /// </para>
        ///  
        /// <para>
        /// If the object you want to delete is in a bucket where the bucket versioning configuration
        /// is MFA Delete enabled, you must include the <code>x-amz-mfa</code> request header
        /// in the DELETE <code>versionId</code> request. Requests that include <code>x-amz-mfa</code>
        /// must use HTTPS. 
        /// </para>
        ///  
        /// <para>
        ///  For more information about MFA Delete, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingMFADelete.html">Using
        /// MFA Delete</a>. To see sample requests that use versioning, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTObjectDELETE.html#ExampleVersionObjectDelete">Sample
        /// Request</a>. 
        /// </para>
        ///  
        /// <para>
        /// You can delete objects by explicitly calling the DELETE Object API or configure its
        /// lifecycle (<a>PutBucketLifecycle</a>) to enable Amazon S3 to remove them for you.
        /// If you want to block users or accounts from removing or deleting objects from your
        /// bucket, you must deny them the <code>s3:DeleteObject</code>, <code>s3:DeleteObjectVersion</code>,
        /// and <code>s3:PutLifeCycleConfiguration</code> actions. 
        /// </para>
        ///  
        /// <para>
        /// The following operation is related to <code>DeleteObject</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name of the bucket containing the object.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="key">Key name of the object to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/DeleteObject">REST API Reference for DeleteObject Operation</seealso>
        public virtual Task<DeleteObjectResponse> DeleteObjectAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return DeleteObjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Removes the null version (if there is one) of an object and inserts a delete marker,
        /// which becomes the latest version of the object. If there isn't a null version, Amazon
        /// S3 does not remove any objects.
        /// 
        ///  
        /// <para>
        /// To remove a specific version, you must be the bucket owner and you must use the version
        /// Id subresource. Using this subresource permanently deletes the version. If the object
        /// deleted is a delete marker, Amazon S3 sets the response header, <code>x-amz-delete-marker</code>,
        /// to true. 
        /// </para>
        ///  
        /// <para>
        /// If the object you want to delete is in a bucket where the bucket versioning configuration
        /// is MFA Delete enabled, you must include the <code>x-amz-mfa</code> request header
        /// in the DELETE <code>versionId</code> request. Requests that include <code>x-amz-mfa</code>
        /// must use HTTPS. 
        /// </para>
        ///  
        /// <para>
        ///  For more information about MFA Delete, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingMFADelete.html">Using
        /// MFA Delete</a>. To see sample requests that use versioning, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTObjectDELETE.html#ExampleVersionObjectDelete">Sample
        /// Request</a>. 
        /// </para>
        ///  
        /// <para>
        /// You can delete objects by explicitly calling the DELETE Object API or configure its
        /// lifecycle (<a>PutBucketLifecycle</a>) to enable Amazon S3 to remove them for you.
        /// If you want to block users or accounts from removing or deleting objects from your
        /// bucket, you must deny them the <code>s3:DeleteObject</code>, <code>s3:DeleteObjectVersion</code>,
        /// and <code>s3:PutLifeCycleConfiguration</code> actions. 
        /// </para>
        ///  
        /// <para>
        /// The following operation is related to <code>DeleteObject</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name of the bucket containing the object.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="key">Key name of the object to delete.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/DeleteObject">REST API Reference for DeleteObject Operation</seealso>
        public virtual Task<DeleteObjectResponse> DeleteObjectAsync(string bucketName, string key, string versionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            return DeleteObjectAsync(request, cancellationToken);
        }



        /// <summary>
        /// Removes the null version (if there is one) of an object and inserts a delete marker,
        /// which becomes the latest version of the object. If there isn't a null version, Amazon
        /// S3 does not remove any objects.
        /// 
        ///  
        /// <para>
        /// To remove a specific version, you must be the bucket owner and you must use the version
        /// Id subresource. Using this subresource permanently deletes the version. If the object
        /// deleted is a delete marker, Amazon S3 sets the response header, <code>x-amz-delete-marker</code>,
        /// to true. 
        /// </para>
        ///  
        /// <para>
        /// If the object you want to delete is in a bucket where the bucket versioning configuration
        /// is MFA Delete enabled, you must include the <code>x-amz-mfa</code> request header
        /// in the DELETE <code>versionId</code> request. Requests that include <code>x-amz-mfa</code>
        /// must use HTTPS. 
        /// </para>
        ///  
        /// <para>
        ///  For more information about MFA Delete, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingMFADelete.html">Using
        /// MFA Delete</a>. To see sample requests that use versioning, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTObjectDELETE.html#ExampleVersionObjectDelete">Sample
        /// Request</a>. 
        /// </para>
        ///  
        /// <para>
        /// You can delete objects by explicitly calling the DELETE Object API or configure its
        /// lifecycle (<a>PutBucketLifecycle</a>) to enable Amazon S3 to remove them for you.
        /// If you want to block users or accounts from removing or deleting objects from your
        /// bucket, you must deny them the <code>s3:DeleteObject</code>, <code>s3:DeleteObjectVersion</code>,
        /// and <code>s3:PutLifeCycleConfiguration</code> actions. 
        /// </para>
        ///  
        /// <para>
        /// The following operation is related to <code>DeleteObject</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/DeleteObject">REST API Reference for DeleteObject Operation</seealso>
        public virtual Task<DeleteObjectResponse> DeleteObjectAsync(DeleteObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteObjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteObjects

        internal virtual DeleteObjectsResponse DeleteObjects(DeleteObjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectsResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectsResponse>(request, options);
        }



        /// <summary>
        /// This operation enables you to delete multiple objects from a bucket using a single
        /// HTTP request. If you know the object keys that you want to delete, then this operation
        /// provides a suitable alternative to sending individual delete requests, reducing per-request
        /// overhead.
        /// 
        ///  
        /// <para>
        /// The request contains a list of up to 1000 keys that you want to delete. In the XML,
        /// you provide the object key names, and optionally, version IDs if you want to delete
        /// a specific version of the object from a versioning-enabled bucket. For each key, Amazon
        /// S3 performs a delete operation and returns the result of that delete, success, or
        /// failure, in the response. Note that if the object specified in the request is not
        /// found, Amazon S3 returns the result as deleted.
        /// </para>
        ///  
        /// <para>
        ///  The operation supports two modes for the response: verbose and quiet. By default,
        /// the operation uses verbose mode in which the response includes the result of deletion
        /// of each key in your request. In quiet mode the response includes only keys where the
        /// delete operation encountered an error. For a successful deletion, the operation does
        /// not return any information about the delete in the response body.
        /// </para>
        ///  
        /// <para>
        /// When performing this operation on an MFA Delete enabled bucket, that attempts to delete
        /// any versioned objects, you must include an MFA token. If you do not provide one, the
        /// entire request will fail, even if there are non-versioned objects you are trying to
        /// delete. If you provide an invalid token, whether there are versioned keys in the request
        /// or not, the entire Multi-Object Delete request will fail. For information about MFA
        /// Delete, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/Versioning.html#MultiFactorAuthenticationDelete">
        /// MFA Delete</a>.
        /// </para>
        ///  
        /// <para>
        /// Finally, the Content-MD5 header is required for all Multi-Object Delete requests.
        /// Amazon S3 uses the header value to ensure that your request body has not been altered
        /// in transit.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>DeleteObjects</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UploadPart</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CompleteMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListParts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AbortMultipartUpload</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteObjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteObjects service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/DeleteObjects">REST API Reference for DeleteObjects Operation</seealso>
        public virtual Task<DeleteObjectsResponse> DeleteObjectsAsync(DeleteObjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteObjectsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteObjectTagging

        internal virtual DeleteObjectTaggingResponse DeleteObjectTagging(DeleteObjectTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectTaggingResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectTaggingResponse>(request, options);
        }



        /// <summary>
        /// Removes the entire tag set from the specified object. For more information about managing
        /// object tags, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-tagging.html">
        /// Object Tagging</a>.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <code>s3:DeleteObjectTagging</code>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// To delete tags of a specific object version, add the <code>versionId</code> query
        /// parameter in the request. You will need permission for the <code>s3:DeleteObjectVersionTagging</code>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>DeleteBucketMetricsConfiguration</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObjectTagging</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetObjectTagging</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteObjectTagging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteObjectTagging service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/DeleteObjectTagging">REST API Reference for DeleteObjectTagging Operation</seealso>
        public virtual Task<DeleteObjectTaggingResponse> DeleteObjectTaggingAsync(DeleteObjectTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectTaggingResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteObjectTaggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePublicAccessBlock

        internal virtual DeletePublicAccessBlockResponse DeletePublicAccessBlock(DeletePublicAccessBlockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePublicAccessBlockResponseUnmarshaller.Instance;

            return Invoke<DeletePublicAccessBlockResponse>(request, options);
        }



        /// <summary>
        /// Removes the <code>PublicAccessBlock</code> configuration for an Amazon S3 bucket.
        /// To use this operation, you must have the <code>s3:PutBucketPublicAccessBlock</code>
        /// permission. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// 
        ///  
        /// <para>
        /// The following operations are related to <code>DeletePublicAccessBlock</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html">Using
        /// Amazon S3 Block Public Access</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetPublicAccessBlock</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutPublicAccessBlock</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketPolicyStatus</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePublicAccessBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePublicAccessBlock service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/DeletePublicAccessBlock">REST API Reference for DeletePublicAccessBlock Operation</seealso>
        public virtual Task<DeletePublicAccessBlockResponse> DeletePublicAccessBlockAsync(DeletePublicAccessBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePublicAccessBlockResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePublicAccessBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetACL

        internal virtual GetACLResponse GetACL(GetACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetACLResponseUnmarshaller.Instance;

            return Invoke<GetACLResponse>(request, options);
        }


        /// <summary>
        /// This implementation of the <code>GET</code> operation uses the <code>acl</code> subresource
        /// to return the access control list (ACL) of a bucket. To use <code>GET</code> to return
        /// the ACL of the bucket, you must have <code>READ_ACP</code> access to the bucket. If
        /// <code>READ_ACP</code> permission is granted to the anonymous user, you can return
        /// the ACL of the bucket without using an authorization header.
        /// 
        ///  <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">Specifies the S3 bucket whose ACL is being requested.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetACL service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketAcl">REST API Reference for GetACL Operation</seealso>
        public virtual Task<GetACLResponse> GetACLAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetACLRequest();
            request.BucketName = bucketName;
            return GetACLAsync(request, cancellationToken);
        }



        /// <summary>
        /// This implementation of the <code>GET</code> operation uses the <code>acl</code> subresource
        /// to return the access control list (ACL) of a bucket. To use <code>GET</code> to return
        /// the ACL of the bucket, you must have <code>READ_ACP</code> access to the bucket. If
        /// <code>READ_ACP</code> permission is granted to the anonymous user, you can return
        /// the ACL of the bucket without using an authorization header.
        /// 
        ///  <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetACL service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketAcl">REST API Reference for GetACL Operation</seealso>
        public virtual Task<GetACLResponse> GetACLAsync(GetACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetACLResponseUnmarshaller.Instance;

            return InvokeAsync<GetACLResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketAccelerateConfiguration

        internal virtual GetBucketAccelerateConfigurationResponse GetBucketAccelerateConfiguration(GetBucketAccelerateConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketAccelerateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketAccelerateConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetBucketAccelerateConfigurationResponse>(request, options);
        }


        /// <summary>
        /// This implementation of the GET operation uses the <code>accelerate</code> subresource
        /// to return the Transfer Acceleration state of a bucket, which is either <code>Enabled</code>
        /// or <code>Suspended</code>. Amazon S3 Transfer Acceleration is a bucket-level feature
        /// that enables you to perform faster data transfers to and from Amazon S3.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <code>s3:GetAccelerateConfiguration</code>
        /// action. The bucket owner has this permission by default. The bucket owner can grant
        /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to your Amazon S3 Resources</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You set the Transfer Acceleration state of an existing bucket to <code>Enabled</code>
        /// or <code>Suspended</code> by using the <a>PutBucketAccelerateConfiguration</a> operation.
        /// 
        /// </para>
        ///  
        /// <para>
        /// A GET <code>accelerate</code> request does not return a state value for a bucket that
        /// has no transfer acceleration state. A bucket has no Transfer Acceleration state if
        /// a state has never been set on the bucket. 
        /// </para>
        ///  
        /// <para>
        /// For more information about transfer acceleration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/transfer-acceleration.html">Transfer
        /// Acceleration</a> in the Amazon Simple Storage Service Developer Guide.
        /// </para>
        ///  <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketAccelerateConfiguration</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">Name of the bucket for which the accelerate configuration is retrieved.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketAccelerateConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketAccelerateConfiguration">REST API Reference for GetBucketAccelerateConfiguration Operation</seealso>
        public virtual Task<GetBucketAccelerateConfigurationResponse> GetBucketAccelerateConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketAccelerateConfigurationRequest();
            request.BucketName = bucketName;
            return GetBucketAccelerateConfigurationAsync(request, cancellationToken);
        }



        /// <summary>
        /// This implementation of the GET operation uses the <code>accelerate</code> subresource
        /// to return the Transfer Acceleration state of a bucket, which is either <code>Enabled</code>
        /// or <code>Suspended</code>. Amazon S3 Transfer Acceleration is a bucket-level feature
        /// that enables you to perform faster data transfers to and from Amazon S3.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <code>s3:GetAccelerateConfiguration</code>
        /// action. The bucket owner has this permission by default. The bucket owner can grant
        /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to your Amazon S3 Resources</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You set the Transfer Acceleration state of an existing bucket to <code>Enabled</code>
        /// or <code>Suspended</code> by using the <a>PutBucketAccelerateConfiguration</a> operation.
        /// 
        /// </para>
        ///  
        /// <para>
        /// A GET <code>accelerate</code> request does not return a state value for a bucket that
        /// has no transfer acceleration state. A bucket has no Transfer Acceleration state if
        /// a state has never been set on the bucket. 
        /// </para>
        ///  
        /// <para>
        /// For more information about transfer acceleration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/transfer-acceleration.html">Transfer
        /// Acceleration</a> in the Amazon Simple Storage Service Developer Guide.
        /// </para>
        ///  <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketAccelerateConfiguration</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketAccelerateConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketAccelerateConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketAccelerateConfiguration">REST API Reference for GetBucketAccelerateConfiguration Operation</seealso>
        public virtual Task<GetBucketAccelerateConfigurationResponse> GetBucketAccelerateConfigurationAsync(GetBucketAccelerateConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketAccelerateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketAccelerateConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketAccelerateConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketAnalyticsConfiguration

        internal virtual GetBucketAnalyticsConfigurationResponse GetBucketAnalyticsConfiguration(GetBucketAnalyticsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketAnalyticsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetBucketAnalyticsConfigurationResponse>(request, options);
        }



        /// <summary>
        /// This implementation of the GET operation returns an analytics configuration (identified
        /// by the analytics configuration ID) from the bucket.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:GetAnalyticsConfiguration</code>
        /// action. The bucket owner has this permission by default. The bucket owner can grant
        /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">
        /// Permissions Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// For information about Amazon S3 analytics feature, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/analytics-storage-class.html">Amazon
        /// S3 Analytics – Storage Class Analysis</a> in the <i>Amazon Simple Storage Service
        /// Developer Guide</i>.
        /// </para>
        ///  <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketAnalyticsConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketAnalyticsConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketAnalyticsConfiguration">REST API Reference for GetBucketAnalyticsConfiguration Operation</seealso>
        public virtual Task<GetBucketAnalyticsConfigurationResponse> GetBucketAnalyticsConfigurationAsync(GetBucketAnalyticsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketAnalyticsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketAnalyticsConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketEncryption

        internal virtual GetBucketEncryptionResponse GetBucketEncryption(GetBucketEncryptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketEncryptionResponseUnmarshaller.Instance;

            return Invoke<GetBucketEncryptionResponse>(request, options);
        }



        /// <summary>
        /// Returns the default encryption configuration for an Amazon S3 bucket. For information
        /// about the Amazon S3 default encryption feature, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/bucket-encryption.html">Amazon
        /// S3 Default Bucket Encryption</a>.
        /// 
        ///  
        /// <para>
        ///  To use this operation, you must have permission to perform the <code>s3:GetEncryptionConfiguration</code>
        /// action. The bucket owner has this permission by default. The bucket owner can grant
        /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>GetBucketEncryption</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketEncryption</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketEncryption</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketEncryption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketEncryption service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketEncryption">REST API Reference for GetBucketEncryption Operation</seealso>
        public virtual Task<GetBucketEncryptionResponse> GetBucketEncryptionAsync(GetBucketEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketEncryptionResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketEncryptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketInventoryConfiguration

        internal virtual GetBucketInventoryConfigurationResponse GetBucketInventoryConfiguration(GetBucketInventoryConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketInventoryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetBucketInventoryConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Returns an inventory configuration (identified by the inventory configuration ID)
        /// from the bucket.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:GetInventoryConfiguration</code>
        /// action. The bucket owner has this permission by default and can grant this permission
        /// to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about the Amazon S3 inventory feature, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage-inventory.html">Amazon
        /// S3 Inventory</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>GetBucketInventoryConfiguration</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DeleteBucketInventoryConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBucketInventoryConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutBucketInventoryConfiguration</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketInventoryConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketInventoryConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketInventoryConfiguration">REST API Reference for GetBucketInventoryConfiguration Operation</seealso>
        public virtual Task<GetBucketInventoryConfigurationResponse> GetBucketInventoryConfigurationAsync(GetBucketInventoryConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketInventoryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketInventoryConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketLocation

        internal virtual GetBucketLocationResponse GetBucketLocation(GetBucketLocationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketLocationResponseUnmarshaller.Instance;

            return Invoke<GetBucketLocationResponse>(request, options);
        }


        /// <summary>
        /// Returns the Region the bucket resides in. You set the bucket's Region using the <code>LocationConstraint</code>
        /// request parameter in a <code>CreateBucket</code> request. For more information, see
        /// <a>CreateBucket</a>.
        /// 
        ///  
        /// <para>
        ///  To use this implementation of the operation, you must be the bucket owner.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>GetBucketLocation</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The name of the bucket for which to get the location.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketLocation service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketLocation">REST API Reference for GetBucketLocation Operation</seealso>
        public virtual Task<GetBucketLocationResponse> GetBucketLocationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketLocationRequest();
            request.BucketName = bucketName;
            return GetBucketLocationAsync(request, cancellationToken);
        }



        /// <summary>
        /// Returns the Region the bucket resides in. You set the bucket's Region using the <code>LocationConstraint</code>
        /// request parameter in a <code>CreateBucket</code> request. For more information, see
        /// <a>CreateBucket</a>.
        /// 
        ///  
        /// <para>
        ///  To use this implementation of the operation, you must be the bucket owner.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>GetBucketLocation</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketLocation service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketLocation">REST API Reference for GetBucketLocation Operation</seealso>
        public virtual Task<GetBucketLocationResponse> GetBucketLocationAsync(GetBucketLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketLocationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketLocationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketLogging

        internal virtual GetBucketLoggingResponse GetBucketLogging(GetBucketLoggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketLoggingResponseUnmarshaller.Instance;

            return Invoke<GetBucketLoggingResponse>(request, options);
        }


        /// <summary>
        /// Returns the logging status of a bucket and the permissions users have to view and
        /// modify that status. To use GET, you must be the bucket owner.
        /// 
        ///  
        /// <para>
        /// The following operations are related to <code>GetBucketLogging</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutBucketLogging</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name for which to get the logging information.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketLogging service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketLogging">REST API Reference for GetBucketLogging Operation</seealso>
        public virtual Task<GetBucketLoggingResponse> GetBucketLoggingAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketLoggingRequest();
            request.BucketName = bucketName;
            return GetBucketLoggingAsync(request, cancellationToken);
        }



        /// <summary>
        /// Returns the logging status of a bucket and the permissions users have to view and
        /// modify that status. To use GET, you must be the bucket owner.
        /// 
        ///  
        /// <para>
        /// The following operations are related to <code>GetBucketLogging</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutBucketLogging</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLogging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketLogging service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketLogging">REST API Reference for GetBucketLogging Operation</seealso>
        public virtual Task<GetBucketLoggingResponse> GetBucketLoggingAsync(GetBucketLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketLoggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketMetricsConfiguration

        internal virtual GetBucketMetricsConfigurationResponse GetBucketMetricsConfiguration(GetBucketMetricsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketMetricsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetBucketMetricsConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Gets a metrics configuration (specified by the metrics configuration ID) from the
        /// bucket. Note that this doesn't include the daily storage metrics.
        /// 
        ///  
        /// <para>
        ///  To use this operation, you must have permissions to perform the <code>s3:GetMetricsConfiguration</code>
        /// action. The bucket owner has this permission by default. The bucket owner can grant
        /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        ///  For information about CloudWatch request metrics for Amazon S3, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/cloudwatch-monitoring.html">Monitoring
        /// Metrics with Amazon CloudWatch</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>GetBucketMetricsConfiguration</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketMetricsConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketMetricsConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBucketMetricsConfigurations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/cloudwatch-monitoring.html">Monitoring
        /// Metrics with Amazon CloudWatch</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketMetricsConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketMetricsConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketMetricsConfiguration">REST API Reference for GetBucketMetricsConfiguration Operation</seealso>
        public virtual Task<GetBucketMetricsConfigurationResponse> GetBucketMetricsConfigurationAsync(GetBucketMetricsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketMetricsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketMetricsConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketNotification

        internal virtual GetBucketNotificationResponse GetBucketNotification(GetBucketNotificationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketNotificationResponseUnmarshaller.Instance;

            return Invoke<GetBucketNotificationResponse>(request, options);
        }


        /// <summary>
        /// Returns the notification configuration of a bucket.
        /// 
        ///  
        /// <para>
        /// If notifications are not enabled on the bucket, the operation returns an empty <code>NotificationConfiguration</code>
        /// element.
        /// </para>
        ///  
        /// <para>
        /// By default, you must be the bucket owner to read the notification configuration of
        /// a bucket. However, the bucket owner can use a bucket policy to grant permission to
        /// other users to read this configuration with the <code>s3:GetBucketNotification</code>
        /// permission.
        /// </para>
        ///  
        /// <para>
        /// For more information about setting and reading the notification configuration on a
        /// bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html">Setting
        /// Up Notification of Bucket Events</a>. For more information about bucket policies,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
        /// Bucket Policies</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operation is related to <code>GetBucketNotification</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketNotification</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">Name of the bucket for which to get the notification configuration.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketNotification service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketNotificationConfiguration">REST API Reference for GetBucketNotification Operation</seealso>
        public virtual Task<GetBucketNotificationResponse> GetBucketNotificationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketNotificationRequest();
            request.BucketName = bucketName;
            return GetBucketNotificationAsync(request, cancellationToken);
        }



        /// <summary>
        /// Returns the notification configuration of a bucket.
        /// 
        ///  
        /// <para>
        /// If notifications are not enabled on the bucket, the operation returns an empty <code>NotificationConfiguration</code>
        /// element.
        /// </para>
        ///  
        /// <para>
        /// By default, you must be the bucket owner to read the notification configuration of
        /// a bucket. However, the bucket owner can use a bucket policy to grant permission to
        /// other users to read this configuration with the <code>s3:GetBucketNotification</code>
        /// permission.
        /// </para>
        ///  
        /// <para>
        /// For more information about setting and reading the notification configuration on a
        /// bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html">Setting
        /// Up Notification of Bucket Events</a>. For more information about bucket policies,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
        /// Bucket Policies</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operation is related to <code>GetBucketNotification</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketNotification</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketNotification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketNotification service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketNotificationConfiguration">REST API Reference for GetBucketNotification Operation</seealso>
        public virtual Task<GetBucketNotificationResponse> GetBucketNotificationAsync(GetBucketNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketNotificationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketNotificationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketPolicy

        internal virtual GetBucketPolicyResponse GetBucketPolicy(GetBucketPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<GetBucketPolicyResponse>(request, options);
        }


        /// <summary>
        /// Returns the policy of a specified bucket. If you are using an identity other than
        /// the root user of the AWS account that owns the bucket, the calling identity must have
        /// the <code>GetBucketPolicy</code> permissions on the specified bucket and belong to
        /// the bucket owner's account in order to use this operation.
        /// 
        ///  
        /// <para>
        /// If you don't have <code>GetBucketPolicy</code> permissions, Amazon S3 returns a <code>403
        /// Access Denied</code> error. If you have the correct permissions, but you're not using
        /// an identity that belongs to the bucket owner's account, Amazon S3 returns a <code>405
        /// Method Not Allowed</code> error.
        /// </para>
        ///  <important> 
        /// <para>
        /// As a security precaution, the root user of the AWS account that owns a bucket can
        /// always use this operation, even if the policy explicitly denies the root user the
        /// ability to perform this action.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about bucket policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
        /// Bucket Policies and User Policies</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operation is related to <code>GetBucketPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name for which to get the bucket policy.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketPolicy service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketPolicy">REST API Reference for GetBucketPolicy Operation</seealso>
        public virtual Task<GetBucketPolicyResponse> GetBucketPolicyAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketPolicyRequest();
            request.BucketName = bucketName;
            return GetBucketPolicyAsync(request, cancellationToken);
        }



        /// <summary>
        /// Returns the policy of a specified bucket. If you are using an identity other than
        /// the root user of the AWS account that owns the bucket, the calling identity must have
        /// the <code>GetBucketPolicy</code> permissions on the specified bucket and belong to
        /// the bucket owner's account in order to use this operation.
        /// 
        ///  
        /// <para>
        /// If you don't have <code>GetBucketPolicy</code> permissions, Amazon S3 returns a <code>403
        /// Access Denied</code> error. If you have the correct permissions, but you're not using
        /// an identity that belongs to the bucket owner's account, Amazon S3 returns a <code>405
        /// Method Not Allowed</code> error.
        /// </para>
        ///  <important> 
        /// <para>
        /// As a security precaution, the root user of the AWS account that owns a bucket can
        /// always use this operation, even if the policy explicitly denies the root user the
        /// ability to perform this action.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about bucket policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
        /// Bucket Policies and User Policies</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operation is related to <code>GetBucketPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketPolicy service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketPolicy">REST API Reference for GetBucketPolicy Operation</seealso>
        public virtual Task<GetBucketPolicyResponse> GetBucketPolicyAsync(GetBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketPolicyStatus

        internal virtual GetBucketPolicyStatusResponse GetBucketPolicyStatus(GetBucketPolicyStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketPolicyStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketPolicyStatusResponseUnmarshaller.Instance;

            return Invoke<GetBucketPolicyStatusResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the policy status for an Amazon S3 bucket, indicating whether the bucket
        /// is public. In order to use this operation, you must have the <code>s3:GetBucketPolicyStatus</code>
        /// permission. For more information about Amazon S3 permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
        /// Permissions in a Policy</a>.
        /// 
        ///  
        /// <para>
        ///  For more information about when Amazon S3 considers a bucket public, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html#access-control-block-public-access-policy-status">The
        /// Meaning of "Public"</a>. 
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>GetBucketPolicyStatus</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html">Using
        /// Amazon S3 Block Public Access</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetPublicAccessBlock</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutPublicAccessBlock</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeletePublicAccessBlock</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketPolicyStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketPolicyStatus service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketPolicyStatus">REST API Reference for GetBucketPolicyStatus Operation</seealso>
        public virtual Task<GetBucketPolicyStatusResponse> GetBucketPolicyStatusAsync(GetBucketPolicyStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketPolicyStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketPolicyStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketPolicyStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketReplication

        internal virtual GetBucketReplicationResponse GetBucketReplication(GetBucketReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketReplicationResponseUnmarshaller.Instance;

            return Invoke<GetBucketReplicationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the replication configuration for the given Amazon S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketReplication service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketReplication">REST API Reference for GetBucketReplication Operation</seealso>
        public virtual Task<GetBucketReplicationResponse> GetBucketReplicationAsync(GetBucketReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketReplicationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketReplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketRequestPayment

        internal virtual GetBucketRequestPaymentResponse GetBucketRequestPayment(GetBucketRequestPaymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketRequestPaymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketRequestPaymentResponseUnmarshaller.Instance;

            return Invoke<GetBucketRequestPaymentResponse>(request, options);
        }


        /// <summary>
        /// Returns the request payment configuration of a bucket. To use this version of the
        /// operation, you must be the bucket owner. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RequesterPaysBuckets.html">Requester
        /// Pays Buckets</a>.
        /// 
        ///  
        /// <para>
        /// The following operations are related to <code>GetBucketRequestPayment</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListObjects</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The name of the bucket for which to get the payment request configuration</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketRequestPayment service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketRequestPayment">REST API Reference for GetBucketRequestPayment Operation</seealso>
        public virtual Task<GetBucketRequestPaymentResponse> GetBucketRequestPaymentAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketRequestPaymentRequest();
            request.BucketName = bucketName;
            return GetBucketRequestPaymentAsync(request, cancellationToken);
        }



        /// <summary>
        /// Returns the request payment configuration of a bucket. To use this version of the
        /// operation, you must be the bucket owner. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RequesterPaysBuckets.html">Requester
        /// Pays Buckets</a>.
        /// 
        ///  
        /// <para>
        /// The following operations are related to <code>GetBucketRequestPayment</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListObjects</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketRequestPayment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketRequestPayment service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketRequestPayment">REST API Reference for GetBucketRequestPayment Operation</seealso>
        public virtual Task<GetBucketRequestPaymentResponse> GetBucketRequestPaymentAsync(GetBucketRequestPaymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketRequestPaymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketRequestPaymentResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketRequestPaymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketTagging

        internal virtual GetBucketTaggingResponse GetBucketTagging(GetBucketTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketTaggingResponseUnmarshaller.Instance;

            return Invoke<GetBucketTaggingResponse>(request, options);
        }



        /// <summary>
        /// Returns the tag set associated with the bucket.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <code>s3:GetBucketTagging</code>
        /// action. By default, the bucket owner has this permission and can grant this permission
        /// to others.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetBucketTagging</code> has the following special error:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Error code: <code>NoSuchTagSetError</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: There is no tag set associated with the bucket.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// The following operations are related to <code>GetBucketTagging</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketTagging</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketTagging</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketTagging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketTagging service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketTagging">REST API Reference for GetBucketTagging Operation</seealso>
        public virtual Task<GetBucketTaggingResponse> GetBucketTaggingAsync(GetBucketTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketTaggingResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketTaggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketVersioning

        internal virtual GetBucketVersioningResponse GetBucketVersioning(GetBucketVersioningRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketVersioningRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketVersioningResponseUnmarshaller.Instance;

            return Invoke<GetBucketVersioningResponse>(request, options);
        }


        /// <summary>
        /// Returns the versioning state of a bucket.
        /// 
        ///  
        /// <para>
        /// To retrieve the versioning state of a bucket, you must be the bucket owner.
        /// </para>
        ///  
        /// <para>
        /// This implementation also returns the MFA Delete status of the versioning state. If
        /// the MFA Delete status is <code>enabled</code>, the bucket owner must use an authentication
        /// device to change the versioning state of the bucket.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>GetBucketVersioning</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteObject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The name of the bucket for which to get the versioning information.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketVersioning service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketVersioning">REST API Reference for GetBucketVersioning Operation</seealso>
        public virtual Task<GetBucketVersioningResponse> GetBucketVersioningAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketVersioningRequest();
            request.BucketName = bucketName;
            return GetBucketVersioningAsync(request, cancellationToken);
        }



        /// <summary>
        /// Returns the versioning state of a bucket.
        /// 
        ///  
        /// <para>
        /// To retrieve the versioning state of a bucket, you must be the bucket owner.
        /// </para>
        ///  
        /// <para>
        /// This implementation also returns the MFA Delete status of the versioning state. If
        /// the MFA Delete status is <code>enabled</code>, the bucket owner must use an authentication
        /// device to change the versioning state of the bucket.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>GetBucketVersioning</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteObject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketVersioning service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketVersioning service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketVersioning">REST API Reference for GetBucketVersioning Operation</seealso>
        public virtual Task<GetBucketVersioningResponse> GetBucketVersioningAsync(GetBucketVersioningRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketVersioningRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketVersioningResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketVersioningResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketWebsite

        internal virtual GetBucketWebsiteResponse GetBucketWebsite(GetBucketWebsiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketWebsiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketWebsiteResponseUnmarshaller.Instance;

            return Invoke<GetBucketWebsiteResponse>(request, options);
        }


        /// <summary>
        /// Returns the website configuration for a bucket. To host website on Amazon S3, you
        /// can configure a bucket as website by adding a website configuration. For more information
        /// about hosting websites, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/WebsiteHosting.html">Hosting
        /// Websites on Amazon S3</a>. 
        /// 
        ///  
        /// <para>
        /// This GET operation requires the <code>S3:GetBucketWebsite</code> permission. By default,
        /// only the bucket owner can read the bucket website configuration. However, bucket owners
        /// can allow other users to read the website configuration by writing a bucket policy
        /// granting them the <code>S3:GetBucketWebsite</code> permission.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>DeleteBucketWebsite</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DeleteBucketWebsite</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutBucketWebsite</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name for which to get the website configuration.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketWebsite service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketWebsite">REST API Reference for GetBucketWebsite Operation</seealso>
        public virtual Task<GetBucketWebsiteResponse> GetBucketWebsiteAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketWebsiteRequest();
            request.BucketName = bucketName;
            return GetBucketWebsiteAsync(request, cancellationToken);
        }



        /// <summary>
        /// Returns the website configuration for a bucket. To host website on Amazon S3, you
        /// can configure a bucket as website by adding a website configuration. For more information
        /// about hosting websites, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/WebsiteHosting.html">Hosting
        /// Websites on Amazon S3</a>. 
        /// 
        ///  
        /// <para>
        /// This GET operation requires the <code>S3:GetBucketWebsite</code> permission. By default,
        /// only the bucket owner can read the bucket website configuration. However, bucket owners
        /// can allow other users to read the website configuration by writing a bucket policy
        /// granting them the <code>S3:GetBucketWebsite</code> permission.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>DeleteBucketWebsite</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DeleteBucketWebsite</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutBucketWebsite</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketWebsite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketWebsite service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketWebsite">REST API Reference for GetBucketWebsite Operation</seealso>
        public virtual Task<GetBucketWebsiteResponse> GetBucketWebsiteAsync(GetBucketWebsiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketWebsiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketWebsiteResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketWebsiteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCORSConfiguration

        internal virtual GetCORSConfigurationResponse GetCORSConfiguration(GetCORSConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCORSConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCORSConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetCORSConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Returns the cors configuration information set for the bucket.
        /// 
        ///  
        /// <para>
        ///  To use this operation, you must have permission to perform the s3:GetBucketCORS action.
        /// By default, the bucket owner has this permission and can grant it to others.
        /// </para>
        ///  
        /// <para>
        ///  For more information about cors, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/cors.html">
        /// Enabling Cross-Origin Resource Sharing</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>GetBucketCors</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketCors</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketCors</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name for which to get the cors configuration.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCORSConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketCors">REST API Reference for GetCORSConfiguration Operation</seealso>
        public virtual Task<GetCORSConfigurationResponse> GetCORSConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetCORSConfigurationRequest();
            request.BucketName = bucketName;
            return GetCORSConfigurationAsync(request, cancellationToken);
        }



        /// <summary>
        /// Returns the cors configuration information set for the bucket.
        /// 
        ///  
        /// <para>
        ///  To use this operation, you must have permission to perform the s3:GetBucketCORS action.
        /// By default, the bucket owner has this permission and can grant it to others.
        /// </para>
        ///  
        /// <para>
        ///  For more information about cors, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/cors.html">
        /// Enabling Cross-Origin Resource Sharing</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>GetBucketCors</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketCors</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketCors</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCORSConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCORSConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketCors">REST API Reference for GetCORSConfiguration Operation</seealso>
        public virtual Task<GetCORSConfigurationResponse> GetCORSConfigurationAsync(GetCORSConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCORSConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCORSConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetCORSConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLifecycleConfiguration

        internal virtual GetLifecycleConfigurationResponse GetLifecycleConfiguration(GetLifecycleConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecycleConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetLifecycleConfigurationResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// Bucket lifecycle configuration now supports specifying a lifecycle rule using an object
        /// key name prefix, one or more object tags, or a combination of both. Accordingly, this
        /// section describes the latest API. The response describes the new filter element that
        /// you can use to specify a filter to select a subset of objects to which the rule applies.
        /// If you are still using previous version of the lifecycle configuration, it works.
        /// For the earlier API description, see <a>GetBucketLifecycle</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the lifecycle configuration information set on the bucket. For information
        /// about lifecycle configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html">Object
        /// Lifecycle Management</a>.
        /// </para>
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <code>s3:GetLifecycleConfiguration</code>
        /// action. The bucket owner has this permission, by default. The bucket owner can grant
        /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetBucketLifecycleConfiguration</code> has the following special error:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Error code: <code>NoSuchLifecycleConfiguration</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The lifecycle configuration does not exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HTTP Status Code: 404 Not Found
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SOAP Fault Code Prefix: Client
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// The following operations are related to <code>GetBucketLifecycleConfiguration</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketLifecycle</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutBucketLifecycle</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketLifecycle</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The name of the bucket for which to get the lifecycle information.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLifecycleConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketLifecycleConfiguration">REST API Reference for GetLifecycleConfiguration Operation</seealso>
        public virtual Task<GetLifecycleConfigurationResponse> GetLifecycleConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetLifecycleConfigurationRequest();
            request.BucketName = bucketName;
            return GetLifecycleConfigurationAsync(request, cancellationToken);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// Bucket lifecycle configuration now supports specifying a lifecycle rule using an object
        /// key name prefix, one or more object tags, or a combination of both. Accordingly, this
        /// section describes the latest API. The response describes the new filter element that
        /// you can use to specify a filter to select a subset of objects to which the rule applies.
        /// If you are still using previous version of the lifecycle configuration, it works.
        /// For the earlier API description, see <a>GetBucketLifecycle</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the lifecycle configuration information set on the bucket. For information
        /// about lifecycle configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html">Object
        /// Lifecycle Management</a>.
        /// </para>
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <code>s3:GetLifecycleConfiguration</code>
        /// action. The bucket owner has this permission, by default. The bucket owner can grant
        /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetBucketLifecycleConfiguration</code> has the following special error:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Error code: <code>NoSuchLifecycleConfiguration</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The lifecycle configuration does not exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HTTP Status Code: 404 Not Found
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SOAP Fault Code Prefix: Client
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// The following operations are related to <code>GetBucketLifecycleConfiguration</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketLifecycle</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutBucketLifecycle</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketLifecycle</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLifecycleConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLifecycleConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetBucketLifecycleConfiguration">REST API Reference for GetLifecycleConfiguration Operation</seealso>
        public virtual Task<GetLifecycleConfigurationResponse> GetLifecycleConfigurationAsync(GetLifecycleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecycleConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetLifecycleConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetObject

        internal virtual GetObjectResponse GetObject(GetObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectResponseUnmarshaller.Instance;

            return Invoke<GetObjectResponse>(request, options);
        }


        /// <summary>
        /// Retrieves objects from Amazon S3. To use <code>GET</code>, you must have <code>READ</code>
        /// access to the object. If you grant <code>READ</code> access to the anonymous user,
        /// you can return the object without using an authorization header.
        /// 
        ///  
        /// <para>
        /// An Amazon S3 bucket has no directory hierarchy such as you would find in a typical
        /// computer file system. You can, however, create a logical hierarchy by using object
        /// key names that imply a folder structure. For example, instead of naming an object
        /// <code>sample.jpg</code>, you can name it <code>photos/2006/February/sample.jpg</code>.
        /// </para>
        ///  
        /// <para>
        /// To get an object from such a logical hierarchy, specify the full key name for the
        /// object in the <code>GET</code> operation. For a virtual hosted-style request example,
        /// if you have the object <code>photos/2006/February/sample.jpg</code>, specify the resource
        /// as <code>/photos/2006/February/sample.jpg</code>. For a path-style request example,
        /// if you have the object <code>photos/2006/February/sample.jpg</code> in the bucket
        /// named <code>examplebucket</code>, specify the resource as <code>/examplebucket/photos/2006/February/sample.jpg</code>.
        /// For more information about request types, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/VirtualHosting.html#VirtualHostingSpecifyBucket">HTTP
        /// Host Header Bucket Specification</a>.
        /// </para>
        ///  
        /// <para>
        /// To distribute large files to many people, you can save bandwidth costs by using BitTorrent.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3Torrent.html">Amazon
        /// S3 Torrent</a>. For more information about returning the ACL of an object, see <a>GetObjectAcl</a>.
        /// </para>
        ///  
        /// <para>
        /// If the object you are retrieving is stored in the GLACIER or DEEP_ARCHIVE storage
        /// classes, before you can retrieve the object you must first restore a copy using .
        /// Otherwise, this operation returns an <code>InvalidObjectStateError</code> error. For
        /// information about restoring archived objects, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html">Restoring
        /// Archived Objects</a>.
        /// </para>
        ///  
        /// <para>
        /// Encryption request headers, like <code>x-amz-server-side-encryption</code>, should
        /// not be sent for GET requests if your object uses server-side encryption with CMKs
        /// stored in AWS KMS (SSE-KMS) or server-side encryption with Amazon S3–managed encryption
        /// keys (SSE-S3). If your object does use these types of keys, you’ll get an HTTP 400
        /// BadRequest error.
        /// </para>
        ///  
        /// <para>
        /// If you encrypt an object by using server-side encryption with customer-provided encryption
        /// keys (SSE-C) when you store the object in Amazon S3, then when you GET the object,
        /// you must use the following headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-algorithm
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key-MD5
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about SSE-C, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Server-Side
        /// Encryption (Using Customer-Provided Encryption Keys)</a>.
        /// </para>
        ///  
        /// <para>
        /// Assuming you have permission to read object tags (permission for the <code>s3:GetObjectVersionTagging</code>
        /// action), the response also returns the <code>x-amz-tagging-count</code> header that
        /// provides the count of number of tags associated with the object. You can use <a>GetObjectTagging</a>
        /// to retrieve the tag set associated with an object.
        /// </para>
        ///  
        /// <para>
        ///  <b>Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// You need the <code>s3:GetObject</code> permission for this operation. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
        /// Permissions in a Policy</a>. If the object you request does not exist, the error Amazon
        /// S3 returns depends on whether you also have the <code>s3:ListBucket</code> permission.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you have the <code>s3:ListBucket</code> permission on the bucket, Amazon S3 will
        /// return an HTTP status code 404 ("no such key") error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don’t have the <code>s3:ListBucket</code> permission, Amazon S3 will return
        /// an HTTP status code 403 ("access denied") error.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Versioning</b> 
        /// </para>
        ///  
        /// <para>
        /// By default, the GET operation returns the current version of an object. To return
        /// a different version, use the <code>versionId</code> subresource.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the current version of the object is a delete marker, Amazon S3 behaves as if the
        /// object was deleted and includes <code>x-amz-delete-marker: true</code> in the response.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about versioning, see <a>PutBucketVersioning</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Overriding Response Header Values</b> 
        /// </para>
        ///  
        /// <para>
        /// There are times when you want to override certain response header values in a GET
        /// response. For example, you might override the Content-Disposition response header
        /// value in your GET request.
        /// </para>
        ///  
        /// <para>
        /// You can override values for a set of response headers using the following query parameters.
        /// These response header values are sent only on a successful request, that is, when
        /// status code 200 OK is returned. The set of headers you can override using these parameters
        /// is a subset of the headers that Amazon S3 accepts when you create an object. The response
        /// headers that you can override for the GET response are <code>Content-Type</code>,
        /// <code>Content-Language</code>, <code>Expires</code>, <code>Cache-Control</code>, <code>Content-Disposition</code>,
        /// and <code>Content-Encoding</code>. To override these header values in the GET response,
        /// you use the following request parameters.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must sign the request, either using an Authorization header or a presigned URL,
        /// when using these parameters. They cannot be used with an unsigned (anonymous) request.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  <code>response-content-type</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-content-language</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-expires</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-cache-control</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-content-disposition</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-content-encoding</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Additional Considerations about Request Headers</b> 
        /// </para>
        ///  
        /// <para>
        /// If both of the <code>If-Match</code> and <code>If-Unmodified-Since</code> headers
        /// are present in the request as follows: <code>If-Match</code> condition evaluates to
        /// <code>true</code>, and; <code>If-Unmodified-Since</code> condition evaluates to <code>false</code>;
        /// then, S3 returns 200 OK and the data requested. 
        /// </para>
        ///  
        /// <para>
        /// If both of the <code>If-None-Match</code> and <code>If-Modified-Since</code> headers
        /// are present in the request as follows:<code> If-None-Match</code> condition evaluates
        /// to <code>false</code>, and; <code>If-Modified-Since</code> condition evaluates to
        /// <code>true</code>; then, S3 returns 304 Not Modified response code.
        /// </para>
        ///  
        /// <para>
        /// For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC
        /// 7232</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>GetObject</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListBuckets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetObjectAcl</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name containing the object.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="key">Key of the object to get.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetObject">REST API Reference for GetObject Operation</seealso>
        public virtual Task<GetObjectResponse> GetObjectAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return GetObjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Retrieves objects from Amazon S3. To use <code>GET</code>, you must have <code>READ</code>
        /// access to the object. If you grant <code>READ</code> access to the anonymous user,
        /// you can return the object without using an authorization header.
        /// 
        ///  
        /// <para>
        /// An Amazon S3 bucket has no directory hierarchy such as you would find in a typical
        /// computer file system. You can, however, create a logical hierarchy by using object
        /// key names that imply a folder structure. For example, instead of naming an object
        /// <code>sample.jpg</code>, you can name it <code>photos/2006/February/sample.jpg</code>.
        /// </para>
        ///  
        /// <para>
        /// To get an object from such a logical hierarchy, specify the full key name for the
        /// object in the <code>GET</code> operation. For a virtual hosted-style request example,
        /// if you have the object <code>photos/2006/February/sample.jpg</code>, specify the resource
        /// as <code>/photos/2006/February/sample.jpg</code>. For a path-style request example,
        /// if you have the object <code>photos/2006/February/sample.jpg</code> in the bucket
        /// named <code>examplebucket</code>, specify the resource as <code>/examplebucket/photos/2006/February/sample.jpg</code>.
        /// For more information about request types, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/VirtualHosting.html#VirtualHostingSpecifyBucket">HTTP
        /// Host Header Bucket Specification</a>.
        /// </para>
        ///  
        /// <para>
        /// To distribute large files to many people, you can save bandwidth costs by using BitTorrent.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3Torrent.html">Amazon
        /// S3 Torrent</a>. For more information about returning the ACL of an object, see <a>GetObjectAcl</a>.
        /// </para>
        ///  
        /// <para>
        /// If the object you are retrieving is stored in the GLACIER or DEEP_ARCHIVE storage
        /// classes, before you can retrieve the object you must first restore a copy using .
        /// Otherwise, this operation returns an <code>InvalidObjectStateError</code> error. For
        /// information about restoring archived objects, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html">Restoring
        /// Archived Objects</a>.
        /// </para>
        ///  
        /// <para>
        /// Encryption request headers, like <code>x-amz-server-side-encryption</code>, should
        /// not be sent for GET requests if your object uses server-side encryption with CMKs
        /// stored in AWS KMS (SSE-KMS) or server-side encryption with Amazon S3–managed encryption
        /// keys (SSE-S3). If your object does use these types of keys, you’ll get an HTTP 400
        /// BadRequest error.
        /// </para>
        ///  
        /// <para>
        /// If you encrypt an object by using server-side encryption with customer-provided encryption
        /// keys (SSE-C) when you store the object in Amazon S3, then when you GET the object,
        /// you must use the following headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-algorithm
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key-MD5
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about SSE-C, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Server-Side
        /// Encryption (Using Customer-Provided Encryption Keys)</a>.
        /// </para>
        ///  
        /// <para>
        /// Assuming you have permission to read object tags (permission for the <code>s3:GetObjectVersionTagging</code>
        /// action), the response also returns the <code>x-amz-tagging-count</code> header that
        /// provides the count of number of tags associated with the object. You can use <a>GetObjectTagging</a>
        /// to retrieve the tag set associated with an object.
        /// </para>
        ///  
        /// <para>
        ///  <b>Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// You need the <code>s3:GetObject</code> permission for this operation. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
        /// Permissions in a Policy</a>. If the object you request does not exist, the error Amazon
        /// S3 returns depends on whether you also have the <code>s3:ListBucket</code> permission.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you have the <code>s3:ListBucket</code> permission on the bucket, Amazon S3 will
        /// return an HTTP status code 404 ("no such key") error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don’t have the <code>s3:ListBucket</code> permission, Amazon S3 will return
        /// an HTTP status code 403 ("access denied") error.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Versioning</b> 
        /// </para>
        ///  
        /// <para>
        /// By default, the GET operation returns the current version of an object. To return
        /// a different version, use the <code>versionId</code> subresource.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the current version of the object is a delete marker, Amazon S3 behaves as if the
        /// object was deleted and includes <code>x-amz-delete-marker: true</code> in the response.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about versioning, see <a>PutBucketVersioning</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Overriding Response Header Values</b> 
        /// </para>
        ///  
        /// <para>
        /// There are times when you want to override certain response header values in a GET
        /// response. For example, you might override the Content-Disposition response header
        /// value in your GET request.
        /// </para>
        ///  
        /// <para>
        /// You can override values for a set of response headers using the following query parameters.
        /// These response header values are sent only on a successful request, that is, when
        /// status code 200 OK is returned. The set of headers you can override using these parameters
        /// is a subset of the headers that Amazon S3 accepts when you create an object. The response
        /// headers that you can override for the GET response are <code>Content-Type</code>,
        /// <code>Content-Language</code>, <code>Expires</code>, <code>Cache-Control</code>, <code>Content-Disposition</code>,
        /// and <code>Content-Encoding</code>. To override these header values in the GET response,
        /// you use the following request parameters.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must sign the request, either using an Authorization header or a presigned URL,
        /// when using these parameters. They cannot be used with an unsigned (anonymous) request.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  <code>response-content-type</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-content-language</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-expires</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-cache-control</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-content-disposition</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-content-encoding</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Additional Considerations about Request Headers</b> 
        /// </para>
        ///  
        /// <para>
        /// If both of the <code>If-Match</code> and <code>If-Unmodified-Since</code> headers
        /// are present in the request as follows: <code>If-Match</code> condition evaluates to
        /// <code>true</code>, and; <code>If-Unmodified-Since</code> condition evaluates to <code>false</code>;
        /// then, S3 returns 200 OK and the data requested. 
        /// </para>
        ///  
        /// <para>
        /// If both of the <code>If-None-Match</code> and <code>If-Modified-Since</code> headers
        /// are present in the request as follows:<code> If-None-Match</code> condition evaluates
        /// to <code>false</code>, and; <code>If-Modified-Since</code> condition evaluates to
        /// <code>true</code>; then, S3 returns 304 Not Modified response code.
        /// </para>
        ///  
        /// <para>
        /// For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC
        /// 7232</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>GetObject</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListBuckets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetObjectAcl</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name containing the object.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="key">Key of the object to get.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetObject">REST API Reference for GetObject Operation</seealso>
        public virtual Task<GetObjectResponse> GetObjectAsync(string bucketName, string key, string versionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            return GetObjectAsync(request, cancellationToken);
        }



        /// <summary>
        /// Retrieves objects from Amazon S3. To use <code>GET</code>, you must have <code>READ</code>
        /// access to the object. If you grant <code>READ</code> access to the anonymous user,
        /// you can return the object without using an authorization header.
        /// 
        ///  
        /// <para>
        /// An Amazon S3 bucket has no directory hierarchy such as you would find in a typical
        /// computer file system. You can, however, create a logical hierarchy by using object
        /// key names that imply a folder structure. For example, instead of naming an object
        /// <code>sample.jpg</code>, you can name it <code>photos/2006/February/sample.jpg</code>.
        /// </para>
        ///  
        /// <para>
        /// To get an object from such a logical hierarchy, specify the full key name for the
        /// object in the <code>GET</code> operation. For a virtual hosted-style request example,
        /// if you have the object <code>photos/2006/February/sample.jpg</code>, specify the resource
        /// as <code>/photos/2006/February/sample.jpg</code>. For a path-style request example,
        /// if you have the object <code>photos/2006/February/sample.jpg</code> in the bucket
        /// named <code>examplebucket</code>, specify the resource as <code>/examplebucket/photos/2006/February/sample.jpg</code>.
        /// For more information about request types, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/VirtualHosting.html#VirtualHostingSpecifyBucket">HTTP
        /// Host Header Bucket Specification</a>.
        /// </para>
        ///  
        /// <para>
        /// To distribute large files to many people, you can save bandwidth costs by using BitTorrent.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3Torrent.html">Amazon
        /// S3 Torrent</a>. For more information about returning the ACL of an object, see <a>GetObjectAcl</a>.
        /// </para>
        ///  
        /// <para>
        /// If the object you are retrieving is stored in the GLACIER or DEEP_ARCHIVE storage
        /// classes, before you can retrieve the object you must first restore a copy using .
        /// Otherwise, this operation returns an <code>InvalidObjectStateError</code> error. For
        /// information about restoring archived objects, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html">Restoring
        /// Archived Objects</a>.
        /// </para>
        ///  
        /// <para>
        /// Encryption request headers, like <code>x-amz-server-side-encryption</code>, should
        /// not be sent for GET requests if your object uses server-side encryption with CMKs
        /// stored in AWS KMS (SSE-KMS) or server-side encryption with Amazon S3–managed encryption
        /// keys (SSE-S3). If your object does use these types of keys, you’ll get an HTTP 400
        /// BadRequest error.
        /// </para>
        ///  
        /// <para>
        /// If you encrypt an object by using server-side encryption with customer-provided encryption
        /// keys (SSE-C) when you store the object in Amazon S3, then when you GET the object,
        /// you must use the following headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-algorithm
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key-MD5
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about SSE-C, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Server-Side
        /// Encryption (Using Customer-Provided Encryption Keys)</a>.
        /// </para>
        ///  
        /// <para>
        /// Assuming you have permission to read object tags (permission for the <code>s3:GetObjectVersionTagging</code>
        /// action), the response also returns the <code>x-amz-tagging-count</code> header that
        /// provides the count of number of tags associated with the object. You can use <a>GetObjectTagging</a>
        /// to retrieve the tag set associated with an object.
        /// </para>
        ///  
        /// <para>
        ///  <b>Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// You need the <code>s3:GetObject</code> permission for this operation. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
        /// Permissions in a Policy</a>. If the object you request does not exist, the error Amazon
        /// S3 returns depends on whether you also have the <code>s3:ListBucket</code> permission.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you have the <code>s3:ListBucket</code> permission on the bucket, Amazon S3 will
        /// return an HTTP status code 404 ("no such key") error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don’t have the <code>s3:ListBucket</code> permission, Amazon S3 will return
        /// an HTTP status code 403 ("access denied") error.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Versioning</b> 
        /// </para>
        ///  
        /// <para>
        /// By default, the GET operation returns the current version of an object. To return
        /// a different version, use the <code>versionId</code> subresource.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the current version of the object is a delete marker, Amazon S3 behaves as if the
        /// object was deleted and includes <code>x-amz-delete-marker: true</code> in the response.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about versioning, see <a>PutBucketVersioning</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Overriding Response Header Values</b> 
        /// </para>
        ///  
        /// <para>
        /// There are times when you want to override certain response header values in a GET
        /// response. For example, you might override the Content-Disposition response header
        /// value in your GET request.
        /// </para>
        ///  
        /// <para>
        /// You can override values for a set of response headers using the following query parameters.
        /// These response header values are sent only on a successful request, that is, when
        /// status code 200 OK is returned. The set of headers you can override using these parameters
        /// is a subset of the headers that Amazon S3 accepts when you create an object. The response
        /// headers that you can override for the GET response are <code>Content-Type</code>,
        /// <code>Content-Language</code>, <code>Expires</code>, <code>Cache-Control</code>, <code>Content-Disposition</code>,
        /// and <code>Content-Encoding</code>. To override these header values in the GET response,
        /// you use the following request parameters.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must sign the request, either using an Authorization header or a presigned URL,
        /// when using these parameters. They cannot be used with an unsigned (anonymous) request.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  <code>response-content-type</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-content-language</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-expires</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-cache-control</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-content-disposition</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-content-encoding</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Additional Considerations about Request Headers</b> 
        /// </para>
        ///  
        /// <para>
        /// If both of the <code>If-Match</code> and <code>If-Unmodified-Since</code> headers
        /// are present in the request as follows: <code>If-Match</code> condition evaluates to
        /// <code>true</code>, and; <code>If-Unmodified-Since</code> condition evaluates to <code>false</code>;
        /// then, S3 returns 200 OK and the data requested. 
        /// </para>
        ///  
        /// <para>
        /// If both of the <code>If-None-Match</code> and <code>If-Modified-Since</code> headers
        /// are present in the request as follows:<code> If-None-Match</code> condition evaluates
        /// to <code>false</code>, and; <code>If-Modified-Since</code> condition evaluates to
        /// <code>true</code>; then, S3 returns 304 Not Modified response code.
        /// </para>
        ///  
        /// <para>
        /// For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC
        /// 7232</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>GetObject</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListBuckets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetObjectAcl</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetObject">REST API Reference for GetObject Operation</seealso>
        public virtual Task<GetObjectResponse> GetObjectAsync(GetObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetObjectLegalHold

        internal virtual GetObjectLegalHoldResponse GetObjectLegalHold(GetObjectLegalHoldRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectLegalHoldResponseUnmarshaller.Instance;

            return Invoke<GetObjectLegalHoldResponse>(request, options);
        }



        /// <summary>
        /// Gets an object's current Legal Hold status. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lock.html">Locking
        /// Objects</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectLegalHold service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectLegalHold service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetObjectLegalHold">REST API Reference for GetObjectLegalHold Operation</seealso>
        public virtual Task<GetObjectLegalHoldResponse> GetObjectLegalHoldAsync(GetObjectLegalHoldRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectLegalHoldResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectLegalHoldResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetObjectLockConfiguration

        internal virtual GetObjectLockConfigurationResponse GetObjectLockConfiguration(GetObjectLockConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectLockConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectLockConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetObjectLockConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Gets the Object Lock configuration for a bucket. The rule specified in the Object
        /// Lock configuration will be applied by default to every new object placed in the specified
        /// bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lock.html">Locking
        /// Objects</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectLockConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectLockConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetObjectLockConfiguration">REST API Reference for GetObjectLockConfiguration Operation</seealso>
        public virtual Task<GetObjectLockConfigurationResponse> GetObjectLockConfigurationAsync(GetObjectLockConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectLockConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectLockConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectLockConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetObjectMetadata

        internal virtual GetObjectMetadataResponse GetObjectMetadata(GetObjectMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectMetadataResponseUnmarshaller.Instance;

            return Invoke<GetObjectMetadataResponse>(request, options);
        }


        /// <summary>
        /// The HEAD operation retrieves metadata from an object without returning the object
        /// itself. This operation is useful if you're only interested in an object's metadata.
        /// To use HEAD, you must have READ access to the object.
        /// 
        ///  
        /// <para>
        /// A <code>HEAD</code> request has the same options as a <code>GET</code> operation on
        /// an object. The response is identical to the <code>GET</code> response except that
        /// there is no response body.
        /// </para>
        ///  
        /// <para>
        /// If you encrypt an object by using server-side encryption with customer-provided encryption
        /// keys (SSE-C) when you store the object in Amazon S3, then when you retrieve the metadata
        /// from the object, you must use the following headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-algorithm
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key-MD5
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about SSE-C, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Server-Side
        /// Encryption (Using Customer-Provided Encryption Keys)</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Encryption request headers, like <code>x-amz-server-side-encryption</code>, should
        /// not be sent for GET requests if your object uses server-side encryption with CMKs
        /// stored in AWS KMS (SSE-KMS) or server-side encryption with Amazon S3–managed encryption
        /// keys (SSE-S3). If your object does use these types of keys, you’ll get an HTTP 400
        /// BadRequest error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Request headers are limited to 8 KB in size. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTCommonRequestHeaders.html">Common
        /// Request Headers</a>.
        /// </para>
        ///  
        /// <para>
        /// Consider the following when using request headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Consideration 1 – If both of the <code>If-Match</code> and <code>If-Unmodified-Since</code>
        /// headers are present in the request as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>If-Match</code> condition evaluates to <code>true</code>, and;
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>If-Unmodified-Since</code> condition evaluates to <code>false</code>;
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Then Amazon S3 returns <code>200 OK</code> and the data requested.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Consideration 2 – If both of the <code>If-None-Match</code> and <code>If-Modified-Since</code>
        /// headers are present in the request as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>If-None-Match</code> condition evaluates to <code>false</code>, and;
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>If-Modified-Since</code> condition evaluates to <code>true</code>;
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Then Amazon S3 returns the <code>304 Not Modified</code> response code.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC
        /// 7232</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// You need the <code>s3:GetObject</code> permission for this operation. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
        /// Permissions in a Policy</a>. If the object you request does not exist, the error Amazon
        /// S3 returns depends on whether you also have the s3:ListBucket permission.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you have the <code>s3:ListBucket</code> permission on the bucket, Amazon S3 returns
        /// an HTTP status code 404 ("no such key") error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don’t have the <code>s3:ListBucket</code> permission, Amazon S3 returns an
        /// HTTP status code 403 ("access denied") error.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following operation is related to <code>HeadObject</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The name of the bucket containing the object.</param>
        /// <param name="key">The object key.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectMetadata service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/HeadObject">REST API Reference for GetObjectMetadata Operation</seealso>
        public virtual Task<GetObjectMetadataResponse> GetObjectMetadataAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetObjectMetadataRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return GetObjectMetadataAsync(request, cancellationToken);
        }


        /// <summary>
        /// The HEAD operation retrieves metadata from an object without returning the object
        /// itself. This operation is useful if you're only interested in an object's metadata.
        /// To use HEAD, you must have READ access to the object.
        /// 
        ///  
        /// <para>
        /// A <code>HEAD</code> request has the same options as a <code>GET</code> operation on
        /// an object. The response is identical to the <code>GET</code> response except that
        /// there is no response body.
        /// </para>
        ///  
        /// <para>
        /// If you encrypt an object by using server-side encryption with customer-provided encryption
        /// keys (SSE-C) when you store the object in Amazon S3, then when you retrieve the metadata
        /// from the object, you must use the following headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-algorithm
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key-MD5
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about SSE-C, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Server-Side
        /// Encryption (Using Customer-Provided Encryption Keys)</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Encryption request headers, like <code>x-amz-server-side-encryption</code>, should
        /// not be sent for GET requests if your object uses server-side encryption with CMKs
        /// stored in AWS KMS (SSE-KMS) or server-side encryption with Amazon S3–managed encryption
        /// keys (SSE-S3). If your object does use these types of keys, you’ll get an HTTP 400
        /// BadRequest error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Request headers are limited to 8 KB in size. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTCommonRequestHeaders.html">Common
        /// Request Headers</a>.
        /// </para>
        ///  
        /// <para>
        /// Consider the following when using request headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Consideration 1 – If both of the <code>If-Match</code> and <code>If-Unmodified-Since</code>
        /// headers are present in the request as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>If-Match</code> condition evaluates to <code>true</code>, and;
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>If-Unmodified-Since</code> condition evaluates to <code>false</code>;
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Then Amazon S3 returns <code>200 OK</code> and the data requested.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Consideration 2 – If both of the <code>If-None-Match</code> and <code>If-Modified-Since</code>
        /// headers are present in the request as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>If-None-Match</code> condition evaluates to <code>false</code>, and;
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>If-Modified-Since</code> condition evaluates to <code>true</code>;
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Then Amazon S3 returns the <code>304 Not Modified</code> response code.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC
        /// 7232</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// You need the <code>s3:GetObject</code> permission for this operation. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
        /// Permissions in a Policy</a>. If the object you request does not exist, the error Amazon
        /// S3 returns depends on whether you also have the s3:ListBucket permission.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you have the <code>s3:ListBucket</code> permission on the bucket, Amazon S3 returns
        /// an HTTP status code 404 ("no such key") error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don’t have the <code>s3:ListBucket</code> permission, Amazon S3 returns an
        /// HTTP status code 403 ("access denied") error.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following operation is related to <code>HeadObject</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The name of the bucket containing the object.</param>
        /// <param name="key">The object key.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectMetadata service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/HeadObject">REST API Reference for GetObjectMetadata Operation</seealso>
        public virtual Task<GetObjectMetadataResponse> GetObjectMetadataAsync(string bucketName, string key, string versionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetObjectMetadataRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            return GetObjectMetadataAsync(request, cancellationToken);
        }



        /// <summary>
        /// The HEAD operation retrieves metadata from an object without returning the object
        /// itself. This operation is useful if you're only interested in an object's metadata.
        /// To use HEAD, you must have READ access to the object.
        /// 
        ///  
        /// <para>
        /// A <code>HEAD</code> request has the same options as a <code>GET</code> operation on
        /// an object. The response is identical to the <code>GET</code> response except that
        /// there is no response body.
        /// </para>
        ///  
        /// <para>
        /// If you encrypt an object by using server-side encryption with customer-provided encryption
        /// keys (SSE-C) when you store the object in Amazon S3, then when you retrieve the metadata
        /// from the object, you must use the following headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-algorithm
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key-MD5
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about SSE-C, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Server-Side
        /// Encryption (Using Customer-Provided Encryption Keys)</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Encryption request headers, like <code>x-amz-server-side-encryption</code>, should
        /// not be sent for GET requests if your object uses server-side encryption with CMKs
        /// stored in AWS KMS (SSE-KMS) or server-side encryption with Amazon S3–managed encryption
        /// keys (SSE-S3). If your object does use these types of keys, you’ll get an HTTP 400
        /// BadRequest error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Request headers are limited to 8 KB in size. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTCommonRequestHeaders.html">Common
        /// Request Headers</a>.
        /// </para>
        ///  
        /// <para>
        /// Consider the following when using request headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Consideration 1 – If both of the <code>If-Match</code> and <code>If-Unmodified-Since</code>
        /// headers are present in the request as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>If-Match</code> condition evaluates to <code>true</code>, and;
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>If-Unmodified-Since</code> condition evaluates to <code>false</code>;
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Then Amazon S3 returns <code>200 OK</code> and the data requested.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Consideration 2 – If both of the <code>If-None-Match</code> and <code>If-Modified-Since</code>
        /// headers are present in the request as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>If-None-Match</code> condition evaluates to <code>false</code>, and;
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>If-Modified-Since</code> condition evaluates to <code>true</code>;
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Then Amazon S3 returns the <code>304 Not Modified</code> response code.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC
        /// 7232</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// You need the <code>s3:GetObject</code> permission for this operation. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
        /// Permissions in a Policy</a>. If the object you request does not exist, the error Amazon
        /// S3 returns depends on whether you also have the s3:ListBucket permission.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you have the <code>s3:ListBucket</code> permission on the bucket, Amazon S3 returns
        /// an HTTP status code 404 ("no such key") error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don’t have the <code>s3:ListBucket</code> permission, Amazon S3 returns an
        /// HTTP status code 403 ("access denied") error.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following operation is related to <code>HeadObject</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectMetadata service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/HeadObject">REST API Reference for GetObjectMetadata Operation</seealso>
        public virtual Task<GetObjectMetadataResponse> GetObjectMetadataAsync(GetObjectMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetObjectRetention

        internal virtual GetObjectRetentionResponse GetObjectRetention(GetObjectRetentionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectRetentionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectRetentionResponseUnmarshaller.Instance;

            return Invoke<GetObjectRetentionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves an object's retention settings. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lock.html">Locking
        /// Objects</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectRetention service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectRetention service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetObjectRetention">REST API Reference for GetObjectRetention Operation</seealso>
        public virtual Task<GetObjectRetentionResponse> GetObjectRetentionAsync(GetObjectRetentionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectRetentionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectRetentionResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectRetentionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetObjectTagging

        internal virtual GetObjectTaggingResponse GetObjectTagging(GetObjectTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectTaggingResponseUnmarshaller.Instance;

            return Invoke<GetObjectTaggingResponse>(request, options);
        }



        /// <summary>
        /// Returns the tag-set of an object. You send the GET request against the tagging subresource
        /// associated with the object.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <code>s3:GetObjectTagging</code>
        /// action. By default, the GET operation returns information about current version of
        /// an object. For a versioned bucket, you can have multiple versions of an object in
        /// your bucket. To retrieve tags of any other version, use the versionId query parameter.
        /// You also need permission for the <code>s3:GetObjectVersionTagging</code> action.
        /// </para>
        ///  
        /// <para>
        ///  By default, the bucket owner has this permission and can grant this permission to
        /// others.
        /// </para>
        ///  
        /// <para>
        ///  For information about the Amazon S3 object tagging feature, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-tagging.html">Object
        /// Tagging</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operation is related to <code>GetObjectTagging</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObjectTagging</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectTagging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectTagging service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetObjectTagging">REST API Reference for GetObjectTagging Operation</seealso>
        public virtual Task<GetObjectTaggingResponse> GetObjectTaggingAsync(GetObjectTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectTaggingResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectTaggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetObjectTorrent

        internal virtual GetObjectTorrentResponse GetObjectTorrent(GetObjectTorrentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectTorrentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectTorrentResponseUnmarshaller.Instance;

            return Invoke<GetObjectTorrentResponse>(request, options);
        }


        /// <summary>
        /// Return torrent files from a bucket. BitTorrent can save you bandwidth when you're
        /// distributing large files. For more information about BitTorrent, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3Torrent.html">Amazon
        /// S3 Torrent</a>.
        /// 
        ///  <note> 
        /// <para>
        /// You can get torrent only for objects that are less than 5 GB in size and that are
        /// not encrypted using server-side encryption with customer-provided encryption key.
        /// </para>
        ///  </note> 
        /// <para>
        /// To use GET, you must have READ access to the object.
        /// </para>
        ///  
        /// <para>
        /// The following operation is related to <code>GetObjectTorrent</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The name of the bucket containing the object for which to get the torrent files.</param>
        /// <param name="key">The object key for which to get the information.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectTorrent service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetObjectTorrent">REST API Reference for GetObjectTorrent Operation</seealso>
        public virtual Task<GetObjectTorrentResponse> GetObjectTorrentAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetObjectTorrentRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return GetObjectTorrentAsync(request, cancellationToken);
        }



        /// <summary>
        /// Return torrent files from a bucket. BitTorrent can save you bandwidth when you're
        /// distributing large files. For more information about BitTorrent, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3Torrent.html">Amazon
        /// S3 Torrent</a>.
        /// 
        ///  <note> 
        /// <para>
        /// You can get torrent only for objects that are less than 5 GB in size and that are
        /// not encrypted using server-side encryption with customer-provided encryption key.
        /// </para>
        ///  </note> 
        /// <para>
        /// To use GET, you must have READ access to the object.
        /// </para>
        ///  
        /// <para>
        /// The following operation is related to <code>GetObjectTorrent</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectTorrent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectTorrent service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetObjectTorrent">REST API Reference for GetObjectTorrent Operation</seealso>
        public virtual Task<GetObjectTorrentResponse> GetObjectTorrentAsync(GetObjectTorrentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectTorrentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectTorrentResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectTorrentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPublicAccessBlock

        internal virtual GetPublicAccessBlockResponse GetPublicAccessBlock(GetPublicAccessBlockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicAccessBlockResponseUnmarshaller.Instance;

            return Invoke<GetPublicAccessBlockResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the <code>PublicAccessBlock</code> configuration for an Amazon S3 bucket.
        /// To use this operation, you must have the <code>s3:GetBucketPublicAccessBlock</code>
        /// permission. For more information about Amazon S3 permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
        /// Permissions in a Policy</a>.
        /// 
        ///  <important> 
        /// <para>
        /// When Amazon S3 evaluates the <code>PublicAccessBlock</code> configuration for a bucket
        /// or an object, it checks the <code>PublicAccessBlock</code> configuration for both
        /// the bucket (or the bucket that contains the object) and the bucket owner's account.
        /// If the <code>PublicAccessBlock</code> settings are different between the bucket and
        /// the account, Amazon S3 uses the most restrictive combination of the bucket-level and
        /// account-level settings.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about when Amazon S3 considers a bucket or an object public,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html#access-control-block-public-access-policy-status">The
        /// Meaning of "Public"</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>GetPublicAccessBlock</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html">Using
        /// Amazon S3 Block Public Access</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutPublicAccessBlock</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetPublicAccessBlock</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeletePublicAccessBlock</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPublicAccessBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPublicAccessBlock service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/GetPublicAccessBlock">REST API Reference for GetPublicAccessBlock Operation</seealso>
        public virtual Task<GetPublicAccessBlockResponse> GetPublicAccessBlockAsync(GetPublicAccessBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicAccessBlockResponseUnmarshaller.Instance;

            return InvokeAsync<GetPublicAccessBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  HeadBucket

        internal virtual HeadBucketResponse HeadBucket(HeadBucketRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HeadBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HeadBucketResponseUnmarshaller.Instance;

            return Invoke<HeadBucketResponse>(request, options);
        }



        /// <summary>
        /// This operation is useful to determine if a bucket exists and you have permission to
        /// access it. The operation returns a <code>200 OK</code> if the bucket exists and you
        /// have permission to access it. Otherwise, the operation might return responses such
        /// as <code>404 Not Found</code> and <code>403 Forbidden</code>. 
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:ListBucket</code>
        /// action. The bucket owner has this permission by default and can grant this permission
        /// to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HeadBucket service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HeadBucket service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/HeadBucket">REST API Reference for HeadBucket Operation</seealso>
        internal virtual Task<HeadBucketResponse> HeadBucketAsync(HeadBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HeadBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HeadBucketResponseUnmarshaller.Instance;

            return InvokeAsync<HeadBucketResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InitiateMultipartUpload

        internal virtual InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitiateMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<InitiateMultipartUploadResponse>(request, options);
        }


        /// <summary>
        /// This operation initiates a multipart upload and returns an upload ID. This upload
        /// ID is used to associate all of the parts in the specific multipart upload. You specify
        /// this upload ID in each of your subsequent upload part requests (see <a>UploadPart</a>).
        /// You also include this upload ID in the final request to either complete or abort the
        /// multipart upload request.
        /// 
        ///  
        /// <para>
        /// For more information about multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuoverview.html">Multipart
        /// Upload Overview</a>.
        /// </para>
        ///  
        /// <para>
        /// If you have configured a lifecycle rule to abort incomplete multipart uploads, the
        /// upload must complete within the number of days specified in the bucket lifecycle configuration.
        /// Otherwise, the incomplete multipart upload becomes eligible for an abort operation
        /// and Amazon S3 aborts the multipart upload. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuoverview.html#mpu-abort-incomplete-mpu-lifecycle-config">Aborting
        /// Incomplete Multipart Uploads Using a Bucket Lifecycle Policy</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about the permissions required to use the multipart upload API, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
        /// Upload API and Permissions</a>.
        /// </para>
        ///  
        /// <para>
        /// For request signing, multipart upload is just a series of regular requests. You initiate
        /// a multipart upload, send one or more requests to upload parts, and then complete the
        /// multipart upload process. You sign each request individually. There is nothing special
        /// about signing multipart upload requests. For more information about signing, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">Authenticating
        /// Requests (AWS Signature Version 4)</a>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  After you initiate a multipart upload and upload one or more parts, to stop being
        /// charged for storing the uploaded parts, you must either complete or abort the multipart
        /// upload. Amazon S3 frees up the space used to store the parts and stop charging you
        /// for storing them only after you either complete or abort a multipart upload. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You can optionally request server-side encryption. For server-side encryption, Amazon
        /// S3 encrypts your data as it writes it to disks in its data centers and decrypts it
        /// when you access it. You can provide your own encryption key, or use AWS Key Management
        /// Service (AWS KMS) customer master keys (CMKs) or Amazon S3-managed encryption keys.
        /// If you choose to provide your own encryption key, the request headers you provide
        /// in <a>UploadPart</a>) and <a>UploadPartCopy</a>) requests must match the headers you
        /// used in the request to initiate the upload by using <code>CreateMultipartUpload</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To perform a multipart upload with encryption using an AWS KMS CMK, the requester
        /// must have permission to the <code>kms:Encrypt</code>, <code>kms:Decrypt</code>, <code>kms:ReEncrypt*</code>,
        /// <code>kms:GenerateDataKey*</code>, and <code>kms:DescribeKey</code> actions on the
        /// key. These permissions are required because Amazon S3 must decrypt and read data from
        /// the encrypted file parts before it completes the multipart upload.
        /// </para>
        ///  
        /// <para>
        /// If your AWS Identity and Access Management (IAM) user or role is in the same AWS account
        /// as the AWS KMS CMK, then you must have these permissions on the key policy. If your
        /// IAM user or role belongs to a different account than the key, then you must have the
        /// permissions on both the key policy and your IAM user or role.
        /// </para>
        ///  
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">Protecting
        /// Data Using Server-Side Encryption</a>.
        /// </para>
        ///  <dl> <dt>Access Permissions</dt> <dd> 
        /// <para>
        /// When copying an object, you can optionally specify the accounts or groups that should
        /// be granted specific permissions on the new object. There are two ways to grant the
        /// permissions using the request headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a canned ACL with the <code>x-amz-acl</code> request header. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#CannedACL">Canned
        /// ACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify access permissions explicitly with the <code>x-amz-grant-read</code>, <code>x-amz-grant-read-acp</code>,
        /// <code>x-amz-grant-write-acp</code>, and <code>x-amz-grant-full-control</code> headers.
        /// These parameters map to the set of permissions that Amazon S3 supports in an ACL.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
        /// Control List (ACL) Overview</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can use either a canned ACL or specify access permissions explicitly. You cannot
        /// do both.
        /// </para>
        ///  </dd> <dt>Server-Side- Encryption-Specific Request Headers</dt> <dd> 
        /// <para>
        /// You can optionally tell Amazon S3 to encrypt data at rest using server-side encryption.
        /// Server-side encryption is for data encryption at rest. Amazon S3 encrypts your data
        /// as it writes it to disks in its data centers and decrypts it when you access it. The
        /// option you use depends on whether you want to use AWS managed encryption keys or provide
        /// your own encryption key. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use encryption keys managed by Amazon S3 or customer master keys (CMKs) stored in
        /// AWS Key Management Service (AWS KMS) – If you want AWS to manage the keys used to
        /// encrypt data, specify the following headers in the request.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-server-side​-encryption
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side-encryption-aws-kms-key-id
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side-encryption-context
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If you specify <code>x-amz-server-side-encryption:aws:kms</code>, but don't provide
        /// <code>x-amz-server-side-encryption-aws-kms-key-id</code>, Amazon S3 uses the AWS managed
        /// CMK in AWS KMS to protect the data.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// All GET and PUT requests for an object protected by AWS KMS fail if you don't make
        /// them with SSL or by using SigV4.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about server-side encryption with CMKs stored in AWS KMS (SSE-KMS),
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingKMSEncryption.html">Protecting
        /// Data Using Server-Side Encryption with CMKs stored in AWS KMS</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use customer-provided encryption keys – If you want to manage your own encryption
        /// keys, provide all the following headers in the request.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-algorithm
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key-MD5
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about server-side encryption with CMKs stored in AWS KMS (SSE-KMS),
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingKMSEncryption.html">Protecting
        /// Data Using Server-Side Encryption with CMKs stored in AWS KMS</a>.
        /// </para>
        ///  </li> </ul> </dd> <dt>Access-Control-List (ACL)-Specific Request Headers</dt> <dd>
        /// 
        /// <para>
        /// You also can use the following access control–related headers with this operation.
        /// By default, all objects are private. Only the owner has full access control. When
        /// adding a new object, you can grant permissions to individual AWS accounts or to predefined
        /// groups defined by Amazon S3. These permissions are then added to the access control
        /// list (ACL) on the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Using
        /// ACLs</a>. With this operation, you can grant access permissions using one of the following
        /// two methods:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a canned ACL (<code>x-amz-acl</code>) — Amazon S3 supports a set of predefined
        /// ACLs, known as <i>canned ACLs</i>. Each canned ACL has a predefined set of grantees
        /// and permissions. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#CannedACL">Canned
        /// ACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify access permissions explicitly — To explicitly grant access permissions to
        /// specific AWS accounts or groups, use the following headers. Each header maps to specific
        /// permissions that Amazon S3 supports in an ACL. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
        /// Control List (ACL) Overview</a>. In the header, you specify a list of grantees who
        /// get the specific permission. To grant permissions explicitly, use:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-grant-read
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-grant-write
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-grant-read-acp
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-grant-write-acp
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-grant-full-control
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You specify each grantee as a type=value pair, where the type is one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>id</code> – if the value specified is the canonical user ID of an AWS account
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>uri</code> – if you are granting permissions to a predefined group
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>emailAddress</code> – if the value specified is the email address of an AWS
        /// account
        /// </para>
        ///  <note> 
        /// <para>
        /// Using email addresses to specify a grantee is only supported in the following AWS
        /// Regions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// US East (N. Virginia)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// US West (N. California)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  US West (Oregon)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Asia Pacific (Singapore)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Sydney)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Tokyo)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Europe (Ireland)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// South America (São Paulo)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a list of all the Amazon S3 supported Regions and endpoints, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#s3_region">Regions
        /// and Endpoints</a> in the AWS General Reference.
        /// </para>
        ///  </note> </li> </ul> 
        /// <para>
        /// For example, the following <code>x-amz-grant-read</code> header grants the AWS accounts
        /// identified by account IDs permissions to read object data and its metadata:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-grant-read: id="11112222333", id="444455556666" </code> 
        /// </para>
        ///  </li> </ul> </dd> </dl> 
        /// <para>
        /// The following operations are related to <code>CreateMultipartUpload</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>UploadPart</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CompleteMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AbortMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListParts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListMultipartUploads</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The name of the bucket to which to initiate the upload</param>
        /// <param name="key">Object key for which the multipart upload is to be initiated.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InitiateMultipartUpload service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/CreateMultipartUpload">REST API Reference for InitiateMultipartUpload Operation</seealso>
        public virtual Task<InitiateMultipartUploadResponse> InitiateMultipartUploadAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new InitiateMultipartUploadRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return InitiateMultipartUploadAsync(request, cancellationToken);
        }



        /// <summary>
        /// This operation initiates a multipart upload and returns an upload ID. This upload
        /// ID is used to associate all of the parts in the specific multipart upload. You specify
        /// this upload ID in each of your subsequent upload part requests (see <a>UploadPart</a>).
        /// You also include this upload ID in the final request to either complete or abort the
        /// multipart upload request.
        /// 
        ///  
        /// <para>
        /// For more information about multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuoverview.html">Multipart
        /// Upload Overview</a>.
        /// </para>
        ///  
        /// <para>
        /// If you have configured a lifecycle rule to abort incomplete multipart uploads, the
        /// upload must complete within the number of days specified in the bucket lifecycle configuration.
        /// Otherwise, the incomplete multipart upload becomes eligible for an abort operation
        /// and Amazon S3 aborts the multipart upload. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuoverview.html#mpu-abort-incomplete-mpu-lifecycle-config">Aborting
        /// Incomplete Multipart Uploads Using a Bucket Lifecycle Policy</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about the permissions required to use the multipart upload API, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
        /// Upload API and Permissions</a>.
        /// </para>
        ///  
        /// <para>
        /// For request signing, multipart upload is just a series of regular requests. You initiate
        /// a multipart upload, send one or more requests to upload parts, and then complete the
        /// multipart upload process. You sign each request individually. There is nothing special
        /// about signing multipart upload requests. For more information about signing, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">Authenticating
        /// Requests (AWS Signature Version 4)</a>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  After you initiate a multipart upload and upload one or more parts, to stop being
        /// charged for storing the uploaded parts, you must either complete or abort the multipart
        /// upload. Amazon S3 frees up the space used to store the parts and stop charging you
        /// for storing them only after you either complete or abort a multipart upload. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You can optionally request server-side encryption. For server-side encryption, Amazon
        /// S3 encrypts your data as it writes it to disks in its data centers and decrypts it
        /// when you access it. You can provide your own encryption key, or use AWS Key Management
        /// Service (AWS KMS) customer master keys (CMKs) or Amazon S3-managed encryption keys.
        /// If you choose to provide your own encryption key, the request headers you provide
        /// in <a>UploadPart</a>) and <a>UploadPartCopy</a>) requests must match the headers you
        /// used in the request to initiate the upload by using <code>CreateMultipartUpload</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To perform a multipart upload with encryption using an AWS KMS CMK, the requester
        /// must have permission to the <code>kms:Encrypt</code>, <code>kms:Decrypt</code>, <code>kms:ReEncrypt*</code>,
        /// <code>kms:GenerateDataKey*</code>, and <code>kms:DescribeKey</code> actions on the
        /// key. These permissions are required because Amazon S3 must decrypt and read data from
        /// the encrypted file parts before it completes the multipart upload.
        /// </para>
        ///  
        /// <para>
        /// If your AWS Identity and Access Management (IAM) user or role is in the same AWS account
        /// as the AWS KMS CMK, then you must have these permissions on the key policy. If your
        /// IAM user or role belongs to a different account than the key, then you must have the
        /// permissions on both the key policy and your IAM user or role.
        /// </para>
        ///  
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">Protecting
        /// Data Using Server-Side Encryption</a>.
        /// </para>
        ///  <dl> <dt>Access Permissions</dt> <dd> 
        /// <para>
        /// When copying an object, you can optionally specify the accounts or groups that should
        /// be granted specific permissions on the new object. There are two ways to grant the
        /// permissions using the request headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a canned ACL with the <code>x-amz-acl</code> request header. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#CannedACL">Canned
        /// ACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify access permissions explicitly with the <code>x-amz-grant-read</code>, <code>x-amz-grant-read-acp</code>,
        /// <code>x-amz-grant-write-acp</code>, and <code>x-amz-grant-full-control</code> headers.
        /// These parameters map to the set of permissions that Amazon S3 supports in an ACL.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
        /// Control List (ACL) Overview</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can use either a canned ACL or specify access permissions explicitly. You cannot
        /// do both.
        /// </para>
        ///  </dd> <dt>Server-Side- Encryption-Specific Request Headers</dt> <dd> 
        /// <para>
        /// You can optionally tell Amazon S3 to encrypt data at rest using server-side encryption.
        /// Server-side encryption is for data encryption at rest. Amazon S3 encrypts your data
        /// as it writes it to disks in its data centers and decrypts it when you access it. The
        /// option you use depends on whether you want to use AWS managed encryption keys or provide
        /// your own encryption key. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use encryption keys managed by Amazon S3 or customer master keys (CMKs) stored in
        /// AWS Key Management Service (AWS KMS) – If you want AWS to manage the keys used to
        /// encrypt data, specify the following headers in the request.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-server-side​-encryption
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side-encryption-aws-kms-key-id
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side-encryption-context
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If you specify <code>x-amz-server-side-encryption:aws:kms</code>, but don't provide
        /// <code>x-amz-server-side-encryption-aws-kms-key-id</code>, Amazon S3 uses the AWS managed
        /// CMK in AWS KMS to protect the data.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// All GET and PUT requests for an object protected by AWS KMS fail if you don't make
        /// them with SSL or by using SigV4.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about server-side encryption with CMKs stored in AWS KMS (SSE-KMS),
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingKMSEncryption.html">Protecting
        /// Data Using Server-Side Encryption with CMKs stored in AWS KMS</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use customer-provided encryption keys – If you want to manage your own encryption
        /// keys, provide all the following headers in the request.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-algorithm
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key-MD5
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about server-side encryption with CMKs stored in AWS KMS (SSE-KMS),
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingKMSEncryption.html">Protecting
        /// Data Using Server-Side Encryption with CMKs stored in AWS KMS</a>.
        /// </para>
        ///  </li> </ul> </dd> <dt>Access-Control-List (ACL)-Specific Request Headers</dt> <dd>
        /// 
        /// <para>
        /// You also can use the following access control–related headers with this operation.
        /// By default, all objects are private. Only the owner has full access control. When
        /// adding a new object, you can grant permissions to individual AWS accounts or to predefined
        /// groups defined by Amazon S3. These permissions are then added to the access control
        /// list (ACL) on the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Using
        /// ACLs</a>. With this operation, you can grant access permissions using one of the following
        /// two methods:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a canned ACL (<code>x-amz-acl</code>) — Amazon S3 supports a set of predefined
        /// ACLs, known as <i>canned ACLs</i>. Each canned ACL has a predefined set of grantees
        /// and permissions. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#CannedACL">Canned
        /// ACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify access permissions explicitly — To explicitly grant access permissions to
        /// specific AWS accounts or groups, use the following headers. Each header maps to specific
        /// permissions that Amazon S3 supports in an ACL. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
        /// Control List (ACL) Overview</a>. In the header, you specify a list of grantees who
        /// get the specific permission. To grant permissions explicitly, use:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-grant-read
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-grant-write
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-grant-read-acp
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-grant-write-acp
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-grant-full-control
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You specify each grantee as a type=value pair, where the type is one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>id</code> – if the value specified is the canonical user ID of an AWS account
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>uri</code> – if you are granting permissions to a predefined group
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>emailAddress</code> – if the value specified is the email address of an AWS
        /// account
        /// </para>
        ///  <note> 
        /// <para>
        /// Using email addresses to specify a grantee is only supported in the following AWS
        /// Regions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// US East (N. Virginia)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// US West (N. California)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  US West (Oregon)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Asia Pacific (Singapore)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Sydney)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Tokyo)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Europe (Ireland)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// South America (São Paulo)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a list of all the Amazon S3 supported Regions and endpoints, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#s3_region">Regions
        /// and Endpoints</a> in the AWS General Reference.
        /// </para>
        ///  </note> </li> </ul> 
        /// <para>
        /// For example, the following <code>x-amz-grant-read</code> header grants the AWS accounts
        /// identified by account IDs permissions to read object data and its metadata:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-grant-read: id="11112222333", id="444455556666" </code> 
        /// </para>
        ///  </li> </ul> </dd> </dl> 
        /// <para>
        /// The following operations are related to <code>CreateMultipartUpload</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>UploadPart</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CompleteMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AbortMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListParts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListMultipartUploads</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateMultipartUpload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InitiateMultipartUpload service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/CreateMultipartUpload">REST API Reference for InitiateMultipartUpload Operation</seealso>
        public virtual Task<InitiateMultipartUploadResponse> InitiateMultipartUploadAsync(InitiateMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitiateMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateMultipartUploadResponseUnmarshaller.Instance;

            return InvokeAsync<InitiateMultipartUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBucketAnalyticsConfigurations

        internal virtual ListBucketAnalyticsConfigurationsResponse ListBucketAnalyticsConfigurations(ListBucketAnalyticsConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketAnalyticsConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketAnalyticsConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListBucketAnalyticsConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the analytics configurations for the bucket. You can have up to 1,000 analytics
        /// configurations per bucket.
        /// 
        ///  
        /// <para>
        /// This operation supports list pagination and does not return more than 100 configurations
        /// at a time. You should always check the <code>IsTruncated</code> element in the response.
        /// If there are no more configurations to list, <code>IsTruncated</code> is set to false.
        /// If there are more configurations to list, <code>IsTruncated</code> is set to true,
        /// and there will be a value in <code>NextContinuationToken</code>. You use the <code>NextContinuationToken</code>
        /// value to continue the pagination of the list by passing the value in continuation-token
        /// in the request to <code>GET</code> the next page.
        /// </para>
        ///  
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:GetAnalyticsConfiguration</code>
        /// action. The bucket owner has this permission by default. The bucket owner can grant
        /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about Amazon S3 analytics feature, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/analytics-storage-class.html">Amazon
        /// S3 Analytics – Storage Class Analysis</a>. 
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>ListBucketAnalyticsConfigurations</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketAnalyticsConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketAnalyticsConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutBucketAnalyticsConfiguration</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBucketAnalyticsConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBucketAnalyticsConfigurations service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/ListBucketAnalyticsConfigurations">REST API Reference for ListBucketAnalyticsConfigurations Operation</seealso>
        public virtual Task<ListBucketAnalyticsConfigurationsResponse> ListBucketAnalyticsConfigurationsAsync(ListBucketAnalyticsConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketAnalyticsConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketAnalyticsConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBucketAnalyticsConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBucketInventoryConfigurations

        internal virtual ListBucketInventoryConfigurationsResponse ListBucketInventoryConfigurations(ListBucketInventoryConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketInventoryConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketInventoryConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListBucketInventoryConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of inventory configurations for the bucket. You can have up to 1,000
        /// analytics configurations per bucket.
        /// 
        ///  
        /// <para>
        /// This operation supports list pagination and does not return more than 100 configurations
        /// at a time. Always check the <code>IsTruncated</code> element in the response. If there
        /// are no more configurations to list, <code>IsTruncated</code> is set to false. If there
        /// are more configurations to list, <code>IsTruncated</code> is set to true, and there
        /// is a value in <code>NextContinuationToken</code>. You use the <code>NextContinuationToken</code>
        /// value to continue the pagination of the list by passing the value in continuation-token
        /// in the request to <code>GET</code> the next page.
        /// </para>
        ///  
        /// <para>
        ///  To use this operation, you must have permissions to perform the <code>s3:GetInventoryConfiguration</code>
        /// action. The bucket owner has this permission by default. The bucket owner can grant
        /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about the Amazon S3 inventory feature, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage-inventory.html">Amazon
        /// S3 Inventory</a> 
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>ListBucketInventoryConfigurations</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketInventoryConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketInventoryConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutBucketInventoryConfiguration</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBucketInventoryConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBucketInventoryConfigurations service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/ListBucketInventoryConfigurations">REST API Reference for ListBucketInventoryConfigurations Operation</seealso>
        public virtual Task<ListBucketInventoryConfigurationsResponse> ListBucketInventoryConfigurationsAsync(ListBucketInventoryConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketInventoryConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketInventoryConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBucketInventoryConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBucketMetricsConfigurations

        internal virtual ListBucketMetricsConfigurationsResponse ListBucketMetricsConfigurations(ListBucketMetricsConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketMetricsConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketMetricsConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListBucketMetricsConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the metrics configurations for the bucket. The metrics configurations are only
        /// for the request metrics of the bucket and do not provide information on daily storage
        /// metrics. You can have up to 1,000 configurations per bucket.
        /// 
        ///  
        /// <para>
        /// This operation supports list pagination and does not return more than 100 configurations
        /// at a time. Always check the <code>IsTruncated</code> element in the response. If there
        /// are no more configurations to list, <code>IsTruncated</code> is set to false. If there
        /// are more configurations to list, <code>IsTruncated</code> is set to true, and there
        /// is a value in <code>NextContinuationToken</code>. You use the <code>NextContinuationToken</code>
        /// value to continue the pagination of the list by passing the value in <code>continuation-token</code>
        /// in the request to <code>GET</code> the next page.
        /// </para>
        ///  
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:GetMetricsConfiguration</code>
        /// action. The bucket owner has this permission by default. The bucket owner can grant
        /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about metrics configurations and CloudWatch request metrics,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/cloudwatch-monitoring.html">Monitoring
        /// Metrics with Amazon CloudWatch</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>ListBucketMetricsConfigurations</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketMetricsConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketMetricsConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketMetricsConfiguration</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBucketMetricsConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBucketMetricsConfigurations service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/ListBucketMetricsConfigurations">REST API Reference for ListBucketMetricsConfigurations Operation</seealso>
        public virtual Task<ListBucketMetricsConfigurationsResponse> ListBucketMetricsConfigurationsAsync(ListBucketMetricsConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketMetricsConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketMetricsConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBucketMetricsConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBuckets

        internal virtual ListBucketsResponse ListBuckets()
        {
            return ListBuckets(new ListBucketsRequest());
        }
        internal virtual ListBucketsResponse ListBuckets(ListBucketsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketsResponseUnmarshaller.Instance;

            return Invoke<ListBucketsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of all buckets owned by the authenticated sender of the request.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBuckets service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/ListBuckets">REST API Reference for ListBuckets Operation</seealso>
        public virtual Task<ListBucketsResponse> ListBucketsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListBucketsAsync(new ListBucketsRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns a list of all buckets owned by the authenticated sender of the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuckets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBuckets service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/ListBuckets">REST API Reference for ListBuckets Operation</seealso>
        public virtual Task<ListBucketsResponse> ListBucketsAsync(ListBucketsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBucketsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMultipartUploads

        internal virtual ListMultipartUploadsResponse ListMultipartUploads(ListMultipartUploadsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMultipartUploadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMultipartUploadsResponseUnmarshaller.Instance;

            return Invoke<ListMultipartUploadsResponse>(request, options);
        }


        /// <summary>
        /// This operation lists in-progress multipart uploads. An in-progress multipart upload
        /// is a multipart upload that has been initiated using the Initiate Multipart Upload
        /// request, but has not yet been completed or aborted.
        /// 
        ///  
        /// <para>
        /// This operation returns at most 1,000 multipart uploads in the response. 1,000 multipart
        /// uploads is the maximum number of uploads a response can include, which is also the
        /// default value. You can further limit the number of uploads in a response by specifying
        /// the <code>max-uploads</code> parameter in the response. If additional multipart uploads
        /// satisfy the list criteria, the response will contain an <code>IsTruncated</code> element
        /// with the value true. To list the additional multipart uploads, use the <code>key-marker</code>
        /// and <code>upload-id-marker</code> request parameters.
        /// </para>
        ///  
        /// <para>
        /// In the response, the uploads are sorted by key. If your application has initiated
        /// more than one multipart upload using the same object key, then uploads in the response
        /// are first sorted by key. Additionally, uploads are sorted in ascending order within
        /// each key by the upload initiation time.
        /// </para>
        ///  
        /// <para>
        /// For more information on multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/uploadobjusingmpu.html">Uploading
        /// Objects Using Multipart Upload</a>.
        /// </para>
        ///  
        /// <para>
        /// For information on permissions required to use the multipart upload API, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
        /// Upload API and Permissions</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>ListMultipartUploads</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UploadPart</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CompleteMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListParts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AbortMultipartUpload</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">Name of the bucket to which the multipart upload was initiated.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/ListMultipartUploads">REST API Reference for ListMultipartUploads Operation</seealso>
        public virtual Task<ListMultipartUploadsResponse> ListMultipartUploadsAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListMultipartUploadsRequest();
            request.BucketName = bucketName;
            return ListMultipartUploadsAsync(request, cancellationToken);
        }


        /// <summary>
        /// This operation lists in-progress multipart uploads. An in-progress multipart upload
        /// is a multipart upload that has been initiated using the Initiate Multipart Upload
        /// request, but has not yet been completed or aborted.
        /// 
        ///  
        /// <para>
        /// This operation returns at most 1,000 multipart uploads in the response. 1,000 multipart
        /// uploads is the maximum number of uploads a response can include, which is also the
        /// default value. You can further limit the number of uploads in a response by specifying
        /// the <code>max-uploads</code> parameter in the response. If additional multipart uploads
        /// satisfy the list criteria, the response will contain an <code>IsTruncated</code> element
        /// with the value true. To list the additional multipart uploads, use the <code>key-marker</code>
        /// and <code>upload-id-marker</code> request parameters.
        /// </para>
        ///  
        /// <para>
        /// In the response, the uploads are sorted by key. If your application has initiated
        /// more than one multipart upload using the same object key, then uploads in the response
        /// are first sorted by key. Additionally, uploads are sorted in ascending order within
        /// each key by the upload initiation time.
        /// </para>
        ///  
        /// <para>
        /// For more information on multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/uploadobjusingmpu.html">Uploading
        /// Objects Using Multipart Upload</a>.
        /// </para>
        ///  
        /// <para>
        /// For information on permissions required to use the multipart upload API, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
        /// Upload API and Permissions</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>ListMultipartUploads</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UploadPart</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CompleteMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListParts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AbortMultipartUpload</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">Name of the bucket to which the multipart upload was initiated.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="prefix">Lists in-progress uploads only for those keys that begin with the specified prefix. You can use prefixes to separate a bucket into different grouping of keys. (You can think of using prefix to make groups in the same way you'd use a folder in a file system.)</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/ListMultipartUploads">REST API Reference for ListMultipartUploads Operation</seealso>
        public virtual Task<ListMultipartUploadsResponse> ListMultipartUploadsAsync(string bucketName, string prefix, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListMultipartUploadsRequest();
            request.BucketName = bucketName;
            request.Prefix = prefix;
            return ListMultipartUploadsAsync(request, cancellationToken);
        }



        /// <summary>
        /// This operation lists in-progress multipart uploads. An in-progress multipart upload
        /// is a multipart upload that has been initiated using the Initiate Multipart Upload
        /// request, but has not yet been completed or aborted.
        /// 
        ///  
        /// <para>
        /// This operation returns at most 1,000 multipart uploads in the response. 1,000 multipart
        /// uploads is the maximum number of uploads a response can include, which is also the
        /// default value. You can further limit the number of uploads in a response by specifying
        /// the <code>max-uploads</code> parameter in the response. If additional multipart uploads
        /// satisfy the list criteria, the response will contain an <code>IsTruncated</code> element
        /// with the value true. To list the additional multipart uploads, use the <code>key-marker</code>
        /// and <code>upload-id-marker</code> request parameters.
        /// </para>
        ///  
        /// <para>
        /// In the response, the uploads are sorted by key. If your application has initiated
        /// more than one multipart upload using the same object key, then uploads in the response
        /// are first sorted by key. Additionally, uploads are sorted in ascending order within
        /// each key by the upload initiation time.
        /// </para>
        ///  
        /// <para>
        /// For more information on multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/uploadobjusingmpu.html">Uploading
        /// Objects Using Multipart Upload</a>.
        /// </para>
        ///  
        /// <para>
        /// For information on permissions required to use the multipart upload API, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
        /// Upload API and Permissions</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>ListMultipartUploads</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UploadPart</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CompleteMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListParts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AbortMultipartUpload</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartUploads service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/ListMultipartUploads">REST API Reference for ListMultipartUploads Operation</seealso>
        public virtual Task<ListMultipartUploadsResponse> ListMultipartUploadsAsync(ListMultipartUploadsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMultipartUploadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMultipartUploadsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMultipartUploadsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListObjects

        internal virtual ListObjectsResponse ListObjects(ListObjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectsResponseUnmarshaller.Instance;

            return Invoke<ListObjectsResponse>(request, options);
        }


        /// <summary>
        /// Returns some or all (up to 1,000) of the objects in a bucket. You can use the request
        /// parameters as selection criteria to return a subset of the objects in a bucket. A
        /// 200 OK response can contain valid or invalid XML. Be sure to design your application
        /// to parse the contents of the response and handle it appropriately.
        /// 
        ///  <important> 
        /// <para>
        /// This API has been revised. We recommend that you use the newer version, <a>ListObjectsV2</a>,
        /// when developing applications. For backward compatibility, Amazon S3 continues to support
        /// <code>ListObjects</code>.
        /// </para>
        ///  </important> 
        /// <para>
        /// The following operations are related to <code>ListObjects</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListObjectsV2</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBuckets</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The name of the bucket containing the objects.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/ListObjects">REST API Reference for ListObjects Operation</seealso>
        public virtual Task<ListObjectsResponse> ListObjectsAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListObjectsRequest();
            request.BucketName = bucketName;
            return ListObjectsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns some or all (up to 1,000) of the objects in a bucket. You can use the request
        /// parameters as selection criteria to return a subset of the objects in a bucket. A
        /// 200 OK response can contain valid or invalid XML. Be sure to design your application
        /// to parse the contents of the response and handle it appropriately.
        /// 
        ///  <important> 
        /// <para>
        /// This API has been revised. We recommend that you use the newer version, <a>ListObjectsV2</a>,
        /// when developing applications. For backward compatibility, Amazon S3 continues to support
        /// <code>ListObjects</code>.
        /// </para>
        ///  </important> 
        /// <para>
        /// The following operations are related to <code>ListObjects</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListObjectsV2</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBuckets</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The name of the bucket containing the objects.</param>
        /// <param name="prefix">Limits the response to keys that begin with the specified prefix.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/ListObjects">REST API Reference for ListObjects Operation</seealso>
        public virtual Task<ListObjectsResponse> ListObjectsAsync(string bucketName, string prefix, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListObjectsRequest();
            request.BucketName = bucketName;
            request.Prefix = prefix;
            return ListObjectsAsync(request, cancellationToken);
        }



        /// <summary>
        /// Returns some or all (up to 1,000) of the objects in a bucket. You can use the request
        /// parameters as selection criteria to return a subset of the objects in a bucket. A
        /// 200 OK response can contain valid or invalid XML. Be sure to design your application
        /// to parse the contents of the response and handle it appropriately.
        /// 
        ///  <important> 
        /// <para>
        /// This API has been revised. We recommend that you use the newer version, <a>ListObjectsV2</a>,
        /// when developing applications. For backward compatibility, Amazon S3 continues to support
        /// <code>ListObjects</code>.
        /// </para>
        ///  </important> 
        /// <para>
        /// The following operations are related to <code>ListObjects</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListObjectsV2</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBuckets</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/ListObjects">REST API Reference for ListObjects Operation</seealso>
        public virtual Task<ListObjectsResponse> ListObjectsAsync(ListObjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectsResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListObjectsV2

        internal virtual ListObjectsV2Response ListObjectsV2(ListObjectsV2Request request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectsV2ResponseUnmarshaller.Instance;

            return Invoke<ListObjectsV2Response>(request, options);
        }



        /// <summary>
        /// Returns some or all (up to 1,000) of the objects in a bucket. You can use the request
        /// parameters as selection criteria to return a subset of the objects in a bucket. A
        /// <code>200 OK</code> response can contain valid or invalid XML. Make sure to design
        /// your application to parse the contents of the response and handle it appropriately.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have READ access to the bucket.
        /// </para>
        ///  
        /// <para>
        /// To use this operation in an AWS Identity and Access Management (IAM) policy, you must
        /// have permissions to perform the <code>s3:ListBucket</code> action. The bucket owner
        /// has this permission by default and can grant this permission to others. For more information
        /// about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// This section describes the latest revision of the API. We recommend that you use this
        /// revised API for application development. For backward compatibility, Amazon S3 continues
        /// to support the prior version of this API, <a>ListObjects</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// To get a list of your buckets, see <a>ListBuckets</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>ListObjectsV2</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectsV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListObjectsV2 service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/ListObjectsV2">REST API Reference for ListObjectsV2 Operation</seealso>
        public virtual Task<ListObjectsV2Response> ListObjectsV2Async(ListObjectsV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectsV2ResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectsV2Response>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListParts

        internal virtual ListPartsResponse ListParts(ListPartsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPartsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartsResponseUnmarshaller.Instance;

            return Invoke<ListPartsResponse>(request, options);
        }


        /// <summary>
        /// Lists the parts that have been uploaded for a specific multipart upload. This operation
        /// must include the upload ID, which you obtain by sending the initiate multipart upload
        /// request (see <a>CreateMultipartUpload</a>). This request returns a maximum of 1,000
        /// uploaded parts. The default number of parts returned is 1,000 parts. You can restrict
        /// the number of parts returned by specifying the <code>max-parts</code> request parameter.
        /// If your multipart upload consists of more than 1,000 parts, the response returns an
        /// <code>IsTruncated</code> field with the value of true, and a <code>NextPartNumberMarker</code>
        /// element. In subsequent <code>ListParts</code> requests you can include the part-number-marker
        /// query string parameter and set its value to the <code>NextPartNumberMarker</code>
        /// field value from the previous response.
        /// 
        ///  
        /// <para>
        /// For more information on multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/uploadobjusingmpu.html">Uploading
        /// Objects Using Multipart Upload</a>.
        /// </para>
        ///  
        /// <para>
        /// For information on permissions required to use the multipart upload API, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
        /// Upload API and Permissions</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>ListParts</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UploadPart</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CompleteMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AbortMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListMultipartUploads</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">Name of the bucket to which the parts are being uploaded.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="key">Object key for which the multipart upload was initiated.</param>
        /// <param name="uploadId">Upload ID identifying the multipart upload whose parts are being listed.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListParts service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/ListParts">REST API Reference for ListParts Operation</seealso>
        public virtual Task<ListPartsResponse> ListPartsAsync(string bucketName, string key, string uploadId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListPartsRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.UploadId = uploadId;
            return ListPartsAsync(request, cancellationToken);
        }



        /// <summary>
        /// Lists the parts that have been uploaded for a specific multipart upload. This operation
        /// must include the upload ID, which you obtain by sending the initiate multipart upload
        /// request (see <a>CreateMultipartUpload</a>). This request returns a maximum of 1,000
        /// uploaded parts. The default number of parts returned is 1,000 parts. You can restrict
        /// the number of parts returned by specifying the <code>max-parts</code> request parameter.
        /// If your multipart upload consists of more than 1,000 parts, the response returns an
        /// <code>IsTruncated</code> field with the value of true, and a <code>NextPartNumberMarker</code>
        /// element. In subsequent <code>ListParts</code> requests you can include the part-number-marker
        /// query string parameter and set its value to the <code>NextPartNumberMarker</code>
        /// field value from the previous response.
        /// 
        ///  
        /// <para>
        /// For more information on multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/uploadobjusingmpu.html">Uploading
        /// Objects Using Multipart Upload</a>.
        /// </para>
        ///  
        /// <para>
        /// For information on permissions required to use the multipart upload API, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
        /// Upload API and Permissions</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>ListParts</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UploadPart</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CompleteMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AbortMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListMultipartUploads</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListParts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListParts service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/ListParts">REST API Reference for ListParts Operation</seealso>
        public virtual Task<ListPartsResponse> ListPartsAsync(ListPartsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPartsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPartsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVersions

        internal virtual ListVersionsResponse ListVersions(ListVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVersionsResponseUnmarshaller.Instance;

            return Invoke<ListVersionsResponse>(request, options);
        }


        /// <summary>
        /// Returns metadata about all of the versions of objects in a bucket. You can also use
        /// request parameters as selection criteria to return metadata about a subset of all
        /// the object versions. 
        /// 
        ///  <note> 
        /// <para>
        ///  A 200 OK response can contain valid or invalid XML. Make sure to design your application
        /// to parse the contents of the response and handle it appropriately.
        /// </para>
        ///  </note> 
        /// <para>
        /// To use this operation, you must have READ access to the bucket.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>ListObjectVersions</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListObjectsV2</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteObject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name that contains the objects.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/ListObjectVersions">REST API Reference for ListVersions Operation</seealso>
        public virtual Task<ListVersionsResponse> ListVersionsAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListVersionsRequest();
            request.BucketName = bucketName;
            return ListVersionsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns metadata about all of the versions of objects in a bucket. You can also use
        /// request parameters as selection criteria to return metadata about a subset of all
        /// the object versions. 
        /// 
        ///  <note> 
        /// <para>
        ///  A 200 OK response can contain valid or invalid XML. Make sure to design your application
        /// to parse the contents of the response and handle it appropriately.
        /// </para>
        ///  </note> 
        /// <para>
        /// To use this operation, you must have READ access to the bucket.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>ListObjectVersions</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListObjectsV2</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteObject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name that contains the objects.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="prefix">Use this parameter to select only those keys that begin with the specified prefix. You can use prefixes to separate a bucket into different groupings of keys. (You can think of using prefix to make groups in the same way you'd use a folder in a file system.) You can use prefix with delimiter to roll up numerous objects into a single result under CommonPrefixes. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/ListObjectVersions">REST API Reference for ListVersions Operation</seealso>
        public virtual Task<ListVersionsResponse> ListVersionsAsync(string bucketName, string prefix, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListVersionsRequest();
            request.BucketName = bucketName;
            request.Prefix = prefix;
            return ListVersionsAsync(request, cancellationToken);
        }



        /// <summary>
        /// Returns metadata about all of the versions of objects in a bucket. You can also use
        /// request parameters as selection criteria to return metadata about a subset of all
        /// the object versions. 
        /// 
        ///  <note> 
        /// <para>
        ///  A 200 OK response can contain valid or invalid XML. Make sure to design your application
        /// to parse the contents of the response and handle it appropriately.
        /// </para>
        ///  </note> 
        /// <para>
        /// To use this operation, you must have READ access to the bucket.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>ListObjectVersions</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListObjectsV2</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteObject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/ListObjectVersions">REST API Reference for ListVersions Operation</seealso>
        public virtual Task<ListVersionsResponse> ListVersionsAsync(ListVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutACL

        internal virtual PutACLResponse PutACL(PutACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutACLResponseUnmarshaller.Instance;

            return Invoke<PutACLResponse>(request, options);
        }



        /// <summary>
        /// Sets the permissions on an existing bucket using access control lists (ACL). For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Using
        /// ACLs</a>. To set the ACL of a bucket, you must have <code>WRITE_ACP</code> permission.
        /// 
        ///  
        /// <para>
        /// You can use one of the following two ways to set a bucket's permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify the ACL in the request body
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify permissions using request headers
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// You cannot specify access permission using both the body and the request headers.
        /// </para>
        ///  </note> 
        /// <para>
        /// Depending on your application needs, you may choose to set the ACL on a bucket using
        /// either the request body or the headers. For example, if you have an existing application
        /// that updates a bucket ACL using the request body, then you can continue to use that
        /// approach.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// You can set access permissions using one of the following methods:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a canned ACL with the <code>x-amz-acl</code> request header. Amazon S3 supports
        /// a set of predefined ACLs, known as <i>canned ACLs</i>. Each canned ACL has a predefined
        /// set of grantees and permissions. Specify the canned ACL name as the value of <code>x-amz-acl</code>.
        /// If you use this header, you cannot use other access control-specific headers in your
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#CannedACL">Canned
        /// ACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify access permissions explicitly with the <code>x-amz-grant-read</code>, <code>x-amz-grant-read-acp</code>,
        /// <code>x-amz-grant-write-acp</code>, and <code>x-amz-grant-full-control</code> headers.
        /// When using these headers, you specify explicit access permissions and grantees (AWS
        /// accounts or Amazon S3 groups) who will receive the permission. If you use these ACL-specific
        /// headers, you cannot use the <code>x-amz-acl</code> header to set a canned ACL. These
        /// parameters map to the set of permissions that Amazon S3 supports in an ACL. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
        /// Control List (ACL) Overview</a>.
        /// </para>
        ///  
        /// <para>
        /// You specify each grantee as a type=value pair, where the type is one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>id</code> – if the value specified is the canonical user ID of an AWS account
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>uri</code> – if you are granting permissions to a predefined group
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>emailAddress</code> – if the value specified is the email address of an AWS
        /// account
        /// </para>
        ///  <note> 
        /// <para>
        /// Using email addresses to specify a grantee is only supported in the following AWS
        /// Regions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// US East (N. Virginia)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// US West (N. California)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  US West (Oregon)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Asia Pacific (Singapore)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Sydney)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Tokyo)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Europe (Ireland)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// South America (São Paulo)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a list of all the Amazon S3 supported Regions and endpoints, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#s3_region">Regions
        /// and Endpoints</a> in the AWS General Reference.
        /// </para>
        ///  </note> </li> </ul> 
        /// <para>
        /// For example, the following <code>x-amz-grant-write</code> header grants create, overwrite,
        /// and delete objects permission to LogDelivery group predefined by Amazon S3 and two
        /// AWS accounts identified by their email addresses.
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-grant-write: uri="http://acs.amazonaws.com/groups/s3/LogDelivery", id="111122223333",
        /// id="555566667777" </code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can use either a canned ACL or specify access permissions explicitly. You cannot
        /// do both.
        /// </para>
        ///  
        /// <para>
        ///  <b>Grantee Values</b> 
        /// </para>
        ///  
        /// <para>
        /// You can specify the person (grantee) to whom you're assigning access rights (using
        /// request elements) in the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// By the person's ID:
        /// </para>
        ///  
        /// <para>
        ///  <code>&lt;Grantee xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:type="CanonicalUser"&gt;&lt;ID&gt;&lt;&gt;ID&lt;&gt;&lt;/ID&gt;&lt;DisplayName&gt;&lt;&gt;GranteesEmail&lt;&gt;&lt;/DisplayName&gt;
        /// &lt;/Grantee&gt;</code> 
        /// </para>
        ///  
        /// <para>
        /// DisplayName is optional and ignored in the request
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// By URI:
        /// </para>
        ///  
        /// <para>
        ///  <code>&lt;Grantee xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:type="Group"&gt;&lt;URI&gt;&lt;&gt;http://acs.amazonaws.com/groups/global/AuthenticatedUsers&lt;&gt;&lt;/URI&gt;&lt;/Grantee&gt;</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// By Email address:
        /// </para>
        ///  
        /// <para>
        ///  <code>&lt;Grantee xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:type="AmazonCustomerByEmail"&gt;&lt;EmailAddress&gt;&lt;&gt;Grantees@email.com&lt;&gt;&lt;/EmailAddress&gt;lt;/Grantee&gt;</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The grantee is resolved to the CanonicalUser and, in a response to a GET Object acl
        /// request, appears as the CanonicalUser. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Using email addresses to specify a grantee is only supported in the following AWS
        /// Regions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// US East (N. Virginia)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// US West (N. California)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  US West (Oregon)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Asia Pacific (Singapore)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Sydney)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Tokyo)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Europe (Ireland)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// South America (São Paulo)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a list of all the Amazon S3 supported Regions and endpoints, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#s3_region">Regions
        /// and Endpoints</a> in the AWS General Reference.
        /// </para>
        ///  </note> </li> </ul> <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetObjectAcl</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutACL service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketAcl">REST API Reference for PutACL Operation</seealso>
        public virtual Task<PutACLResponse> PutACLAsync(PutACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutACLResponseUnmarshaller.Instance;

            return InvokeAsync<PutACLResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucket

        internal virtual PutBucketResponse PutBucket(PutBucketRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketResponseUnmarshaller.Instance;

            return Invoke<PutBucketResponse>(request, options);
        }


        /// <summary>
        /// Creates a new bucket. To create a bucket, you must register with Amazon S3 and have
        /// a valid AWS Access Key ID to authenticate requests. Anonymous requests are never allowed
        /// to create buckets. By creating the bucket, you become the bucket owner.
        /// 
        ///  
        /// <para>
        /// Not every string is an acceptable bucket name. For information on bucket naming restrictions,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingBucket.html">Working
        /// with Amazon S3 Buckets</a>.
        /// </para>
        ///  
        /// <para>
        /// By default, the bucket is created in the US East (N. Virginia) Region. You can optionally
        /// specify a Region in the request body. You might choose a Region to optimize latency,
        /// minimize costs, or address regulatory requirements. For example, if you reside in
        /// Europe, you will probably find it advantageous to create buckets in the Europe (Ireland)
        /// Region. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingBucket.html#access-bucket-intro">How
        /// to Select a Region for Your Buckets</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you send your create bucket request to the <code>s3.amazonaws.com</code> endpoint,
        /// the request goes to the us-east-1 Region. Accordingly, the signature calculations
        /// in Signature Version 4 must use us-east-1 as the Region, even if the location constraint
        /// in the request specifies another Region where the bucket is to be created. If you
        /// create a bucket in a Region other than US East (N. Virginia), your application must
        /// be able to handle 307 redirect. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/VirtualHosting.html">Virtual
        /// Hosting of Buckets</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// When creating a bucket using this operation, you can optionally specify the accounts
        /// or groups that should be granted specific permissions on the bucket. There are two
        /// ways to grant the appropriate permissions using the request headers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a canned ACL using the <code>x-amz-acl</code> request header. Amazon S3 supports
        /// a set of predefined ACLs, known as <i>canned ACLs</i>. Each canned ACL has a predefined
        /// set of grantees and permissions. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#CannedACL">Canned
        /// ACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify access permissions explicitly using the <code>x-amz-grant-read</code>, <code>x-amz-grant-write</code>,
        /// <code>x-amz-grant-read-acp</code>, <code>x-amz-grant-write-acp</code>, and <code>x-amz-grant-full-control</code>
        /// headers. These headers map to the set of permissions Amazon S3 supports in an ACL.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
        /// Control List (ACL) Overview</a>.
        /// </para>
        ///  
        /// <para>
        /// You specify each grantee as a type=value pair, where the type is one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>id</code> – if the value specified is the canonical user ID of an AWS account
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>uri</code> – if you are granting permissions to a predefined group
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>emailAddress</code> – if the value specified is the email address of an AWS
        /// account
        /// </para>
        ///  <note> 
        /// <para>
        /// Using email addresses to specify a grantee is only supported in the following AWS
        /// Regions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// US East (N. Virginia)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// US West (N. California)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  US West (Oregon)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Asia Pacific (Singapore)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Sydney)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Tokyo)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Europe (Ireland)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// South America (São Paulo)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a list of all the Amazon S3 supported Regions and endpoints, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#s3_region">Regions
        /// and Endpoints</a> in the AWS General Reference.
        /// </para>
        ///  </note> </li> </ul> 
        /// <para>
        /// For example, the following <code>x-amz-grant-read</code> header grants the AWS accounts
        /// identified by account IDs permissions to read object data and its metadata:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-grant-read: id="11112222333", id="444455556666" </code> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// You can use either a canned ACL or specify access permissions explicitly. You cannot
        /// do both.
        /// </para>
        ///  </note> 
        /// <para>
        /// The following operations are related to <code>CreateBucket</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucket</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The name of the bucket to create.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucket service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/CreateBucket">REST API Reference for PutBucket Operation</seealso>
        public virtual Task<PutBucketResponse> PutBucketAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutBucketRequest();
            request.BucketName = bucketName;
            return PutBucketAsync(request, cancellationToken);
        }



        /// <summary>
        /// Creates a new bucket. To create a bucket, you must register with Amazon S3 and have
        /// a valid AWS Access Key ID to authenticate requests. Anonymous requests are never allowed
        /// to create buckets. By creating the bucket, you become the bucket owner.
        /// 
        ///  
        /// <para>
        /// Not every string is an acceptable bucket name. For information on bucket naming restrictions,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingBucket.html">Working
        /// with Amazon S3 Buckets</a>.
        /// </para>
        ///  
        /// <para>
        /// By default, the bucket is created in the US East (N. Virginia) Region. You can optionally
        /// specify a Region in the request body. You might choose a Region to optimize latency,
        /// minimize costs, or address regulatory requirements. For example, if you reside in
        /// Europe, you will probably find it advantageous to create buckets in the Europe (Ireland)
        /// Region. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingBucket.html#access-bucket-intro">How
        /// to Select a Region for Your Buckets</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you send your create bucket request to the <code>s3.amazonaws.com</code> endpoint,
        /// the request goes to the us-east-1 Region. Accordingly, the signature calculations
        /// in Signature Version 4 must use us-east-1 as the Region, even if the location constraint
        /// in the request specifies another Region where the bucket is to be created. If you
        /// create a bucket in a Region other than US East (N. Virginia), your application must
        /// be able to handle 307 redirect. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/VirtualHosting.html">Virtual
        /// Hosting of Buckets</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// When creating a bucket using this operation, you can optionally specify the accounts
        /// or groups that should be granted specific permissions on the bucket. There are two
        /// ways to grant the appropriate permissions using the request headers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a canned ACL using the <code>x-amz-acl</code> request header. Amazon S3 supports
        /// a set of predefined ACLs, known as <i>canned ACLs</i>. Each canned ACL has a predefined
        /// set of grantees and permissions. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#CannedACL">Canned
        /// ACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify access permissions explicitly using the <code>x-amz-grant-read</code>, <code>x-amz-grant-write</code>,
        /// <code>x-amz-grant-read-acp</code>, <code>x-amz-grant-write-acp</code>, and <code>x-amz-grant-full-control</code>
        /// headers. These headers map to the set of permissions Amazon S3 supports in an ACL.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
        /// Control List (ACL) Overview</a>.
        /// </para>
        ///  
        /// <para>
        /// You specify each grantee as a type=value pair, where the type is one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>id</code> – if the value specified is the canonical user ID of an AWS account
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>uri</code> – if you are granting permissions to a predefined group
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>emailAddress</code> – if the value specified is the email address of an AWS
        /// account
        /// </para>
        ///  <note> 
        /// <para>
        /// Using email addresses to specify a grantee is only supported in the following AWS
        /// Regions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// US East (N. Virginia)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// US West (N. California)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  US West (Oregon)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Asia Pacific (Singapore)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Sydney)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Tokyo)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Europe (Ireland)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// South America (São Paulo)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a list of all the Amazon S3 supported Regions and endpoints, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#s3_region">Regions
        /// and Endpoints</a> in the AWS General Reference.
        /// </para>
        ///  </note> </li> </ul> 
        /// <para>
        /// For example, the following <code>x-amz-grant-read</code> header grants the AWS accounts
        /// identified by account IDs permissions to read object data and its metadata:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-grant-read: id="11112222333", id="444455556666" </code> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// You can use either a canned ACL or specify access permissions explicitly. You cannot
        /// do both.
        /// </para>
        ///  </note> 
        /// <para>
        /// The following operations are related to <code>CreateBucket</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucket</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucket service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucket service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/CreateBucket">REST API Reference for PutBucket Operation</seealso>
        public virtual Task<PutBucketResponse> PutBucketAsync(PutBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketAccelerateConfiguration

        internal virtual PutBucketAccelerateConfigurationResponse PutBucketAccelerateConfiguration(PutBucketAccelerateConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketAccelerateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketAccelerateConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutBucketAccelerateConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Sets the accelerate configuration of an existing bucket. Amazon S3 Transfer Acceleration
        /// is a bucket-level feature that enables you to perform faster data transfers to Amazon
        /// S3.
        /// 
        ///  
        /// <para>
        ///  To use this operation, you must have permission to perform the s3:PutAccelerateConfiguration
        /// action. The bucket owner has this permission by default. The bucket owner can grant
        /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        ///  The Transfer Acceleration state of a bucket can be set to one of the following two
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Enabled – Enables accelerated data transfers to the bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Suspended – Disables accelerated data transfers to the bucket.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The <a>GetBucketAccelerateConfiguration</a> operation returns the transfer acceleration
        /// state of a bucket.
        /// </para>
        ///  
        /// <para>
        /// After setting the Transfer Acceleration state of a bucket to Enabled, it might take
        /// up to thirty minutes before the data transfer rates to the bucket increase.
        /// </para>
        ///  
        /// <para>
        ///  The name of the bucket used for Transfer Acceleration must be DNS-compliant and must
        /// not contain periods (".").
        /// </para>
        ///  
        /// <para>
        ///  For more information about transfer acceleration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/transfer-acceleration.html">Transfer
        /// Acceleration</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>PutBucketAccelerateConfiguration</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketAccelerateConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketAccelerateConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketAccelerateConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketAccelerateConfiguration">REST API Reference for PutBucketAccelerateConfiguration Operation</seealso>
        public virtual Task<PutBucketAccelerateConfigurationResponse> PutBucketAccelerateConfigurationAsync(PutBucketAccelerateConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketAccelerateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketAccelerateConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketAccelerateConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketAnalyticsConfiguration

        internal virtual PutBucketAnalyticsConfigurationResponse PutBucketAnalyticsConfiguration(PutBucketAnalyticsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketAnalyticsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutBucketAnalyticsConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Sets an analytics configuration for the bucket (specified by the analytics configuration
        /// ID). You can have up to 1,000 analytics configurations per bucket.
        /// 
        ///  
        /// <para>
        /// You can choose to have storage class analysis export analysis reports sent to a comma-separated
        /// values (CSV) flat file. See the <code>DataExport</code> request element. Reports are
        /// updated daily and are based on the object filters that you configure. When selecting
        /// data export, you specify a destination bucket and an optional destination prefix where
        /// the file is written. You can export the data to a destination bucket in a different
        /// account. However, the destination bucket must be in the same Region as the bucket
        /// that you are making the PUT analytics configuration to. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/analytics-storage-class.html">Amazon
        /// S3 Analytics – Storage Class Analysis</a>. 
        /// </para>
        ///  <important> 
        /// <para>
        /// You must create a bucket policy on the destination bucket where the exported file
        /// is written to grant permissions to Amazon S3 to write objects to the bucket. For an
        /// example policy, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/example-bucket-policies.html#example-bucket-policies-use-case-9">Granting
        /// Permissions for Amazon S3 Inventory and Storage Class Analysis</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:PutAnalyticsConfiguration</code>
        /// action. The bucket owner has this permission by default. The bucket owner can grant
        /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  <p class="title"> <b>Special Errors</b> 
        /// </para>
        ///  <ul> <li> <ul> <li> 
        /// <para>
        ///  <i>HTTP Error: HTTP 400 Bad Request</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Code: InvalidArgument</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: Invalid argument.</i> 
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>HTTP Error: HTTP 400 Bad Request</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Code: TooManyConfigurations</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: You are attempting to create a new configuration but have already reached
        /// the 1,000-configuration limit.</i> 
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>HTTP Error: HTTP 403 Forbidden</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Code: AccessDenied</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: You are not the owner of the specified bucket, or you do not have the s3:PutAnalyticsConfiguration
        /// bucket permission to set the configuration on the bucket.</i> 
        /// </para>
        ///  </li> </ul> </li> </ul> <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketAnalyticsConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketAnalyticsConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketAnalyticsConfiguration">REST API Reference for PutBucketAnalyticsConfiguration Operation</seealso>
        public virtual Task<PutBucketAnalyticsConfigurationResponse> PutBucketAnalyticsConfigurationAsync(PutBucketAnalyticsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketAnalyticsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketAnalyticsConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketEncryption

        internal virtual PutBucketEncryptionResponse PutBucketEncryption(PutBucketEncryptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketEncryptionResponseUnmarshaller.Instance;

            return Invoke<PutBucketEncryptionResponse>(request, options);
        }



        /// <summary>
        /// This implementation of the <code>PUT</code> operation uses the <code>encryption</code>
        /// subresource to set the default encryption state of an existing bucket.
        /// 
        ///  
        /// <para>
        /// This implementation of the <code>PUT</code> operation sets default encryption for
        /// a bucket using server-side encryption with Amazon S3-managed keys SSE-S3 or AWS KMS
        /// customer master keys (CMKs) (SSE-KMS). For information about the Amazon S3 default
        /// encryption feature, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/bucket-encryption.html">Amazon
        /// S3 Default Bucket Encryption</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// This operation requires AWS Signature Version 4. For more information, see <a href="sig-v4-authenticating-requests.html">
        /// Authenticating Requests (AWS Signature Version 4)</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:PutEncryptionConfiguration</code>
        /// action. The bucket owner has this permission by default. The bucket owner can grant
        /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a> in the Amazon Simple Storage Service
        /// Developer Guide. 
        /// </para>
        ///  <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketEncryption</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketEncryption</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketEncryption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketEncryption service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketEncryption">REST API Reference for PutBucketEncryption Operation</seealso>
        public virtual Task<PutBucketEncryptionResponse> PutBucketEncryptionAsync(PutBucketEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketEncryptionResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketEncryptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketInventoryConfiguration

        internal virtual PutBucketInventoryConfigurationResponse PutBucketInventoryConfiguration(PutBucketInventoryConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketInventoryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutBucketInventoryConfigurationResponse>(request, options);
        }



        /// <summary>
        /// This implementation of the <code>PUT</code> operation adds an inventory configuration
        /// (identified by the inventory ID) to the bucket. You can have up to 1,000 inventory
        /// configurations per bucket. 
        /// 
        ///  
        /// <para>
        /// Amazon S3 inventory generates inventories of the objects in the bucket on a daily
        /// or weekly basis, and the results are published to a flat file. The bucket that is
        /// inventoried is called the <i>source</i> bucket, and the bucket where the inventory
        /// flat file is stored is called the <i>destination</i> bucket. The <i>destination</i>
        /// bucket must be in the same AWS Region as the <i>source</i> bucket. 
        /// </para>
        ///  
        /// <para>
        /// When you configure an inventory for a <i>source</i> bucket, you specify the <i>destination</i>
        /// bucket where you want the inventory to be stored, and whether to generate the inventory
        /// daily or weekly. You can also configure what object metadata to include and whether
        /// to inventory all object versions or only current versions. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage-inventory.html">Amazon
        /// S3 Inventory</a> in the Amazon Simple Storage Service Developer Guide.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must create a bucket policy on the <i>destination</i> bucket to grant permissions
        /// to Amazon S3 to write objects to the bucket in the defined location. For an example
        /// policy, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/example-bucket-policies.html#example-bucket-policies-use-case-9">
        /// Granting Permissions for Amazon S3 Inventory and Storage Class Analysis</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:PutInventoryConfiguration</code>
        /// action. The bucket owner has this permission by default and can grant this permission
        /// to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a> in the Amazon Simple Storage Service
        /// Developer Guide.
        /// </para>
        ///  <p class="title"> <b>Special Errors</b> 
        /// </para>
        ///  <ul> <li> <p class="title"> <b>HTTP 400 Bad Request Error</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code:</i> InvalidArgument
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause:</i> Invalid Argument
        /// </para>
        ///  </li> </ul> </li> <li> <p class="title"> <b>HTTP 400 Bad Request Error</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code:</i> TooManyConfigurations
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause:</i> You are attempting to create a new configuration but have already reached
        /// the 1,000-configuration limit. 
        /// </para>
        ///  </li> </ul> </li> <li> <p class="title"> <b>HTTP 403 Forbidden Error</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code:</i> AccessDenied
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause:</i> You are not the owner of the specified bucket, or you do not have the
        /// <code>s3:PutInventoryConfiguration</code> bucket permission to set the configuration
        /// on the bucket. 
        /// </para>
        ///  </li> </ul> </li> </ul> <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketInventoryConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketInventoryConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBucketInventoryConfigurations</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketInventoryConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketInventoryConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketInventoryConfiguration">REST API Reference for PutBucketInventoryConfiguration Operation</seealso>
        public virtual Task<PutBucketInventoryConfigurationResponse> PutBucketInventoryConfigurationAsync(PutBucketInventoryConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketInventoryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketInventoryConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketLogging

        internal virtual PutBucketLoggingResponse PutBucketLogging(PutBucketLoggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketLoggingResponseUnmarshaller.Instance;

            return Invoke<PutBucketLoggingResponse>(request, options);
        }



        /// <summary>
        /// Set the logging parameters for a bucket and to specify permissions for who can view
        /// and modify the logging parameters. All logs are saved to buckets in the same AWS Region
        /// as the source bucket. To set the logging status of a bucket, you must be the bucket
        /// owner.
        /// 
        ///  
        /// <para>
        /// The bucket owner is automatically granted FULL_CONTROL to all logs. You use the <code>Grantee</code>
        /// request element to grant access to other people. The <code>Permissions</code> request
        /// element specifies the kind of access the grantee has to the logs.
        /// </para>
        ///  
        /// <para>
        ///  <b>Grantee Values</b> 
        /// </para>
        ///  
        /// <para>
        /// You can specify the person (grantee) to whom you're assigning access rights (using
        /// request elements) in the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// By the person's ID:
        /// </para>
        ///  
        /// <para>
        ///  <code>&lt;Grantee xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:type="CanonicalUser"&gt;&lt;ID&gt;&lt;&gt;ID&lt;&gt;&lt;/ID&gt;&lt;DisplayName&gt;&lt;&gt;GranteesEmail&lt;&gt;&lt;/DisplayName&gt;
        /// &lt;/Grantee&gt;</code> 
        /// </para>
        ///  
        /// <para>
        /// DisplayName is optional and ignored in the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// By Email address:
        /// </para>
        ///  
        /// <para>
        ///  <code> &lt;Grantee xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:type="AmazonCustomerByEmail"&gt;&lt;EmailAddress&gt;&lt;&gt;Grantees@email.com&lt;&gt;&lt;/EmailAddress&gt;&lt;/Grantee&gt;</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The grantee is resolved to the CanonicalUser and, in a response to a GET Object acl
        /// request, appears as the CanonicalUser.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// By URI:
        /// </para>
        ///  
        /// <para>
        ///  <code>&lt;Grantee xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:type="Group"&gt;&lt;URI&gt;&lt;&gt;http://acs.amazonaws.com/groups/global/AuthenticatedUsers&lt;&gt;&lt;/URI&gt;&lt;/Grantee&gt;</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To enable logging, you use LoggingEnabled and its children request elements. To disable
        /// logging, you use an empty BucketLoggingStatus request element:
        /// </para>
        ///  
        /// <para>
        ///  <code>&lt;BucketLoggingStatus xmlns="http://doc.s3.amazonaws.com/2006-03-01" /&gt;</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information about server access logging, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerLogs.html">Server
        /// Access Logging</a>. 
        /// </para>
        ///  
        /// <para>
        /// For more information about creating a bucket, see <a>CreateBucket</a>. For more information
        /// about returning the logging status of a bucket, see <a>GetBucketLogging</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>PutBucketLogging</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketLogging</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketLogging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketLogging service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketLogging">REST API Reference for PutBucketLogging Operation</seealso>
        public virtual Task<PutBucketLoggingResponse> PutBucketLoggingAsync(PutBucketLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketLoggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketMetricsConfiguration

        internal virtual PutBucketMetricsConfigurationResponse PutBucketMetricsConfiguration(PutBucketMetricsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketMetricsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutBucketMetricsConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Sets a metrics configuration (specified by the metrics configuration ID) for the bucket.
        /// You can have up to 1,000 metrics configurations per bucket. If you're updating an
        /// existing metrics configuration, note that this is a full replacement of the existing
        /// metrics configuration. If you don't include the elements you want to keep, they are
        /// erased.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:PutMetricsConfiguration</code>
        /// action. The bucket owner has this permission by default. The bucket owner can grant
        /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about CloudWatch request metrics for Amazon S3, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/cloudwatch-monitoring.html">Monitoring
        /// Metrics with Amazon CloudWatch</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>PutBucketMetricsConfiguration</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DeleteBucketMetricsConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutBucketMetricsConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBucketMetricsConfigurations</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <code>GetBucketLifecycle</code> has the following special error:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Error code: <code>TooManyConfigurations</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: You are attempting to create a new configuration but have already reached
        /// the 1,000-configuration limit.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HTTP Status Code: HTTP 400 Bad Request
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketMetricsConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketMetricsConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketMetricsConfiguration">REST API Reference for PutBucketMetricsConfiguration Operation</seealso>
        public virtual Task<PutBucketMetricsConfigurationResponse> PutBucketMetricsConfigurationAsync(PutBucketMetricsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketMetricsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketMetricsConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketNotification

        internal virtual PutBucketNotificationResponse PutBucketNotification(PutBucketNotificationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketNotificationResponseUnmarshaller.Instance;

            return Invoke<PutBucketNotificationResponse>(request, options);
        }



        /// <summary>
        /// Enables notifications of specified events for a bucket. For more information about
        /// event notifications, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html">Configuring
        /// Event Notifications</a>.
        /// 
        ///  
        /// <para>
        /// Using this API, you can replace an existing notification configuration. The configuration
        /// is an XML file that defines the event types that you want Amazon S3 to publish and
        /// the destination where you want Amazon S3 to publish an event notification when it
        /// detects an event of the specified type.
        /// </para>
        ///  
        /// <para>
        /// By default, your bucket has no event notifications configured. That is, the notification
        /// configuration will be an empty <code>NotificationConfiguration</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>&lt;NotificationConfiguration&gt;</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>&lt;/NotificationConfiguration&gt;</code> 
        /// </para>
        ///  
        /// <para>
        /// This operation replaces the existing notification configuration with the configuration
        /// you include in the request body.
        /// </para>
        ///  
        /// <para>
        /// After Amazon S3 receives this request, it first verifies that any Amazon Simple Notification
        /// Service (Amazon SNS) or Amazon Simple Queue Service (Amazon SQS) destination exists,
        /// and that the bucket owner has permission to publish to it by sending a test notification.
        /// In the case of AWS Lambda destinations, Amazon S3 verifies that the Lambda function
        /// permissions grant Amazon S3 permission to invoke the function from the Amazon S3 bucket.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html">Configuring
        /// Notifications for Amazon S3 Events</a>.
        /// </para>
        ///  
        /// <para>
        /// You can disable notifications by adding the empty NotificationConfiguration element.
        /// </para>
        ///  
        /// <para>
        /// By default, only the bucket owner can configure notifications on a bucket. However,
        /// bucket owners can use a bucket policy to grant permission to other users to set this
        /// configuration with <code>s3:PutBucketNotification</code> permission.
        /// </para>
        ///  <note> 
        /// <para>
        /// The PUT notification is an atomic operation. For example, suppose your notification
        /// configuration includes SNS topic, SQS queue, and Lambda function configurations. When
        /// you send a PUT request with this configuration, Amazon S3 sends test messages to your
        /// SNS topic. If the message fails, the entire PUT operation will fail, and Amazon S3
        /// will not add the configuration to your bucket.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Responses</b> 
        /// </para>
        ///  
        /// <para>
        /// If the configuration in the request body includes only one <code>TopicConfiguration</code>
        /// specifying only the <code>s3:ReducedRedundancyLostObject</code> event type, the response
        /// will also include the <code>x-amz-sns-test-message-id</code> header containing the
        /// message ID of the test notification sent to the topic.
        /// </para>
        ///  
        /// <para>
        /// The following operation is related to <code>PutBucketNotificationConfiguration</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketNotificationConfiguration</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketNotification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketNotification service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketNotificationConfiguration">REST API Reference for PutBucketNotification Operation</seealso>
        public virtual Task<PutBucketNotificationResponse> PutBucketNotificationAsync(PutBucketNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketNotificationResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketNotificationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketPolicy

        internal virtual PutBucketPolicyResponse PutBucketPolicy(PutBucketPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<PutBucketPolicyResponse>(request, options);
        }


        /// <summary>
        /// Applies an Amazon S3 bucket policy to an Amazon S3 bucket. If you are using an identity
        /// other than the root user of the AWS account that owns the bucket, the calling identity
        /// must have the <code>PutBucketPolicy</code> permissions on the specified bucket and
        /// belong to the bucket owner's account in order to use this operation.
        /// 
        ///  
        /// <para>
        /// If you don't have <code>PutBucketPolicy</code> permissions, Amazon S3 returns a <code>403
        /// Access Denied</code> error. If you have the correct permissions, but you're not using
        /// an identity that belongs to the bucket owner's account, Amazon S3 returns a <code>405
        /// Method Not Allowed</code> error.
        /// </para>
        ///  <important> 
        /// <para>
        ///  As a security precaution, the root user of the AWS account that owns a bucket can
        /// always use this operation, even if the policy explicitly denies the root user the
        /// ability to perform this action. 
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about bucket policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
        /// Bucket Policies and User Policies</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>PutBucketPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucket</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <param name="policy">The bucket policy as a JSON document.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketPolicy service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketPolicy">REST API Reference for PutBucketPolicy Operation</seealso>
        public virtual Task<PutBucketPolicyResponse> PutBucketPolicyAsync(string bucketName, string policy, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutBucketPolicyRequest();
            request.BucketName = bucketName;
            request.Policy = policy;
            return PutBucketPolicyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Applies an Amazon S3 bucket policy to an Amazon S3 bucket. If you are using an identity
        /// other than the root user of the AWS account that owns the bucket, the calling identity
        /// must have the <code>PutBucketPolicy</code> permissions on the specified bucket and
        /// belong to the bucket owner's account in order to use this operation.
        /// 
        ///  
        /// <para>
        /// If you don't have <code>PutBucketPolicy</code> permissions, Amazon S3 returns a <code>403
        /// Access Denied</code> error. If you have the correct permissions, but you're not using
        /// an identity that belongs to the bucket owner's account, Amazon S3 returns a <code>405
        /// Method Not Allowed</code> error.
        /// </para>
        ///  <important> 
        /// <para>
        ///  As a security precaution, the root user of the AWS account that owns a bucket can
        /// always use this operation, even if the policy explicitly denies the root user the
        /// ability to perform this action. 
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about bucket policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
        /// Bucket Policies and User Policies</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>PutBucketPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucket</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <param name="policy">The bucket policy as a JSON document.</param>
        /// <param name="contentMD5">The MD5 hash of the request body.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketPolicy service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketPolicy">REST API Reference for PutBucketPolicy Operation</seealso>
        public virtual Task<PutBucketPolicyResponse> PutBucketPolicyAsync(string bucketName, string policy, string contentMD5, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutBucketPolicyRequest();
            request.BucketName = bucketName;
            request.Policy = policy;
            request.ContentMD5 = contentMD5;
            return PutBucketPolicyAsync(request, cancellationToken);
        }



        /// <summary>
        /// Applies an Amazon S3 bucket policy to an Amazon S3 bucket. If you are using an identity
        /// other than the root user of the AWS account that owns the bucket, the calling identity
        /// must have the <code>PutBucketPolicy</code> permissions on the specified bucket and
        /// belong to the bucket owner's account in order to use this operation.
        /// 
        ///  
        /// <para>
        /// If you don't have <code>PutBucketPolicy</code> permissions, Amazon S3 returns a <code>403
        /// Access Denied</code> error. If you have the correct permissions, but you're not using
        /// an identity that belongs to the bucket owner's account, Amazon S3 returns a <code>405
        /// Method Not Allowed</code> error.
        /// </para>
        ///  <important> 
        /// <para>
        ///  As a security precaution, the root user of the AWS account that owns a bucket can
        /// always use this operation, even if the policy explicitly denies the root user the
        /// ability to perform this action. 
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about bucket policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
        /// Bucket Policies and User Policies</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>PutBucketPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucket</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketPolicy service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketPolicy">REST API Reference for PutBucketPolicy Operation</seealso>
        public virtual Task<PutBucketPolicyResponse> PutBucketPolicyAsync(PutBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketReplication

        internal virtual PutBucketReplicationResponse PutBucketReplication(PutBucketReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketReplicationResponseUnmarshaller.Instance;

            return Invoke<PutBucketReplicationResponse>(request, options);
        }



        /// <summary>
        /// Creates a replication configuration or replaces an existing one. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/replication.html">Replication</a>
        /// in the <i>Amazon S3 Developer Guide</i>. 
        /// 
        ///  <note> 
        /// <para>
        /// To perform this operation, the user or role performing the operation must have the
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">iam:PassRole</a>
        /// permission.
        /// </para>
        ///  </note> 
        /// <para>
        /// Specify the replication configuration in the request body. In the replication configuration,
        /// you provide the name of the destination bucket where you want Amazon S3 to replicate
        /// objects, the IAM role that Amazon S3 can assume to replicate objects on your behalf,
        /// and other relevant information.
        /// </para>
        ///  
        /// <para>
        /// A replication configuration must include at least one rule, and can contain a maximum
        /// of 1,000. Each rule identifies a subset of objects to replicate by filtering the objects
        /// in the source bucket. To choose additional subsets of objects to replicate, add a
        /// rule for each subset. All rules must specify the same destination bucket.
        /// </para>
        ///  
        /// <para>
        /// To specify a subset of the objects in the source bucket to apply a replication rule
        /// to, add the Filter element as a child of the Rule element. You can filter objects
        /// based on an object key prefix, one or more object tags, or both. When you add the
        /// Filter element in the configuration, you must also add the following elements: <code>DeleteMarkerReplication</code>,
        /// <code>Status</code>, and <code>Priority</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The latest version of the replication configuration XML is V2. XML V2 replication
        /// configurations are those that contain the <code>Filter</code> element for rules, and
        /// rules that specify S3 Replication Time Control (S3 RTC). In XML V2 replication configurations,
        /// Amazon S3 doesn't replicate delete markers. Therefore, you must set the <code>DeleteMarkerReplication</code>
        /// element to <code>Disabled</code>. For backward compatibility, Amazon S3 continues
        /// to support the XML V1 replication configuration.
        /// </para>
        ///  </note> 
        /// <para>
        /// For information about enabling versioning on a bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/Versioning.html">Using
        /// Versioning</a>.
        /// </para>
        ///  
        /// <para>
        /// By default, a resource owner, in this case the AWS account that created the bucket,
        /// can perform this operation. The resource owner can also grant others permissions to
        /// perform the operation. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
        /// Permissions in a Policy</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Handling Replication of Encrypted Objects</b> 
        /// </para>
        ///  
        /// <para>
        /// By default, Amazon S3 doesn't replicate objects that are stored at rest using server-side
        /// encryption with CMKs stored in AWS KMS. To replicate AWS KMS-encrypted objects, add
        /// the following: <code>SourceSelectionCriteria</code>, <code>SseKmsEncryptedObjects</code>,
        /// <code>Status</code>, <code>EncryptionConfiguration</code>, and <code>ReplicaKmsKeyID</code>.
        /// For information about replication configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/replication-config-for-kms-objects.html">Replicating
        /// Objects Created with SSE Using CMKs stored in AWS KMS</a>.
        /// </para>
        ///  
        /// <para>
        /// For information on <code>PutBucketReplication</code> errors, see <a>ReplicationErrorCodeList</a>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>PutBucketReplication</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketReplication</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketReplication</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketReplication service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketReplication">REST API Reference for PutBucketReplication Operation</seealso>
        public virtual Task<PutBucketReplicationResponse> PutBucketReplicationAsync(PutBucketReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketReplicationResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketReplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketRequestPayment

        internal virtual PutBucketRequestPaymentResponse PutBucketRequestPayment(PutBucketRequestPaymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketRequestPaymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketRequestPaymentResponseUnmarshaller.Instance;

            return Invoke<PutBucketRequestPaymentResponse>(request, options);
        }


        /// <summary>
        /// Sets the request payment configuration for a bucket. By default, the bucket owner
        /// pays for downloads from the bucket. This configuration parameter enables the bucket
        /// owner (only) to specify that the person requesting the download will be charged for
        /// the download. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RequesterPaysBuckets.html">Requester
        /// Pays Buckets</a>.
        /// 
        ///  
        /// <para>
        /// The following operations are related to <code>PutBucketRequestPayment</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketRequestPayment</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name.</param>
        /// <param name="requestPaymentConfiguration">Container for Payer.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketRequestPayment service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketRequestPayment">REST API Reference for PutBucketRequestPayment Operation</seealso>
        public virtual Task<PutBucketRequestPaymentResponse> PutBucketRequestPaymentAsync(string bucketName, RequestPaymentConfiguration requestPaymentConfiguration, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutBucketRequestPaymentRequest();
            request.BucketName = bucketName;
            request.RequestPaymentConfiguration = requestPaymentConfiguration;
            return PutBucketRequestPaymentAsync(request, cancellationToken);
        }



        /// <summary>
        /// Sets the request payment configuration for a bucket. By default, the bucket owner
        /// pays for downloads from the bucket. This configuration parameter enables the bucket
        /// owner (only) to specify that the person requesting the download will be charged for
        /// the download. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RequesterPaysBuckets.html">Requester
        /// Pays Buckets</a>.
        /// 
        ///  
        /// <para>
        /// The following operations are related to <code>PutBucketRequestPayment</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketRequestPayment</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketRequestPayment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketRequestPayment service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketRequestPayment">REST API Reference for PutBucketRequestPayment Operation</seealso>
        public virtual Task<PutBucketRequestPaymentResponse> PutBucketRequestPaymentAsync(PutBucketRequestPaymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketRequestPaymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketRequestPaymentResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketRequestPaymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketTagging

        internal virtual PutBucketTaggingResponse PutBucketTagging(PutBucketTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketTaggingResponseUnmarshaller.Instance;

            return Invoke<PutBucketTaggingResponse>(request, options);
        }


        /// <summary>
        /// Sets the tags for a bucket.
        /// 
        ///  
        /// <para>
        /// Use tags to organize your AWS bill to reflect your own cost structure. To do this,
        /// sign up to get your AWS account bill with tag key values included. Then, to see the
        /// cost of combined resources, organize your billing information according to resources
        /// with the same tag key values. For example, you can tag several resources with a specific
        /// application name, and then organize your billing information to see the total cost
        /// of that application across several services. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Cost
        /// Allocation and Tagging</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Within a bucket, if you add a tag that has the same key as an existing tag, the new
        /// value overwrites the old value. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/CostAllocTagging.html">Using
        /// Cost Allocation in Amazon S3 Bucket Tags</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:PutBucketTagging</code>
        /// action. The bucket owner has this permission by default and can grant this permission
        /// to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        ///  <code>PutBucketTagging</code> has the following special errors:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Error code: <code>InvalidTagError</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The tag provided was not a valid tag. This error can occur if the tag
        /// did not pass input validation. For information about tag restrictions, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/allocation-tag-restrictions.html">User-Defined
        /// Tag Restrictions</a> and <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/aws-tag-restrictions.html">AWS-Generated
        /// Cost Allocation Tag Restrictions</a>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Error code: <code>MalformedXMLError</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The XML provided does not match the schema.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Error code: <code>OperationAbortedError </code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: A conflicting conditional operation is currently in progress against
        /// this resource. Please try again.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Error code: <code>InternalError</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The service was unable to apply the provided tag to the bucket.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// The following operations are related to <code>PutBucketTagging</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketTagging</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketTagging</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name.</param>
        /// <param name="tagSet">A property of PutBucketTaggingRequest used to execute the PutBucketTagging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketTagging service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketTagging">REST API Reference for PutBucketTagging Operation</seealso>
        public virtual Task<PutBucketTaggingResponse> PutBucketTaggingAsync(string bucketName, List<Tag> tagSet, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutBucketTaggingRequest();
            request.BucketName = bucketName;
            request.TagSet = tagSet;
            return PutBucketTaggingAsync(request, cancellationToken);
        }



        /// <summary>
        /// Sets the tags for a bucket.
        /// 
        ///  
        /// <para>
        /// Use tags to organize your AWS bill to reflect your own cost structure. To do this,
        /// sign up to get your AWS account bill with tag key values included. Then, to see the
        /// cost of combined resources, organize your billing information according to resources
        /// with the same tag key values. For example, you can tag several resources with a specific
        /// application name, and then organize your billing information to see the total cost
        /// of that application across several services. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Cost
        /// Allocation and Tagging</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Within a bucket, if you add a tag that has the same key as an existing tag, the new
        /// value overwrites the old value. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/CostAllocTagging.html">Using
        /// Cost Allocation in Amazon S3 Bucket Tags</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:PutBucketTagging</code>
        /// action. The bucket owner has this permission by default and can grant this permission
        /// to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        ///  <code>PutBucketTagging</code> has the following special errors:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Error code: <code>InvalidTagError</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The tag provided was not a valid tag. This error can occur if the tag
        /// did not pass input validation. For information about tag restrictions, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/allocation-tag-restrictions.html">User-Defined
        /// Tag Restrictions</a> and <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/aws-tag-restrictions.html">AWS-Generated
        /// Cost Allocation Tag Restrictions</a>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Error code: <code>MalformedXMLError</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The XML provided does not match the schema.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Error code: <code>OperationAbortedError </code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: A conflicting conditional operation is currently in progress against
        /// this resource. Please try again.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Error code: <code>InternalError</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The service was unable to apply the provided tag to the bucket.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// The following operations are related to <code>PutBucketTagging</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketTagging</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketTagging</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketTagging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketTagging service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketTagging">REST API Reference for PutBucketTagging Operation</seealso>
        public virtual Task<PutBucketTaggingResponse> PutBucketTaggingAsync(PutBucketTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketTaggingResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketTaggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketVersioning

        internal virtual PutBucketVersioningResponse PutBucketVersioning(PutBucketVersioningRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketVersioningRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketVersioningResponseUnmarshaller.Instance;

            return Invoke<PutBucketVersioningResponse>(request, options);
        }



        /// <summary>
        /// Sets the versioning state of an existing bucket. To set the versioning state, you
        /// must be the bucket owner.
        /// 
        ///  
        /// <para>
        /// You can set the versioning state with one of the following values:
        /// </para>
        ///  
        /// <para>
        ///  <b>Enabled</b>—Enables versioning for the objects in the bucket. All objects added
        /// to the bucket receive a unique version ID.
        /// </para>
        ///  
        /// <para>
        ///  <b>Suspended</b>—Disables versioning for the objects in the bucket. All objects added
        /// to the bucket receive the version ID null.
        /// </para>
        ///  
        /// <para>
        /// If the versioning state has never been set on a bucket, it has no versioning state;
        /// a <a>GetBucketVersioning</a> request does not return a versioning state value.
        /// </para>
        ///  
        /// <para>
        /// If the bucket owner enables MFA Delete in the bucket versioning configuration, the
        /// bucket owner must include the <code>x-amz-mfa request</code> header and the <code>Status</code>
        /// and the <code>MfaDelete</code> request elements in a request to set the versioning
        /// state of the bucket.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you have an object expiration lifecycle policy in your non-versioned bucket and
        /// you want to maintain the same permanent delete behavior when you enable versioning,
        /// you must add a noncurrent expiration policy. The noncurrent expiration lifecycle policy
        /// will manage the deletes of the noncurrent object versions in the version-enabled bucket.
        /// (A version-enabled bucket maintains one current and zero or more noncurrent object
        /// versions.) For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html#lifecycle-and-other-bucket-config">Lifecycle
        /// and Versioning</a>.
        /// </para>
        ///  </important> <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketVersioning</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketVersioning service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketVersioning service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketVersioning">REST API Reference for PutBucketVersioning Operation</seealso>
        public virtual Task<PutBucketVersioningResponse> PutBucketVersioningAsync(PutBucketVersioningRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketVersioningRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketVersioningResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketVersioningResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketWebsite

        internal virtual PutBucketWebsiteResponse PutBucketWebsite(PutBucketWebsiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketWebsiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketWebsiteResponseUnmarshaller.Instance;

            return Invoke<PutBucketWebsiteResponse>(request, options);
        }


        /// <summary>
        /// Sets the configuration of the website that is specified in the <code>website</code>
        /// subresource. To configure a bucket as a website, you can add this subresource on the
        /// bucket with website configuration information such as the file name of the index document
        /// and any redirect rules. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/WebsiteHosting.html">Hosting
        /// Websites on Amazon S3</a>.
        /// 
        ///  
        /// <para>
        /// This PUT operation requires the <code>S3:PutBucketWebsite</code> permission. By default,
        /// only the bucket owner can configure the website attached to a bucket; however, bucket
        /// owners can allow other users to set the website configuration by writing a bucket
        /// policy that grants them the <code>S3:PutBucketWebsite</code> permission.
        /// </para>
        ///  
        /// <para>
        /// To redirect all website requests sent to the bucket's website endpoint, you add a
        /// website configuration with the following elements. Because all requests are sent to
        /// another website, you don't need to provide index document name for the bucket.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>WebsiteConfiguration</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RedirectAllRequestsTo</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HostName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Protocol</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you want granular control over redirects, you can use the following elements to
        /// add routing rules that describe conditions for redirecting requests and information
        /// about the redirect destination. In this case, the website configuration must provide
        /// an index document for the bucket, because some requests might not be redirected. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>WebsiteConfiguration</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IndexDocument</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Suffix</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ErrorDocument</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Key</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RoutingRules</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RoutingRule</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Condition</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HttpErrorCodeReturnedEquals</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KeyPrefixEquals</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Redirect</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Protocol</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HostName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReplaceKeyPrefixWith</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReplaceKeyWith</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HttpRedirectCode</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon S3 has a limitation of 50 routing rules per website configuration. If you require
        /// more than 50 routing rules, you can use object redirect. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/how-to-page-redirect.html">Configuring
        /// an Object Redirect</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="bucketName">The bucket name.</param>
        /// <param name="websiteConfiguration">Container for the request.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketWebsite service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketWebsite">REST API Reference for PutBucketWebsite Operation</seealso>
        public virtual Task<PutBucketWebsiteResponse> PutBucketWebsiteAsync(string bucketName, WebsiteConfiguration websiteConfiguration, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutBucketWebsiteRequest();
            request.BucketName = bucketName;
            request.WebsiteConfiguration = websiteConfiguration;
            return PutBucketWebsiteAsync(request, cancellationToken);
        }



        /// <summary>
        /// Sets the configuration of the website that is specified in the <code>website</code>
        /// subresource. To configure a bucket as a website, you can add this subresource on the
        /// bucket with website configuration information such as the file name of the index document
        /// and any redirect rules. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/WebsiteHosting.html">Hosting
        /// Websites on Amazon S3</a>.
        /// 
        ///  
        /// <para>
        /// This PUT operation requires the <code>S3:PutBucketWebsite</code> permission. By default,
        /// only the bucket owner can configure the website attached to a bucket; however, bucket
        /// owners can allow other users to set the website configuration by writing a bucket
        /// policy that grants them the <code>S3:PutBucketWebsite</code> permission.
        /// </para>
        ///  
        /// <para>
        /// To redirect all website requests sent to the bucket's website endpoint, you add a
        /// website configuration with the following elements. Because all requests are sent to
        /// another website, you don't need to provide index document name for the bucket.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>WebsiteConfiguration</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RedirectAllRequestsTo</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HostName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Protocol</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you want granular control over redirects, you can use the following elements to
        /// add routing rules that describe conditions for redirecting requests and information
        /// about the redirect destination. In this case, the website configuration must provide
        /// an index document for the bucket, because some requests might not be redirected. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>WebsiteConfiguration</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IndexDocument</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Suffix</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ErrorDocument</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Key</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RoutingRules</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RoutingRule</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Condition</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HttpErrorCodeReturnedEquals</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KeyPrefixEquals</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Redirect</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Protocol</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HostName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReplaceKeyPrefixWith</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReplaceKeyWith</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HttpRedirectCode</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon S3 has a limitation of 50 routing rules per website configuration. If you require
        /// more than 50 routing rules, you can use object redirect. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/how-to-page-redirect.html">Configuring
        /// an Object Redirect</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketWebsite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketWebsite service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketWebsite">REST API Reference for PutBucketWebsite Operation</seealso>
        public virtual Task<PutBucketWebsiteResponse> PutBucketWebsiteAsync(PutBucketWebsiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketWebsiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketWebsiteResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketWebsiteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutCORSConfiguration

        internal virtual PutCORSConfigurationResponse PutCORSConfiguration(PutCORSConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutCORSConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCORSConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutCORSConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Sets the <code>cors</code> configuration for your bucket. If the configuration exists,
        /// Amazon S3 replaces it.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must be allowed to perform the <code>s3:PutBucketCORS</code>
        /// action. By default, the bucket owner has this permission and can grant it to others.
        /// </para>
        ///  
        /// <para>
        /// You set this configuration on a bucket so that the bucket can service cross-origin
        /// requests. For example, you might want to enable a request whose origin is <code>http://www.example.com</code>
        /// to access your Amazon S3 bucket at <code>my.example.bucket.com</code> by using the
        /// browser's <code>XMLHttpRequest</code> capability.
        /// </para>
        ///  
        /// <para>
        /// To enable cross-origin resource sharing (CORS) on a bucket, you add the <code>cors</code>
        /// subresource to the bucket. The <code>cors</code> subresource is an XML document in
        /// which you configure rules that identify origins and the HTTP methods that can be executed
        /// on your bucket. The document is limited to 64 KB in size. 
        /// </para>
        ///  
        /// <para>
        /// When Amazon S3 receives a cross-origin request (or a pre-flight OPTIONS request) against
        /// a bucket, it evaluates the <code>cors</code> configuration on the bucket and uses
        /// the first <code>CORSRule</code> rule that matches the incoming browser request to
        /// enable a cross-origin request. For a rule to match, the following conditions must
        /// be met:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The request's <code>Origin</code> header must match <code>AllowedOrigin</code> elements.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The request method (for example, GET, PUT, HEAD, and so on) or the <code>Access-Control-Request-Method</code>
        /// header in case of a pre-flight <code>OPTIONS</code> request must be one of the <code>AllowedMethod</code>
        /// elements. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Every header specified in the <code>Access-Control-Request-Headers</code> request
        /// header of a pre-flight request must match an <code>AllowedHeader</code> element. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information about CORS, go to <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/cors.html">Enabling
        /// Cross-Origin Resource Sharing</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i>.
        /// </para>
        ///  <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketCors</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketCors</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RESTOPTIONSobject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">Specifies the bucket impacted by the <code>cors</code>configuration.</param>
        /// <param name="configuration">Describes the cross-origin access configuration for objects in an Amazon S3 bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/cors.html">Enabling Cross-Origin Resource Sharing</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutCORSConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketCors">REST API Reference for PutCORSConfiguration Operation</seealso>
        public virtual Task<PutCORSConfigurationResponse> PutCORSConfigurationAsync(string bucketName, CORSConfiguration configuration, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutCORSConfigurationRequest();
            request.BucketName = bucketName;
            request.Configuration = configuration;
            return PutCORSConfigurationAsync(request, cancellationToken);
        }



        /// <summary>
        /// Sets the <code>cors</code> configuration for your bucket. If the configuration exists,
        /// Amazon S3 replaces it.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must be allowed to perform the <code>s3:PutBucketCORS</code>
        /// action. By default, the bucket owner has this permission and can grant it to others.
        /// </para>
        ///  
        /// <para>
        /// You set this configuration on a bucket so that the bucket can service cross-origin
        /// requests. For example, you might want to enable a request whose origin is <code>http://www.example.com</code>
        /// to access your Amazon S3 bucket at <code>my.example.bucket.com</code> by using the
        /// browser's <code>XMLHttpRequest</code> capability.
        /// </para>
        ///  
        /// <para>
        /// To enable cross-origin resource sharing (CORS) on a bucket, you add the <code>cors</code>
        /// subresource to the bucket. The <code>cors</code> subresource is an XML document in
        /// which you configure rules that identify origins and the HTTP methods that can be executed
        /// on your bucket. The document is limited to 64 KB in size. 
        /// </para>
        ///  
        /// <para>
        /// When Amazon S3 receives a cross-origin request (or a pre-flight OPTIONS request) against
        /// a bucket, it evaluates the <code>cors</code> configuration on the bucket and uses
        /// the first <code>CORSRule</code> rule that matches the incoming browser request to
        /// enable a cross-origin request. For a rule to match, the following conditions must
        /// be met:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The request's <code>Origin</code> header must match <code>AllowedOrigin</code> elements.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The request method (for example, GET, PUT, HEAD, and so on) or the <code>Access-Control-Request-Method</code>
        /// header in case of a pre-flight <code>OPTIONS</code> request must be one of the <code>AllowedMethod</code>
        /// elements. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Every header specified in the <code>Access-Control-Request-Headers</code> request
        /// header of a pre-flight request must match an <code>AllowedHeader</code> element. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information about CORS, go to <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/cors.html">Enabling
        /// Cross-Origin Resource Sharing</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i>.
        /// </para>
        ///  <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketCors</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketCors</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RESTOPTIONSobject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutCORSConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutCORSConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketCors">REST API Reference for PutCORSConfiguration Operation</seealso>
        public virtual Task<PutCORSConfigurationResponse> PutCORSConfigurationAsync(PutCORSConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutCORSConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCORSConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutCORSConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutLifecycleConfiguration

        internal virtual PutLifecycleConfigurationResponse PutLifecycleConfiguration(PutLifecycleConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLifecycleConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutLifecycleConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Creates a new lifecycle configuration for the bucket or replaces an existing lifecycle
        /// configuration. For information about lifecycle configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Bucket lifecycle configuration now supports specifying a lifecycle rule using an object
        /// key name prefix, one or more object tags, or a combination of both. Accordingly, this
        /// section describes the latest API. The previous version of the API supported filtering
        /// based only on an object key name prefix, which is supported for backward compatibility.
        /// For the related API description, see <a>PutBucketLifecycle</a>.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Rules</b> 
        /// </para>
        ///  
        /// <para>
        /// You specify the lifecycle configuration in your request body. The lifecycle configuration
        /// is specified as XML consisting of one or more rules. Each rule consists of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Filter identifying a subset of objects to which the rule applies. The filter can be
        /// based on a key name prefix, object tags, or a combination of both.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Status whether the rule is in effect.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// One or more lifecycle transition and expiration actions that you want Amazon S3 to
        /// perform on the objects identified by the filter. If the state of your bucket is versioning-enabled
        /// or versioning-suspended, you can have many versions of the same object (one current
        /// version and zero or more noncurrent versions). Amazon S3 provides predefined actions
        /// that you can specify for current and noncurrent object versions.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html">Object
        /// Lifecycle Management</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/intro-lifecycle-rules.html">Lifecycle
        /// Configuration Elements</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// By default, all Amazon S3 resources are private, including buckets, objects, and related
        /// subresources (for example, lifecycle configuration and website configuration). Only
        /// the resource owner (that is, the AWS account that created it) can access the resource.
        /// The resource owner can optionally grant access permissions to others by writing an
        /// access policy. For this operation, a user must get the s3:PutLifecycleConfiguration
        /// permission.
        /// </para>
        ///  
        /// <para>
        /// You can also explicitly deny permissions. Explicit deny also supersedes any other
        /// permissions. If you want to block users or accounts from removing or deleting objects
        /// from your bucket, you must deny them permissions for the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// s3:DeleteObject
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3:DeleteObjectVersion
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3:PutLifecycleConfiguration
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// The following are related to <code>PutBucketLifecycleConfiguration</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/lifecycle-configuration-examples.html">Examples
        /// of Lifecycle Configuration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketLifecycleConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketLifecycle</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The name of the bucket for which to set the configuration.</param>
        /// <param name="configuration">A property of PutLifecycleConfigurationRequest used to execute the PutLifecycleConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutLifecycleConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketLifecycleConfiguration">REST API Reference for PutLifecycleConfiguration Operation</seealso>
        public virtual Task<PutLifecycleConfigurationResponse> PutLifecycleConfigurationAsync(string bucketName, LifecycleConfiguration configuration, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutLifecycleConfigurationRequest();
            request.BucketName = bucketName;
            request.Configuration = configuration;
            return PutLifecycleConfigurationAsync(request, cancellationToken);
        }



        /// <summary>
        /// Creates a new lifecycle configuration for the bucket or replaces an existing lifecycle
        /// configuration. For information about lifecycle configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Bucket lifecycle configuration now supports specifying a lifecycle rule using an object
        /// key name prefix, one or more object tags, or a combination of both. Accordingly, this
        /// section describes the latest API. The previous version of the API supported filtering
        /// based only on an object key name prefix, which is supported for backward compatibility.
        /// For the related API description, see <a>PutBucketLifecycle</a>.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Rules</b> 
        /// </para>
        ///  
        /// <para>
        /// You specify the lifecycle configuration in your request body. The lifecycle configuration
        /// is specified as XML consisting of one or more rules. Each rule consists of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Filter identifying a subset of objects to which the rule applies. The filter can be
        /// based on a key name prefix, object tags, or a combination of both.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Status whether the rule is in effect.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// One or more lifecycle transition and expiration actions that you want Amazon S3 to
        /// perform on the objects identified by the filter. If the state of your bucket is versioning-enabled
        /// or versioning-suspended, you can have many versions of the same object (one current
        /// version and zero or more noncurrent versions). Amazon S3 provides predefined actions
        /// that you can specify for current and noncurrent object versions.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html">Object
        /// Lifecycle Management</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/intro-lifecycle-rules.html">Lifecycle
        /// Configuration Elements</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// By default, all Amazon S3 resources are private, including buckets, objects, and related
        /// subresources (for example, lifecycle configuration and website configuration). Only
        /// the resource owner (that is, the AWS account that created it) can access the resource.
        /// The resource owner can optionally grant access permissions to others by writing an
        /// access policy. For this operation, a user must get the s3:PutLifecycleConfiguration
        /// permission.
        /// </para>
        ///  
        /// <para>
        /// You can also explicitly deny permissions. Explicit deny also supersedes any other
        /// permissions. If you want to block users or accounts from removing or deleting objects
        /// from your bucket, you must deny them permissions for the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// s3:DeleteObject
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3:DeleteObjectVersion
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3:PutLifecycleConfiguration
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// The following are related to <code>PutBucketLifecycleConfiguration</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/lifecycle-configuration-examples.html">Examples
        /// of Lifecycle Configuration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketLifecycleConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketLifecycle</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutLifecycleConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutBucketLifecycleConfiguration">REST API Reference for PutLifecycleConfiguration Operation</seealso>
        public virtual Task<PutLifecycleConfigurationResponse> PutLifecycleConfigurationAsync(PutLifecycleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLifecycleConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutLifecycleConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutObject

        internal virtual PutObjectResponse PutObject(PutObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectResponseUnmarshaller.Instance;

            return Invoke<PutObjectResponse>(request, options);
        }



        /// <summary>
        /// Adds an object to a bucket. You must have WRITE permissions on a bucket to add an
        /// object to it.
        /// 
        ///  
        /// <para>
        /// Amazon S3 never adds partial objects; if you receive a success response, Amazon S3
        /// added the entire object to the bucket.
        /// </para>
        ///  
        /// <para>
        /// Amazon S3 is a distributed system. If it receives multiple write requests for the
        /// same object simultaneously, it overwrites all but the last object written. Amazon
        /// S3 does not provide object locking; if you need this, make sure to build it into your
        /// application layer or use versioning instead.
        /// </para>
        ///  
        /// <para>
        /// To ensure that data is not corrupted traversing the network, use the <code>Content-MD5</code>
        /// header. When you use this header, Amazon S3 checks the object against the provided
        /// MD5 value and, if they do not match, returns an error. Additionally, you can calculate
        /// the MD5 while putting an object to Amazon S3 and compare the returned ETag to the
        /// calculated MD5 value.
        /// </para>
        ///  <note> 
        /// <para>
        ///  The <code>Content-MD5</code> header is required for any request to upload an object
        /// with a retention period configured using Amazon S3 Object Lock. For more information
        /// about Amazon S3 Object Lock, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lock-overview.html">Amazon
        /// S3 Object Lock Overview</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Server-side Encryption</b> 
        /// </para>
        ///  
        /// <para>
        /// You can optionally request server-side encryption. With server-side encryption, Amazon
        /// S3 encrypts your data as it writes it to disks in its data centers and decrypts the
        /// data when you access it. You have the option to provide your own encryption key or
        /// use AWS managed encryption keys. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingServerSideEncryption.html">Using
        /// Server-Side Encryption</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access Control List (ACL)-Specific Request Headers</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use headers to grant ACL- based permissions. By default, all objects are private.
        /// Only the owner has full access control. When adding a new object, you can grant permissions
        /// to individual AWS accounts or to predefined groups defined by Amazon S3. These permissions
        /// are then added to the ACL on the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
        /// Control List (ACL) Overview</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-using-rest-api.html">Managing
        /// ACLs Using the REST API</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Storage Class Options</b> 
        /// </para>
        ///  
        /// <para>
        /// By default, Amazon S3 uses the STANDARD storage class to store newly created objects.
        /// The STANDARD storage class provides high durability and high availability. Depending
        /// on performance needs, you can specify a different storage class. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage-class-intro.html">Storage
        /// Classes</a> in the <i>Amazon S3 Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Versioning</b> 
        /// </para>
        ///  
        /// <para>
        /// If you enable versioning for a bucket, Amazon S3 automatically generates a unique
        /// version ID for the object being stored. Amazon S3 returns this ID in the response.
        /// When you enable versioning for a bucket, if Amazon S3 receives multiple write requests
        /// for the same object simultaneously, it stores all of the objects.
        /// </para>
        ///  
        /// <para>
        /// For more information about versioning, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/AddingObjectstoVersioningEnabledBuckets.html">Adding
        /// Objects to Versioning Enabled Buckets</a>. For information about returning the versioning
        /// state of a bucket, see <a>GetBucketVersioning</a>. 
        /// </para>
        ///  <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CopyObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteObject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutObject service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutObject">REST API Reference for PutObject Operation</seealso>
        public virtual Task<PutObjectResponse> PutObjectAsync(PutObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectResponseUnmarshaller.Instance;

            return InvokeAsync<PutObjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutObjectLegalHold

        internal virtual PutObjectLegalHoldResponse PutObjectLegalHold(PutObjectLegalHoldRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectLegalHoldResponseUnmarshaller.Instance;

            return Invoke<PutObjectLegalHoldResponse>(request, options);
        }



        /// <summary>
        /// Applies a Legal Hold configuration to the specified object.
        /// 
        ///  <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lock.html">Locking
        /// Objects</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutObjectLegalHold service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutObjectLegalHold service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutObjectLegalHold">REST API Reference for PutObjectLegalHold Operation</seealso>
        public virtual Task<PutObjectLegalHoldResponse> PutObjectLegalHoldAsync(PutObjectLegalHoldRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectLegalHoldResponseUnmarshaller.Instance;

            return InvokeAsync<PutObjectLegalHoldResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutObjectLockConfiguration

        internal virtual PutObjectLockConfigurationResponse PutObjectLockConfiguration(PutObjectLockConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectLockConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectLockConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutObjectLockConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Places an Object Lock configuration on the specified bucket. The rule specified in
        /// the Object Lock configuration will be applied by default to every new object placed
        /// in the specified bucket.
        /// 
        ///  <note> 
        /// <para>
        ///  <code>DefaultRetention</code> requires either Days or Years. You can't specify both
        /// at the same time.
        /// </para>
        ///  </note> <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lock.html">Locking
        /// Objects</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutObjectLockConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutObjectLockConfiguration service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutObjectLockConfiguration">REST API Reference for PutObjectLockConfiguration Operation</seealso>
        public virtual Task<PutObjectLockConfigurationResponse> PutObjectLockConfigurationAsync(PutObjectLockConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectLockConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectLockConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutObjectLockConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutObjectRetention

        internal virtual PutObjectRetentionResponse PutObjectRetention(PutObjectRetentionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectRetentionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectRetentionResponseUnmarshaller.Instance;

            return Invoke<PutObjectRetentionResponse>(request, options);
        }



        /// <summary>
        /// Places an Object Retention configuration on an object.
        /// 
        ///  <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lock.html">Locking
        /// Objects</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutObjectRetention service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutObjectRetention service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutObjectRetention">REST API Reference for PutObjectRetention Operation</seealso>
        public virtual Task<PutObjectRetentionResponse> PutObjectRetentionAsync(PutObjectRetentionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectRetentionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectRetentionResponseUnmarshaller.Instance;

            return InvokeAsync<PutObjectRetentionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutObjectTagging

        internal virtual PutObjectTaggingResponse PutObjectTagging(PutObjectTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectTaggingResponseUnmarshaller.Instance;

            return Invoke<PutObjectTaggingResponse>(request, options);
        }



        /// <summary>
        /// Sets the supplied tag-set to an object that already exists in a bucket.
        /// 
        ///  
        /// <para>
        /// A tag is a key-value pair. You can associate tags with an object by sending a PUT
        /// request against the tagging subresource that is associated with the object. You can
        /// retrieve tags by sending a GET request. For more information, see <a>GetObjectTagging</a>.
        /// </para>
        ///  
        /// <para>
        /// For tagging-related restrictions related to characters and encodings, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/allocation-tag-restrictions.html">Tag
        /// Restrictions</a>. Note that Amazon S3 limits the maximum number of tags to 10 tags
        /// per object.
        /// </para>
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <code>s3:PutObjectTagging</code>
        /// action. By default, the bucket owner has this permission and can grant this permission
        /// to others.
        /// </para>
        ///  
        /// <para>
        /// To put tags of any other version, use the <code>versionId</code> query parameter.
        /// You also need permission for the <code>s3:PutObjectVersionTagging</code> action.
        /// </para>
        ///  
        /// <para>
        /// For information about the Amazon S3 object tagging feature, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-tagging.html">Object
        /// Tagging</a>.
        /// </para>
        ///  <p class="title"> <b>Special Errors</b> 
        /// </para>
        ///  <ul> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: InvalidTagError </i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: The tag provided was not a valid tag. This error can occur if the tag did
        /// not pass input validation. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-tagging.html">Object
        /// Tagging</a>.</i> 
        /// </para>
        ///  </li> </ul> </li> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: MalformedXMLError </i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: The XML provided does not match the schema.</i> 
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code: OperationAbortedError </i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: A conflicting conditional operation is currently in progress against this
        /// resource. Please try again.</i> 
        /// </para>
        ///  </li> </ul> </li> <li> <ul> <li> 
        /// <para>
        ///  <i>Code: InternalError</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: The service was unable to apply the provided tag to the object.</i> 
        /// </para>
        ///  </li> </ul> </li> </ul> <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetObjectTagging</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutObjectTagging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutObjectTagging service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutObjectTagging">REST API Reference for PutObjectTagging Operation</seealso>
        public virtual Task<PutObjectTaggingResponse> PutObjectTaggingAsync(PutObjectTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectTaggingResponseUnmarshaller.Instance;

            return InvokeAsync<PutObjectTaggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutPublicAccessBlock

        internal virtual PutPublicAccessBlockResponse PutPublicAccessBlock(PutPublicAccessBlockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPublicAccessBlockResponseUnmarshaller.Instance;

            return Invoke<PutPublicAccessBlockResponse>(request, options);
        }



        /// <summary>
        /// Creates or modifies the <code>PublicAccessBlock</code> configuration for an Amazon
        /// S3 bucket. To use this operation, you must have the <code>s3:PutBucketPublicAccessBlock</code>
        /// permission. For more information about Amazon S3 permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
        /// Permissions in a Policy</a>.
        /// 
        ///  <important> 
        /// <para>
        /// When Amazon S3 evaluates the <code>PublicAccessBlock</code> configuration for a bucket
        /// or an object, it checks the <code>PublicAccessBlock</code> configuration for both
        /// the bucket (or the bucket that contains the object) and the bucket owner's account.
        /// If the <code>PublicAccessBlock</code> configurations are different between the bucket
        /// and the account, Amazon S3 uses the most restrictive combination of the bucket-level
        /// and account-level settings.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about when Amazon S3 considers a bucket or an object public,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html#access-control-block-public-access-policy-status">The
        /// Meaning of "Public"</a>.
        /// </para>
        ///  <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetPublicAccessBlock</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeletePublicAccessBlock</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketPolicyStatus</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html">Using
        /// Amazon S3 Block Public Access</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPublicAccessBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutPublicAccessBlock service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/PutPublicAccessBlock">REST API Reference for PutPublicAccessBlock Operation</seealso>
        public virtual Task<PutPublicAccessBlockResponse> PutPublicAccessBlockAsync(PutPublicAccessBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPublicAccessBlockResponseUnmarshaller.Instance;

            return InvokeAsync<PutPublicAccessBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreObject

        internal virtual RestoreObjectResponse RestoreObject(RestoreObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreObjectResponseUnmarshaller.Instance;

            return Invoke<RestoreObjectResponse>(request, options);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// 
        ///  
        /// <para>
        /// This operation performs the following types of requests: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>select</code> - Perform a select query on an archived object
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>restore an archive</code> - Restore an archived object
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:RestoreObject</code>
        /// action. The bucket owner has this permission by default and can grant this permission
        /// to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Querying Archives with Select Requests</b> 
        /// </para>
        ///  
        /// <para>
        /// You use a select type of request to perform SQL queries on archived objects. The archived
        /// objects that are being queried by the select request must be formatted as uncompressed
        /// comma-separated values (CSV) files. You can run queries and custom analytics on your
        /// archived data without having to restore your data to a hotter Amazon S3 tier. For
        /// an overview about select requests, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/querying-glacier-archives.html">Querying
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When making a select request, do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Define an output location for the select query's output. This must be an Amazon S3
        /// bucket in the same AWS Region as the bucket that contains the archive object that
        /// is being queried. The AWS account that initiates the job must have permissions to
        /// write to the S3 bucket. You can specify the storage class and encryption for the output
        /// objects stored in the bucket. For more information about output, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/querying-glacier-archives.html">Querying
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <code>S3</code> structure in the request body, see
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Managing
        /// Access with ACLs</a> in the <i>Amazon Simple Storage Service Developer Guide</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">Protecting
        /// Data Using Server-Side Encryption</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Define the SQL expression for the <code>SELECT</code> type of restoration for your
        /// query in the request body's <code>SelectParameters</code> structure. You can use expressions
        /// like the following examples.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The following expression returns all records from the specified object.
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT * FROM Object</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Assuming that you are not using any headers for data stored in the object, you can
        /// specify columns with positional headers.
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT s._1, s._2 FROM Object s WHERE s._3 &gt; 100</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you have headers and you set the <code>fileHeaderInfo</code> in the <code>CSV</code>
        /// structure in the request body to <code>USE</code>, you can specify headers in the
        /// query. (If you set the <code>fileHeaderInfo</code> field to <code>IGNORE</code>, the
        /// first row is skipped for the query.) You cannot mix ordinal positions with header
        /// column names. 
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT s.Id, s.FirstName, s.SSN FROM S3Object s</code> 
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For more information about using SQL with S3 Glacier Select restore, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-glacier-select-sql-reference.html">SQL
        /// Reference for Amazon S3 Select and S3 Glacier Select</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// When making a select request, you can also do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To expedite your queries, specify the <code>Expedited</code> tier. For more information
        /// about tiers, see "Restoring Archives," later in this topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify details about the data serialization format of both the input object that
        /// is being queried and the serialization of the CSV-encoded query results.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following are additional important facts about the select feature:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The output results are new Amazon S3 objects. Unlike archive retrievals, they are
        /// stored until explicitly deleted-manually or through a lifecycle policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can issue more than one select request on the same Amazon S3 object. Amazon S3
        /// doesn't deduplicate requests, so avoid issuing duplicate requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Amazon S3 accepts a select request even if the object has already been restored.
        /// A select request doesn’t return error response <code>409</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Restoring Archives</b> 
        /// </para>
        ///  
        /// <para>
        /// Objects in the GLACIER and DEEP_ARCHIVE storage classes are archived. To access an
        /// archived object, you must first initiate a restore request. This restores a temporary
        /// copy of the archived object. In a restore request, you specify the number of days
        /// that you want the restored copy to exist. After the specified period, Amazon S3 deletes
        /// the temporary copy but the object remains archived in the GLACIER or DEEP_ARCHIVE
        /// storage class that object was restored from. 
        /// </para>
        ///  
        /// <para>
        /// To restore a specific object version, you can provide a version ID. If you don't provide
        /// a version ID, Amazon S3 restores the current version.
        /// </para>
        ///  
        /// <para>
        /// The time it takes restore jobs to finish depends on which storage class the object
        /// is being restored from and which data access tier you specify. 
        /// </para>
        ///  
        /// <para>
        /// When restoring an archived object (or using a select request), you can specify one
        /// of the following data access tier options in the <code>Tier</code> element of the
        /// request body: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>Expedited</code> </b> - Expedited retrievals allow you to quickly access
        /// your data stored in the GLACIER storage class when occasional urgent requests for
        /// a subset of archives are required. For all but the largest archived objects (250 MB+),
        /// data accessed using Expedited retrievals are typically made available within 1–5 minutes.
        /// Provisioned capacity ensures that retrieval capacity for Expedited retrievals is available
        /// when you need it. Expedited retrievals and provisioned capacity are not available
        /// for the DEEP_ARCHIVE storage class.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Standard</code> </b> - S3 Standard retrievals allow you to access any of
        /// your archived objects within several hours. This is the default option for the GLACIER
        /// and DEEP_ARCHIVE retrieval requests that do not specify the retrieval option. S3 Standard
        /// retrievals typically complete within 3-5 hours from the GLACIER storage class and
        /// typically complete within 12 hours from the DEEP_ARCHIVE storage class. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Bulk</code> </b> - Bulk retrievals are Amazon S3 Glacier’s lowest-cost
        /// retrieval option, enabling you to retrieve large amounts, even petabytes, of data
        /// inexpensively in a day. Bulk retrievals typically complete within 5-12 hours from
        /// the GLACIER storage class and typically complete within 48 hours from the DEEP_ARCHIVE
        /// storage class.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about archive retrieval options and provisioned capacity for
        /// <code>Expedited</code> data access, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html">Restoring
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can use Amazon S3 restore speed upgrade to change the restore speed to a faster
        /// speed while it is in progress. You upgrade the speed of an in-progress restoration
        /// by issuing another restore request to the same object, setting a new <code>Tier</code>
        /// request element. When issuing a request to upgrade the restore tier, you must choose
        /// a tier that is faster than the tier that the in-progress restore is using. You must
        /// not change any other parameters, such as the <code>Days</code> request element. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html#restoring-objects-upgrade-tier.title.html">
        /// Upgrading the Speed of an In-Progress Restore</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// To get the status of object restoration, you can send a <code>HEAD</code> request.
        /// Operations return the <code>x-amz-restore</code> header, which provides information
        /// about the restoration status, in the response. You can use Amazon S3 event notifications
        /// to notify you when a restore is initiated or completed. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html">Configuring
        /// Amazon S3 Event Notifications</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// After restoring an archived object, you can update the restoration period by reissuing
        /// the request with a new period. Amazon S3 updates the restoration period relative to
        /// the current time and charges only for the request-there are no data transfer charges.
        /// You cannot update the restoration period when Amazon S3 is actively processing your
        /// current restore request for the object.
        /// </para>
        ///  
        /// <para>
        /// If your bucket has a lifecycle configuration with a rule that includes an expiration
        /// action, the object expiration overrides the life span that you specify in a restore
        /// request. For example, if you restore an object copy for 10 days, but the object is
        /// scheduled to expire in 3 days, Amazon S3 deletes the object in 3 days. For more information
        /// about lifecycle configuration, see <a>PutBucketLifecycleConfiguration</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html">Object
        /// Lifecycle Management</a> in <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Responses</b> 
        /// </para>
        ///  
        /// <para>
        /// A successful operation returns either the <code>200 OK</code> or <code>202 Accepted</code>
        /// status code. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the object copy is not previously restored, then Amazon S3 returns <code>202 Accepted</code>
        /// in the response. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the object copy is previously restored, Amazon S3 returns <code>200 OK</code> in
        /// the response. 
        /// </para>
        ///  </li> </ul> <p class="title"> <b>Special Errors</b> 
        /// </para>
        ///  <ul> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: RestoreAlreadyInProgress</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: Object restore is already in progress. (This error does not apply to SELECT
        /// type requests.)</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 409 Conflict</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix: Client</i> 
        /// </para>
        ///  </li> </ul> </li> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: GlacierExpeditedRetrievalNotAvailable</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: S3 Glacier expedited retrievals are currently not available. Try again
        /// later. (Returned if there is insufficient capacity to process the Expedited request.
        /// This error applies only to Expedited retrievals and not to S3 Standard or Bulk retrievals.)</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 503</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix: N/A</i> 
        /// </para>
        ///  </li> </ul> </li> </ul> <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketLifecycleConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketNotificationConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-glacier-select-sql-reference.html">SQL
        /// Reference for Amazon S3 Select and S3 Glacier Select </a> in the <i>Amazon Simple
        /// Storage Service Developer Guide</i> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name or containing the object to restore.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="key">Object key for which the operation was initiated.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/RestoreObject">REST API Reference for RestoreObject Operation</seealso>
        public virtual Task<RestoreObjectResponse> RestoreObjectAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return RestoreObjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// 
        ///  
        /// <para>
        /// This operation performs the following types of requests: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>select</code> - Perform a select query on an archived object
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>restore an archive</code> - Restore an archived object
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:RestoreObject</code>
        /// action. The bucket owner has this permission by default and can grant this permission
        /// to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Querying Archives with Select Requests</b> 
        /// </para>
        ///  
        /// <para>
        /// You use a select type of request to perform SQL queries on archived objects. The archived
        /// objects that are being queried by the select request must be formatted as uncompressed
        /// comma-separated values (CSV) files. You can run queries and custom analytics on your
        /// archived data without having to restore your data to a hotter Amazon S3 tier. For
        /// an overview about select requests, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/querying-glacier-archives.html">Querying
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When making a select request, do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Define an output location for the select query's output. This must be an Amazon S3
        /// bucket in the same AWS Region as the bucket that contains the archive object that
        /// is being queried. The AWS account that initiates the job must have permissions to
        /// write to the S3 bucket. You can specify the storage class and encryption for the output
        /// objects stored in the bucket. For more information about output, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/querying-glacier-archives.html">Querying
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <code>S3</code> structure in the request body, see
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Managing
        /// Access with ACLs</a> in the <i>Amazon Simple Storage Service Developer Guide</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">Protecting
        /// Data Using Server-Side Encryption</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Define the SQL expression for the <code>SELECT</code> type of restoration for your
        /// query in the request body's <code>SelectParameters</code> structure. You can use expressions
        /// like the following examples.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The following expression returns all records from the specified object.
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT * FROM Object</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Assuming that you are not using any headers for data stored in the object, you can
        /// specify columns with positional headers.
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT s._1, s._2 FROM Object s WHERE s._3 &gt; 100</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you have headers and you set the <code>fileHeaderInfo</code> in the <code>CSV</code>
        /// structure in the request body to <code>USE</code>, you can specify headers in the
        /// query. (If you set the <code>fileHeaderInfo</code> field to <code>IGNORE</code>, the
        /// first row is skipped for the query.) You cannot mix ordinal positions with header
        /// column names. 
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT s.Id, s.FirstName, s.SSN FROM S3Object s</code> 
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For more information about using SQL with S3 Glacier Select restore, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-glacier-select-sql-reference.html">SQL
        /// Reference for Amazon S3 Select and S3 Glacier Select</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// When making a select request, you can also do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To expedite your queries, specify the <code>Expedited</code> tier. For more information
        /// about tiers, see "Restoring Archives," later in this topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify details about the data serialization format of both the input object that
        /// is being queried and the serialization of the CSV-encoded query results.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following are additional important facts about the select feature:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The output results are new Amazon S3 objects. Unlike archive retrievals, they are
        /// stored until explicitly deleted-manually or through a lifecycle policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can issue more than one select request on the same Amazon S3 object. Amazon S3
        /// doesn't deduplicate requests, so avoid issuing duplicate requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Amazon S3 accepts a select request even if the object has already been restored.
        /// A select request doesn’t return error response <code>409</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Restoring Archives</b> 
        /// </para>
        ///  
        /// <para>
        /// Objects in the GLACIER and DEEP_ARCHIVE storage classes are archived. To access an
        /// archived object, you must first initiate a restore request. This restores a temporary
        /// copy of the archived object. In a restore request, you specify the number of days
        /// that you want the restored copy to exist. After the specified period, Amazon S3 deletes
        /// the temporary copy but the object remains archived in the GLACIER or DEEP_ARCHIVE
        /// storage class that object was restored from. 
        /// </para>
        ///  
        /// <para>
        /// To restore a specific object version, you can provide a version ID. If you don't provide
        /// a version ID, Amazon S3 restores the current version.
        /// </para>
        ///  
        /// <para>
        /// The time it takes restore jobs to finish depends on which storage class the object
        /// is being restored from and which data access tier you specify. 
        /// </para>
        ///  
        /// <para>
        /// When restoring an archived object (or using a select request), you can specify one
        /// of the following data access tier options in the <code>Tier</code> element of the
        /// request body: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>Expedited</code> </b> - Expedited retrievals allow you to quickly access
        /// your data stored in the GLACIER storage class when occasional urgent requests for
        /// a subset of archives are required. For all but the largest archived objects (250 MB+),
        /// data accessed using Expedited retrievals are typically made available within 1–5 minutes.
        /// Provisioned capacity ensures that retrieval capacity for Expedited retrievals is available
        /// when you need it. Expedited retrievals and provisioned capacity are not available
        /// for the DEEP_ARCHIVE storage class.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Standard</code> </b> - S3 Standard retrievals allow you to access any of
        /// your archived objects within several hours. This is the default option for the GLACIER
        /// and DEEP_ARCHIVE retrieval requests that do not specify the retrieval option. S3 Standard
        /// retrievals typically complete within 3-5 hours from the GLACIER storage class and
        /// typically complete within 12 hours from the DEEP_ARCHIVE storage class. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Bulk</code> </b> - Bulk retrievals are Amazon S3 Glacier’s lowest-cost
        /// retrieval option, enabling you to retrieve large amounts, even petabytes, of data
        /// inexpensively in a day. Bulk retrievals typically complete within 5-12 hours from
        /// the GLACIER storage class and typically complete within 48 hours from the DEEP_ARCHIVE
        /// storage class.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about archive retrieval options and provisioned capacity for
        /// <code>Expedited</code> data access, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html">Restoring
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can use Amazon S3 restore speed upgrade to change the restore speed to a faster
        /// speed while it is in progress. You upgrade the speed of an in-progress restoration
        /// by issuing another restore request to the same object, setting a new <code>Tier</code>
        /// request element. When issuing a request to upgrade the restore tier, you must choose
        /// a tier that is faster than the tier that the in-progress restore is using. You must
        /// not change any other parameters, such as the <code>Days</code> request element. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html#restoring-objects-upgrade-tier.title.html">
        /// Upgrading the Speed of an In-Progress Restore</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// To get the status of object restoration, you can send a <code>HEAD</code> request.
        /// Operations return the <code>x-amz-restore</code> header, which provides information
        /// about the restoration status, in the response. You can use Amazon S3 event notifications
        /// to notify you when a restore is initiated or completed. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html">Configuring
        /// Amazon S3 Event Notifications</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// After restoring an archived object, you can update the restoration period by reissuing
        /// the request with a new period. Amazon S3 updates the restoration period relative to
        /// the current time and charges only for the request-there are no data transfer charges.
        /// You cannot update the restoration period when Amazon S3 is actively processing your
        /// current restore request for the object.
        /// </para>
        ///  
        /// <para>
        /// If your bucket has a lifecycle configuration with a rule that includes an expiration
        /// action, the object expiration overrides the life span that you specify in a restore
        /// request. For example, if you restore an object copy for 10 days, but the object is
        /// scheduled to expire in 3 days, Amazon S3 deletes the object in 3 days. For more information
        /// about lifecycle configuration, see <a>PutBucketLifecycleConfiguration</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html">Object
        /// Lifecycle Management</a> in <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Responses</b> 
        /// </para>
        ///  
        /// <para>
        /// A successful operation returns either the <code>200 OK</code> or <code>202 Accepted</code>
        /// status code. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the object copy is not previously restored, then Amazon S3 returns <code>202 Accepted</code>
        /// in the response. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the object copy is previously restored, Amazon S3 returns <code>200 OK</code> in
        /// the response. 
        /// </para>
        ///  </li> </ul> <p class="title"> <b>Special Errors</b> 
        /// </para>
        ///  <ul> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: RestoreAlreadyInProgress</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: Object restore is already in progress. (This error does not apply to SELECT
        /// type requests.)</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 409 Conflict</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix: Client</i> 
        /// </para>
        ///  </li> </ul> </li> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: GlacierExpeditedRetrievalNotAvailable</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: S3 Glacier expedited retrievals are currently not available. Try again
        /// later. (Returned if there is insufficient capacity to process the Expedited request.
        /// This error applies only to Expedited retrievals and not to S3 Standard or Bulk retrievals.)</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 503</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix: N/A</i> 
        /// </para>
        ///  </li> </ul> </li> </ul> <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketLifecycleConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketNotificationConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-glacier-select-sql-reference.html">SQL
        /// Reference for Amazon S3 Select and S3 Glacier Select </a> in the <i>Amazon Simple
        /// Storage Service Developer Guide</i> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name or containing the object to restore.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="key">Object key for which the operation was initiated.</param>
        /// <param name="days">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/RestoreObject">REST API Reference for RestoreObject Operation</seealso>
        public virtual Task<RestoreObjectResponse> RestoreObjectAsync(string bucketName, string key, int days, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.Days = days;
            return RestoreObjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// 
        ///  
        /// <para>
        /// This operation performs the following types of requests: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>select</code> - Perform a select query on an archived object
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>restore an archive</code> - Restore an archived object
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:RestoreObject</code>
        /// action. The bucket owner has this permission by default and can grant this permission
        /// to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Querying Archives with Select Requests</b> 
        /// </para>
        ///  
        /// <para>
        /// You use a select type of request to perform SQL queries on archived objects. The archived
        /// objects that are being queried by the select request must be formatted as uncompressed
        /// comma-separated values (CSV) files. You can run queries and custom analytics on your
        /// archived data without having to restore your data to a hotter Amazon S3 tier. For
        /// an overview about select requests, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/querying-glacier-archives.html">Querying
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When making a select request, do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Define an output location for the select query's output. This must be an Amazon S3
        /// bucket in the same AWS Region as the bucket that contains the archive object that
        /// is being queried. The AWS account that initiates the job must have permissions to
        /// write to the S3 bucket. You can specify the storage class and encryption for the output
        /// objects stored in the bucket. For more information about output, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/querying-glacier-archives.html">Querying
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <code>S3</code> structure in the request body, see
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Managing
        /// Access with ACLs</a> in the <i>Amazon Simple Storage Service Developer Guide</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">Protecting
        /// Data Using Server-Side Encryption</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Define the SQL expression for the <code>SELECT</code> type of restoration for your
        /// query in the request body's <code>SelectParameters</code> structure. You can use expressions
        /// like the following examples.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The following expression returns all records from the specified object.
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT * FROM Object</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Assuming that you are not using any headers for data stored in the object, you can
        /// specify columns with positional headers.
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT s._1, s._2 FROM Object s WHERE s._3 &gt; 100</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you have headers and you set the <code>fileHeaderInfo</code> in the <code>CSV</code>
        /// structure in the request body to <code>USE</code>, you can specify headers in the
        /// query. (If you set the <code>fileHeaderInfo</code> field to <code>IGNORE</code>, the
        /// first row is skipped for the query.) You cannot mix ordinal positions with header
        /// column names. 
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT s.Id, s.FirstName, s.SSN FROM S3Object s</code> 
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For more information about using SQL with S3 Glacier Select restore, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-glacier-select-sql-reference.html">SQL
        /// Reference for Amazon S3 Select and S3 Glacier Select</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// When making a select request, you can also do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To expedite your queries, specify the <code>Expedited</code> tier. For more information
        /// about tiers, see "Restoring Archives," later in this topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify details about the data serialization format of both the input object that
        /// is being queried and the serialization of the CSV-encoded query results.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following are additional important facts about the select feature:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The output results are new Amazon S3 objects. Unlike archive retrievals, they are
        /// stored until explicitly deleted-manually or through a lifecycle policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can issue more than one select request on the same Amazon S3 object. Amazon S3
        /// doesn't deduplicate requests, so avoid issuing duplicate requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Amazon S3 accepts a select request even if the object has already been restored.
        /// A select request doesn’t return error response <code>409</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Restoring Archives</b> 
        /// </para>
        ///  
        /// <para>
        /// Objects in the GLACIER and DEEP_ARCHIVE storage classes are archived. To access an
        /// archived object, you must first initiate a restore request. This restores a temporary
        /// copy of the archived object. In a restore request, you specify the number of days
        /// that you want the restored copy to exist. After the specified period, Amazon S3 deletes
        /// the temporary copy but the object remains archived in the GLACIER or DEEP_ARCHIVE
        /// storage class that object was restored from. 
        /// </para>
        ///  
        /// <para>
        /// To restore a specific object version, you can provide a version ID. If you don't provide
        /// a version ID, Amazon S3 restores the current version.
        /// </para>
        ///  
        /// <para>
        /// The time it takes restore jobs to finish depends on which storage class the object
        /// is being restored from and which data access tier you specify. 
        /// </para>
        ///  
        /// <para>
        /// When restoring an archived object (or using a select request), you can specify one
        /// of the following data access tier options in the <code>Tier</code> element of the
        /// request body: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>Expedited</code> </b> - Expedited retrievals allow you to quickly access
        /// your data stored in the GLACIER storage class when occasional urgent requests for
        /// a subset of archives are required. For all but the largest archived objects (250 MB+),
        /// data accessed using Expedited retrievals are typically made available within 1–5 minutes.
        /// Provisioned capacity ensures that retrieval capacity for Expedited retrievals is available
        /// when you need it. Expedited retrievals and provisioned capacity are not available
        /// for the DEEP_ARCHIVE storage class.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Standard</code> </b> - S3 Standard retrievals allow you to access any of
        /// your archived objects within several hours. This is the default option for the GLACIER
        /// and DEEP_ARCHIVE retrieval requests that do not specify the retrieval option. S3 Standard
        /// retrievals typically complete within 3-5 hours from the GLACIER storage class and
        /// typically complete within 12 hours from the DEEP_ARCHIVE storage class. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Bulk</code> </b> - Bulk retrievals are Amazon S3 Glacier’s lowest-cost
        /// retrieval option, enabling you to retrieve large amounts, even petabytes, of data
        /// inexpensively in a day. Bulk retrievals typically complete within 5-12 hours from
        /// the GLACIER storage class and typically complete within 48 hours from the DEEP_ARCHIVE
        /// storage class.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about archive retrieval options and provisioned capacity for
        /// <code>Expedited</code> data access, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html">Restoring
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can use Amazon S3 restore speed upgrade to change the restore speed to a faster
        /// speed while it is in progress. You upgrade the speed of an in-progress restoration
        /// by issuing another restore request to the same object, setting a new <code>Tier</code>
        /// request element. When issuing a request to upgrade the restore tier, you must choose
        /// a tier that is faster than the tier that the in-progress restore is using. You must
        /// not change any other parameters, such as the <code>Days</code> request element. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html#restoring-objects-upgrade-tier.title.html">
        /// Upgrading the Speed of an In-Progress Restore</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// To get the status of object restoration, you can send a <code>HEAD</code> request.
        /// Operations return the <code>x-amz-restore</code> header, which provides information
        /// about the restoration status, in the response. You can use Amazon S3 event notifications
        /// to notify you when a restore is initiated or completed. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html">Configuring
        /// Amazon S3 Event Notifications</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// After restoring an archived object, you can update the restoration period by reissuing
        /// the request with a new period. Amazon S3 updates the restoration period relative to
        /// the current time and charges only for the request-there are no data transfer charges.
        /// You cannot update the restoration period when Amazon S3 is actively processing your
        /// current restore request for the object.
        /// </para>
        ///  
        /// <para>
        /// If your bucket has a lifecycle configuration with a rule that includes an expiration
        /// action, the object expiration overrides the life span that you specify in a restore
        /// request. For example, if you restore an object copy for 10 days, but the object is
        /// scheduled to expire in 3 days, Amazon S3 deletes the object in 3 days. For more information
        /// about lifecycle configuration, see <a>PutBucketLifecycleConfiguration</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html">Object
        /// Lifecycle Management</a> in <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Responses</b> 
        /// </para>
        ///  
        /// <para>
        /// A successful operation returns either the <code>200 OK</code> or <code>202 Accepted</code>
        /// status code. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the object copy is not previously restored, then Amazon S3 returns <code>202 Accepted</code>
        /// in the response. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the object copy is previously restored, Amazon S3 returns <code>200 OK</code> in
        /// the response. 
        /// </para>
        ///  </li> </ul> <p class="title"> <b>Special Errors</b> 
        /// </para>
        ///  <ul> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: RestoreAlreadyInProgress</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: Object restore is already in progress. (This error does not apply to SELECT
        /// type requests.)</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 409 Conflict</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix: Client</i> 
        /// </para>
        ///  </li> </ul> </li> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: GlacierExpeditedRetrievalNotAvailable</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: S3 Glacier expedited retrievals are currently not available. Try again
        /// later. (Returned if there is insufficient capacity to process the Expedited request.
        /// This error applies only to Expedited retrievals and not to S3 Standard or Bulk retrievals.)</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 503</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix: N/A</i> 
        /// </para>
        ///  </li> </ul> </li> </ul> <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketLifecycleConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketNotificationConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-glacier-select-sql-reference.html">SQL
        /// Reference for Amazon S3 Select and S3 Glacier Select </a> in the <i>Amazon Simple
        /// Storage Service Developer Guide</i> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name or containing the object to restore.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="key">Object key for which the operation was initiated.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/RestoreObject">REST API Reference for RestoreObject Operation</seealso>
        public virtual Task<RestoreObjectResponse> RestoreObjectAsync(string bucketName, string key, string versionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            return RestoreObjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// 
        ///  
        /// <para>
        /// This operation performs the following types of requests: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>select</code> - Perform a select query on an archived object
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>restore an archive</code> - Restore an archived object
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:RestoreObject</code>
        /// action. The bucket owner has this permission by default and can grant this permission
        /// to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Querying Archives with Select Requests</b> 
        /// </para>
        ///  
        /// <para>
        /// You use a select type of request to perform SQL queries on archived objects. The archived
        /// objects that are being queried by the select request must be formatted as uncompressed
        /// comma-separated values (CSV) files. You can run queries and custom analytics on your
        /// archived data without having to restore your data to a hotter Amazon S3 tier. For
        /// an overview about select requests, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/querying-glacier-archives.html">Querying
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When making a select request, do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Define an output location for the select query's output. This must be an Amazon S3
        /// bucket in the same AWS Region as the bucket that contains the archive object that
        /// is being queried. The AWS account that initiates the job must have permissions to
        /// write to the S3 bucket. You can specify the storage class and encryption for the output
        /// objects stored in the bucket. For more information about output, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/querying-glacier-archives.html">Querying
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <code>S3</code> structure in the request body, see
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Managing
        /// Access with ACLs</a> in the <i>Amazon Simple Storage Service Developer Guide</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">Protecting
        /// Data Using Server-Side Encryption</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Define the SQL expression for the <code>SELECT</code> type of restoration for your
        /// query in the request body's <code>SelectParameters</code> structure. You can use expressions
        /// like the following examples.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The following expression returns all records from the specified object.
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT * FROM Object</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Assuming that you are not using any headers for data stored in the object, you can
        /// specify columns with positional headers.
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT s._1, s._2 FROM Object s WHERE s._3 &gt; 100</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you have headers and you set the <code>fileHeaderInfo</code> in the <code>CSV</code>
        /// structure in the request body to <code>USE</code>, you can specify headers in the
        /// query. (If you set the <code>fileHeaderInfo</code> field to <code>IGNORE</code>, the
        /// first row is skipped for the query.) You cannot mix ordinal positions with header
        /// column names. 
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT s.Id, s.FirstName, s.SSN FROM S3Object s</code> 
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For more information about using SQL with S3 Glacier Select restore, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-glacier-select-sql-reference.html">SQL
        /// Reference for Amazon S3 Select and S3 Glacier Select</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// When making a select request, you can also do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To expedite your queries, specify the <code>Expedited</code> tier. For more information
        /// about tiers, see "Restoring Archives," later in this topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify details about the data serialization format of both the input object that
        /// is being queried and the serialization of the CSV-encoded query results.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following are additional important facts about the select feature:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The output results are new Amazon S3 objects. Unlike archive retrievals, they are
        /// stored until explicitly deleted-manually or through a lifecycle policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can issue more than one select request on the same Amazon S3 object. Amazon S3
        /// doesn't deduplicate requests, so avoid issuing duplicate requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Amazon S3 accepts a select request even if the object has already been restored.
        /// A select request doesn’t return error response <code>409</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Restoring Archives</b> 
        /// </para>
        ///  
        /// <para>
        /// Objects in the GLACIER and DEEP_ARCHIVE storage classes are archived. To access an
        /// archived object, you must first initiate a restore request. This restores a temporary
        /// copy of the archived object. In a restore request, you specify the number of days
        /// that you want the restored copy to exist. After the specified period, Amazon S3 deletes
        /// the temporary copy but the object remains archived in the GLACIER or DEEP_ARCHIVE
        /// storage class that object was restored from. 
        /// </para>
        ///  
        /// <para>
        /// To restore a specific object version, you can provide a version ID. If you don't provide
        /// a version ID, Amazon S3 restores the current version.
        /// </para>
        ///  
        /// <para>
        /// The time it takes restore jobs to finish depends on which storage class the object
        /// is being restored from and which data access tier you specify. 
        /// </para>
        ///  
        /// <para>
        /// When restoring an archived object (or using a select request), you can specify one
        /// of the following data access tier options in the <code>Tier</code> element of the
        /// request body: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>Expedited</code> </b> - Expedited retrievals allow you to quickly access
        /// your data stored in the GLACIER storage class when occasional urgent requests for
        /// a subset of archives are required. For all but the largest archived objects (250 MB+),
        /// data accessed using Expedited retrievals are typically made available within 1–5 minutes.
        /// Provisioned capacity ensures that retrieval capacity for Expedited retrievals is available
        /// when you need it. Expedited retrievals and provisioned capacity are not available
        /// for the DEEP_ARCHIVE storage class.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Standard</code> </b> - S3 Standard retrievals allow you to access any of
        /// your archived objects within several hours. This is the default option for the GLACIER
        /// and DEEP_ARCHIVE retrieval requests that do not specify the retrieval option. S3 Standard
        /// retrievals typically complete within 3-5 hours from the GLACIER storage class and
        /// typically complete within 12 hours from the DEEP_ARCHIVE storage class. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Bulk</code> </b> - Bulk retrievals are Amazon S3 Glacier’s lowest-cost
        /// retrieval option, enabling you to retrieve large amounts, even petabytes, of data
        /// inexpensively in a day. Bulk retrievals typically complete within 5-12 hours from
        /// the GLACIER storage class and typically complete within 48 hours from the DEEP_ARCHIVE
        /// storage class.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about archive retrieval options and provisioned capacity for
        /// <code>Expedited</code> data access, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html">Restoring
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can use Amazon S3 restore speed upgrade to change the restore speed to a faster
        /// speed while it is in progress. You upgrade the speed of an in-progress restoration
        /// by issuing another restore request to the same object, setting a new <code>Tier</code>
        /// request element. When issuing a request to upgrade the restore tier, you must choose
        /// a tier that is faster than the tier that the in-progress restore is using. You must
        /// not change any other parameters, such as the <code>Days</code> request element. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html#restoring-objects-upgrade-tier.title.html">
        /// Upgrading the Speed of an In-Progress Restore</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// To get the status of object restoration, you can send a <code>HEAD</code> request.
        /// Operations return the <code>x-amz-restore</code> header, which provides information
        /// about the restoration status, in the response. You can use Amazon S3 event notifications
        /// to notify you when a restore is initiated or completed. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html">Configuring
        /// Amazon S3 Event Notifications</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// After restoring an archived object, you can update the restoration period by reissuing
        /// the request with a new period. Amazon S3 updates the restoration period relative to
        /// the current time and charges only for the request-there are no data transfer charges.
        /// You cannot update the restoration period when Amazon S3 is actively processing your
        /// current restore request for the object.
        /// </para>
        ///  
        /// <para>
        /// If your bucket has a lifecycle configuration with a rule that includes an expiration
        /// action, the object expiration overrides the life span that you specify in a restore
        /// request. For example, if you restore an object copy for 10 days, but the object is
        /// scheduled to expire in 3 days, Amazon S3 deletes the object in 3 days. For more information
        /// about lifecycle configuration, see <a>PutBucketLifecycleConfiguration</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html">Object
        /// Lifecycle Management</a> in <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Responses</b> 
        /// </para>
        ///  
        /// <para>
        /// A successful operation returns either the <code>200 OK</code> or <code>202 Accepted</code>
        /// status code. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the object copy is not previously restored, then Amazon S3 returns <code>202 Accepted</code>
        /// in the response. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the object copy is previously restored, Amazon S3 returns <code>200 OK</code> in
        /// the response. 
        /// </para>
        ///  </li> </ul> <p class="title"> <b>Special Errors</b> 
        /// </para>
        ///  <ul> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: RestoreAlreadyInProgress</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: Object restore is already in progress. (This error does not apply to SELECT
        /// type requests.)</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 409 Conflict</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix: Client</i> 
        /// </para>
        ///  </li> </ul> </li> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: GlacierExpeditedRetrievalNotAvailable</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: S3 Glacier expedited retrievals are currently not available. Try again
        /// later. (Returned if there is insufficient capacity to process the Expedited request.
        /// This error applies only to Expedited retrievals and not to S3 Standard or Bulk retrievals.)</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 503</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix: N/A</i> 
        /// </para>
        ///  </li> </ul> </li> </ul> <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketLifecycleConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketNotificationConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-glacier-select-sql-reference.html">SQL
        /// Reference for Amazon S3 Select and S3 Glacier Select </a> in the <i>Amazon Simple
        /// Storage Service Developer Guide</i> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name or containing the object to restore.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="key">Object key for which the operation was initiated.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// <param name="days">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/RestoreObject">REST API Reference for RestoreObject Operation</seealso>
        public virtual Task<RestoreObjectResponse> RestoreObjectAsync(string bucketName, string key, string versionId, int days, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            request.Days = days;
            return RestoreObjectAsync(request, cancellationToken);
        }



        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// 
        ///  
        /// <para>
        /// This operation performs the following types of requests: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>select</code> - Perform a select query on an archived object
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>restore an archive</code> - Restore an archived object
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:RestoreObject</code>
        /// action. The bucket owner has this permission by default and can grant this permission
        /// to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Querying Archives with Select Requests</b> 
        /// </para>
        ///  
        /// <para>
        /// You use a select type of request to perform SQL queries on archived objects. The archived
        /// objects that are being queried by the select request must be formatted as uncompressed
        /// comma-separated values (CSV) files. You can run queries and custom analytics on your
        /// archived data without having to restore your data to a hotter Amazon S3 tier. For
        /// an overview about select requests, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/querying-glacier-archives.html">Querying
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When making a select request, do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Define an output location for the select query's output. This must be an Amazon S3
        /// bucket in the same AWS Region as the bucket that contains the archive object that
        /// is being queried. The AWS account that initiates the job must have permissions to
        /// write to the S3 bucket. You can specify the storage class and encryption for the output
        /// objects stored in the bucket. For more information about output, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/querying-glacier-archives.html">Querying
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <code>S3</code> structure in the request body, see
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Managing
        /// Access with ACLs</a> in the <i>Amazon Simple Storage Service Developer Guide</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">Protecting
        /// Data Using Server-Side Encryption</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Define the SQL expression for the <code>SELECT</code> type of restoration for your
        /// query in the request body's <code>SelectParameters</code> structure. You can use expressions
        /// like the following examples.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The following expression returns all records from the specified object.
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT * FROM Object</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Assuming that you are not using any headers for data stored in the object, you can
        /// specify columns with positional headers.
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT s._1, s._2 FROM Object s WHERE s._3 &gt; 100</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you have headers and you set the <code>fileHeaderInfo</code> in the <code>CSV</code>
        /// structure in the request body to <code>USE</code>, you can specify headers in the
        /// query. (If you set the <code>fileHeaderInfo</code> field to <code>IGNORE</code>, the
        /// first row is skipped for the query.) You cannot mix ordinal positions with header
        /// column names. 
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT s.Id, s.FirstName, s.SSN FROM S3Object s</code> 
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For more information about using SQL with S3 Glacier Select restore, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-glacier-select-sql-reference.html">SQL
        /// Reference for Amazon S3 Select and S3 Glacier Select</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// When making a select request, you can also do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To expedite your queries, specify the <code>Expedited</code> tier. For more information
        /// about tiers, see "Restoring Archives," later in this topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify details about the data serialization format of both the input object that
        /// is being queried and the serialization of the CSV-encoded query results.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following are additional important facts about the select feature:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The output results are new Amazon S3 objects. Unlike archive retrievals, they are
        /// stored until explicitly deleted-manually or through a lifecycle policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can issue more than one select request on the same Amazon S3 object. Amazon S3
        /// doesn't deduplicate requests, so avoid issuing duplicate requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Amazon S3 accepts a select request even if the object has already been restored.
        /// A select request doesn’t return error response <code>409</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Restoring Archives</b> 
        /// </para>
        ///  
        /// <para>
        /// Objects in the GLACIER and DEEP_ARCHIVE storage classes are archived. To access an
        /// archived object, you must first initiate a restore request. This restores a temporary
        /// copy of the archived object. In a restore request, you specify the number of days
        /// that you want the restored copy to exist. After the specified period, Amazon S3 deletes
        /// the temporary copy but the object remains archived in the GLACIER or DEEP_ARCHIVE
        /// storage class that object was restored from. 
        /// </para>
        ///  
        /// <para>
        /// To restore a specific object version, you can provide a version ID. If you don't provide
        /// a version ID, Amazon S3 restores the current version.
        /// </para>
        ///  
        /// <para>
        /// The time it takes restore jobs to finish depends on which storage class the object
        /// is being restored from and which data access tier you specify. 
        /// </para>
        ///  
        /// <para>
        /// When restoring an archived object (or using a select request), you can specify one
        /// of the following data access tier options in the <code>Tier</code> element of the
        /// request body: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>Expedited</code> </b> - Expedited retrievals allow you to quickly access
        /// your data stored in the GLACIER storage class when occasional urgent requests for
        /// a subset of archives are required. For all but the largest archived objects (250 MB+),
        /// data accessed using Expedited retrievals are typically made available within 1–5 minutes.
        /// Provisioned capacity ensures that retrieval capacity for Expedited retrievals is available
        /// when you need it. Expedited retrievals and provisioned capacity are not available
        /// for the DEEP_ARCHIVE storage class.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Standard</code> </b> - S3 Standard retrievals allow you to access any of
        /// your archived objects within several hours. This is the default option for the GLACIER
        /// and DEEP_ARCHIVE retrieval requests that do not specify the retrieval option. S3 Standard
        /// retrievals typically complete within 3-5 hours from the GLACIER storage class and
        /// typically complete within 12 hours from the DEEP_ARCHIVE storage class. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Bulk</code> </b> - Bulk retrievals are Amazon S3 Glacier’s lowest-cost
        /// retrieval option, enabling you to retrieve large amounts, even petabytes, of data
        /// inexpensively in a day. Bulk retrievals typically complete within 5-12 hours from
        /// the GLACIER storage class and typically complete within 48 hours from the DEEP_ARCHIVE
        /// storage class.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about archive retrieval options and provisioned capacity for
        /// <code>Expedited</code> data access, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html">Restoring
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can use Amazon S3 restore speed upgrade to change the restore speed to a faster
        /// speed while it is in progress. You upgrade the speed of an in-progress restoration
        /// by issuing another restore request to the same object, setting a new <code>Tier</code>
        /// request element. When issuing a request to upgrade the restore tier, you must choose
        /// a tier that is faster than the tier that the in-progress restore is using. You must
        /// not change any other parameters, such as the <code>Days</code> request element. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html#restoring-objects-upgrade-tier.title.html">
        /// Upgrading the Speed of an In-Progress Restore</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// To get the status of object restoration, you can send a <code>HEAD</code> request.
        /// Operations return the <code>x-amz-restore</code> header, which provides information
        /// about the restoration status, in the response. You can use Amazon S3 event notifications
        /// to notify you when a restore is initiated or completed. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html">Configuring
        /// Amazon S3 Event Notifications</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// After restoring an archived object, you can update the restoration period by reissuing
        /// the request with a new period. Amazon S3 updates the restoration period relative to
        /// the current time and charges only for the request-there are no data transfer charges.
        /// You cannot update the restoration period when Amazon S3 is actively processing your
        /// current restore request for the object.
        /// </para>
        ///  
        /// <para>
        /// If your bucket has a lifecycle configuration with a rule that includes an expiration
        /// action, the object expiration overrides the life span that you specify in a restore
        /// request. For example, if you restore an object copy for 10 days, but the object is
        /// scheduled to expire in 3 days, Amazon S3 deletes the object in 3 days. For more information
        /// about lifecycle configuration, see <a>PutBucketLifecycleConfiguration</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html">Object
        /// Lifecycle Management</a> in <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Responses</b> 
        /// </para>
        ///  
        /// <para>
        /// A successful operation returns either the <code>200 OK</code> or <code>202 Accepted</code>
        /// status code. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the object copy is not previously restored, then Amazon S3 returns <code>202 Accepted</code>
        /// in the response. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the object copy is previously restored, Amazon S3 returns <code>200 OK</code> in
        /// the response. 
        /// </para>
        ///  </li> </ul> <p class="title"> <b>Special Errors</b> 
        /// </para>
        ///  <ul> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: RestoreAlreadyInProgress</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: Object restore is already in progress. (This error does not apply to SELECT
        /// type requests.)</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 409 Conflict</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix: Client</i> 
        /// </para>
        ///  </li> </ul> </li> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: GlacierExpeditedRetrievalNotAvailable</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: S3 Glacier expedited retrievals are currently not available. Try again
        /// later. (Returned if there is insufficient capacity to process the Expedited request.
        /// This error applies only to Expedited retrievals and not to S3 Standard or Bulk retrievals.)</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 503</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix: N/A</i> 
        /// </para>
        ///  </li> </ul> </li> </ul> <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketLifecycleConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketNotificationConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-glacier-select-sql-reference.html">SQL
        /// Reference for Amazon S3 Select and S3 Glacier Select </a> in the <i>Amazon Simple
        /// Storage Service Developer Guide</i> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/RestoreObject">REST API Reference for RestoreObject Operation</seealso>
        public virtual Task<RestoreObjectResponse> RestoreObjectAsync(RestoreObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreObjectResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreObjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SelectObjectContent

        internal virtual SelectObjectContentResponse SelectObjectContent(SelectObjectContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SelectObjectContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SelectObjectContentResponseUnmarshaller.Instance;

            return Invoke<SelectObjectContentResponse>(request, options);
        }



        /// <summary>
        /// This operation filters the contents of an Amazon S3 object based on a simple structured
        /// query language (SQL) statement. In the request, along with the SQL expression, you
        /// must also specify a data serialization format (JSON, CSV, or Apache Parquet) of the
        /// object. Amazon S3 uses this format to parse object data into records, and returns
        /// only records that match the specified SQL expression. You must also specify the data
        /// serialization format for the response.
        /// 
        ///  
        /// <para>
        /// For more information about Amazon S3 Select, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/selecting-content-from-objects.html">Selecting
        /// Content from Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about using SQL with Amazon S3 Select, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-glacier-select-sql-reference.html">
        /// SQL Reference for Amazon S3 Select and S3 Glacier Select</a> in the <i>Amazon Simple
        /// Storage Service Developer Guide</i>.
        /// </para>
        ///   
        /// <para>
        ///  <b>Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// You must have <code>s3:GetObject</code> permission for this operation. Amazon S3 Select
        /// does not support anonymous access. For more information about permissions, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
        /// Permissions in a Policy</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///   
        /// <para>
        ///  <i>Object Data Formats</i> 
        /// </para>
        ///  
        /// <para>
        /// You can use Amazon S3 Select to query objects that have the following format properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>CSV, JSON, and Parquet</i> - Objects must be in CSV, JSON, or Parquet format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>UTF-8</i> - UTF-8 is the only encoding type Amazon S3 Select supports.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>GZIP or BZIP2</i> - CSV and JSON files can be compressed using GZIP or BZIP2.
        /// GZIP and BZIP2 are the only compression formats that Amazon S3 Select supports for
        /// CSV and JSON files. Amazon S3 Select supports columnar compression for Parquet using
        /// GZIP or Snappy. Amazon S3 Select does not support whole-object compression for Parquet
        /// objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Server-side encryption</i> - Amazon S3 Select supports querying objects that are
        /// protected with server-side encryption.
        /// </para>
        ///  
        /// <para>
        /// For objects that are encrypted with customer-provided encryption keys (SSE-C), you
        /// must use HTTPS, and you must use the headers that are documented in the <a>GetObject</a>.
        /// For more information about SSE-C, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Server-Side
        /// Encryption (Using Customer-Provided Encryption Keys)</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For objects that are encrypted with Amazon S3 managed encryption keys (SSE-S3) and
        /// customer master keys (CMKs) stored in AWS Key Management Service (SSE-KMS), server-side
        /// encryption is handled transparently, so you don't need to specify anything. For more
        /// information about server-side encryption, including SSE-S3 and SSE-KMS, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">Protecting
        /// Data Using Server-Side Encryption</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Working with the Response Body</b> 
        /// </para>
        ///  
        /// <para>
        /// Given the response size is unknown, Amazon S3 Select streams the response as a series
        /// of messages and includes a <code>Transfer-Encoding</code> header with <code>chunked</code>
        /// as its value in the response. For more information, see <a>RESTSelectObjectAppendix</a>
        /// .
        /// </para>
        ///   
        /// <para>
        ///  <b>GetObject Support</b> 
        /// </para>
        ///  
        /// <para>
        /// The <code>SelectObjectContent</code> operation does not support the following <code>GetObject</code>
        /// functionality. For more information, see <a>GetObject</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Range</code>: Although you can specify a scan range for an Amazon S3 Select
        /// request (see <a>SelectObjectContentRequest$ScanRange</a> in the request parameters),
        /// you cannot specify the range of bytes of an object to return. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GLACIER, DEEP_ARCHIVE and REDUCED_REDUNDANCY storage classes: You cannot specify the
        /// GLACIER, DEEP_ARCHIVE, or <code>REDUCED_REDUNDANCY</code> storage classes. For more
        /// information, about storage classes see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingMetadata.html#storage-class-intro">Storage
        /// Classes</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  </li> </ul>  
        /// <para>
        ///  <b>Special Errors</b> 
        /// </para>
        ///  
        /// <para>
        /// For a list of special errors for this operation, see <a>SelectObjectContentErrorCodeList</a>
        /// 
        /// </para>
        ///  <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketLifecycleConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutBucketLifecycleConfiguration</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SelectObjectContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SelectObjectContent service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/SelectObjectContent">REST API Reference for SelectObjectContent Operation</seealso>
        public virtual Task<SelectObjectContentResponse> SelectObjectContentAsync(SelectObjectContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SelectObjectContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SelectObjectContentResponseUnmarshaller.Instance;

            return InvokeAsync<SelectObjectContentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UploadPart

        internal virtual UploadPartResponse UploadPart(UploadPartRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UploadPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadPartResponseUnmarshaller.Instance;

            return Invoke<UploadPartResponse>(request, options);
        }



        /// <summary>
        /// Uploads a part in a multipart upload.
        /// 
        ///  <note> 
        /// <para>
        /// In this operation, you provide part data in your request. However, you have an option
        /// to specify your existing Amazon S3 object as a data source for the part you are uploading.
        /// To upload a part from an existing object, you use the <a>UploadPartCopy</a> operation.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        /// You must initiate a multipart upload (see <a>CreateMultipartUpload</a>) before you
        /// can upload any part. In response to your initiate request, Amazon S3 returns an upload
        /// ID, a unique identifier, that you must include in your upload part request.
        /// </para>
        ///  
        /// <para>
        /// Part numbers can be any number from 1 to 10,000, inclusive. A part number uniquely
        /// identifies a part and also defines its position within the object being created. If
        /// you upload a new part using the same part number that was used with a previous part,
        /// the previously uploaded part is overwritten. Each part must be at least 5 MB in size,
        /// except the last part. There is no size limit on the last part of your multipart upload.
        /// </para>
        ///  
        /// <para>
        /// To ensure that data is not corrupted when traversing the network, specify the <code>Content-MD5</code>
        /// header in the upload part request. Amazon S3 checks the part data against the provided
        /// MD5 value. If they do not match, Amazon S3 returns an error. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> After you initiate multipart upload and upload one or more parts, you
        /// must either complete or abort multipart upload in order to stop getting charged for
        /// storage of the uploaded parts. Only after you either complete or abort multipart upload,
        /// Amazon S3 frees up the parts storage and stops charging you for the parts storage.
        /// </para>
        ///  
        /// <para>
        /// For more information on multipart uploads, go to <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuoverview.html">Multipart
        /// Upload Overview</a> in the <i>Amazon Simple Storage Service Developer Guide </i>.
        /// </para>
        ///  
        /// <para>
        /// For information on the permissions required to use the multipart upload API, go to
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
        /// Upload API and Permissions</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can optionally request server-side encryption where Amazon S3 encrypts your data
        /// as it writes it to disks in its data centers and decrypts it for you when you access
        /// it. You have the option of providing your own encryption key, or you can use the AWS
        /// managed encryption keys. If you choose to provide your own encryption key, the request
        /// headers you provide in the request must match the headers you used in the request
        /// to initiate the upload by using <a>CreateMultipartUpload</a>. For more information,
        /// go to <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingServerSideEncryption.html">Using
        /// Server-Side Encryption</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Server-side encryption is supported by the S3 Multipart Upload actions. Unless you
        /// are using a customer-provided encryption key, you don't need to specify the encryption
        /// parameters in each UploadPart request. Instead, you only need to specify the server-side
        /// encryption parameters in the initial Initiate Multipart request. For more information,
        /// see <a>CreateMultipartUpload</a>.
        /// </para>
        ///  
        /// <para>
        /// If you requested server-side encryption using a customer-provided encryption key in
        /// your initiate multipart upload request, you must provide identical encryption information
        /// in each part upload using the following headers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-algorithm
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key-MD5
        /// </para>
        ///  </li> </ul> <p class="title"> <b>Special Errors</b> 
        /// </para>
        ///  <ul> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: NoSuchUpload</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: The specified multipart upload does not exist. The upload ID might be invalid,
        /// or the multipart upload might have been aborted or completed.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i> HTTP Status Code: 404 Not Found </i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix: Client</i> 
        /// </para>
        ///  </li> </ul> </li> </ul> <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CompleteMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AbortMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListParts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListMultipartUploads</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadPart service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UploadPart service method, as returned by S3.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3-2006-03-01/UploadPart">REST API Reference for UploadPart Operation</seealso>
        public virtual Task<UploadPartResponse> UploadPartAsync(UploadPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UploadPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadPartResponseUnmarshaller.Instance;

            return InvokeAsync<UploadPartResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}