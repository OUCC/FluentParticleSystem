namespace OUCC.FluentParticleSystem.SourceGenerator
{
    internal static class StringEx
    {
#pragma warning disable IDE1006 // 命名スタイル
        public static string p2c(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            else if (str.Length < 1)
                return str.ToLower();

            return $"{char.ToLower(str[0])}{str[1..]}";
        }

        public static string c2p(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            else if (str.Length < 1)
                return str.ToUpper();

            return $"{char.ToUpper(str[0])}{str[1..]}";
        }
#pragma warning restore IDE1006 // 命名スタイル
    }
}
