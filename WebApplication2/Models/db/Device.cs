using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
        [DataType(DataType.Date)]
        public DateTime ExecutionDate { get; set; }
    }
}
