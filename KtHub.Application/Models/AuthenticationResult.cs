using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtHub.Application.Models
{
    public record AuthenticationResult
    (
        Guid Id,
        string UserName,
        string Email,
        string Token

    );
}
