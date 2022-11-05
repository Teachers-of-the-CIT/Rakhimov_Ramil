namespace DemoRakhimov4432
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShopAddress")]
    public partial class ShopAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShopAddress()
        {
            OrderShopAddress = new HashSet<OrderShopAddress>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderShopAddress> OrderShopAddress { get; set; }
    }
}
