//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PryorCalendarLogin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cal_Event
    {
        public System.Guid Event_ID { get; set; }
        public string Event_Name { get; set; }
        public System.DateTime Date { get; set; }
        public System.Guid User_ID { get; set; }
        public Nullable<System.TimeSpan> Time { get; set; }
        public string Comment { get; set; }
        public virtual User User { get; set; }
    }
}
