using SteamKit2;
using System.Collections.Generic;
using SteamTrade;

namespace SteamBot
{
    public class DogeUserHandler : UserHandler
    {
        public int ScrapPutUp;

        public DogeUserHandler (Bot bot, SteamID sid) : base(bot, sid) {}

        public override bool OnGroupAdd()
        {
            return false;
        }

        public override bool OnFriendAdd () 
        {
            return true;
        }

        public override void OnLoginCompleted()
        {
        }

        public override void OnChatRoomMessage(SteamID chatID, SteamID sender, string message)
        {
        }

        public override void OnFriendRemove () {}
        
        public override void OnMessage (string message, EChatEntryType type) 
        {
            Bot.SteamFriends.SendChatMessage(OtherSID, type, Bot.ChatResponse);
            if (message.StartsWith("+"))
            {
                string[] args = message.Split(' ');
                string command = args[0];

                switch (command)
                {
                    case "+help":
                        Bot.SteamFriends.SendChatMessage(OtherSID, type, "command stuff");
                        break;
                    case "+info":
                        Bot.SteamFriends.SendChatMessage(OtherSID, type, "info stuff goes here");
                        break;
                    case "+withdraw":
                        Bot.SteamFriends.SendChatMessage(OtherSID, type, "add transaction here");
                        break;
                    case "+tip":
                        Bot.SteamFriends.SendChatMessage(OtherSID, type, "movefromaccounts here");
                        break;
                    case "+accept":
                        Bot.SteamFriends.SendChatMessage(OtherSID, type, "create account here");
                        break;
                    case "+reject":
                        Bot.SteamFriends.SendChatMessage(OtherSID, type, "do nothing here");
                        break;
                    case "+register":
                        Bot.SteamFriends.SendChatMessage(OtherSID, type, "register here");
                        break;

                }

            }
        }

        public override bool OnTradeRequest() 
        {
            return false;
        }
        
        public override void OnTradeError (string error) 
        {
        }
        
        public override void OnTradeTimeout () 
        {
        }
        
        public override void OnTradeInit() 
        {
        }
        
        public override void OnTradeAddItem (Schema.Item schemaItem, Inventory.Item inventoryItem) {}
        
        public override void OnTradeRemoveItem (Schema.Item schemaItem, Inventory.Item inventoryItem) {}
        
        public override void OnTradeMessage (string message) {}
        
        public override void OnTradeReady (bool ready) 
        {
        }

        public override void OnTradeSuccess()
        {
        }

        public override void OnTradeAccept() 
        {
        }

        public bool Validate()
        {
            return false;
        }
        
    }
 
}

