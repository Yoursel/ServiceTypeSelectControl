using ServiceTypeService.Dto;
using System.Collections.Generic;

namespace ServiceTest
{
    public class ModelView
    {
        private ServiceTypeService.ServiceTypeService Service = new ServiceTypeService.ServiceTypeService();
        public IEnumerable<ServiceTypeDto> Services => Service.GetServiceTypesTree();
    }
}
