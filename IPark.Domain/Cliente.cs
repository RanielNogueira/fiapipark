using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IPark.Domain
{
    [Table("T_SC_CLIENTE")]
    public class Cliente : PessoaEntity
    {
        [Key]
        [Column("id_cliente")]
        public int idCliente { get; set; }

        [Column("ds_cpf")]
        public override long Cpf { get => base.Cpf; set => base.Cpf = value; }

        public virtual IList<ClienteLocatario> ClienteLocatario { get; set; }
    }
}
