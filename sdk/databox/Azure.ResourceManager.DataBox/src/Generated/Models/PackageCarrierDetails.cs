// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Package carrier details. </summary>
    public partial class PackageCarrierDetails
    {
        /// <summary> Initializes a new instance of PackageCarrierDetails. </summary>
        public PackageCarrierDetails()
        {
        }

        /// <summary> Initializes a new instance of PackageCarrierDetails. </summary>
        /// <param name="carrierAccountNumber"> Carrier Account Number of customer for customer disk. </param>
        /// <param name="carrierName"> Name of the carrier. </param>
        /// <param name="trackingId"> Tracking Id of shipment. </param>
        internal PackageCarrierDetails(string carrierAccountNumber, string carrierName, string trackingId)
        {
            CarrierAccountNumber = carrierAccountNumber;
            CarrierName = carrierName;
            TrackingId = trackingId;
        }

        /// <summary> Carrier Account Number of customer for customer disk. </summary>
        public string CarrierAccountNumber { get; set; }
        /// <summary> Name of the carrier. </summary>
        public string CarrierName { get; set; }
        /// <summary> Tracking Id of shipment. </summary>
        public string TrackingId { get; set; }
    }
}
