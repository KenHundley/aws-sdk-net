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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CodeBuild.Model;

namespace Amazon.CodeBuild
{
    /// <summary>
    /// Interface for accessing CodeBuild
    ///
    /// AWS CodeBuild 
    /// <para>
    /// AWS CodeBuild is a fully managed build service in the cloud. AWS CodeBuild compiles
    /// your source code, runs unit tests, and produces artifacts that are ready to deploy.
    /// AWS CodeBuild eliminates the need to provision, manage, and scale your own build servers.
    /// It provides prepackaged build environments for the most popular programming languages
    /// and build tools, such as Apache Maven, Gradle, and more. You can also fully customize
    /// build environments in AWS CodeBuild to use your own build tools. AWS CodeBuild scales
    /// automatically to meet peak build requests. You pay only for the build time you consume.
    /// For more information about AWS CodeBuild, see the <i> <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/welcome.html">AWS
    /// CodeBuild User Guide</a>.</i> 
    /// </para>
    ///  
    /// <para>
    /// AWS CodeBuild supports these operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>BatchDeleteBuilds</code>: Deletes one or more builds.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>BatchGetBuilds</code>: Gets information about one or more builds.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>BatchGetProjects</code>: Gets information about one or more build projects.
    /// A <i>build project</i> defines how AWS CodeBuild runs a build. This includes information
    /// such as where to get the source code to build, the build environment to use, the build
    /// commands to run, and where to store the build output. A <i>build environment</i> is
    /// a representation of operating system, programming language runtime, and tools that
    /// AWS CodeBuild uses to run a build. You can add tags to build projects to help manage
    /// your resources and costs.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>BatchGetReportGroups</code>: Returns an array of report groups. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>BatchGetReports</code>: Returns an array of reports. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CreateProject</code>: Creates a build project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CreateReportGroup</code>: Creates a report group. A report group contains a
    /// collection of reports. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CreateWebhook</code>: For an existing AWS CodeBuild build project that has
    /// its source code stored in a GitHub or Bitbucket repository, enables AWS CodeBuild
    /// to start rebuilding the source code every time a code change is pushed to the repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteProject</code>: Deletes a build project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteReport</code>: Deletes a report. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteReportGroup</code>: Deletes a report group. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteResourcePolicy</code>: Deletes a resource policy that is identified by
    /// its resource ARN. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteSourceCredentials</code>: Deletes a set of GitHub, GitHub Enterprise,
    /// or Bitbucket source credentials.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteWebhook</code>: For an existing AWS CodeBuild build project that has
    /// its source code stored in a GitHub or Bitbucket repository, stops AWS CodeBuild from
    /// rebuilding the source code every time a code change is pushed to the repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DescribeTestCases</code>: Returns a list of details about test cases for a
    /// report. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>GetResourcePolicy</code>: Gets a resource policy that is identified by its
    /// resource ARN. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ImportSourceCredentials</code>: Imports the source repository credentials for
    /// an AWS CodeBuild project that has its source code stored in a GitHub, GitHub Enterprise,
    /// or Bitbucket repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>InvalidateProjectCache</code>: Resets the cache for a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListBuilds</code>: Gets a list of build IDs, with each build ID representing
    /// a single build.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListBuildsForProject</code>: Gets a list of build IDs for the specified build
    /// project, with each build ID representing a single build.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListCuratedEnvironmentImages</code>: Gets information about Docker images that
    /// are managed by AWS CodeBuild.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListProjects</code>: Gets a list of build project names, with each build project
    /// name representing a single build project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListReportGroups</code>: Gets a list ARNs for the report groups in the current
    /// AWS account. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListReports</code>: Gets a list ARNs for the reports in the current AWS account.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListReportsForReportGroup</code>: Returns a list of ARNs for the reports that
    /// belong to a <code>ReportGroup</code>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListSharedProjects</code>: Gets a list of ARNs associated with projects shared
    /// with the current AWS account or user.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListSharedReportGroups</code>: Gets a list of ARNs associated with report groups
    /// shared with the current AWS account or user
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListSourceCredentials</code>: Returns a list of <code>SourceCredentialsInfo</code>
    /// objects. Each <code>SourceCredentialsInfo</code> object includes the authentication
    /// type, token ARN, and type of source provider for one set of credentials.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PutResourcePolicy</code>: Stores a resource policy for the ARN of a <code>Project</code>
    /// or <code>ReportGroup</code> object. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>StartBuild</code>: Starts running a build.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>StopBuild</code>: Attempts to stop running a build.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UpdateProject</code>: Changes the settings of an existing build project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UpdateReportGroup</code>: Changes a report group.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UpdateWebhook</code>: Changes the settings of an existing webhook.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonCodeBuild : IAmazonService, IDisposable
    {

        
        #region  BatchDeleteBuilds


        /// <summary>
        /// Deletes one or more builds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteBuilds service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteBuilds service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchDeleteBuilds">REST API Reference for BatchDeleteBuilds Operation</seealso>
        BatchDeleteBuildsResponse BatchDeleteBuilds(BatchDeleteBuildsRequest request);



        /// <summary>
        /// Deletes one or more builds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteBuilds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteBuilds service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchDeleteBuilds">REST API Reference for BatchDeleteBuilds Operation</seealso>
        Task<BatchDeleteBuildsResponse> BatchDeleteBuildsAsync(BatchDeleteBuildsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetBuildBatches


        /// <summary>
        /// Retrieves information about one or more batch builds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetBuildBatches service method.</param>
        /// 
        /// <returns>The response from the BatchGetBuildBatches service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetBuildBatches">REST API Reference for BatchGetBuildBatches Operation</seealso>
        BatchGetBuildBatchesResponse BatchGetBuildBatches(BatchGetBuildBatchesRequest request);



        /// <summary>
        /// Retrieves information about one or more batch builds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetBuildBatches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetBuildBatches service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetBuildBatches">REST API Reference for BatchGetBuildBatches Operation</seealso>
        Task<BatchGetBuildBatchesResponse> BatchGetBuildBatchesAsync(BatchGetBuildBatchesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetBuilds


        /// <summary>
        /// Gets information about one or more builds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetBuilds service method.</param>
        /// 
        /// <returns>The response from the BatchGetBuilds service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetBuilds">REST API Reference for BatchGetBuilds Operation</seealso>
        BatchGetBuildsResponse BatchGetBuilds(BatchGetBuildsRequest request);



        /// <summary>
        /// Gets information about one or more builds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetBuilds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetBuilds service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetBuilds">REST API Reference for BatchGetBuilds Operation</seealso>
        Task<BatchGetBuildsResponse> BatchGetBuildsAsync(BatchGetBuildsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetProjects


        /// <summary>
        /// Gets information about one or more build projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetProjects service method.</param>
        /// 
        /// <returns>The response from the BatchGetProjects service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetProjects">REST API Reference for BatchGetProjects Operation</seealso>
        BatchGetProjectsResponse BatchGetProjects(BatchGetProjectsRequest request);



        /// <summary>
        /// Gets information about one or more build projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetProjects service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetProjects">REST API Reference for BatchGetProjects Operation</seealso>
        Task<BatchGetProjectsResponse> BatchGetProjectsAsync(BatchGetProjectsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetReportGroups


        /// <summary>
        /// Returns an array of report groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetReportGroups service method.</param>
        /// 
        /// <returns>The response from the BatchGetReportGroups service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetReportGroups">REST API Reference for BatchGetReportGroups Operation</seealso>
        BatchGetReportGroupsResponse BatchGetReportGroups(BatchGetReportGroupsRequest request);



        /// <summary>
        /// Returns an array of report groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetReportGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetReportGroups service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetReportGroups">REST API Reference for BatchGetReportGroups Operation</seealso>
        Task<BatchGetReportGroupsResponse> BatchGetReportGroupsAsync(BatchGetReportGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetReports


        /// <summary>
        /// Returns an array of reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetReports service method.</param>
        /// 
        /// <returns>The response from the BatchGetReports service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetReports">REST API Reference for BatchGetReports Operation</seealso>
        BatchGetReportsResponse BatchGetReports(BatchGetReportsRequest request);



        /// <summary>
        /// Returns an array of reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetReports service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetReports">REST API Reference for BatchGetReports Operation</seealso>
        Task<BatchGetReportsResponse> BatchGetReportsAsync(BatchGetReportsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateProject


        /// <summary>
        /// Creates a build project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.AccountLimitExceededException">
        /// An AWS service limit was exceeded for the calling AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceAlreadyExistsException">
        /// The specified AWS resource cannot be created, because an AWS resource with the same
        /// settings already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateProject">REST API Reference for CreateProject Operation</seealso>
        CreateProjectResponse CreateProject(CreateProjectRequest request);



        /// <summary>
        /// Creates a build project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.AccountLimitExceededException">
        /// An AWS service limit was exceeded for the calling AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceAlreadyExistsException">
        /// The specified AWS resource cannot be created, because an AWS resource with the same
        /// settings already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateProject">REST API Reference for CreateProject Operation</seealso>
        Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateReportGroup


        /// <summary>
        /// Creates a report group. A report group contains a collection of reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReportGroup service method.</param>
        /// 
        /// <returns>The response from the CreateReportGroup service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.AccountLimitExceededException">
        /// An AWS service limit was exceeded for the calling AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceAlreadyExistsException">
        /// The specified AWS resource cannot be created, because an AWS resource with the same
        /// settings already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateReportGroup">REST API Reference for CreateReportGroup Operation</seealso>
        CreateReportGroupResponse CreateReportGroup(CreateReportGroupRequest request);



        /// <summary>
        /// Creates a report group. A report group contains a collection of reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReportGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateReportGroup service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.AccountLimitExceededException">
        /// An AWS service limit was exceeded for the calling AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceAlreadyExistsException">
        /// The specified AWS resource cannot be created, because an AWS resource with the same
        /// settings already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateReportGroup">REST API Reference for CreateReportGroup Operation</seealso>
        Task<CreateReportGroupResponse> CreateReportGroupAsync(CreateReportGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateWebhook


        /// <summary>
        /// For an existing AWS CodeBuild build project that has its source code stored in a GitHub
        /// or Bitbucket repository, enables AWS CodeBuild to start rebuilding the source code
        /// every time a code change is pushed to the repository.
        /// 
        ///  <important> 
        /// <para>
        /// If you enable webhooks for an AWS CodeBuild project, and the project is used as a
        /// build step in AWS CodePipeline, then two identical builds are created for each commit.
        /// One build is triggered through webhooks, and one through AWS CodePipeline. Because
        /// billing is on a per-build basis, you are billed for both builds. Therefore, if you
        /// are using AWS CodePipeline, we recommend that you disable webhooks in AWS CodeBuild.
        /// In the AWS CodeBuild console, clear the Webhook box. For more information, see step
        /// 5 in <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/change-project.html#change-project-console">Change
        /// a Build Project's Settings</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebhook service method.</param>
        /// 
        /// <returns>The response from the CreateWebhook service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.OAuthProviderException">
        /// There was a problem with the underlying OAuth provider.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceAlreadyExistsException">
        /// The specified AWS resource cannot be created, because an AWS resource with the same
        /// settings already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateWebhook">REST API Reference for CreateWebhook Operation</seealso>
        CreateWebhookResponse CreateWebhook(CreateWebhookRequest request);



        /// <summary>
        /// For an existing AWS CodeBuild build project that has its source code stored in a GitHub
        /// or Bitbucket repository, enables AWS CodeBuild to start rebuilding the source code
        /// every time a code change is pushed to the repository.
        /// 
        ///  <important> 
        /// <para>
        /// If you enable webhooks for an AWS CodeBuild project, and the project is used as a
        /// build step in AWS CodePipeline, then two identical builds are created for each commit.
        /// One build is triggered through webhooks, and one through AWS CodePipeline. Because
        /// billing is on a per-build basis, you are billed for both builds. Therefore, if you
        /// are using AWS CodePipeline, we recommend that you disable webhooks in AWS CodeBuild.
        /// In the AWS CodeBuild console, clear the Webhook box. For more information, see step
        /// 5 in <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/change-project.html#change-project-console">Change
        /// a Build Project's Settings</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebhook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWebhook service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.OAuthProviderException">
        /// There was a problem with the underlying OAuth provider.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceAlreadyExistsException">
        /// The specified AWS resource cannot be created, because an AWS resource with the same
        /// settings already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateWebhook">REST API Reference for CreateWebhook Operation</seealso>
        Task<CreateWebhookResponse> CreateWebhookAsync(CreateWebhookRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteBuildBatch


        /// <summary>
        /// Deletes a batch build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBuildBatch service method.</param>
        /// 
        /// <returns>The response from the DeleteBuildBatch service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteBuildBatch">REST API Reference for DeleteBuildBatch Operation</seealso>
        DeleteBuildBatchResponse DeleteBuildBatch(DeleteBuildBatchRequest request);



        /// <summary>
        /// Deletes a batch build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBuildBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBuildBatch service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteBuildBatch">REST API Reference for DeleteBuildBatch Operation</seealso>
        Task<DeleteBuildBatchResponse> DeleteBuildBatchAsync(DeleteBuildBatchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteProject


        /// <summary>
        /// Deletes a build project. When you delete a project, its builds are not deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        DeleteProjectResponse DeleteProject(DeleteProjectRequest request);



        /// <summary>
        /// Deletes a build project. When you delete a project, its builds are not deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteReport


        /// <summary>
        /// Deletes a report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReport service method.</param>
        /// 
        /// <returns>The response from the DeleteReport service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteReport">REST API Reference for DeleteReport Operation</seealso>
        DeleteReportResponse DeleteReport(DeleteReportRequest request);



        /// <summary>
        /// Deletes a report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReport service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteReport">REST API Reference for DeleteReport Operation</seealso>
        Task<DeleteReportResponse> DeleteReportAsync(DeleteReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteReportGroup


        /// <summary>
        /// <code>DeleteReportGroup</code>: Deletes a report group. Before you delete a report
        /// group, you must delete its reports. Use <a href="https://docs.aws.amazon.com/codebuild/latest/APIReference/API_ListReportsForReportGroup.html">ListReportsForReportGroup</a>
        /// to get the reports in a report group. Use <a href="https://docs.aws.amazon.com/codebuild/latest/APIReference/API_DeleteReport.html">DeleteReport</a>
        /// to delete the reports. If you call <code>DeleteReportGroup</code> for a report group
        /// that contains one or more reports, an exception is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReportGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteReportGroup service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteReportGroup">REST API Reference for DeleteReportGroup Operation</seealso>
        DeleteReportGroupResponse DeleteReportGroup(DeleteReportGroupRequest request);



        /// <summary>
        /// <code>DeleteReportGroup</code>: Deletes a report group. Before you delete a report
        /// group, you must delete its reports. Use <a href="https://docs.aws.amazon.com/codebuild/latest/APIReference/API_ListReportsForReportGroup.html">ListReportsForReportGroup</a>
        /// to get the reports in a report group. Use <a href="https://docs.aws.amazon.com/codebuild/latest/APIReference/API_DeleteReport.html">DeleteReport</a>
        /// to delete the reports. If you call <code>DeleteReportGroup</code> for a report group
        /// that contains one or more reports, an exception is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReportGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReportGroup service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteReportGroup">REST API Reference for DeleteReportGroup Operation</seealso>
        Task<DeleteReportGroupResponse> DeleteReportGroupAsync(DeleteReportGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Deletes a resource policy that is identified by its resource ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);



        /// <summary>
        /// Deletes a resource policy that is identified by its resource ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSourceCredentials


        /// <summary>
        /// Deletes a set of GitHub, GitHub Enterprise, or Bitbucket source credentials.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceCredentials service method.</param>
        /// 
        /// <returns>The response from the DeleteSourceCredentials service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteSourceCredentials">REST API Reference for DeleteSourceCredentials Operation</seealso>
        DeleteSourceCredentialsResponse DeleteSourceCredentials(DeleteSourceCredentialsRequest request);



        /// <summary>
        /// Deletes a set of GitHub, GitHub Enterprise, or Bitbucket source credentials.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSourceCredentials service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteSourceCredentials">REST API Reference for DeleteSourceCredentials Operation</seealso>
        Task<DeleteSourceCredentialsResponse> DeleteSourceCredentialsAsync(DeleteSourceCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteWebhook


        /// <summary>
        /// For an existing AWS CodeBuild build project that has its source code stored in a GitHub
        /// or Bitbucket repository, stops AWS CodeBuild from rebuilding the source code every
        /// time a code change is pushed to the repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebhook service method.</param>
        /// 
        /// <returns>The response from the DeleteWebhook service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.OAuthProviderException">
        /// There was a problem with the underlying OAuth provider.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteWebhook">REST API Reference for DeleteWebhook Operation</seealso>
        DeleteWebhookResponse DeleteWebhook(DeleteWebhookRequest request);



        /// <summary>
        /// For an existing AWS CodeBuild build project that has its source code stored in a GitHub
        /// or Bitbucket repository, stops AWS CodeBuild from rebuilding the source code every
        /// time a code change is pushed to the repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebhook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWebhook service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.OAuthProviderException">
        /// There was a problem with the underlying OAuth provider.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteWebhook">REST API Reference for DeleteWebhook Operation</seealso>
        Task<DeleteWebhookResponse> DeleteWebhookAsync(DeleteWebhookRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCodeCoverages


        /// <summary>
        /// Retrieves one or more code coverage reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeCoverages service method.</param>
        /// 
        /// <returns>The response from the DescribeCodeCoverages service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DescribeCodeCoverages">REST API Reference for DescribeCodeCoverages Operation</seealso>
        DescribeCodeCoveragesResponse DescribeCodeCoverages(DescribeCodeCoveragesRequest request);



        /// <summary>
        /// Retrieves one or more code coverage reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeCoverages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCodeCoverages service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DescribeCodeCoverages">REST API Reference for DescribeCodeCoverages Operation</seealso>
        Task<DescribeCodeCoveragesResponse> DescribeCodeCoveragesAsync(DescribeCodeCoveragesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTestCases


        /// <summary>
        /// Returns a list of details about test cases for a report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTestCases service method.</param>
        /// 
        /// <returns>The response from the DescribeTestCases service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DescribeTestCases">REST API Reference for DescribeTestCases Operation</seealso>
        DescribeTestCasesResponse DescribeTestCases(DescribeTestCasesRequest request);



        /// <summary>
        /// Returns a list of details about test cases for a report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTestCases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTestCases service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DescribeTestCases">REST API Reference for DescribeTestCases Operation</seealso>
        Task<DescribeTestCasesResponse> DescribeTestCasesAsync(DescribeTestCasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResourcePolicy


        /// <summary>
        /// Gets a resource policy that is identified by its resource ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request);



        /// <summary>
        /// Gets a resource policy that is identified by its resource ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ImportSourceCredentials


        /// <summary>
        /// Imports the source repository credentials for an AWS CodeBuild project that has its
        /// source code stored in a GitHub, GitHub Enterprise, or Bitbucket repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportSourceCredentials service method.</param>
        /// 
        /// <returns>The response from the ImportSourceCredentials service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.AccountLimitExceededException">
        /// An AWS service limit was exceeded for the calling AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceAlreadyExistsException">
        /// The specified AWS resource cannot be created, because an AWS resource with the same
        /// settings already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ImportSourceCredentials">REST API Reference for ImportSourceCredentials Operation</seealso>
        ImportSourceCredentialsResponse ImportSourceCredentials(ImportSourceCredentialsRequest request);



        /// <summary>
        /// Imports the source repository credentials for an AWS CodeBuild project that has its
        /// source code stored in a GitHub, GitHub Enterprise, or Bitbucket repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportSourceCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportSourceCredentials service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.AccountLimitExceededException">
        /// An AWS service limit was exceeded for the calling AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceAlreadyExistsException">
        /// The specified AWS resource cannot be created, because an AWS resource with the same
        /// settings already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ImportSourceCredentials">REST API Reference for ImportSourceCredentials Operation</seealso>
        Task<ImportSourceCredentialsResponse> ImportSourceCredentialsAsync(ImportSourceCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  InvalidateProjectCache


        /// <summary>
        /// Resets the cache for a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvalidateProjectCache service method.</param>
        /// 
        /// <returns>The response from the InvalidateProjectCache service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/InvalidateProjectCache">REST API Reference for InvalidateProjectCache Operation</seealso>
        InvalidateProjectCacheResponse InvalidateProjectCache(InvalidateProjectCacheRequest request);



        /// <summary>
        /// Resets the cache for a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvalidateProjectCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvalidateProjectCache service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/InvalidateProjectCache">REST API Reference for InvalidateProjectCache Operation</seealso>
        Task<InvalidateProjectCacheResponse> InvalidateProjectCacheAsync(InvalidateProjectCacheRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListBuildBatches


        /// <summary>
        /// Retrieves the identifiers of your build batches in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuildBatches service method.</param>
        /// 
        /// <returns>The response from the ListBuildBatches service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildBatches">REST API Reference for ListBuildBatches Operation</seealso>
        ListBuildBatchesResponse ListBuildBatches(ListBuildBatchesRequest request);



        /// <summary>
        /// Retrieves the identifiers of your build batches in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuildBatches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBuildBatches service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildBatches">REST API Reference for ListBuildBatches Operation</seealso>
        Task<ListBuildBatchesResponse> ListBuildBatchesAsync(ListBuildBatchesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListBuildBatchesForProject


        /// <summary>
        /// Retrieves the identifiers of the build batches for a specific project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuildBatchesForProject service method.</param>
        /// 
        /// <returns>The response from the ListBuildBatchesForProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildBatchesForProject">REST API Reference for ListBuildBatchesForProject Operation</seealso>
        ListBuildBatchesForProjectResponse ListBuildBatchesForProject(ListBuildBatchesForProjectRequest request);



        /// <summary>
        /// Retrieves the identifiers of the build batches for a specific project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuildBatchesForProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBuildBatchesForProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildBatchesForProject">REST API Reference for ListBuildBatchesForProject Operation</seealso>
        Task<ListBuildBatchesForProjectResponse> ListBuildBatchesForProjectAsync(ListBuildBatchesForProjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListBuilds


        /// <summary>
        /// Gets a list of build IDs, with each build ID representing a single build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuilds service method.</param>
        /// 
        /// <returns>The response from the ListBuilds service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuilds">REST API Reference for ListBuilds Operation</seealso>
        ListBuildsResponse ListBuilds(ListBuildsRequest request);



        /// <summary>
        /// Gets a list of build IDs, with each build ID representing a single build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuilds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBuilds service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuilds">REST API Reference for ListBuilds Operation</seealso>
        Task<ListBuildsResponse> ListBuildsAsync(ListBuildsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListBuildsForProject


        /// <summary>
        /// Gets a list of build IDs for the specified build project, with each build ID representing
        /// a single build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuildsForProject service method.</param>
        /// 
        /// <returns>The response from the ListBuildsForProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildsForProject">REST API Reference for ListBuildsForProject Operation</seealso>
        ListBuildsForProjectResponse ListBuildsForProject(ListBuildsForProjectRequest request);



        /// <summary>
        /// Gets a list of build IDs for the specified build project, with each build ID representing
        /// a single build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuildsForProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBuildsForProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildsForProject">REST API Reference for ListBuildsForProject Operation</seealso>
        Task<ListBuildsForProjectResponse> ListBuildsForProjectAsync(ListBuildsForProjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCuratedEnvironmentImages


        /// <summary>
        /// Gets information about Docker images that are managed by AWS CodeBuild.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCuratedEnvironmentImages service method.</param>
        /// 
        /// <returns>The response from the ListCuratedEnvironmentImages service method, as returned by CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListCuratedEnvironmentImages">REST API Reference for ListCuratedEnvironmentImages Operation</seealso>
        ListCuratedEnvironmentImagesResponse ListCuratedEnvironmentImages(ListCuratedEnvironmentImagesRequest request);



        /// <summary>
        /// Gets information about Docker images that are managed by AWS CodeBuild.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCuratedEnvironmentImages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCuratedEnvironmentImages service method, as returned by CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListCuratedEnvironmentImages">REST API Reference for ListCuratedEnvironmentImages Operation</seealso>
        Task<ListCuratedEnvironmentImagesResponse> ListCuratedEnvironmentImagesAsync(ListCuratedEnvironmentImagesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListProjects


        /// <summary>
        /// Gets a list of build project names, with each build project name representing a single
        /// build project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListProjects">REST API Reference for ListProjects Operation</seealso>
        ListProjectsResponse ListProjects(ListProjectsRequest request);



        /// <summary>
        /// Gets a list of build project names, with each build project name representing a single
        /// build project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListProjects">REST API Reference for ListProjects Operation</seealso>
        Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListReportGroups


        /// <summary>
        /// Gets a list ARNs for the report groups in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReportGroups service method.</param>
        /// 
        /// <returns>The response from the ListReportGroups service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReportGroups">REST API Reference for ListReportGroups Operation</seealso>
        ListReportGroupsResponse ListReportGroups(ListReportGroupsRequest request);



        /// <summary>
        /// Gets a list ARNs for the report groups in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReportGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReportGroups service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReportGroups">REST API Reference for ListReportGroups Operation</seealso>
        Task<ListReportGroupsResponse> ListReportGroupsAsync(ListReportGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListReports


        /// <summary>
        /// Returns a list of ARNs for the reports in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReports service method.</param>
        /// 
        /// <returns>The response from the ListReports service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReports">REST API Reference for ListReports Operation</seealso>
        ListReportsResponse ListReports(ListReportsRequest request);



        /// <summary>
        /// Returns a list of ARNs for the reports in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReports service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReports">REST API Reference for ListReports Operation</seealso>
        Task<ListReportsResponse> ListReportsAsync(ListReportsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListReportsForReportGroup


        /// <summary>
        /// Returns a list of ARNs for the reports that belong to a <code>ReportGroup</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReportsForReportGroup service method.</param>
        /// 
        /// <returns>The response from the ListReportsForReportGroup service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReportsForReportGroup">REST API Reference for ListReportsForReportGroup Operation</seealso>
        ListReportsForReportGroupResponse ListReportsForReportGroup(ListReportsForReportGroupRequest request);



        /// <summary>
        /// Returns a list of ARNs for the reports that belong to a <code>ReportGroup</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReportsForReportGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReportsForReportGroup service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReportsForReportGroup">REST API Reference for ListReportsForReportGroup Operation</seealso>
        Task<ListReportsForReportGroupResponse> ListReportsForReportGroupAsync(ListReportsForReportGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSharedProjects


        /// <summary>
        /// Gets a list of projects that are shared with other AWS accounts or users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSharedProjects service method.</param>
        /// 
        /// <returns>The response from the ListSharedProjects service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSharedProjects">REST API Reference for ListSharedProjects Operation</seealso>
        ListSharedProjectsResponse ListSharedProjects(ListSharedProjectsRequest request);



        /// <summary>
        /// Gets a list of projects that are shared with other AWS accounts or users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSharedProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSharedProjects service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSharedProjects">REST API Reference for ListSharedProjects Operation</seealso>
        Task<ListSharedProjectsResponse> ListSharedProjectsAsync(ListSharedProjectsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSharedReportGroups


        /// <summary>
        /// Gets a list of report groups that are shared with other AWS accounts or users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSharedReportGroups service method.</param>
        /// 
        /// <returns>The response from the ListSharedReportGroups service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSharedReportGroups">REST API Reference for ListSharedReportGroups Operation</seealso>
        ListSharedReportGroupsResponse ListSharedReportGroups(ListSharedReportGroupsRequest request);



        /// <summary>
        /// Gets a list of report groups that are shared with other AWS accounts or users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSharedReportGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSharedReportGroups service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSharedReportGroups">REST API Reference for ListSharedReportGroups Operation</seealso>
        Task<ListSharedReportGroupsResponse> ListSharedReportGroupsAsync(ListSharedReportGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSourceCredentials


        /// <summary>
        /// Returns a list of <code>SourceCredentialsInfo</code> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceCredentials service method.</param>
        /// 
        /// <returns>The response from the ListSourceCredentials service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSourceCredentials">REST API Reference for ListSourceCredentials Operation</seealso>
        ListSourceCredentialsResponse ListSourceCredentials(ListSourceCredentialsRequest request);



        /// <summary>
        /// Returns a list of <code>SourceCredentialsInfo</code> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSourceCredentials service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSourceCredentials">REST API Reference for ListSourceCredentials Operation</seealso>
        Task<ListSourceCredentialsResponse> ListSourceCredentialsAsync(ListSourceCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Stores a resource policy for the ARN of a <code>Project</code> or <code>ReportGroup</code>
        /// object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);



        /// <summary>
        /// Stores a resource policy for the ARN of a <code>Project</code> or <code>ReportGroup</code>
        /// object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RetryBuild


        /// <summary>
        /// Restarts a build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryBuild service method.</param>
        /// 
        /// <returns>The response from the RetryBuild service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.AccountLimitExceededException">
        /// An AWS service limit was exceeded for the calling AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/RetryBuild">REST API Reference for RetryBuild Operation</seealso>
        RetryBuildResponse RetryBuild(RetryBuildRequest request);



        /// <summary>
        /// Restarts a build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryBuild service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetryBuild service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.AccountLimitExceededException">
        /// An AWS service limit was exceeded for the calling AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/RetryBuild">REST API Reference for RetryBuild Operation</seealso>
        Task<RetryBuildResponse> RetryBuildAsync(RetryBuildRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RetryBuildBatch


        /// <summary>
        /// Restarts a batch build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryBuildBatch service method.</param>
        /// 
        /// <returns>The response from the RetryBuildBatch service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/RetryBuildBatch">REST API Reference for RetryBuildBatch Operation</seealso>
        RetryBuildBatchResponse RetryBuildBatch(RetryBuildBatchRequest request);



        /// <summary>
        /// Restarts a batch build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryBuildBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetryBuildBatch service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/RetryBuildBatch">REST API Reference for RetryBuildBatch Operation</seealso>
        Task<RetryBuildBatchResponse> RetryBuildBatchAsync(RetryBuildBatchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartBuild


        /// <summary>
        /// Starts running a build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBuild service method.</param>
        /// 
        /// <returns>The response from the StartBuild service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.AccountLimitExceededException">
        /// An AWS service limit was exceeded for the calling AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartBuild">REST API Reference for StartBuild Operation</seealso>
        StartBuildResponse StartBuild(StartBuildRequest request);



        /// <summary>
        /// Starts running a build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBuild service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartBuild service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.AccountLimitExceededException">
        /// An AWS service limit was exceeded for the calling AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartBuild">REST API Reference for StartBuild Operation</seealso>
        Task<StartBuildResponse> StartBuildAsync(StartBuildRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartBuildBatch


        /// <summary>
        /// Starts a batch build for a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBuildBatch service method.</param>
        /// 
        /// <returns>The response from the StartBuildBatch service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartBuildBatch">REST API Reference for StartBuildBatch Operation</seealso>
        StartBuildBatchResponse StartBuildBatch(StartBuildBatchRequest request);



        /// <summary>
        /// Starts a batch build for a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBuildBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartBuildBatch service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartBuildBatch">REST API Reference for StartBuildBatch Operation</seealso>
        Task<StartBuildBatchResponse> StartBuildBatchAsync(StartBuildBatchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopBuild


        /// <summary>
        /// Attempts to stop running a build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopBuild service method.</param>
        /// 
        /// <returns>The response from the StopBuild service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopBuild">REST API Reference for StopBuild Operation</seealso>
        StopBuildResponse StopBuild(StopBuildRequest request);



        /// <summary>
        /// Attempts to stop running a build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopBuild service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopBuild service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopBuild">REST API Reference for StopBuild Operation</seealso>
        Task<StopBuildResponse> StopBuildAsync(StopBuildRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopBuildBatch


        /// <summary>
        /// Stops a running batch build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopBuildBatch service method.</param>
        /// 
        /// <returns>The response from the StopBuildBatch service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopBuildBatch">REST API Reference for StopBuildBatch Operation</seealso>
        StopBuildBatchResponse StopBuildBatch(StopBuildBatchRequest request);



        /// <summary>
        /// Stops a running batch build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopBuildBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopBuildBatch service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopBuildBatch">REST API Reference for StopBuildBatch Operation</seealso>
        Task<StopBuildBatchResponse> StopBuildBatchAsync(StopBuildBatchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateProject


        /// <summary>
        /// Changes the settings of a build project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        UpdateProjectResponse UpdateProject(UpdateProjectRequest request);



        /// <summary>
        /// Changes the settings of a build project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateReportGroup


        /// <summary>
        /// Updates a report group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReportGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateReportGroup service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateReportGroup">REST API Reference for UpdateReportGroup Operation</seealso>
        UpdateReportGroupResponse UpdateReportGroup(UpdateReportGroupRequest request);



        /// <summary>
        /// Updates a report group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReportGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateReportGroup service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateReportGroup">REST API Reference for UpdateReportGroup Operation</seealso>
        Task<UpdateReportGroupResponse> UpdateReportGroupAsync(UpdateReportGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateWebhook


        /// <summary>
        /// Updates the webhook associated with an AWS CodeBuild build project. 
        /// 
        ///  <note> 
        /// <para>
        ///  If you use Bitbucket for your repository, <code>rotateSecret</code> is ignored. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebhook service method.</param>
        /// 
        /// <returns>The response from the UpdateWebhook service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.OAuthProviderException">
        /// There was a problem with the underlying OAuth provider.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateWebhook">REST API Reference for UpdateWebhook Operation</seealso>
        UpdateWebhookResponse UpdateWebhook(UpdateWebhookRequest request);



        /// <summary>
        /// Updates the webhook associated with an AWS CodeBuild build project. 
        /// 
        ///  <note> 
        /// <para>
        ///  If you use Bitbucket for your repository, <code>rotateSecret</code> is ignored. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebhook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWebhook service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.OAuthProviderException">
        /// There was a problem with the underlying OAuth provider.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateWebhook">REST API Reference for UpdateWebhook Operation</seealso>
        Task<UpdateWebhookResponse> UpdateWebhookAsync(UpdateWebhookRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}