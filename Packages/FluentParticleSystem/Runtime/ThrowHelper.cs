using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUCC.FluentParticleSystem
{
    internal static class ThrowHelper
    {
        public static void ThrowArgumentNullExceptionIfNull(object parameter, string paramName) {
            if (parameter is null)
                throw new ArgumentNullException(paramName);
        }
    }
}
