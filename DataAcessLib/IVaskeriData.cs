using System.Collections.Generic;
using System.Threading.Tasks;
using DataAcessLib.Models;

namespace DataAcessLib
{
    public interface IVaskeriData
    {
        Task<List<BrugerModel>> GetBruger();
        Task InsertPerson(BrugerModel bruger);
    }
}