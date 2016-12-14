using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using TKGenericSurveyLib.model;

namespace TKGenericSurveyLib.services
{
    public class SurveySerializeContractResolver : DefaultContractResolver
    {
        protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
        {
            IList<JsonProperty> properties = base.CreateProperties(type, memberSerialization);

            properties =
                properties.Where(p => CheckAttribute(p.AttributeProvider)).ToList();

            return properties;
        }

        private bool CheckAttribute(IAttributeProvider provider)
        {
            return provider.GetAttributes(typeof(JsonIgnoreSerializeAttribute), true).Count == 0;
        }
    }
}