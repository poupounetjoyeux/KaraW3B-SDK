using KaraW3B.SDK.Helpers.Interfaces;

namespace KaraW3B.SDK.Helpers.Models.Analyzes
{
    public sealed class NoteAnalyzeError
    {
        public NoteAnalyzeError(string message, ISongNote note = null)
        {
            FileLine = note?.FileLine;
            Message = message;
        }

        public int? FileLine { get; }

        public string Message { get; }
    }
}