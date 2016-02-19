using System;
using Concordia.Objects;
namespace Concordia
{
    public class DiscordPrivateMessageEventArgs : EventArgs
    {
        public DiscordPrivateChannel Channel { get; internal set; }
        public DiscordMember author { get; internal set; }
        public string message { get; internal set; }
    }
}