// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Utilities.FigmaImporter
{
    /// <summary>
    /// A class to hold an MRTK prefab and additional fields
    /// </summary>
    [Serializable]
    public class CustomMapItem
    {
        public GameObject Prefab;
        public PostProcessType ProcessType = PostProcessType.Default;
        public Vector3 offset;
    }
}