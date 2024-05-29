namespace Ncea.Mapper.Services.Contracts;

public interface IValidationService
{
    bool IsValid(string harvestedData, string mdcMappedData);
}
