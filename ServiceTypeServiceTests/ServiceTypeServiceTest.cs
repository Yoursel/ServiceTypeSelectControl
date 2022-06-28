using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ServiceTypeServiceTests
{
    [TestClass]
    public class ServiceTypeServiceTest
    {
        [TestMethod]
        public void ServiceTypeServiceSholdBeReturnServiceTypeTree()
        {
            var service = new ServiceTypeService.ServiceTypeService();
            var tree = service.GetServiceTypesTree();
             Assert.IsNotNull(tree);
        }
    }
}
