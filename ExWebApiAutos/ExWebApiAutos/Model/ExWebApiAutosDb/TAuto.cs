using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExWebApiAutos.Model.ExWebApiAutosDb
{
    [Table("T_auto")]
    public partial class TAuto
    {
        [Key]
        [Column("auto_id")]
        public Guid AutoId { get; set; }
        [Required]
        [Column("auto_color")]
        [StringLength(20)]
        public string AutoColor { get; set; }
        [Required]
        [Column("auto_anio_fab")]
        [StringLength(4)]
        public string AutoAnioFab { get; set; }
        [Required]
        [Column("auto_placa")]
        [StringLength(10)]
        public string AutoPlaca { get; set; }
        [Required]
        [Column("auto_nro_asientos")]
        [StringLength(2)]
        public string AutoNroAsientos { get; set; }
        [Required]
        [Column("auto_transmision")]
        [StringLength(20)]
        public string AutoTransmision { get; set; }
        [Required]
        [Column("auto_version")]
        [StringLength(10)]
        public string AutoVersion { get; set; }
        [Column("marca_id")]
        public Guid MarcaId { get; set; }

        [ForeignKey("MarcaId")]
        [InverseProperty("TAuto")]
        public TMarca Marca { get; set; }
    }
}
