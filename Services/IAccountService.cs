using APBD10.ResponceModels;

namespace APBD10.Services;

public interface IAccountService
{
    Task<GetAccountWithCart> GetAccountWithCart(int id);
}