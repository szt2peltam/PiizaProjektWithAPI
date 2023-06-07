using System;
using System.Runtime.Serialization;

namespace PizzaProjekt.Exceptions
{
    [Serializable]
    internal class PasswordMustBeLongerThan5Char : Exception
    {
        public PasswordMustBeLongerThan5Char()
        {
        }

        public PasswordMustBeLongerThan5Char(string? message) : base(message)
        {
        }

        public PasswordMustBeLongerThan5Char(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected PasswordMustBeLongerThan5Char(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}