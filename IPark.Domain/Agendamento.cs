using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IPark.Domain
{
    [Table("T_SC_AGENDAMENTO")]
    public class Agendamento
    {
        [Key]
        [Column("id_agendamento")]
        public int idAgendamento { get; set; }
        
        [Column("dt_entrada")]
        [DataType(DataType.DateTime)]
        public DateTime dtEntrada { get; set; }

        [Column("dt_saida")]
        [DataType(DataType.DateTime)]
        public DateTime dtSaida { get; set; }
    }
}
