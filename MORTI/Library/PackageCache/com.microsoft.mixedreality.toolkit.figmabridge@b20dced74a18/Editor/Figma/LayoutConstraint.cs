// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using Newtonsoft.Json;
using System;

namespace Microsoft.MixedReality.Toolkit.Utilities.FigmaImporter
{
    /// <summary>
    /// Horizontal and vertical layout constraints for node
    ///
    /// Layout constraint relative to containing Frame
    /// </summary>
    [Serializable]
    public partial class LayoutConstraint
    {
        /// <summary>
        /// Horizontal constraint as an enum
        /// "LEFT": Node is laid out relative to left of the containing frame
        /// "RIGHT": Node is laid out relative to right of the containing frame
        /// "CENTER": Node is horizontally centered relative to containing frame
        /// "LEFT_RIGHT": Both left and right of node are constrained relative to containing frame
        /// (node stretches with frame)
        /// "SCALE": Node scales horizontally with containing frame
        /// </summary>
        [JsonProperty("horizontal")]
        public Horizontal horizontal;

        /// <summary>
        /// Vertical constraint as an enum
        /// "TOP": Node is laid out relative to top of the containing frame
        /// "BOTTOM": Node is laid out relative to bottom of the containing frame
        /// "CENTER": Node is vertically centered relative to containing frame
        /// "TOP_BOTTOM": Both top and bottom of node are constrained relative to containing frame
        /// (node stretches with frame)
        /// "SCALE": Node scales vertically with containing frame
        /// </summary>
        [JsonProperty("vertical")]
        public Vertical vertical;
    }
}