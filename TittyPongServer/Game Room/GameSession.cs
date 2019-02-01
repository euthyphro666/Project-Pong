using System;
using System.Threading;
using Common.Game_Data;
using Common.Messages;
using Microsoft.Xna.Framework;

namespace TittyPongServer.Game_Room
{
    public class GameSession
    {
        private readonly Events Events;
        private readonly Guid RoomId;
        private readonly Player ClientA;
        private readonly Player ClientB;
        private readonly Pong Nipple;

        private Timer GameTimer;
        private Thread GameThread;

        public GameSession(Events events, Guid roomId, string clientAId, string clientBId)
        {
            Events = events;
            RoomId = roomId;
            ClientA = new Player(clientAId) {PlayerClient = {Position = new Vector2(100, 100)}};
            ClientB = new Player(clientBId) {PlayerClient = {Position = new Vector2(1754, 100)}};
            Nipple = new Pong {Position = new Vector2(1920 / 2, 1080 / 2)};

            GameThread = new Thread(GameThreadStart);
            
        }

        private void GameThreadStart()
        {
            GameTimer = new Timer(Update);
            GameTimer.Change(17, 0);
        }

        public void Start()
        {
            GameThread.Start();
            Events.OnGuiLogMessageEvent($"Starting game for clients: {ClientA.PlayerId()} and {ClientB.PlayerId()}");
        }

        // The main game loop
        public void QueueInput(GameInputUpdate update)
        {
            if (update.ClientId == ClientA.PlayerId())
            {
                ClientA.QueueInput(update.Input);
            }
            else if (update.ClientId == ClientB.PlayerId())
            {
                ClientB.QueueInput(update.Input);
            }
        }

        // Reads input messages and applies transforms to client objects
        // Raises event to send positions to clients 60 times a second
        private void Update(object sender)
        {
                ClientA.Update();
                ClientB.Update();

            // send results
            var state = new GameState()
                {ClientA = ClientA.PlayerClient, ClientB = ClientB.PlayerClient, Nipple = Nipple};

            Events.OnUpdateClientsEvent(new UpdateClientsEventArgs() {RoomId = RoomId, State = state});
            GameTimer.Change(17, 0);

        }
    }
}