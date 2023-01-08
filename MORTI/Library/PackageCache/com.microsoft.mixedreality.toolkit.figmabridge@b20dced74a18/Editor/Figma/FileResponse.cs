// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Utilities.FigmaImporter
{
    /// <summary>
    /// GET /v1/files/:key
    ///
    /// > Description
    ///
    /// Returns the document refered to by :key as a JSON object. The file key can be parsed from
    /// any Figma file url: https://www.figma.com/file/:key/:title. The "document" attribute
    /// contains a Node of type DOCUMENT.
    ///
    /// The "components" key contains a mapping from node IDs to component metadata. This is to
    /// help you determine which components each instance comes from. Currently the only piece of
    /// metadata available on components is the name of the component, but more properties will
    /// be forthcoming.
    ///
    /// > Path parameters
    ///
    /// key String
    /// File to export JSON from
    /// </summary>
    [Serializable]
    public class FileResponse
    {
        public string name;
        /// <summary>
        /// A mapping from node IDs to component metadata. This is to help you determine which
        /// components each instance comes from. Currently the only piece of metadata available on
        /// components is the name of the component, but more properties will be forthcoming.
        /// </summary>
        [JsonProperty("components")]
        public Dictionary<string, Component> components;

        /// <summary>
        /// The root node within the document
        /// </summary>
        [JsonProperty("document")]
        public RootNode document;

        [HideInInspector]
        [JsonProperty("schemaVersion")]
        public float schemaVersion;

        public static FileResponse FromJson(string json) => JsonConvert.DeserializeObject<FileResponse>(json, Microsoft.MixedReality.Toolkit.Utilities.FigmaImporter.Converter.Settings);
    }
}