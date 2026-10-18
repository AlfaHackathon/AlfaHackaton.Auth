using System.Text.Json.Serialization;

namespace AlfaHackaton.Auth.Common;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ClaimTypes
{
    UserId
}