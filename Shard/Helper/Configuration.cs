using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Shard.Helper
{
    public class Configuration
    {
        private static IConfiguration _configuration;

        public static string ServerName => _configuration.GetValue<string>(nameof(ServerName));
        public static string UserName => _configuration.GetValue<string>(nameof(UserName));

        public static string Password => _configuration.GetValue<string>(nameof(Password));

        public Configuration()
        {

        }
        public static void InitializeConfiguration()
        {
            if (_configuration == null)
            {
                ServiceCollection serviceCollection = new ServiceCollection();
                _configuration = new ConfigurationBuilder()
                       .SetBasePath(Directory.GetCurrentDirectory())
                       .AddJsonFile("appSettings.json").Build();
                serviceCollection.AddSingleton(_configuration);
                var provider = serviceCollection.BuildServiceProvider();
            }
        }

    }
}
