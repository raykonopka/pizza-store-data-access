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
    
    public partial class ToppingList
    {
        public int Id { get; set; }
        public int PizzaId { get; set; }
        public int ToppingId { get; set; }
        public int ToppingPlacementId { get; set; }
    
        public virtual Pizza Pizza { get; set; }
        public virtual Topping Topping { get; set; }
        public virtual ToppingPlacement ToppingPlacement { get; set; }
    }
}
