using Newtonsoft.Json.Linq;
using System;
using Concordia.Objects;
namespace Concordia
{
    public enum DiscordUserStatus { ONLINE, IDLE, OFFLINE }

    public class DiscordPresenceUpdateEventArgs : EventArgs
    {
        public DiscordMember user { get; internal set; }
        public DiscordUserStatus status { get; internal set; }
        public string game { get; internal set; }

        public JObject RawJson { get; internal set; }
    }
}