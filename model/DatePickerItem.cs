using System;
using TKGenericSurveyLib.constants;

namespace TKGenericSurveyLib.model
{
    public class DatePickerItem : ISurveyItem
    {
        public GenericSurveyViewType ItemType
        {
            get
            {
                return GenericSurveyViewType.DatePicker;
            }
            set
            {
            }
        }

        public int Id { get; set; }

        [JsonIgnoreSerialize]
        public string Label { get; set; }

        public string SelectedItem
        {
            get { return SelectedDate.Ticks.ToString(); }
            set { SelectedDate = new DateTime(long.Parse(value)); }
        }

        [JsonIgnoreSerialize]
        public DateTime SelectedDate { get; set; }
    }
}