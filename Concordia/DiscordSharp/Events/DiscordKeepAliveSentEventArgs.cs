using System;
using Concordia.Objects;
namespace Concordia
{
    public class DiscordKeepAliveSentEventArgs : EventArgs
    {
        public DateTime SentAt { get; set; }
        public string JsonSent { get; set; }
    }
}