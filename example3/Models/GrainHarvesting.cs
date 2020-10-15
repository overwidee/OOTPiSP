using System;
using System.Collections.Generic;
using System.Linq;

namespace example3.Models
{
    public class GrainHarvesting : List<Employee>
    {
        public double GetTotal() => this.Sum(x => x.Tones);
        public string GetBest() => this.OrderByDescending(x => x.Tones).FirstOrDefault()?.GetFullName();
    }
}