namespace TKGenericSurveyLib.model
{
    public class SurveyValueItem
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Weight { get; set; }

        public override string ToString()
        {
            return Name;
        }


    }
}