// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Utilities.FigmaImporter
{
    /// <summary>
    /// A class to hold the file response from a figma API call,
    /// additionally populated with the name and id of the file.
    /// </summary>
    [Serializable]
    public class FigmaFile
    {
        public string name;
        public string fileID;
        public TextAsset textAsset;
    }
}