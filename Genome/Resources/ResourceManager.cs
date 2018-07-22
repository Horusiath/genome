#region copyright
// -----------------------------------------------------------------------
//  <copyright file="ResourceManager.cs">
//      Copyright (C) 2018-2018 Bartosz Sypytkowski <b.sypytkowski@gmail.com>
//  </copyright>
// -----------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Genome.Resources
{
    public static class ResourceManager
    {
        public static string[] GetEmbeddedStringList(string path)
        {
            var asm = typeof(ResourceManager).Assembly;
            var resources = asm.GetManifestResourceNames();
            if (!resources.Contains(path))
            {
                throw new ArgumentException($"Cannot find resource with path [{path}]. Available resources: [{string.Join(";", resources)}]");
            }

            var list = new List<string>();
            using (var stream = asm.GetManifestResourceStream(path))
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    var record = reader.ReadLine();
                    list.Add(record);
                }
            }

            return list.ToArray();
        }
    }
}