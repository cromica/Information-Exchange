//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InformationExchange.Services.SouthAmerica.MessageHandlers.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public int Items { get; set; }
        public decimal Value { get; set; }
        public string Country_Code { get; set; }
    
        public virtual Country Country { get; set; }
    }
}
