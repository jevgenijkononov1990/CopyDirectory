﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CopyDirectory.Libs.Models
{
    public class Folders
    {
        public string Source { get; private set; }
        public string Target { get; private set; }

        public Folders(string source, string target)
        {
            Source = source;
            Target = target;
        }
    }
}
