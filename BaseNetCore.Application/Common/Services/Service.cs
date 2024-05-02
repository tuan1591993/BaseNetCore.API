using BaseNetCore.Application.Common.Interdaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseNetCore.Application.Common.Services
{
    public class Service : IService
    {
        private readonly IAssetManagementContext _context;

        public Service(IAssetManagementContext context)
        {
            _context = context;
        }

        public async Task<bool> TestService(bool test)
        {
            var db = await _context.NhomTaiSans.ToListAsync();
            if (db.Count > 0)
            {
                return test;
            }
         
            return false;
        }
    }
}
