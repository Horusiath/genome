#region copyright
// -----------------------------------------------------------------------
//  <copyright file="NumberGenerators.cs">
//      Copyright (C) 2018-2018 Bartosz Sypytkowski <b.sypytkowski@gmail.com>
//  </copyright>
// -----------------------------------------------------------------------
#endregion

namespace Genome.Generators
{
    public class GenInt : GenAttribute, IGenFactory<int>
    {
        public Gen<int> CreateGen()
        {
            throw new System.NotImplementedException();
        }
    }
}