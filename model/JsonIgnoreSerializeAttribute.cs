using System;

namespace TKGenericSurveyLib.model
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class JsonIgnoreSerializeAttribute : Attribute
    {
    }
}