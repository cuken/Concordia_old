using Newtonsoft.Json.Linq;
using System;
using Concordia.Objects;

namespace Concordia
{
    public class DiscordTypingStartEventArgs : EventArgs
    {
        public DiscordMember user { get; internal set; }
        public int timestamp { get; internal set; }
        public DiscordChannel channel { get; internal set; }
        public JObject RawJson { get; internal set; } 
    }
}