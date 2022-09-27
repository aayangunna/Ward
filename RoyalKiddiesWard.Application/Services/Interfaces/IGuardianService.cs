using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalKiddiesWard.Application.Services.Interfaces
{
    public interface IGuardianService
    {
         Task<Ward> RecievePayment(int Id, decimal amount);
    }
}
