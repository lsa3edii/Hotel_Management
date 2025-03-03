using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15.Entities
{
    abstract class User
    {
        [Key]
        public int UserID { get; set; }


        [MaxLength(25)]
        [Unicode] // Redundant
        public required string Username { get; set; }


        [MaxLength(25)]
        [Unicode]
        public required string Password { get; set; }
    }

}
