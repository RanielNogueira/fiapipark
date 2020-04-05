using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IPark.Domain
{
    [Table("T_SC_CLIENTE")]
    public class Cliente : PessoaEntity
    {
        [Key]
        [Column("id_cliente")]
        public int idCliente { get; set; }

        [Column("ds_cpf")]
        public override string Cpf { get => base.Cpf; set => base.Cpf = value; }

        [NotMapped]
        public virtual IList<ClienteLocatario> ClienteLocatario { get; set; }
    }
}
