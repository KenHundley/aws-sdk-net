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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Defines a column containing error.
    /// </summary>
    public partial class ColumnStatisticsError
    {
        private ColumnStatistics _columnStatistics;
        private ErrorDetail _error;

        /// <summary>
        /// Gets and sets the property ColumnStatistics. 
        /// <para>
        /// The ColumnStatistics of the column.
        /// </para>
        /// </summary>
        public ColumnStatistics ColumnStatistics
        {
            get { return this._columnStatistics; }
            set { this._columnStatistics = value; }
        }

        // Check to see if ColumnStatistics property is set
        internal bool IsSetColumnStatistics()
        {
            return this._columnStatistics != null;
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The error message occurred during operation.
        /// </para>
        /// </summary>
        public ErrorDetail Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

    }
}