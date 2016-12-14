using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using TKGenericSurveyLib.constants;
using TKGenericSurveyLib.model;
using TKGenericSurveyLib.view.components;
using Xamarin.Forms;

namespace TKGenericSurveyLib.services
{
    public class SurveyViewFactory
    {
        public List<View> Create(string json)
        {
            var result = JsonConvert.DeserializeObject<List<ISurveyItem>>(json, new SurveyItemConvertor());
            var list = new List<View>();
            for (var i = 0; i < result.Count; i++)
            {
                list.Add(CreateView(result[i]));

            }
            return list;
        }

        public void Create(string json, Layout<View> layout)
        {
            var result = JsonConvert.DeserializeObject<List<ISurveyItem>>(json, new SurveyItemConvertor());
            for (var i = 0; i < result.Count; i++)
            {
                layout.Children.Add(CreateView(result[i]));
            }
        }

        private View CreateView(ISurveyItem item)
        {
            switch (item.ItemType)
            {
                    case GenericSurveyViewType.DatePicker:
                    return CreateDatePicker(item as DatePickerItem);
                    case GenericSurveyViewType.Input:
                    return CreateInput(item as InputItem);
                    case GenericSurveyViewType.Picker:
                    return CreatePicker(item as PickerItem);
                    case GenericSurveyViewType.Slider:
                    return CreateSlider(item as SliderItem);
                    case GenericSurveyViewType.Switch:
                    return CreateSwitch(item as SwitchItem);
                    case GenericSurveyViewType.TimePicker:
                    return CreateTimePicker(item as TimePickerItem);
                default:
                    throw new NotImplementedException("Item type : " + item.ItemType + " is not implemented");

            }
        }

        private View CreateTimePicker(TimePickerItem timePickerItem)
        {
            var view = new SurveyTimePicker();
            view.BindingContext = timePickerItem;

            return view;
        }

        private View CreateSwitch(SwitchItem switchItem)
        {
            throw new NotImplementedException();
        }

        private View CreateSlider(SliderItem sliderItem)
        {
            throw new NotImplementedException();
        }

        private View CreatePicker(PickerItem pickerItem)
        {
            throw new NotImplementedException();
        }

        private View CreateInput(InputItem inputItem)
        {
            throw new NotImplementedException();
        }

        private View CreateDatePicker(DatePickerItem item)
        {
            throw new System.NotImplementedException();
        }
    }
}