using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SeidoDbWebApiConsumer.Models;

namespace SeidoDbWebApiConsumer.Services
{
    public interface ISeidoDbHttpService
    {
        Task<DbInfo> GetDbInfoAsync();

        Task<IEnumerable<ICustomer>> GetCustomersAsync();
        Task<ICustomer> GetCustomerAsync(Guid custId);

        Task<ICustomer> UpdateCustomerAsync(Customer cus);

        Task<ICustomer> CreateCustomerAsync(Customer cus);
        Task<ICustomer> DeleteCustomerAsync(Guid custId);
    }
}
