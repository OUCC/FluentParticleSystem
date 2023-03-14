using System;
using System.Collections.Generic;

namespace OUCC.FluentParticleSystem.Generator
{
    internal class EqualityCompareSelecter<T, TKey> : IEqualityComparer<T>
    {
        private readonly Func<T, TKey> _selecter;

        internal EqualityCompareSelecter(Func<T, TKey> selecter)
        {
            _selecter = selecter;
        }

        public bool Equals(T x, T y)
        {
            var xtemp = _selecter(x);
            var ytemp = _selecter(y);
            if (xtemp == null && ytemp == null)
                return true;
            else if (xtemp == null && ytemp != null)
                return ytemp.Equals(xtemp);
            else
                return xtemp.Equals(ytemp);
        }

        public int GetHashCode(T obj)
        {
            var tobj = _selecter(obj);
            return tobj == null ? 0 : tobj.GetHashCode();
        }
    }

    internal static class EqualityCompareSelecter
    {
        internal static EqualityCompareSelecter<T, TKey> Create<T, TKey>(Func<T, TKey> selecter)
        {
            return new EqualityCompareSelecter<T, TKey>(selecter);
        }

        internal static IEqualityComparer<T> Create<T>(Func<T, string> selecter) => Create<T, string>(selecter);

        internal static IEqualityComparer<T> Create<T>(Func<T, int> selecter) => Create<T, int>(selecter);
    }
}
