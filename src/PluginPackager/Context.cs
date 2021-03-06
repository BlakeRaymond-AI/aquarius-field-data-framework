﻿using System.Collections.Generic;
using System.IO;
using FieldDataPluginFramework;

namespace PluginPackager
{
    public class Context
    {
        public string AssemblyFolder { get; set; }
        public string AssemblyPath { get; set; }
        public string OutputPath { get; set; }
        public string DeployedFolderName { get; set; }
        public string Description { get; set; }
        public string AssemblyQualifiedTypeName { get; set; }
        public bool Subfolders { get; set; } = true;
        public List<string> Include { get; } = new List<string> {"*.*"};
        public List<string> Exclude { get; } = new List<string> {$"{Path.GetFileName(typeof(IFieldDataPlugin).Assembly.GetName().Name)}.dll", "*.xml", "*.pdb"};
    }
}
