using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFID.Service
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class IgnoreDataMemberAttribute : Attribute
    {
    }
}