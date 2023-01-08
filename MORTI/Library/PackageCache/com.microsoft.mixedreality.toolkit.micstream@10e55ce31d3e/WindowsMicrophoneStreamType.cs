﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Microsoft.MixedReality.Toolkit.Audio
{
    /// <summary>
    /// Microphone stream types used by the <see cref="WindowsMicrophoneStream"/> class.
    /// </summary>
    public enum WindowsMicrophoneStreamType
    {
        /// <summary>
        /// Low quality stream from ths microphone(s) focused on the user's voice.
        /// </summary>
        /// <remarks>
        /// On devices such as Microsoft HoloLens, this stream type pulls data from the
        /// microhones focused toward the wearer's mouth.
        /// </remarks>
        LowQualityVoice = 0,

        /// <summary>
        /// High quality stream from ths microphone(s) focused on the user's voice.
        /// </summary>
        /// <remarks>
        /// On devices such as Microsoft HoloLens, this stream type pulls data from the
        /// microhones focused toward the wearer's mouth.
        /// </remarks>
        HighQualityVoice,

        /// <summary>
        /// Ambient microphone(s).
        /// </summary>
        /// <remarks>
        /// On devices such as Microsoft HoloLens, this stream type pulls data from the
        /// microhones facing away from the user.
        /// </remarks>
        RoomCapture
    }
}
