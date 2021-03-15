using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DoanLeMyLinh_5951071049.Models
{
    [DataContract]
    public class Student
    {
        [DataMember(Name = "Class")]
        public string Class { get; set; }
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "ID")]
        public string ID { get; set; }
        [DataMember(Name = "Address")]
        public string Address { get; set; }
        [DataMember(Name = "dateTime")]
        public DateTime DateTime { get; set; }
    }
}