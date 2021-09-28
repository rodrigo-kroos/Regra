using Microsoft.EntityFrameworkCore;
using Regra.Context;
using Regra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regra.Repositories
{
    public class CervejaRepository : ICervejaRepository
    {
        private readonly AppDbContext _context;

        public CervejaRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Cerveja> Cervejas => _context.Cervejas.Include(c => c.Categoria);

        public IEnumerable<Cerveja> CervejasPreferidos => _context.Cervejas.Where(p => 
        p.IsCervejaPreferido).Include(c => c.Categoria);

        public Cerveja GetCervejaById(int cervejaId)
        {
           return _context.Cervejas.FirstOrDefault(l => l.CervejaId == cervejaId); ;
        }
    }
}
