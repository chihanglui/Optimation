using System;
using System.Xml;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace OptimationAPI.Domain.Model {
    public class Email : ModelBase{
        
        public string Content { get; set; }
    }

    
}
