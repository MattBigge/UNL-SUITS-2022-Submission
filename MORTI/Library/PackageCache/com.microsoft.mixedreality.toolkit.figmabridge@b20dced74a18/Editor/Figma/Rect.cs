// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;

namespace Microsoft.MixedReality.Toolkit.Utilities.FigmaImporter
{
    /// <summary>
    /// Bounding box of the node in absolute space coordinates
    ///
    /// A rectangle that expresses a bounding box in absolute coordinates
    /// </summary>
    [Serializable]
    public partial class Rect
    {
        /// <summary>
        /// Height of the rectangle
        /// </summary>
        public float height;
        /// <summary>
        /// Width of the rectangle
        /// </summary>
        public float width;
        /// <summary>
        /// X coordinate of top left corner of the rectangle
        /// </summary>
        public float x;
        /// <summary>
        /// Y coordinate of top left corner of the rectangle
        /// </summary>
        public float y;
        public UnityEngine.Vector3 Position
        {
            get
            {
                return new UnityEngine.Vector3(x, -y);
            }
        }
    }
}