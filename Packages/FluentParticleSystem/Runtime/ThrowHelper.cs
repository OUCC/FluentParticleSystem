using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OUCC.FluentParticleSystem
{
    internal static class ThrowHelper
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowArgumentNullExceptionIfNull(object parameter, string paramName) {
            if (parameter is null)
                ThrowArgumentNullException(paramName);
        }

        public static void ThrowArgumentNullException(string paramName) {
            throw new ArgumentNullException(paramName);
        }
    }
}
