using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace angular_dotnet.Controllers.Resources
{
    public class MakeResource
    {
        public MakeResource(int id, string name)
        {
            Models = new Collection<ModelResource>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ModelResource> Models { get; set; }
    }
}