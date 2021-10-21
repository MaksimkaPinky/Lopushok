namespace Lopushok
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Material")]
    public partial class Material
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public int CountInPack { get; set; }

        [Required]
        [StringLength(10)]
        public string Unit { get; set; }

        public double? CountInStock { get; set; }

        public double MinCount { get; set; }

        public string Description { get; set; }

        public decimal Cost { get; set; }

        [StringLength(100)]
        public string Image { get; set; }

        public int MaterialTypeID { get; set; }

        public virtual MaterialType MaterialType { get; set; }
    }
}
