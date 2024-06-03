using APBD10.Contexts;
using APBD10.ResponceModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;

namespace APBD10.Services;

public class AccountService : IAccountService
{
    private DatabaseContext _databaseContext;

    public AccountService(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    public async Task<GetAccountWithCart> GetAccountWithCart(int id)
    {
        var result = await _databaseContext.Carts.Where(e => e.IdAccount == id)
            .Select(e => new GetAccountWithCart
            {
                FirstNameAccount = e.Account.FirstName,
                SecondNameAccount = e.Account.SecondName,
                EmailAccount = e.Account.Email,
                PhoneAccount = e.Account.Phone,
                RoleAccount = e.Account.Role.Name,
                cart = new GetCart()
                {
                    productId = e.IdProduct,
                    productName = e.Product.Name,
                    amount = e.Amount
                }
                
            }).FirstOrDefaultAsync();

        if (result is null)
        {
            throw new NotFoundException($"Account with id {id} not found");
        }

        return result; 
    }
}

public class NotFoundException(string message) : Exception(message);

