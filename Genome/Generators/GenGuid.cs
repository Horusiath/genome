#region copyright
// -----------------------------------------------------------------------
//  <copyright file="GenGuid.cs">
//      Copyright (C) 2018-2018 Bartosz Sypytkowski <b.sypytkowski@gmail.com>
//  </copyright>
// -----------------------------------------------------------------------
#endregion

using System;

namespace Genome.Generators
{
    public class GenGuid : GenAttribute, IGenFactory<Guid>
    {
        public Gen<Guid> CreateGen()
        {
            throw new NotImplementedException();
        }
    }
}