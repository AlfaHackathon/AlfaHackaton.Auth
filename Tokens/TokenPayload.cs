using System.Text.Json.Serialization;
using AlfaHackaton.Auth.Common;

namespace AlfaHackaton.Auth.Tokens;

public class TokenPayload
{
    public required Guid UserId { get; set; }

    /// <summary>Компания пользователя (claim CompanyId). null — компании пока нет.</summary>
    [JsonPropertyName("CompanyId")]
    public Guid? CompanyId { get; set; }

    [JsonPropertyName(System.Security.Claims.ClaimTypes.Role)]
    public required UserRoles UserRole { get; set; }
    [JsonPropertyName("exp")]
    public required long Exp { get; set; }
    [JsonPropertyName("iss")]
    public required string Iss { get; set; }
    [JsonPropertyName("aud")]
    public required string Aud { get; set; }
}