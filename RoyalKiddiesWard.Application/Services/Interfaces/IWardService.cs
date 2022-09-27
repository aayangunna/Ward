using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoyalKiddiesWard.Data.Models;

namespace RoyalKiddiesWard.Application.Services.Interfaces
{
    public interface IWardService
    {
        Task<Airtime> BuyAirtime(int Id, int network, string phoneNumber );

       
    }
}  
