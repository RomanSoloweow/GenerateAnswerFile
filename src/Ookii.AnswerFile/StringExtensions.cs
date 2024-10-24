namespace Ookii.AnswerFile;

static class StringExtensions
{
    public static char? Last(this ReadOnlySpan<char> value)
        => value.Length == 0 ? null : value[value.Length - 1];
}
