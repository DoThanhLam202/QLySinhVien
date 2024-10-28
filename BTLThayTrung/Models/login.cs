namespace BTLThayTrung.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("login")]
    public partial class login
    {
        public long id { get; set; }

        [StringLength(50)]
        [Required]
        public string user { get; set; }

        [StringLength(50)]
        [DataType(DataType.Password)]
        [Required]
        public string pass { get; set; }
    }
}
