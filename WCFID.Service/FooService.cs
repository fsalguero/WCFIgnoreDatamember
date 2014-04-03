using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Activation;

namespace WCFID.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class FooService : IFooService
    {
        public FooResponse Foo(FooRequest request)
        {
            return new FooResponse
            {
                DataResponse = "FooBar",
                ExtraData = "Sometimes unnecessary data"
            };
        }
    }
}