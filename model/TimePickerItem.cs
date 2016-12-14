using System;
using System.Diagnostics;
using System.Windows.Input;
using Newtonsoft.Json;
using TKGenericSurveyLib.constants;
using Xamarin.Forms;

namespace TKGenericSurveyLib.model
{
    public class TimePickerItem : ISurveyItem
    {
        public GenericSurveyViewType ItemType
        {
            get
            {
                return GenericSurveyViewType.TimePicker;
            }
            set { }
        }

        public int Id { get; set; }

        [JsonIgnoreSerialize]
        public string Label { get; set; }

        public string SelectedItem
        {
            get { return SelectedTime.Ticks.ToString(); }
            set { SelectedTime = new TimeSpan(long.Parse(value)); }
        }
        [JsonIgnore]
        public TimeSpan SelectedTime { get; set; }
    }
}