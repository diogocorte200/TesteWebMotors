using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TesteWebMotors.Entity.Entity
{
    [Table("tb_AnuncioWebmotors")]
    public class AnuncioWebMotorsEntity : BaseEntity
    {
        [Column(TypeName = "varchar(45)")]
        public string Marca { get; set; }
        [Column(TypeName = "varchar(45)")]
        public string Modelo { get; set; }
        [Column(TypeName = "varchar(45)")]
        public string Versao { get; set; }

        [Column(TypeName = "int")]
        public int Ano { get; set; }
        [Column(TypeName = "int")]
        public int Quilometragem { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        public string Observacao { get; set; }
    }
}
