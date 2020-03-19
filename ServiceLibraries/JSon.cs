namespace ServiceLibraries
{
    public class Json
    {
        public Json()
        {
        }

        public Json(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }
        public string Value { get; set; }
    }
}