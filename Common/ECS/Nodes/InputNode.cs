﻿using Common.ECS.Components;
using Common.ECS.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ECS.Nodes
{
    public class InputNode : INode
    {
        public InputComponent Input { get; set; }
    }
}
