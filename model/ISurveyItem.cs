using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TKGenericSurveyLib.constants;

namespace TKGenericSurveyLib.model
{
    public interface ISurveyItem
    {
        [JsonConverter(typeof(StringEnumConverter))]
        GenericSurveyViewType ItemType { get; set; }
        int Id { get; set; }
        string Label { get; set; }
        string SelectedItem { get; set; }
    }
}