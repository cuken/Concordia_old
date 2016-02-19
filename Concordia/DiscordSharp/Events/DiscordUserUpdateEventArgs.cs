using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concordia.Objects;
namespace Concordia.Events
{
    public class DiscordUserUpdateEventArgs : EventArgs
    {
        public DiscordMember OriginalMember { get; internal set; }
        public DiscordMember NewMember { get; internal set; }
        public JObject RawJson { get; internal set; }
    }
}
