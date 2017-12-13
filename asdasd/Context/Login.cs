using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdasd.Context
{
    public class Login
    {
        [Key]
        public int ID { get; set; }
        [Required,MaxLength(length:228)]
        public string Email { get; set; }
        [Required,MaxLength(length:228)]
        public string Password { get; set; }
    }
}
