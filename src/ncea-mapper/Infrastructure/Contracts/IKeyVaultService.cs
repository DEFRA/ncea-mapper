namespace Ncea.Mapper.Infrastructure.Contracts;

public interface IKeyVaultService
{
    Task<string> GetSecretAsync(string key);
}
