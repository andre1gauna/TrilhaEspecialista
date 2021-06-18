using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WPF_DB.ViewModels
{
    public class CadastroCliente
    {
        [Column("IdCliente")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdCliente { get; set; }

        [Column("NomeCliente")]
        [Required]
        [StringLength(50)]
        public string NomeCliente { get; set; }

        [Column("RG")]
        [Required]
        [StringLength(9)]
        public string RG { get; set; }

        [Column("CPF")]
        [Required]
        [StringLength(11)]
        public string CPF { get; set; }

        [Column("Endereco")]
        [Required]
        [StringLength(50)]
        public string Endereco { get; set; }

        [Column("Produto")]
        [Required]
        [StringLength(30)]
        public string Produto { get; set; }

        [Column("PrecoVenda")]
        [Required]
        [StringLength(10)]
        public string PrecoVenda { get; set; }
        

    }
}
