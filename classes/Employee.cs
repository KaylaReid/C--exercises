using System;
using System.Collections.Generic;

namespace Company // the namespace conects the files that all use this name
{
// blue print, all empolyeess will be build in this way
        public class Employee {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
    }
}