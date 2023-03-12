using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enttylayer.concrate
{
     public class Skill
    {
        [Key]
        public int SkilID { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
    }
}
