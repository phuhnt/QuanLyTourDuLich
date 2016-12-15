//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class TourGroup
    {
        public TourGroup()
        {
            this.Passengers = new HashSet<Passenger>();
            this.Employees = new HashSet<Employee>();
            this.Transports = new HashSet<Transport>();
        }
    
        public int id { get; set; }
        public int tour_id { get; set; }
        public System.DateTime depart_date { get; set; }
        public System.DateTime return_date { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<Passenger> Passengers { get; set; }
        public virtual Tour Tour { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Transport> Transports { get; set; }
    }
}
