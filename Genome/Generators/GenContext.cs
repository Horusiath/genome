#region copyright
// -----------------------------------------------------------------------
//  <copyright file="GenContext.cs">
//      Copyright (C) 2018-2018 Bartosz Sypytkowski <b.sypytkowski@gmail.com>
//  </copyright>
// -----------------------------------------------------------------------
#endregion

using System;
using Genome.Distributions;

namespace Genome.Generators
{
    public sealed class GenContext
    {
        /// <summary>
        /// An instance of a <see cref="IDistribution"/> that is used to generate pseudo-random values.
        /// </summary>
        public IDistribution Distribution { get; }

        /// <summary>
        /// Maximum number of samples to generate.
        /// </summary>
        public int MaxCount { get; }
    }
}