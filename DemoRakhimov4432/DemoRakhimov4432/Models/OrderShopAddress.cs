namespace DemoRakhimov4432
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderShopAddress")]
    public partial class OrderShopAddress
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int ShopAddressId { get; set; }

        public virtual Order Order { get; set; }

        public virtual ShopAddress ShopAddress { get; set; }
    }
}
