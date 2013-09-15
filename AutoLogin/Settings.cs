﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLogin
{
    public class Settings
    {
        string ProgramFilesx86()
        {
            if (Environment.Is64BitOperatingSystem)
            {
                return Environment.GetEnvironmentVariable("ProgramFiles(x86)");
            }

            return Environment.GetEnvironmentVariable("ProgramFiles");
        }

        public string WowPath { get; set; }
        public bool HasPassword { get; set; }

        public Settings()
        {
            WowPath = ProgramFilesx86() + @"\World of Warcraft";
            HasPassword = false;
        }
    }
}
