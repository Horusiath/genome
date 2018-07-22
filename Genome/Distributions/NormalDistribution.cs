#region copyright
// -----------------------------------------------------------------------
//  <copyright file="NormalDistribution.cs">
//      Copyright (C) 2018-2018 Bartosz Sypytkowski <b.sypytkowski@gmail.com>
//  </copyright>
// -----------------------------------------------------------------------
#endregion

namespace Genome.Distributions
{
    /// <summary>
    /// Distribution using normal curve.
    /// </summary>
    public class NormalDistribution : IDistribution
    {
        public NormalDistribution(int center = 0, int max = int.MaxValue)
        {

        }

        public int GetInt32()
        {
            throw new System.NotImplementedException();
        }

        public long GetInt64()
        {
            throw new System.NotImplementedException();
        }

        public double GetDouble()
        {
            throw new System.NotImplementedException();
        }

        public void GetBytes(byte[] buffer)
        {
            throw new System.NotImplementedException();
        }
    }
}