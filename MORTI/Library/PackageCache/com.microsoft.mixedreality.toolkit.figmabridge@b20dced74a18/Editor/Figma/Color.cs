// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;

namespace Microsoft.MixedReality.Toolkit.Utilities.FigmaImporter
{/// <summary>
 /// Background color of the node
 ///
 /// An RGBA color
 ///
 /// Background color of the canvas
 ///
 /// Solid color of the paint
 ///
 /// Color attached to corresponding position
 ///
 /// Color of the grid
 /// </summary>
    [Serializable]
    public class Color
    {
        /// <summary>
        /// Alpha channel value, between 0 and 1
        /// </summary>
        public float a;
        /// <summary>
        /// Blue channel value, between 0 and 1
        /// </summary>
        public float b;
        /// <summary>
        /// Green channel value, between 0 and 1
        /// </summary>
        public float g;
        /// <summary>
        /// Red channel value, between 0 and 1
        /// </summary>
        public float r;

    }
}