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
    
    public partial class Topping
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Topping()
        {
            this.ToppingLists = new HashSet<ToppingList>();
        }
    
        public int Id { get; set; }
        public string ToppingName { get; set; }
        public decimal Price { get; set; }
        public int ToppingCategoryId { get; set; }
    
        public virtual ToppingCategory ToppingCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ToppingList> ToppingLists { get; set; }
    }
}
