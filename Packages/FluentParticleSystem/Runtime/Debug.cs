#if UNITY_2020_2_OR_NEWER
#nullable enable
#endif
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

using UDebug = UnityEngine.Debug;

namespace OUCC.FluentParticleSystem
{
    internal static class Debug
    {
        [Conditional("UNITY_ASSERTIONS")]
        internal static void Assert(
#if UNITY_2020_2_OR_NEWER
            [DoesNotReturnIf(false)]
#endif
        bool condition, string message)
        {
            UDebug.Assert(condition, message);
        }
    }
}
