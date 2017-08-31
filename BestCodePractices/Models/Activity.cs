using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BestCodePractices.Models
{
    public class Activity
    {
        public int ActivityId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int OwnerId { get; set; }
    }
}