using Ecommerce.Models.ViewModel.Account;
using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Repositories
{
    public interface IAccountRepository
    {
        Task<IdentityResult> RegisterAsync(RegisterViewModel model);
        Task<SignInResult> PasswordSignInAsync(LoginViewModel model);
        Task SignOutAsync();
    }
}
