#region copyright
// -----------------------------------------------------------------------
//  <copyright file="IDistribution.cs">
//      Copyright (C) 2018-2018 Bartosz Sypytkowski <b.sypytkowski@gmail.com>
//  </copyright>
// -----------------------------------------------------------------------
#endregion

namespace Genome.Distributions
{
    public interface IDistribution
    {
        int GetInt32();
        long GetInt64();
        double GetDouble();
        void GetBytes(byte[] buffer);
    }
}