﻿using Fork2Model.Enums;

namespace Fork2Model.Packages
{
    public abstract class AbstractPackage
    {
        public Command Command { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }

        protected AbstractPackage(string type)
        {
            Type = type;
        }
    }
}