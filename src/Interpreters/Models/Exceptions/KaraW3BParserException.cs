using System;

namespace KaraW3B.SDK.Interpreters.Models.Exceptions
{
    public sealed class KaraW3BParserException : Exception
    {
        public KaraW3BParserException(string message) : base(message)
        {
        }
    }
}
