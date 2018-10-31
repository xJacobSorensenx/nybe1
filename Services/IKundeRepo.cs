using System.Collections.Generic;
using System.Threading.Tasks;
using nybe1.Models;

namespace nybe1.Services
{
    public interface IKundeRepo
    {
         Task<IEnumerable<Kunde>> HentKunderAsync();
         Task<string> AddNyKunde(Kunde indata);
    }
}