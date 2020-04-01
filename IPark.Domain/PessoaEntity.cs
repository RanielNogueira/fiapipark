using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IPark.Domain
{
    public class PessoaEntity 
    {
        [Column("ds_cpf")]
        [MaxLength(11)]
        public virtual long Cpf { get; set; }

        [Column("ds_nome")]
        [Required(AllowEmptyStrings = false)]
        public string Nome { get; set; }

        [Column("ds_telefone")]
        [MaxLength(11),MinLength(10)]
        public string Telefone { get; set; }

        [Column("ds_email")]
        [DataType(DataType.EmailAddress),Display(Name = "E-mail")]
        public string Email { get; set; }
    }
}
