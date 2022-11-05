namespace DemoRakhimov4432
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductOrder")]
    public partial class ProductOrder
    {
        public int Id { get; set; }

        public int? ProductId { get; set; }

        public int OrderId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductCode { get; set; }

        public int Quantity { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
