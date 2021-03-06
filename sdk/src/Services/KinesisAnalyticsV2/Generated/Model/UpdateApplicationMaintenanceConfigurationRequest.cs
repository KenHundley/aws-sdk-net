/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateApplicationMaintenanceConfiguration operation.
    /// Updates the configuration for the automatic maintenance that Kinesis Data Analytics
    /// performs on the application. For information about automatic application maintenance,
    /// see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/java/maintenance.html">Kinesis
    /// Data Analytics for Apache Flink Maintenance</a>.
    /// </summary>
    public partial class UpdateApplicationMaintenanceConfigurationRequest : AmazonKinesisAnalyticsV2Request
    {
        private ApplicationMaintenanceConfigurationUpdate _applicationMaintenanceConfigurationUpdate;
        private string _applicationName;

        /// <summary>
        /// Gets and sets the property ApplicationMaintenanceConfigurationUpdate. 
        /// <para>
        /// Describes the application maintenance configuration update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApplicationMaintenanceConfigurationUpdate ApplicationMaintenanceConfigurationUpdate
        {
            get { return this._applicationMaintenanceConfigurationUpdate; }
            set { this._applicationMaintenanceConfigurationUpdate = value; }
        }

        // Check to see if ApplicationMaintenanceConfigurationUpdate property is set
        internal bool IsSetApplicationMaintenanceConfigurationUpdate()
        {
            return this._applicationMaintenanceConfigurationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application for which you want to update the maintenance time window.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

    }
}