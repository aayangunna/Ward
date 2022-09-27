using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RoyalKiddiesWard.Application.Services.Interfaces;
using RoyalKiddiesWard.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace RoyalKiddiesWard.Application.Services.Implementation
{
    public class WardService : IWardService
    {
        private readonly BankDbContext bankDbContext;

        public WardService(BankDbContext bankDbContext)
        {
            this.bankDbContext = bankDbContext;
        }

       
        public Task<Airtime> BuyAirtime(int Id, int network, string phoneNumber)
        {
            throw new NotImplementedException();
        }

        
    }
}
