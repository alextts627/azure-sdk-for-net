// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> Represents the speed entity resolution model. </summary>
    internal partial class SpeedResolution : BaseResolution
    {
        /// <summary> Initializes a new instance of SpeedResolution. </summary>
        /// <param name="unit"> The speed Unit of measurement. </param>
        /// <param name="value"> The numeric value that the extracted text denotes. </param>
        public SpeedResolution(SpeedUnit unit, double value)
        {
            Unit = unit;
            Value = value;
            ResolutionKind = ResolutionKind.SpeedResolution;
        }

        /// <summary> Initializes a new instance of SpeedResolution. </summary>
        /// <param name="resolutionKind"> The entity resolution object kind. </param>
        /// <param name="unit"> The speed Unit of measurement. </param>
        /// <param name="value"> The numeric value that the extracted text denotes. </param>
        internal SpeedResolution(ResolutionKind resolutionKind, SpeedUnit unit, double value) : base(resolutionKind)
        {
            Unit = unit;
            Value = value;
            ResolutionKind = resolutionKind;
        }

        /// <summary> The speed Unit of measurement. </summary>
        public SpeedUnit Unit { get; set; }
        /// <summary> The numeric value that the extracted text denotes. </summary>
        public double Value { get; set; }
    }
}
