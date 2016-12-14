using TKGenericSurveyLib.constants;

namespace TKGenericSurveyLib.model
{
    public class SliderItem : ISurveyItem
    {
        public GenericSurveyViewType ItemType
        {
            get
            {
                return GenericSurveyViewType.Slider;
            }
            set { }
        }

        public int Id { get; set; }

        [JsonIgnoreSerialize]
        public string Label { get; set; }

        public string SelectedItem
        {
            get { return SelectedValue.ToString(); }
            set { SelectedValue = float.Parse(value); }
               
        }
        [JsonIgnoreSerialize]
        public float SelectedValue { get; set; }

        [JsonIgnoreSerialize]
        public float MaxValue { get; set; }
        [JsonIgnoreSerialize]
        public float MinValue { get; set; }
    }
}