﻿using Common.ECS.Contracts;
using Common.ECS.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.ECS.Contracts;
using Common.ECS.SystemEvents;
using Common.ECS.Components;

namespace Common.ECS.Systems
{
    public class MovementSystem : ISystem
    {
        public uint Priority { get; set; }

        private readonly ISystemContext SystemContext;
        private List<MovementNode> Targets;
        private List<PlayerNode> PlayerTargets;

        private IEventManager Events;

        public MovementSystem(ISystemContext systemContext)
        {
            SystemContext = systemContext;
            Events = SystemContext.Events;
            Targets = new List<MovementNode>();
            PlayerTargets = new List<PlayerNode>();

            Events.InputEvent += OnInputEvent;
            Events.EntityAddedEvent += OnEntityAddedEvent;
        }

        private void OnEntityAddedEvent(object sender, EntityAddedEventArgs args)
        {
            var target = args.Target;
            if (target.TryGetComponent(typeof(PositionComponent), out var position) &&
                target.TryGetComponent(typeof(VelocityComponent), out var velocity))
            {
                if (target.TryGetComponent(typeof(PlayerComponent), out var player))
                {
                    PlayerTargets.Add(new PlayerNode
                    {
                        Position = position as PositionComponent,
                        Velocity = velocity as VelocityComponent,
                        Player = player as PlayerComponent
                    });
                }
                else
                {
                    Targets.Add(new MovementNode
                    {
                        Position = position as PositionComponent,
                        Velocity = velocity as VelocityComponent
                    });
                }
            }
        }

        private void OnInputEvent(object sender, InputEventArgs e)
        {
            foreach(var target in PlayerTargets)
            {
                if(target.Player.Number == e.Player)
                {
                    target.Position.Y += (e.Input - 128);
                }
            }
        }

        public void Update()
        {
            
        }
    }
}