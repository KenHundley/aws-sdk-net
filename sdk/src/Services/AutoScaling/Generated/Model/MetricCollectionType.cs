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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes a metric.
    /// </summary>
    public partial class MetricCollectionType
    {
        private string _metric;

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// One of the following metrics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>GroupMinSize</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupMaxSize</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupDesiredCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupInServiceInstances</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupPendingInstances</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupStandbyInstances</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupTerminatingInstances</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupTotalInstances</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupInServiceCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupPendingCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupStandbyCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupTerminatingCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupTotalCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WarmPoolDesiredCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WarmPoolWarmedCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WarmPoolPendingCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WarmPoolTerminatingCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WarmPoolTotalCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupAndWarmPoolDesiredCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GroupAndWarmPoolTotalCapacity</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Metric
        {
            get { return this._metric; }
            set { this._metric = value; }
        }

        // Check to see if Metric property is set
        internal bool IsSetMetric()
        {
            return this._metric != null;
        }

    }
}