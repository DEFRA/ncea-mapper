using Azure.Security.KeyVault.Secrets;
using Ncea.Mapper.Infrastructure.Contracts;

namespace Ncea.Mapper.Infrastructure;

public class KeyVaultService: IKeyVaultService
{
    private readonly SecretClient _secretClient;

    public KeyVaultService(SecretClient secretClient)
    {
        _secretClient = secretClient;
    }

    public async Task<string> GetSecretAsync(string key)
    {
        var secret = await _secretClient.GetSecretAsync(key);
        return secret.Value.Value;
    }
}
