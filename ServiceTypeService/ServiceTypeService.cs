using System.Collections.Generic;
using System.Linq;
using ServiceTypeService.Domain;
using ServiceTypeService.Dto;

namespace ServiceTypeService
{
    public class ServiceTypeService
    {
        public List<ServiceTypeDto> GetServiceTypesTree()
        {
            var root = ServiceTypeJoinRepository.Joins.Where(j => j.ParentServiceTypeId == 0).ToList();
            return root.Select(serviceTypeJoin => CreateTree(serviceTypeJoin.ChildrenServiceTypeId)).ToList();
        }

        private ServiceTypeDto CreateTree(long serviceTypeId)
        {
            var serviceType = ServiceTypeRepository.ServiceTypes.FirstOrDefault(st => st.Id == serviceTypeId);
            if (serviceType == null)
            {
                return null;
            }
            var result = new ServiceTypeDto {Id = serviceTypeId, Code = serviceType.Code, Name = serviceType.Name};
            var children = ServiceTypeJoinRepository.Joins.Where(j => j.ParentServiceTypeId == serviceTypeId);
            foreach (var child in children)
            {
                result.ChildrenList.Add(CreateTree(child.ChildrenServiceTypeId));
            }
            return result;
        }

        public IEnumerable<ServiceTypeDto> GetAllNodes(IEnumerable<ServiceTypeDto> data)
        {
            var result = new List<ServiceTypeDto>();
            if (data != null)
            {
                foreach (var item in data)
                {
                    if (item != null)
                    {
                        result.Add(item);
                        result.AddRange(GetAllNodes(item.ChildrenList));
                    }
                }
            }
            return result;
        }
    }
}
