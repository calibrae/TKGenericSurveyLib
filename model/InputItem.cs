using TKGenericSurveyLib.constants;

namespace TKGenericSurveyLib.model
{
    public class InputItem : ISurveyItem
    {
        public GenericSurveyViewType ItemType
        {
            get
            {
                return GenericSurveyViewType.Input;
            }
            set { }
        }

        public int Id { get; set; }
        [JsonIgnoreSerialize]
        public string Label { get; set; }
        public string SelectedItem { get; set; }
    }
}