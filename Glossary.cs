using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace WHGWordAddin
{
    public class RootObject
    {
        [JsonProperty("json_category")]
        public List<Glossary> json_category { get; set; }
    }

    public class Glossary
    {
        [JsonProperty("active")]
        [JsonConverter(typeof(BoolConverter))]
        public bool active { get; set; }
        [JsonProperty("editable")]
        [JsonConverter(typeof(BoolConverter))]
        public bool editable { get; set; }
        [JsonProperty("category")]
        public string category { get; set; }
        [JsonProperty("id")]
        public int id { get; set; } 
    }

}
public class BoolConverter : JsonConverter
{
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        writer.WriteValue(((bool)value) ? 1 : 0);
    }
    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer seraializer)
    {
        return reader.Value.ToString() == "1";
    }
    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(bool);
    }
}