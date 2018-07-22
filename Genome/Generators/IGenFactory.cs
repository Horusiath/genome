#region copyright
// -----------------------------------------------------------------------
//  <copyright file="IGenFactory.cs">
//      Copyright (C) 2018-2018 Bartosz Sypytkowski <b.sypytkowski@gmail.com>
//  </copyright>
// -----------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;

namespace Genome.Generators
{
    public delegate IEnumerable<T> Gen<out T>(GenContext context);
    
    public interface IGenFactory<out T>
    {
        Gen<T> CreateGen();
    }

    public static class GenExtensions
    {
        public static Gen<T> Combine<T>(params Gen<T>[] generators)
        {
            throw new NotImplementedException();
        }
    }
}