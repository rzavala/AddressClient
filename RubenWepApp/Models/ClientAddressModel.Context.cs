﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RubenWepApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ClientAddressEntities : DbContext
    {
        public ClientAddressEntities()
            : base("name=ClientAddressEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int RubenClientAddressSD(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RubenClientAddressSD", iDParameter);
        }
    
        public virtual ObjectResult<RubenClientAddressSEL_Result> RubenClientAddressSEL(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RubenClientAddressSEL_Result>("RubenClientAddressSEL", iDParameter);
        }
    
        public virtual int RubenClientAddressSI(string street, string city, string state, string zip, string intersection1)
        {
            var streetParameter = street != null ?
                new ObjectParameter("Street", street) :
                new ObjectParameter("Street", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(string));
    
            var zipParameter = zip != null ?
                new ObjectParameter("Zip", zip) :
                new ObjectParameter("Zip", typeof(string));
    
            var intersection1Parameter = intersection1 != null ?
                new ObjectParameter("Intersection1", intersection1) :
                new ObjectParameter("Intersection1", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RubenClientAddressSI", streetParameter, cityParameter, stateParameter, zipParameter, intersection1Parameter);
        }
    
        public virtual int RubenClientAddressSU(Nullable<int> iD, string street, string city, string state, string zip, string intersection1)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var streetParameter = street != null ?
                new ObjectParameter("Street", street) :
                new ObjectParameter("Street", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(string));
    
            var zipParameter = zip != null ?
                new ObjectParameter("Zip", zip) :
                new ObjectParameter("Zip", typeof(string));
    
            var intersection1Parameter = intersection1 != null ?
                new ObjectParameter("Intersection1", intersection1) :
                new ObjectParameter("Intersection1", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RubenClientAddressSU", iDParameter, streetParameter, cityParameter, stateParameter, zipParameter, intersection1Parameter);
        }
    }
}
