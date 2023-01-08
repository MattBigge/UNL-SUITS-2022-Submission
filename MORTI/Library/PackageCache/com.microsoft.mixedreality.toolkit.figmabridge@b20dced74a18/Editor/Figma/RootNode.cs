// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using Newtonsoft.Json;
using System;

namespace Microsoft.MixedReality.Toolkit.Utilities.FigmaImporter
{
    /// <summary>
    /// Node Properties
    /// The root node
    ///
    /// The root node within the document
    /// </summary>
    [Serializable]
    public class RootNode
    {
        /// <summary>
        /// a string uniquely identifying this node within the document
        /// </summary>
        [JsonProperty("id")]
        public string id;
        /// <summary>
        /// the name given to the node by the user in the tool.
        /// </summary>
        [JsonProperty("name")]
        public string name;
        /// <summary>
        /// the type of the node, refer to table below for details
        /// </summary>
        [JsonProperty("type")]
        public NodeType type;
        /// <summary>
        /// whether or not the node is visible on the canvas
        /// </summary>
        [System.ComponentModel.DefaultValue(true)]
        [JsonProperty("visible", DefaultValueHandling = DefaultValueHandling.Populate)]
        public bool visible;
        /// <summary>
        /// An array of canvases attached to the document
        /// </summary>
        [JsonProperty("children")]
        public Node[] children;
    }
    //[CustomPropertyDrawer(typeof(RootNode))]
    //public class RootNodeDrawer : PropertyDrawer
    //{
    //    public override void OnGUI(UnityEngine.Rect position, SerializedProperty property, GUIContent label)
    //    {
    //        EditorGUILayout.PropertyField(property.FindPropertyRelative("type"),label);
    //        EditorGUILayout.PropertyField(property.FindPropertyRelative("children"));
    //    }
    //}
}