namespace DemoRakhimov4432
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderShopAddress = new HashSet<OrderShopAddress>();
            ProductOrder = new HashSet<ProductOrder>();
            UserOrder = new HashSet<UserOrder>();
        }

        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DeliverDate { get; set; }

        public int ReceptionId { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(250)]
        public string FIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderShopAddress> OrderShopAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductOrder> ProductOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserOrder> UserOrder { get; set; }
    }
}
