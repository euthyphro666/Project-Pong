using System;
using Common;
using Common.Messages;

namespace TittyPongServer.Game_Room
{
    public class Room
    {
        private readonly Guid RoomId;
        private readonly GameSession Game;
        
        private string ClientAId;
        private string ClientBId;

        private bool ClientAConfirmed;
        private bool ClientBConfirmed;
        
        public Room(Events events, string clientAId, string clientBId)
        {
            ClientAId = clientAId;
            ClientBId = clientBId;
            ClientAConfirmed = ClientBConfirmed = false;
            RoomId = Guid.NewGuid();
            
            Game = new GameSession(events, RoomId, ClientAId, ClientBId);
        }

        public Guid GetRoomId()
        {
            return RoomId;
        }

        /// <summary>
        /// Receives messages from the server after it has routed them by the room Id
        /// </summary>
        /// <param name="msg"></param>
        public void HandleMessage(RoomMessage msg)
        {
            switch (msg.RoomMessageId)
            {
                case RoomMessageIds.RoomConfirmation:
                    var confirmation = msg.Contents.ToString().Deserialize<RoomConfirmation>();
                    if (confirmation.ClientMac == ClientAId)
                        ClientAConfirmed = true;
                    else if (confirmation.ClientMac == ClientBId)
                        ClientBConfirmed = true;

                    if (ClientAConfirmed && ClientBConfirmed)
                    {
                      // start game  
                      Game.Start();
                    } 
                    
                    break;
                case RoomMessageIds.GameInputUpdate:
                    var update = msg.Contents.ToString().Deserialize<GameInputUpdate>();
                    Game.QueueInput(update);
                    break;
            }
        }
    }
}