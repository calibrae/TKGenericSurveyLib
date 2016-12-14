using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using TKGenericSurveyLib.constants;
using TKGenericSurveyLib.model;

namespace TKGenericSurveyLib.services
{
    public class SurveyItemConvertor : CustomCreationConverter<ISurveyItem>
    {
        public override ISurveyItem Create(Type objectType)
        {
            throw new NotImplementedException();
        }

        public ISurveyItem Create(Type objectType, JObject jObject)
        {
            var type = (string) jObject.Property("itemType");
            GenericSurveyViewType enumType;
            if (Enum.TryParse(type, true, out enumType))
            {
                switch (enumType)
                {
                    case GenericSurveyViewType.DatePicker:
                        return new DatePickerItem();
                    case GenericSurveyViewType.TimePicker:
                        return new TimePickerItem();
                    case GenericSurveyViewType.Input:
                        return new InputItem();
                    case GenericSurveyViewType.Slider:
                        return new SliderItem();
                    case GenericSurveyViewType.Picker:
                        return new PickerItem();
                    case GenericSurveyViewType.Switch:
                        return new SwitchItem();
                    default:
                        break;
                }
            }
            throw new NotImplementedException("You're trying to instanciate a SurveyItem of type :" + type +
                                              " which obviously does not exist, dumb fucking arse");
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            // Load JObject from stream
            JObject jObject = JObject.Load(reader);

            // Create target object based on JObject
            var target = Create(objectType, jObject);

            // Populate the object properties
            serializer.Populate(jObject.CreateReader(), target);

            return target;
        }
    }
}