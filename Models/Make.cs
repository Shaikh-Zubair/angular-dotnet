using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace angular_dotnet.Model
{
    public partial class Makes
    {
        public Makes()
        {
            Models = new HashSet<Models>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public virtual ICollection<Models> Models { get; set; }
    }
}
