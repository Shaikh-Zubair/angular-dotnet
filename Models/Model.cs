using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace angular_dotnet.Model
{
    public partial class Models
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public int MakeId { get; set; }

        public virtual Makes Make { get; set; }
    }
}
