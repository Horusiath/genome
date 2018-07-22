#region copyright
// -----------------------------------------------------------------------
//  <copyright file="GenEmail.cs">
//      Copyright (C) 2018-2018 Bartosz Sypytkowski <b.sypytkowski@gmail.com>
//  </copyright>
// -----------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using Genome.Resources;

namespace Genome.Generators
{
    /// <summary>
    /// Domain names generator.
    /// </summary>
    public class GenDomain : GenAttribute, IGenFactory<string>
    {
        protected readonly string[] domains;
        protected readonly string[] extensions = Array.Empty<string>();

        public GenDomain()
        {
            this.extensions = ResourceManager.GetEmbeddedStringList($"Genome.Resources.TopLevelDomains.txt");
        }

        public GenDomain(string[] domains)
        {
            this.domains = domains;
        }

        public GenDomain(string[] domains, string[] extensions)
        {
            this.domains = domains;
            this.extensions = extensions;
        }

        public Gen<string> CreateGen()
        {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// Email generator.
    /// </summary>
    public sealed class GenEmail : GenAttribute, IGenFactory<string>
    {
        private readonly IGenFactory<string> firstNameGenerator;
        private readonly IGenFactory<string> lastNameGenerator;
        private readonly IGenFactory<string> domainGenerator;

        public GenEmail()
        {
            this.firstNameGenerator = new GenFirstName();
            this.lastNameGenerator = new GenLastName();
            this.domainGenerator = new GenDomain();
        }

        public GenEmail(params string[] availableDomains)
        {
            this.domainGenerator = new GenDomain(availableDomains);
        }

        public Gen<string> CreateGen()
        {
            return context => { throw new NotImplementedException(); };
        }
    }
}