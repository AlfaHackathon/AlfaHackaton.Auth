using AlfaHackaton.Auth.Common.Interfaces;
using AlfaHackaton.Auth.Common.Settings;
using AlfaHackaton.Auth.Exceptions;

namespace AlfaHackaton.Auth.Tokens;

public class TokenValidator : ITokenValidator
{
    private JwtSettings _jwtSettings;

    public TokenValidator(JwtSettings jwtSettings)
    {
        _jwtSettings = jwtSettings;
    }

    public void Validate(TokenPayload payload)
    {
        if (payload is null)
        {
            throw new TokenInvalidException("Не удалось получить payload токена");
        }
        
        var now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        if (payload.Iss != _jwtSettings.Issuer || payload.Aud != _jwtSettings.Audience || payload.Exp <= now)
        {
            throw new TokenInvalidException("Неверный выпуск токена");
        }
    }
}