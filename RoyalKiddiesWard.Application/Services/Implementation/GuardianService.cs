using RoyalKiddiesWard.Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalKiddiesWard.Application.Services.Implementation
{
    public class GuardianService : IGuardianService
    {
        public Task<Ward> RecievePayment(int Id, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
