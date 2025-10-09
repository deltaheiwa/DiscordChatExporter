using System.Text.Json;
using System.Text.Json.Nodes;
using DiscordChatExporter.Core.Discord.Data.Embeds;

namespace DiscordChatExporter.Core.Discord.Data;

// https://discord.com/developers/docs/resources/message#message-snapshot-object
public partial record MessageSnapshot(Message Message)
{
    public static MessageSnapshot Parse(JsonElement json)
    {
        var messageJson = json.GetProperty("message");
        var message = Message.Parse(messageJson);

        return new MessageSnapshot(message);
    }
}
