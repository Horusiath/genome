#region copyright
// -----------------------------------------------------------------------
//  <copyright file="TimeGenerators.cs">
//      Copyright (C) 2018-2018 Bartosz Sypytkowski <b.sypytkowski@gmail.com>
//  </copyright>
// -----------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;

namespace Genome.Generators
{
    /// <summary>
    /// A <see cref="System.TimeSpan"/> generator - will always generate zero value, lower and upper bound.
    /// </summary>
    public class GenTimeSpan : GenAttribute, IGenFactory<TimeSpan>
    {
        public TimeSpan Default { get; }
        public TimeSpan Min { get; }
        public TimeSpan Max { get; }

        public GenTimeSpan(string min, string max)
        {
            Min = min == null ? TimeSpan.MinValue : TimeSpan.Parse(min);
            Max = max == null ? TimeSpan.MaxValue : TimeSpan.Parse(max);
        }

        public GenTimeSpan(TimeSpan? min = null, TimeSpan? max = null, TimeSpan? empty = null)
        {
            Min = min ?? TimeSpan.MinValue;
            Max = max ?? TimeSpan.MaxValue;
            Default = empty ?? TimeSpan.Zero;
        }

        public IEnumerable<TimeSpan> Generate(GenContext context)
        {
            yield return Default;
            yield return Min;
            yield return Max;

            var minTicks = Min.Ticks;
            var maxTicks = Max.Ticks;
            
            for (var i = 3; i < context.MaxCount; i++)
            {
                var ticks = context.Distribution.GetInt64();
                yield return new TimeSpan(ticks);
            }
        }

        public Gen<TimeSpan> CreateGen() => Generate;
    }
}