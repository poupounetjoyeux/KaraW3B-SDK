using System.Collections.Generic;

namespace KaraW3B.SDK.Helpers
{
    public static class SongConstants
    {
        public const char EndOfFileMarker = 'E';
        public const char EndOfPhraseNoteType = '-';
        public const char DefaultNoteType = 'F';

        public static readonly HashSet<char> SupportedNoteTypes = new()
        {
            DefaultNoteType,
            'G',
            'R',
            '*',
            ':'
        };
    }
}
