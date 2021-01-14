using Newtonsoft.Json;

namespace Teams.Webhook
{
    class Action
    {
        [JsonProperty("@type")]
        public string Type { get; }
        public string Name { get; }
        protected Action(string type, string name)
        {
            Type = type;
            Name = name;
        }
    }
}
