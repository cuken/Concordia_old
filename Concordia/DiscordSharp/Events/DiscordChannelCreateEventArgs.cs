using Concordia.Objects;
using System;

namespace Concordia
{
    public enum DiscordChannelCreateType
    {
        PRIVATE, CHANNEL
    }
    public class DiscordChannelCreateEventArgs : EventArgs
    {
        public DiscordChannelCreateType ChannelType { get; set; }
        public DiscordChannel ChannelCreated { get; set; }
    }
}