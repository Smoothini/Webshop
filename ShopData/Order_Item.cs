namespace ShopData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order_Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_Id { get; set; }

        public int Product_Id { get; set; }

        public int Order_Id { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
