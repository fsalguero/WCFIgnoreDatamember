using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFID.Service
{
    [ServiceContract]
    [XmlSerializerFormat]
    [IgnoreDataMemberBehavior]
    public interface IFooService
    {
        [OperationContract]
        FooResponse Foo(FooRequest request);
    }
}
