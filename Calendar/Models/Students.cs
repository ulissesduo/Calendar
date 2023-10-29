using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Models
{
    public class Students
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime ContractInicialDate { get; set; }
        public DateTime ContractEndDate { get; set; } 
        public string? WeekDays { get; set; }
        public bool Status { get; set; } 

    }
}
