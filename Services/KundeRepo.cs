using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using nybe1.Models;

namespace nybe1.Services
{
    public class KundeRepo : IKundeRepo
    {
        private readonly MinDBContext _ctx;
        public KundeRepo(MinDBContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<string> AddNyKunde(Kunde indata)
        {
            await _ctx.DBSKunder.AddAsync(indata);
            await _ctx.SaveChangesAsync();
            return "Data tilføjet";
        }

        public async Task<IEnumerable<Kunde>> HentKunderAsync() {
            var res = await _ctx.DBSKunder.ToListAsync();
            return res;
        }

    }
}