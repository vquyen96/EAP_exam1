using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EAP_exam1.Models
{
    public class Money
    {
        [Key]
        public string Id { get; set; }

        public long Ratio { get; set; }
    }
}
