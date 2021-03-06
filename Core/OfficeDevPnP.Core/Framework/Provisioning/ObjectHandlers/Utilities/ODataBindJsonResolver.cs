﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDevPnP.Core.Framework.Provisioning.ObjectHandlers.Utilities
{
    internal class ODataBindJsonResolver : CamelCasePropertyNamesContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);
            if (property.PropertyName.Equals("template_odata_bind", StringComparison.OrdinalIgnoreCase))
            {
                property.PropertyName = "template@odata.bind";
            }
            else if (property.PropertyName.Equals("owners_odata_bind", StringComparison.OrdinalIgnoreCase))
            {
                property.PropertyName = "owners@odata.bind";
            }
            else if (property.PropertyName.Equals("members_odata_bind", StringComparison.OrdinalIgnoreCase))
            {
                property.PropertyName = "members@odata.bind";
            }
            return property;
        }
    }
}
