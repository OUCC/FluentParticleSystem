//using System.Linq;
//using NUnit.Framework;
//using UnityEngine;
//using UnityEngine.TestTools.Utils;


//namespace OUCC.FluentParticleSystem.Test
//{
//    public class MainModuleExtensionTest
//    {
//        [TestCaseSource(nameof(GetFloatTestCase))]
//        public void Duration(float setValue, float multiplyValue, float expected) {
//            var ps = new GameObject().AddComponent<ParticleSystem>();
//            var comparer = FloatEqualityComparer.Instance;

//            var psResult = ps.SetMainDuration(setValue);
//            Assert.That(psResult.main.duration, Is.EqualTo(setValue).Using(comparer));
//            Assert.That(psResult, Is.SameAs(ps));

//            psResult = ps.SetMainDuration(d => d * multiplyValue);
//            Assert.That(psResult.main.duration, Is.EqualTo(expected).Using(comparer));
//            Assert.That(psResult, Is.SameAs(ps));

//            ps = new GameObject().AddComponent<ParticleSystem>();
//            var main = ps.main;

//            var result = main.SetDuration(setValue);
//            Assert.That(result.duration, Is.EqualTo(setValue).Using(comparer));
//            Assert.That(result, Is.EqualTo(main));

//            result = main.SetDuration(d => d * multiplyValue);
//            Assert.That(result.duration, Is.EqualTo(expected).Using(comparer));
//            Assert.That(result, Is.EqualTo(main));
//        }

//        public static float[][] GetFloatTestCase() {
//            return new (float setValue, float multiplyValue, float expected)[] {
//                (1f, 2f, 2f),
//                (3f, 2f, 6f),
//                (1.5f, 2f, 3f),
//            }.Select(p => new float[] {p.setValue, p.multiplyValue, p.expected})
//            .ToArray();
//        }
//    }
//}
