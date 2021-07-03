using System;
using Fork2Model.Enums;

namespace Fork2Common.Model.Exceptions
{
    public class ForkException : Exception
    {
        public ErrorMessage Message { get; }
        
        public ForkException(ErrorMessage message)
        {
            Message = message;
        }
    }
}