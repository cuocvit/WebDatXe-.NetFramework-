//------------------------------------------------------------------------------
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
    
    public partial class SearchTrips_Result
    {
        public int id { get; set; }
        public int trip_details_id { get; set; }
        public string vehicle_type { get; set; }
        public Nullable<int> cost { get; set; }
        public string start_point { get; set; }
        public string end_point { get; set; }
        public Nullable<System.TimeSpan> time_start { get; set; }
        public Nullable<System.TimeSpan> time_end { get; set; }
        public Nullable<int> Chair { get; set; }
    }
}