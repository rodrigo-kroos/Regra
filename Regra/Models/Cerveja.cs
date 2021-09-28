using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Regra.Models
{
    public class Cerveja
    {
        public int CervejaId { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(100)]
        public string DescricaoCurta { get; set; }

        [StringLength(250)]
        public string DescricaoDetalhada { get; set; }

        [Column(TypeName = "decimal(10,2")]
        public decimal Preco { get; set; }

        [StringLength(200)]
        public string ImagemUrl { get; set; }

        [StringLength(200)]
        public string ImagemThumbnaiUrl { get; set; }

        public bool IsCervejaPreferido{ get; set; }

        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria{ get; set; }
    }
}
