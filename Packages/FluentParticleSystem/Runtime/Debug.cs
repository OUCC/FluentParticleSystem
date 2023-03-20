#nullable enable
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

using UDebug = UnityEngine.Debug;

namespace OUCC.FluentParticleSystem
{
    internal static class Debug
    {
        [Conditional("UNITY_ASSERTIONS")]
        internal static void Assert([DoesNotReturnIf(false)] bool condition, string message)
        {
            UDebug.Assert(condition, message);
        }
    }
}
