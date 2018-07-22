using System;

namespace Genome
{
    public abstract class GenomeAttribute : Attribute { }

    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
    public abstract class GenAttribute : GenomeAttribute
    {

    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class GenerateAttribute : GenomeAttribute
    {
        /// <summary>
        /// Seed used to supply random generator. Can be used to generate repeatable
        /// test cases. If not provided it will be generated automatically each time.
        /// </summary>
        public int? Seed { get; set; }

        /// <summary>
        /// Maximum number of test cases to generate.
        /// </summary>
        public int MaxCount { get; set; } = 100;
    }
}