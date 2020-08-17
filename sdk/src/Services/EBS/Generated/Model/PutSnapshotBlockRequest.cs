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
 * Do not modify this file. This file is generated from the ebs-2019-11-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.EBS.Model
{
    /// <summary>
    /// Container for the parameters to the PutSnapshotBlock operation.
    /// Writes a block of data to a block in the snapshot. If the specified block contains
    /// data, the existing data is overwritten. The target snapshot must be in the <code>pending</code>
    /// state.
    /// 
    ///  
    /// <para>
    /// Data written to a snapshot must be aligned with 512-byte sectors.
    /// </para>
    /// </summary>
    public partial class PutSnapshotBlockRequest : AmazonEBSRequest
    {
        private Stream _blockData;
        private int? _blockIndex;
        private string _checksum;
        private ChecksumAlgorithm _checksumAlgorithm;
        private int? _dataLength;
        private int? _progress;
        private string _snapshotId;

        /// <summary>
        /// Gets and sets the property BlockData. 
        /// <para>
        /// The data to write to the block.
        /// </para>
        ///  
        /// <para>
        /// The block data is not signed as part of the Signature Version 4 signing process. As
        /// a result, you must generate and provide a Base64-encoded SHA256 checksum for the block
        /// data using the <b>x-amz-Checksum</b> header. Also, you must specify the checksum algorithm
        /// using the <b>x-amz-Checksum-Algorithm</b> header. The checksum that you provide is
        /// part of the Signature Version 4 signing process. It is validated against a checksum
        /// generated by Amazon EBS to ensure the validity and authenticity of the data. If the
        /// checksums do not correspond, the request fails. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-accessing-snapshot.html#ebsapis-using-checksums">
        /// Using checksums with the EBS direct APIs</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Stream BlockData
        {
            get { return this._blockData; }
            set { this._blockData = value; }
        }

        // Check to see if BlockData property is set
        internal bool IsSetBlockData()
        {
            return this._blockData != null;
        }

        /// <summary>
        /// Gets and sets the property BlockIndex. 
        /// <para>
        /// The block index of the block in which to write the data. A block index is the offset
        /// position of a block within a snapshot, and it is used to identify the block. To identify
        /// the logical offset of the data in the logical volume, multiply the block index with
        /// the block size (Block index * 512 bytes).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int BlockIndex
        {
            get { return this._blockIndex.GetValueOrDefault(); }
            set { this._blockIndex = value; }
        }

        // Check to see if BlockIndex property is set
        internal bool IsSetBlockIndex()
        {
            return this._blockIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// A Base64-encoded SHA256 checksum of the data. Only SHA256 checksums are supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string Checksum
        {
            get { return this._checksum; }
            set { this._checksum = value; }
        }

        // Check to see if Checksum property is set
        internal bool IsSetChecksum()
        {
            return this._checksum != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// The algorithm used to generate the checksum. Currently, the only supported algorithm
        /// is <code>SHA256</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=32)]
        public ChecksumAlgorithm ChecksumAlgorithm
        {
            get { return this._checksumAlgorithm; }
            set { this._checksumAlgorithm = value; }
        }

        // Check to see if ChecksumAlgorithm property is set
        internal bool IsSetChecksumAlgorithm()
        {
            return this._checksumAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property DataLength. 
        /// <para>
        /// The size of the data to write to the block, in bytes. Currently, the only supported
        /// size is <code>524288</code>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>524288</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int DataLength
        {
            get { return this._dataLength.GetValueOrDefault(); }
            set { this._dataLength = value; }
        }

        // Check to see if DataLength property is set
        internal bool IsSetDataLength()
        {
            return this._dataLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        /// The progress of the write process, as a percentage.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int Progress
        {
            get { return this._progress.GetValueOrDefault(); }
            set { this._progress = value; }
        }

        // Check to see if Progress property is set
        internal bool IsSetProgress()
        {
            return this._progress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

        /// <summary>
        /// Get the signer to use for this request.
        /// </summary>
        /// <returns>A signer for this request.</returns>
        override protected AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer(false);
        }
    }
}