// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayBackendAddress : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Fqdn != null)
            {
                writer.WritePropertyName("fqdn");
                writer.WriteStringValue(Fqdn);
            }
            if (IpAddress != null)
            {
                writer.WritePropertyName("ipAddress");
                writer.WriteStringValue(IpAddress);
            }
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayBackendAddress DeserializeApplicationGatewayBackendAddress(JsonElement element)
        {
            string fqdn = default;
            string ipAddress = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fqdn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddress = property.Value.GetString();
                    continue;
                }
            }
            return new ApplicationGatewayBackendAddress(fqdn, ipAddress);
        }
    }
}