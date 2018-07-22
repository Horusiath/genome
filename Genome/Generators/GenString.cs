#region copyright
// -----------------------------------------------------------------------
//  <copyright file="GenString.cs">
//      Copyright (C) 2018-2018 Bartosz Sypytkowski <b.sypytkowski@gmail.com>
//  </copyright>
// -----------------------------------------------------------------------
#endregion

namespace Genome.Generators
{
    public class GenAnsiString : GenAttribute, IGenFactory<string>
    {
        public Gen<string> CreateGen()
        {
            throw new System.NotImplementedException();
        }
    }

    public class GenString : GenAttribute, IGenFactory<string>
    {
        public Gen<string> CreateGen()
        {
            throw new System.NotImplementedException();
        }
    }
}