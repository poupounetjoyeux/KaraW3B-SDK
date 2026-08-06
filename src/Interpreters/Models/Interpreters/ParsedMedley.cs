using System;
using KaraW3B.SDK.Helpers.Interfaces;

namespace KaraW3B.SDK.Interpreters.Models.Interpreters
{
    public sealed class ParsedMedley : ISongMedley
    {
        public TimeSpan MedleyStart { get; init; }

        public TimeSpan MedleyEnd { get; init; }
    }
}
