using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFID.Service
{
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