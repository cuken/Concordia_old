using System;
using Concordia.Objects;
namespace Concordia
{
    public class DiscordConnectEventArgs : EventArgs
    {
        public DiscordMember user { get; internal set; }
    }
}