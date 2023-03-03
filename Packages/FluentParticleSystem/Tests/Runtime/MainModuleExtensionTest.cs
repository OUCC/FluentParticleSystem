using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;


namespace OUCC.FluentParticleSystem.Test
{
    public class MainModuleExtensionTest
    {
        [TestCase(1f, 2f, 2f)]
        [TestCase(3f, 2f, 6f)]
        [TestCase(1.5f, 2f, 3f)]
        public void Duration(float setValue, float multiplyValue, float expected) {
            var ps = new GameObject().AddComponent<ParticleSystem>();

            var psResult = ps.SetMainDuration(setValue);
            Assert.That(psResult.main.duration, Is.EqualTo(setValue));
            Assert.That(psResult, Is.SameAs(ps));

            psResult = ps.SetMainDuration(d => d * multiplyValue);
            Assert.That(psResult.main.duration, Is.EqualTo(expected));
            Assert.That(psResult, Is.SameAs(ps));

            ps = new GameObject().AddComponent<ParticleSystem>();
            var main = ps.main;

            var result = main.SetDuration(setValue);
            Assert.That(result.duration, Is.EqualTo(setValue));
            Assert.That(result, Is.EqualTo(main));

            result = main.SetDuration(d => d * multiplyValue);
            Assert.That(result.duration, Is.EqualTo(expected));
            Assert.That(result, Is.EqualTo(main));
        }
    }
}
