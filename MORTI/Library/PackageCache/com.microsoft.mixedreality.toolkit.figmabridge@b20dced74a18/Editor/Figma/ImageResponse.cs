// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Microsoft.MixedReality.Toolkit.Utilities.FigmaImporter
{
    [Serializable]
    public class ImageResponse
    {
        [JsonProperty("err")]
        public String err;
        [JsonProperty("images")]
        public Dictionary<string, string> images;
        [JsonProperty("status")]
        public int status;
    }
}