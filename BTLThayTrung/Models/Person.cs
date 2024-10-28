namespace BTLThayTrung.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Person
    {
        
        public long id { get; set; }

        [StringLength(50)]
        [DisplayName("Họ và Tên")]
        public string name { get; set; }
        [DisplayName("Năm sinh")]
        public int? date { get; set; }

        [StringLength(50)]
        [DisplayName("Địa chỉ")]
        public string address { get; set; }
    }
}
