//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KnjigeIZanrovi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Score
    {
        public int StudentId { get; set; }
        public int ActivityId { get; set; }
        public int Score1 { get; set; }
    
        public virtual Activity Activity { get; set; }
        public virtual Student Student { get; set; }
    }
}
