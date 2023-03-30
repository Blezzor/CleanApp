using System;

namespace CleanApp.Application.Common.Exceptions
{
    public class IsUsedException : Exception
    {

        public IsUsedException()
            : base()
        {
        }
        public IsUsedException(string message)
            : base(message)
        {
        }
        public IsUsedException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public IsUsedException(string name, object key)
            : base($"'{name}', '{key}' is being used.")
        {
        }
    }
}
