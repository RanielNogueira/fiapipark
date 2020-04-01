using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IPark.Domain
{
    [Table("t_sc_vaga")]
    public class Vaga
    {
        [Key]
        [Column("id_vaga")]
        public int idVaga { get; set; }

        [Column("vl_diario")]
        [MinLength(1)]
        public decimal vlDiario { get; set; }

        [Column("vl_mensal")]
        public decimal? vlMensal { get; set; }

        [Column("ds_periodo_locacao")]
        [Required(AllowEmptyStrings = false),MaxLength(255)]
        public string periodoLocacao { get; set; }

        [Column("ds_servicos")]
        [Required(AllowEmptyStrings = false), MaxLength(255)]
        public string dsServicos { get; set; }

        [Column("ds_tamanho")]
        [Required(AllowEmptyStrings = false), MaxLength(255)]
        public string dsTamanho { get; set; }

        [Column("ds_localizacao")]
        [Required(AllowEmptyStrings = false), MaxLength(255)]
        public string dsLocalizacao { get; set; }

        [Column("tp_escabelecimento")]
        [Required(AllowEmptyStrings = false), MaxLength(255)]
        public string tbEstabelecimento { get; set; }

        [Column("t_sc_locatario_id_locatario")]
        [Required]
        public int idLocatario { get; set; }

        public virtual Locatario Locatario { get; set; }
    }
}
