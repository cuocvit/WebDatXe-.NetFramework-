﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATA.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QuanLyBenXeEntities1 : DbContext
    {
        public QuanLyBenXeEntities1()
            : base("name=QuanLyBenXeEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admin_account> admin_account { get; set; }
        public virtual DbSet<buser_account> buser_account { get; set; }
        public virtual DbSet<bus> buses { get; set; }
        public virtual DbSet<checkpoint> checkpoints { get; set; }
        public virtual DbSet<cmt> cmts { get; set; }
        public virtual DbSet<discount> discounts { get; set; }
        public virtual DbSet<guest_account> guest_account { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<transaction> transactions { get; set; }
        public virtual DbSet<trip> trips { get; set; }
        public virtual DbSet<vehicle> vehicles { get; set; }
        public virtual DbSet<trip_details> trip_details { get; set; }
        public virtual DbSet<news> news { get; set; }
    
        public virtual int SearchTrips(string startPoint, string endPoint, Nullable<System.DateTime> dateStart, Nullable<System.TimeSpan> timeStart, Nullable<System.TimeSpan> timeEnd, string vehicleType, string sortOrder)
        {
            var startPointParameter = startPoint != null ?
                new ObjectParameter("StartPoint", startPoint) :
                new ObjectParameter("StartPoint", typeof(string));
    
            var endPointParameter = endPoint != null ?
                new ObjectParameter("EndPoint", endPoint) :
                new ObjectParameter("EndPoint", typeof(string));
    
            var dateStartParameter = dateStart.HasValue ?
                new ObjectParameter("DateStart", dateStart) :
                new ObjectParameter("DateStart", typeof(System.DateTime));
    
            var timeStartParameter = timeStart.HasValue ?
                new ObjectParameter("TimeStart", timeStart) :
                new ObjectParameter("TimeStart", typeof(System.TimeSpan));
    
            var timeEndParameter = timeEnd.HasValue ?
                new ObjectParameter("TimeEnd", timeEnd) :
                new ObjectParameter("TimeEnd", typeof(System.TimeSpan));
    
            var vehicleTypeParameter = vehicleType != null ?
                new ObjectParameter("VehicleType", vehicleType) :
                new ObjectParameter("VehicleType", typeof(string));
    
            var sortOrderParameter = sortOrder != null ?
                new ObjectParameter("SortOrder", sortOrder) :
                new ObjectParameter("SortOrder", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SearchTrips", startPointParameter, endPointParameter, dateStartParameter, timeStartParameter, timeEndParameter, vehicleTypeParameter, sortOrderParameter);
        }
    
        public virtual ObjectResult<SearchTrips1_Result1> SearchTrips1(string startPoint, string endPoint, Nullable<System.DateTime> dateStart)
        {
            var startPointParameter = startPoint != null ?
                new ObjectParameter("StartPoint", startPoint) :
                new ObjectParameter("StartPoint", typeof(string));
    
            var endPointParameter = endPoint != null ?
                new ObjectParameter("EndPoint", endPoint) :
                new ObjectParameter("EndPoint", typeof(string));
    
            var dateStartParameter = dateStart.HasValue ?
                new ObjectParameter("DateStart", dateStart) :
                new ObjectParameter("DateStart", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchTrips1_Result1>("SearchTrips1", startPointParameter, endPointParameter, dateStartParameter);
        }
    
        public virtual ObjectResult<GetTripDetails_Result2> GetTripDetails(Nullable<int> tripId, Nullable<int> tripDetailsId)
        {
            var tripIdParameter = tripId.HasValue ?
                new ObjectParameter("TripId", tripId) :
                new ObjectParameter("TripId", typeof(int));
    
            var tripDetailsIdParameter = tripDetailsId.HasValue ?
                new ObjectParameter("TripDetailsId", tripDetailsId) :
                new ObjectParameter("TripDetailsId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetTripDetails_Result2>("GetTripDetails", tripIdParameter, tripDetailsIdParameter);
        }
    }
}
