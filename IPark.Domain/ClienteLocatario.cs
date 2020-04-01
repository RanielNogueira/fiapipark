using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IPark.Domain
{
    [Table("t_sc_cliente_locatario")]
    public class ClienteLocatario
    {

        [Key]
        [Column("id_cliente_locatario")]
        public int idClienteLocatario { get; set; }

        [Column("locatario_id_locatario")]
        public int idLocatario { get; set; }
        [Column("id_cliente")]
        public int idCliente { get; set; }

        [ForeignKey("locatario_id_locatario")]
        public virtual Locatario Locatario { get; set; }
        [ForeignKey("cliente_ds_cpf")]
        public virtual Cliente Cliente { get; set; }
    }
}
