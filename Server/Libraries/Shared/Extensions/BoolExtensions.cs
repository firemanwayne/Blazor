namespace Shared.Extensions
{
    public static class BoolExtensions
    {
        public static string ToYesNoString(this bool e)
        {
            return e ? "Yes" : "No";
        }
    }
}
