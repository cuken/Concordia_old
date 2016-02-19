using System;
using Concordia.Objects;
namespace Concordia
{
    public class DiscordDebugMessagesEventArgs : EventArgs
    {
        public string message { get; internal set; }
    }
}