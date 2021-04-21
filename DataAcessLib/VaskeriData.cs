using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLib.Models;

namespace DataAcessLib
{
    public class VaskeriData : IVaskeriData
    {
        private readonly ISqlDataAccess _db;

        public VaskeriData(ISqlDataAccess db)
        {
            _db = db;
        }
        

        public Task<List<BrugerModel>> GetBruger()
        {
            string sql = "select * from dbo.bruger";

            return _db.LoadData<BrugerModel, dynamic>(sql, new{});
        }

        public Task InsertPerson(BrugerModel bruger)
        {
            string sql = @"insert into dbo.bruger(bruger_navn, email, password, konto, vaskeri_id, oprettet) 
                            values (@bruger_navn, @email, @password, @konto, @vaskeri_id, @oprettet)";

            return _db.SaveData(sql, bruger);
        }
    }
}
