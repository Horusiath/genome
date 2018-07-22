#region copyright
// -----------------------------------------------------------------------
//  <copyright file="RandomDistribution.cs">
//      Copyright (C) 2018-2018 Bartosz Sypytkowski <b.sypytkowski@gmail.com>
//  </copyright>
// -----------------------------------------------------------------------
#endregion

using System;

namespace Genome.Distributions
{
    /// <summary>
    /// Distribution using randomly generated values.
    /// </summary>
    public class RandomDistribution : IDistribution
    {
        protected readonly Random Random;

        public RandomDistribution()
        {
            Random = new Random();
        }

        public RandomDistribution(int seed)
        {
            Random = new Random(seed);
        }

        public int GetInt32() => Random.Next();

        public long GetInt64()
        {
            long hi = Random.Next() << 32;
            long lo = Random.Next();
            return hi | lo;
        }

        public double GetDouble() => Random.NextDouble();

        public void GetBytes(byte[] buffer)
        {
            Random.NextBytes(buffer);
        }
    }
}