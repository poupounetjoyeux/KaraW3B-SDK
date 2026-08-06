using System;

namespace KaraW3B.SDK.Helpers.Interfaces
{
    public interface ISongMedley
    {
        TimeSpan MedleyStart { get; }
        TimeSpan MedleyEnd { get; }
    }
}