using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseNetCore.Application.Common.Interdaces
{
    public partial interface IService
    {
        Task<bool> TestService(bool test);
    }
}
