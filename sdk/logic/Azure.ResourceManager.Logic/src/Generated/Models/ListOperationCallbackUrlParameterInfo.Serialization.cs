// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class ListOperationCallbackUrlParameterInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(NotAfter))
            {
                writer.WritePropertyName("notAfter");
                writer.WriteStringValue(NotAfter.Value, "O");
            }
            if (Optional.IsDefined(KeyType))
            {
                writer.WritePropertyName("keyType");
                writer.WriteStringValue(KeyType.Value.ToString());
            }
            writer.WriteEndObject();
        }
    }
}
