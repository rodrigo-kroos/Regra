using Regra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regra.Repositories
{
    public interface ICervejaRepository
    {
        IEnumerable<Cerveja> Cervejas { get; }
        IEnumerable<Cerveja> CervejasPreferidos { get; }

        Cerveja GetCervejaById(int lancheId);
    }
}
