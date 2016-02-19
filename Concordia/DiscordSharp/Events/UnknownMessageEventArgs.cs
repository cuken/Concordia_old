using Newtonsoft.Json.Linq;
using System;
using Concordia.Objects;
namespace Concordia.Events
{
    public class UnknownMessageEventArgs : EventArgs
    {
        public JObject RawJson { get; internal set; }
    }
}
