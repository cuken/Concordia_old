using System;
using Concordia.Objects;
namespace Concordia
{
    public class DiscordPrivateChannelEventArgs : EventArgs
    { 
        public DiscordChannelCreateType ChannelType { get; set; }
        public DiscordPrivateChannel ChannelCreated { get; set; }
    }
}