using System;
using Concordia.Objects;

namespace Concordia
{
    public class DiscordBanRemovedEventArgs : EventArgs
    {
        public DiscordServer Guild { get; internal set; }
        public DiscordMember MemberStub { get; internal set; }
    }
}