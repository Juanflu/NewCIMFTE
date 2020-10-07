using NewCIMFTE.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace NewCIMFTE.Repository
{
    public class AccountRepository : IRepository<Account>
    {
        public async Task<IEnumerable<Account>> GetAsync()
        {
            string json = File.ReadAllText(@".\Repository\Accounts.json");
            var list = await Task.Run(() => JsonSerializer.Deserialize<IEnumerable<Account>>(json));

            return list;
        }
    }
}
