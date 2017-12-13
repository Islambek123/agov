using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdasd.Context
{
    public class Role
    {
        [Key]
        public int ID { get; set; }
        [Required,MaxLength(length:20)]
        public string RoleName { get; set; }
        public virtual ICollection<Login> login { get; set; }
    }
}
