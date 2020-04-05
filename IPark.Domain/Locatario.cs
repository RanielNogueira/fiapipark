using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IPark.Domain
{
    [Table("T_SC_LOCATARIO")]
    public class Locatario : PessoaEntity
    {
        [Key]
        [Column("id_locatario")]
        public int idLocatario { get; set; }

        [MaxLength(14)]
        [Column("ds_cnpj")]
        public string Cnpj { get; set; }

        [NotMapped]
        public virtual IList<ClienteLocatario> clienteLocatario { get; set; }

        [NotMapped]
        public virtual IList<Vaga> Vagas { get; set; }
    }
}
