// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;

namespace Microsoft.MixedReality.Toolkit.Utilities.FigmaImporter
{
    /// <summary>
    /// A node that can have instances created of it that share the same properties
    /// A description of a master component. Helps you identify which component
    /// instances are attached to
    /// </summary>
    [Serializable]
    public partial class Component
    {

        /// <summary>
        /// Bounding box of the node in absolute space coordinates
        /// </summary>
        public Rect absoluteBoundingBox;

        /// <summary>
        /// Background color of the node
        /// </summary>
        public Color backgroundColor;
        /// <summary>
        /// How this node blends with nodes behind it in the scene
        /// (see blend mode section for more details)
        /// </summary>
        public BlendMode blendMode;

        /// <summary>
        /// An array of nodes that are direct children of this node
        /// </summary>
        public Node[] children;


        /// <summary>
        /// Does this node clip content outside of its bounds?
        /// </summary>
        public bool clipsContent;

        /// <summary>
        /// Horizontal and vertical layout constraints for node
        /// </summary>
        public LayoutConstraint constraints;

        /// <summary>
        /// The description of the component as entered in the editor
        /// </summary>
        public string description;

        /// <summary>
        /// An array of effects attached to this node
        /// (see effects section for more details)
        /// </summary>
        public Effect[] effects;

        /// <summary>
        /// An array of export settings representing images to export from node
        /// </summary>
        public ExportSetting[] exportSettings;
        /// <summary>
        /// a string uniquely identifying this node within the document
        /// </summary>
        public string id;

        /// <summary>
        /// Does this node mask sibling nodes in front of it?
        /// </summary>
        public bool isMask;

        /// <summary>
        /// An array of layout grids attached to this node (see layout grids section
        /// for more details). GROUP nodes do not have this attribute
        /// </summary>
        public LayoutGrid[] layoutGrids;

        /// <summary>
        /// The name of the component
        /// </summary>
        public string name;

        /// <summary>
        /// Opacity of the node
        /// </summary>
        public float opacity;


        /// <summary>
        /// Keep height and width constrained to same ratio
        /// </summary>
        public bool preserveRatio;

        /// <summary>
        /// Node ID of node to transition to in prototyping
        /// </summary>
        public string transitionNodeId;

        /// <summary>
        /// the type of the node, refer to table below for details
        /// </summary>
        public NodeType type;

        /// <summary>
        /// whether or not the node is visible on the canvas
        /// </summary>
        public bool visible;

    }
}