using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IPark.Domain
{
    [Table("t_sc_agenda")]
    public class Agenda
    {
        [Key]
        [Column("id_agenda")]
        public int idAgenda { get; set; }

        [Column("agendamento_id_agendamento")]
        public int idAgendamento { get; set; }
        [Column("vaga_id_vaga")]
        public int idVaga { get; set; }

        [NotMapped]
        public virtual Agendamento Agendamento { get; set; }

        [NotMapped]
        public virtual Vaga Vaga { get; set; }
    }
}
