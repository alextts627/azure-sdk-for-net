// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.Maps.TimeZone.Tests
{
    public class TimeZoneClientTestEnvironment : TestEnvironment
    {
        public string Endpoint => GetRecordedVariable("TimeZone_ENDPOINT");

        // Add other client paramters here as above.
    }
}
