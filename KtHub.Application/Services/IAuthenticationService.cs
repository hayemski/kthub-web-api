using KtHub.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtHub.Application.Services
{
    public interface IAuthenticationService
    {
        public AuthenticationResult Login (string username, string password);

        public AuthenticationResult Register (string username, string password, string email);
    }
}
