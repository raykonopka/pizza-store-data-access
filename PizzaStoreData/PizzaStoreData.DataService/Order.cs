//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PizzaStoreData.DataService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Pizzas = new HashSet<Pizza>();
        }
    
        public int Id { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
        public Nullable<decimal> Taxes { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<System.DateTime> OrderDateTime { get; set; }
        public int CustomerId { get; set; }
        public int PaymentMethodId { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pizza> Pizzas { get; set; }
    }
}
