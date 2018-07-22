#region copyright
// -----------------------------------------------------------------------
//  <copyright file="SteppingDistribution.cs">
//      Copyright (C) 2018-2018 Bartosz Sypytkowski <b.sypytkowski@gmail.com>
//  </copyright>
// -----------------------------------------------------------------------
#endregion

namespace Genome.Distributions
{
    /// <summary>
    /// Distribution using linear steps.
    /// </summary>
    public class SteppingDistribution : IDistribution
    {
        public SteppingDistribution(int step)
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