namespace Assets.Scripts.Util
{
    public static class Extensions
    {
        public static string ToFormat(this string s, params string[] p)
        {
            return string.Format(s, p);
        }
    }
}
