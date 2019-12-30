using System;
using System.Collections.Generic;

namespace angular_dotnet.Model
{
    public partial class Makes
    {
        public Makes()
        {
            Models = new HashSet<Models>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Models> Models { get; set; }
    }
}
