﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace GTerminalCore
{
    public class GVideoTerminal : VideoTerminal
    {
        public GVideoTerminal(IVTStream stream) : base(stream)
        {
        }

        public override VTTypeEnum Type
        {
            get
            {
                return VTTypeEnum.GVT;
            }
        }
    }
}