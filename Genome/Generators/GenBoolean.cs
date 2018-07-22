#region copyright
// -----------------------------------------------------------------------
//  <copyright file="GenBoolean.cs">
//      Copyright (C) 2018-2018 Bartosz Sypytkowski <b.sypytkowski@gmail.com>
//  </copyright>
// -----------------------------------------------------------------------
#endregion

namespace Genome.Generators
{
    public class GenBoolean : GenAttribute, IGenFactory<bool>
    {
        public Gen<bool> CreateGen()
        {
            throw new System.NotImplementedException();
        }
    }
}