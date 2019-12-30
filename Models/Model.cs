using System;
using System.Collections.Generic;

namespace angular_dotnet.Model
{
    public partial class Models
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MakeId { get; set; }

        public virtual Makes Make { get; set; }
    }
}
