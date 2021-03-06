//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineStore.Model.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class ecom_Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ecom_Orders()
        {
            this.ecom_OrderDetails = new HashSet<ecom_OrderDetails>();
        }
    
        public int Id { get; set; }
        public string OrderCode { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal FeeShip { get; set; }
        public decimal TotalOrder { get; set; }
        public int OrderStatus { get; set; }
        public string OrderNote { get; set; }
        public string NameOfRecipient { get; set; }
        public string PhoneOfRecipient { get; set; }
        public string AddressOfRecipient { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ecom_OrderDetails> ecom_OrderDetails { get; set; }
    }
}
