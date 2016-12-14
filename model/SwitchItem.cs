using TKGenericSurveyLib.constants;

namespace TKGenericSurveyLib.model
{
    public class SwitchItem : ISurveyItem
    {
        public GenericSurveyViewType ItemType
        {
            get { return GenericSurveyViewType.Switch; }
            set { }
        }

        public int Id { get; set; }
        [JsonIgnoreSerialize]
        public string Label { get; set; }

        public string SelectedItem
        {
            get { return IsSelected.ToString(); }
            set { IsSelected = bool.Parse(value); }
        }

        [JsonIgnoreSerialize]
        public bool IsSelected { get; set; }
    }
}