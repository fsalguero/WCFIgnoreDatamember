using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFID.Service
{
    [DataContract]
    public class FooResponse
    {
        [DataMember]
        public string DataResponse { get; set; }

        [DataMember]
        [IgnoreDataMember]
        public string ExtraData { get; set; }
    }
}