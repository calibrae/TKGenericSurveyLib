using System.Collections.Generic;
using TKGenericSurveyLib.constants;

namespace TKGenericSurveyLib.model
{
    public class PickerItem : ISurveyItem
    {
        public GenericSurveyViewType ItemType
        {
            get { return GenericSurveyViewType.Picker; }
            set { }
        }

        public int Id { get; set; }

        [JsonIgnoreSerialize]
        public string Label { get; set; }

        public string SelectedItem
        {
            get { return SelectedPickerItem?.Id.ToString() ?? "null"; }
            set { SelectedPickerItem = PickerItems.Find(i => i.Id == int.Parse(value)); }
        }

        [JsonIgnoreSerialize]
        public List<SurveyValueItem> PickerItems { get; set; }

        public SurveyValueItem SelectedPickerItem { get; set; }
    }
}