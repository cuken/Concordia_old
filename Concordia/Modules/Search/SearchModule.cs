using Discord;
using Discord.Commands;
using Discord.Commands.Permissions.Levels;
using Discord.Commands.Permissions.Visibility;
using Discord.Modules;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Concordia.Helpers;
using System;
using Newtonsoft.Json.Linq;

namespace Concordia.Modules.Admin
{
    /// <summary> Provides easy access to manage users from chat. </summary>
    internal class SearchModule : IModule
    {
        private ModuleManager _manager;
        private DiscordClient _client;

        void IModule.Install(ModuleManager manager)
        {
            _manager = manager;
            _client = manager.Client;

            manager.CreateCommands("", group =>
            {
                group.PublicOnly();

                group.CreateCommand("ud")
                    .Description("Searches for a term in UrbanDictionary")
                    .Parameter("searchTerm")
                    .MinPermissions((int)PermissionLevel.User)
                    .Do(async e =>
                    {
                        var arg = e.GetArg("searchTerm");
                        if( string.IsNullOrWhiteSpace(arg))
                        {
                            await e.Channel.SendMessage("Please enter a search term.");
                            return;
                        }
                        await e.Channel.SendIsTyping();
                        var headers = new WebHeaderCollection();
                        var res = await SearchHelper.GetResponseAsync($"http://api.urbandictionary.com/v0/define?term={Uri.EscapeUriString(arg)}");
                        try
                        {
                            var items = JObject.Parse(res);
                            var sb = new System.Text.StringBuilder();                            
                            sb.AppendLine($"`Term:` {items["list"][0]["word"].ToString()}");
                            sb.AppendLine($"`Definition:` {items["list"][0]["definition"].ToString()}");
                            sb.AppendLine($"`Example:` {items["list"][0]["example"].ToString()}");
                            sb.AppendLine($":thumbsup:: {items["list"][0]["thumbs_up"].ToString()} \t:thumbsdown:: {items["list"][0]["thumbs_down"].ToString()}");

                            await e.Channel.SendMessage(sb.ToString());
                        }
                        catch
                        {
                            await e.Channel.SendMessage("Failed to find a defintion for that term");
                        }
                       //Search Code
                    });

                group.CreateCommand("#")
                    .Description("Searches for a hashtag meaning")
                    .Parameter("searchTerm")
                    .MinPermissions((int)PermissionLevel.User)
                    .Do(async e =>
                    {
                        var arg = e.GetArg("searchTerm");
                        if(string.IsNullOrWhiteSpace(arg))
                        {
                            await e.Channel.SendMessage("Please enter a search term.");
                            return;
                        }
                        await e.Channel.SendIsTyping();
                        var headers = new WebHeaderCollection();
                        var res = await SearchHelper.GetResponseAsync($"http://api.tagdef.com/one.{Uri.EscapeUriString(arg)}.json");
                        try
                        {
                            var items = JObject.Parse(res);
                            var sb = new System.Text.StringBuilder();
                            sb.AppendLine($"`#:` {items["defs"]["def"]["hashtag"].ToString()}");
                            sb.AppendLine($"`Definition:` {items["defs"]["def"]["text"].ToString()}");
                            sb.AppendLine($":thumbsup:: {items["defs"]["def"]["upvotes"].ToString()} \t:thumbsdown:: {items["defs"]["def"]["downvotes"].ToString()}");

                            await e.Channel.SendMessage(sb.ToString());
                        }
                        catch
                        {
                            await e.Channel.SendMessage("Failed to find a defintion for that term");
                        }
                    });
                
            });
        }
    }
}