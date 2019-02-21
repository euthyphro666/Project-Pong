﻿using Common.ECS.Contracts;
using Common.ECS.Nodes;
using Common.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ECS.Systems
{
    public class RenderSystem : ISystem
    {
        private readonly ISystemContext SystemContext;
        public List<RenderNode> Targets { get; set; }

        private readonly Screen Screen;
        private IEventManager Events;
        
        public RenderSystem(ISystemContext systemContext, Screen screen)
        {
            SystemContext = systemContext;
            Events = SystemContext.Events;
            Screen = screen;
        }

        public void Update()
        {
            Screen.Start();
            
            foreach(var target in Targets)
            {
                Screen.Render(
                    target.Display.Sprite, 
                    target.Position.X, 
                    target.Position.Y,
                    target.RigidBody.Width,
                    target.RigidBody.Height);
            }

            Screen.Stop();
        }
    }
}
