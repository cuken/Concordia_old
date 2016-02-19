using System;
using Concordia.Objects;
namespace Concordia
{
    public class DiscordGuildBanEventArgs : EventArgs
    {
        public DiscordMember MemberBanned { get; internal set; }
        public DiscordServer Server { get; internal set; }
    }
}