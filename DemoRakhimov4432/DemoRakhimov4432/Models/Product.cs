namespace DemoRakhimov4432
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            ProductOrder = new HashSet<ProductOrder>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        public int Discount { get; set; }

        public int Quantity { get; set; }

        [Required]
        [StringLength(50)]
        public string Image { get; set; }

        public int? Price { get; set; }

        [StringLength(100)]
        public string Manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductOrder> ProductOrder { get; set; }
    }
}
