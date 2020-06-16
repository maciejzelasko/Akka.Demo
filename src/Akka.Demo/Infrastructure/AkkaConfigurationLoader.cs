﻿using System.IO;
using Akka.Configuration;

namespace Akka.Demo.Infrastructure
{
    public class AkkaConfigurationLoader
    {
        public static Config Load() => LoadConfig("akka.conf");

        private static Config LoadConfig(string configFile)
        {
            if (File.Exists(configFile))
            {
                string config = File.ReadAllText(configFile);
                return ConfigurationFactory.ParseString(config);
            }

            return Config.Empty;
        }
    }
}
