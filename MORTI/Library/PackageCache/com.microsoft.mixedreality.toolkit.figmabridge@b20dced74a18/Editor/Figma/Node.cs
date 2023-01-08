// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Utilities.FigmaImporter
{
    [Serializable]
    public class Node
    {
        public string name;
        public string id;
        public NodeType type;
        [SerializeReference]
        public Node[] children;
        public bool visible;
        public Color backgroundColor;
        public ExportSetting[] exportSettings;
        public Rect absoluteBoundingBox;
        public BlendMode? blendMode;
        public bool? clipsContent;
        public LayoutConstraint constraints;
        public Effect[] effects;
        public bool? isMask;
        public LayoutGrid[] layoutGrids;
        public float? opacity;
        public bool? preserveRatio;
        public string transitionNodeId;
        public Paint[] fills;
        public StrokeAlign? strokeAlign;
        public Paint[] strokes;
        public float? strokeWeight;
        public float? cornerRadius;
        public string characters;
        public float[] characterStyleOverrides;
        public TypeStyle style;
        public TypeStyle styleOverrideTable;
        public string description;
        public string componentId;
    }
}