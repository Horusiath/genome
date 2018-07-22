#region copyright
// -----------------------------------------------------------------------
//  <copyright file="NameGenerators.cs">
//      Copyright (C) 2018-2018 Bartosz Sypytkowski <b.sypytkowski@gmail.com>
//  </copyright>
// -----------------------------------------------------------------------
#endregion

using Genome.Resources;

namespace Genome.Generators
{
    /// <summary>
    /// Full name generator. Can optionally generate middle name as well.
    /// </summary>
    public class GenFullName : GenAttribute, IGenFactory<string>
    {
        public bool IncludeMidName { get; }

        public GenFullName(bool includeMidName = false) : this(CultureIso.EN, includeMidName)
        {
        }

        public GenFullName(CultureIso culture, bool includeMidName)
        {
            IncludeMidName = includeMidName;
        }

        public Gen<string> CreateGen()
        {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// Last name generator.
    /// </summary>
    public class GenLastName : GenAttribute, IGenFactory<string>
    {
        protected readonly string[] names;

        public GenLastName() : this(CultureIso.EN)
        {
        }

        public GenLastName(CultureIso culture)
        {
            names = ResourceManager.GetEmbeddedStringList($"Genome.Resources.LastName.{culture.ToString().ToLowerInvariant()}.txt");
        }

        public virtual Gen<string> CreateGen()
        {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// Female first name generator.
    /// </summary>
    public class GenFemaleName : GenFirstName, IGenFactory<string>
    {
        public override Gen<string> CreateGen()
        {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// Male first name generator.
    /// </summary>
    public class GenMaleName : GenFirstName, IGenFactory<string>
    {
        public override Gen<string> CreateGen()
        {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// First name generator.
    /// </summary>
    public class GenFirstName : GenAttribute, IGenFactory<string>
    {
        protected readonly string[] femaleNames;
        protected readonly string[] maleNames;

        public GenFirstName() : this(CultureIso.EN)
        {
        }

        public GenFirstName(CultureIso culture)
        {
            femaleNames = ResourceManager.GetEmbeddedStringList($"Genome.Resources.FirstName.Female.{culture.ToString().ToLowerInvariant()}.txt");
            maleNames = ResourceManager.GetEmbeddedStringList($"Genome.Resources.FirstName.Male.{culture.ToString().ToLowerInvariant()}.txt");
        }

        public virtual Gen<string> CreateGen()
        {
            throw new System.NotImplementedException();
        }
    }
}