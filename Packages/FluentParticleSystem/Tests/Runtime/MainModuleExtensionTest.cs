using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OUCC.FluentParticleSystem.Test
{
    public class MainModuleExtensionTest
    {
        public void Test() {
            var main = new GameObject().AddComponent<ParticleSystem>().main;

        }
    }
}
