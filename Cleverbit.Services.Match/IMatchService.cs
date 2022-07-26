using System;
using System.Collections.Generic;
using System.Text;

namespace Cleverbit.Services.MatchSevice
{
    public interface IMatchService
    {
        int RegisterUser(int userid, int matchid);
        void RemoveUserRegistration(int userid, int matchid);
        List<object> ListUserRegistrations();

    }
}
