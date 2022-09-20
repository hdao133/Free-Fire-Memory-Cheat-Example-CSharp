using DiscordRPC;
using DiscordRPC.Logging;

namespace Xanax.config
{
    internal class Discord
    {
        public static DiscordRpcClient client;
        public static Timestamps rpctimestamp { get; set; }
        private static RichPresence presence;
        public static void InitializeRPC()
        {
            client = new DiscordRpcClient("983399117327851570");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();
            Button[] buttons = { new Button() { Label = "Discord", Url = "https://discord.gg/fF7XYtjE6w" }, new Button() { Label = "Instagram", Url = "https://www.instagram.com/suspect.client/" } };

            presence = new RichPresence()
            {
                Details = "Version Premium",

                Timestamps = rpctimestamp,
                Buttons = buttons,

                Assets = new Assets()
                {
                    LargeImageKey = "suspect",
                    LargeImageText = "@Suspect.Client",
                    SmallImageKey = "pknever",
                    SmallImageText = "PK NEVER#0672"
                }
            };
            SetState("");
        }
        public static void SetState(string state, bool watching = false)
        {
            if (watching)
                state = "Looking at " + state;

            presence.State = state;
            client.SetPresence(presence);
        }
    }
}
