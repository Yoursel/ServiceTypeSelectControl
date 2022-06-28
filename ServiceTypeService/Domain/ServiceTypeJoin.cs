using System.Collections.Generic;

namespace ServiceTypeService.Domain
{
    public class ServiceTypeJoin
    {
        public long Id { get; set; }
        public long ParentServiceTypeId { get; set; }
        public long ChildrenServiceTypeId { get; set; }
    }

  
}