using Core.Entities.Comcrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilites.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
