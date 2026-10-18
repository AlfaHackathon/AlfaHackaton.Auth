using AlfaHackaton.Auth.Tokens;

namespace AlfaHackaton.Auth.Common.Interfaces;

public interface ITokenValidator
{
    public void Validate(TokenPayload payload);
}