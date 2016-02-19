using System;
using Concordia.Objects;
namespace Concordia
{
    public class DiscordSocketClosedEventArgs : EventArgs
    {
        public ushort Code { get; internal set; }
        public string Reason { get; internal set; }
        public bool WasClean { get; internal set; }

    }
}