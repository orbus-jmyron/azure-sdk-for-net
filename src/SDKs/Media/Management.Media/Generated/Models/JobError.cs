// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Details of JobOutput errors.
    /// </summary>
    public partial class JobError
    {
        /// <summary>
        /// Initializes a new instance of the JobError class.
        /// </summary>
        public JobError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobError class.
        /// </summary>
        /// <param name="code">Error code describing the error. Possible values
        /// include: 'ServiceError', 'ServiceTransientError',
        /// 'DownloadNotAccessible', 'DownloadTransientError',
        /// 'UploadNotAccessible', 'UploadTransientError',
        /// 'ConfigurationUnsupported', 'ContentMalformed',
        /// 'ContentUnsupported'</param>
        /// <param name="message">A human-readable language-dependent
        /// representation of the error.</param>
        /// <param name="category">Helps with categorization of errors.
        /// Possible values include: 'Service', 'Download', 'Upload',
        /// 'Configuration', 'Content'</param>
        /// <param name="retry">Indicates that it may be possible to retry the
        /// Job. If retry is unsuccessful, please contact Azure support via
        /// Azure Portal. Possible values include: 'DoNotRetry',
        /// 'MayRetry'</param>
        /// <param name="details">An array of details about specific errors
        /// that led to this reported error.</param>
        public JobError(JobErrorCode code = default(JobErrorCode), string message = default(string), JobErrorCategory category = default(JobErrorCategory), JobRetry retry = default(JobRetry), IList<JobErrorDetail> details = default(IList<JobErrorDetail>))
        {
            Code = code;
            Message = message;
            Category = category;
            Retry = retry;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets error code describing the error. Possible values include:
        /// 'ServiceError', 'ServiceTransientError', 'DownloadNotAccessible',
        /// 'DownloadTransientError', 'UploadNotAccessible',
        /// 'UploadTransientError', 'ConfigurationUnsupported',
        /// 'ContentMalformed', 'ContentUnsupported'
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public JobErrorCode Code { get; private set; }

        /// <summary>
        /// Gets a human-readable language-dependent representation of the
        /// error.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets helps with categorization of errors. Possible values include:
        /// 'Service', 'Download', 'Upload', 'Configuration', 'Content'
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public JobErrorCategory Category { get; private set; }

        /// <summary>
        /// Gets indicates that it may be possible to retry the Job. If retry
        /// is unsuccessful, please contact Azure support via Azure Portal.
        /// Possible values include: 'DoNotRetry', 'MayRetry'
        /// </summary>
        [JsonProperty(PropertyName = "retry")]
        public JobRetry Retry { get; private set; }

        /// <summary>
        /// Gets an array of details about specific errors that led to this
        /// reported error.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<JobErrorDetail> Details { get; private set; }

    }
}