using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Hospital
{
    internal static class DbConfig
    {
        private const string EnvFileName = ".env";

        public static string BuildConnectionString()
        {
            LoadEnvironmentFromEnvFile();

            string host = GetRequired("MYSQL_HOST");
            string port = GetRequired("MYSQL_PORT");
            string database = GetRequired("MYSQL_DATABASE");
            string user = GetRequired("MYSQL_USER");
            string password = GetRequired("MYSQL_PASSWORD");

            return $"server={host};port={port};user={user};database={database};password={password};";
        }

        private static void LoadEnvironmentFromEnvFile()
        {
            string? envPath = FindEnvFile();
            if (envPath is null)
            {
                return;
            }

            foreach (string rawLine in File.ReadAllLines(envPath))
            {
                string line = rawLine.Trim();
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#", StringComparison.Ordinal))
                {
                    continue;
                }

                int separatorIndex = line.IndexOf('=');
                if (separatorIndex <= 0)
                {
                    continue;
                }

                string key = line[..separatorIndex].Trim();
                string value = line[(separatorIndex + 1)..].Trim();

                if (value.Length >= 2 && value.StartsWith('"') && value.EndsWith('"'))
                {
                    value = value[1..^1];
                }

                if (string.IsNullOrEmpty(Environment.GetEnvironmentVariable(key)))
                {
                    Environment.SetEnvironmentVariable(key, value);
                }
            }
        }

        private static string? FindEnvFile()
        {
            var directories = new List<string>
            {
                Directory.GetCurrentDirectory(),
                AppContext.BaseDirectory
            };

            string? current = AppContext.BaseDirectory;
            for (int i = 0; i < 5 && current is not null; i++)
            {
                directories.Add(current);
                current = Directory.GetParent(current)?.FullName;
            }

            foreach (string directory in directories.Distinct(StringComparer.OrdinalIgnoreCase))
            {
                string candidate = Path.Combine(directory, EnvFileName);
                if (File.Exists(candidate))
                {
                    return candidate;
                }
            }

            return null;
        }

        private static string GetRequired(string key)
        {
            string? value = Environment.GetEnvironmentVariable(key);
            if (!string.IsNullOrWhiteSpace(value))
            {
                return value;
            }

            throw new InvalidOperationException($"Brakuje zmiennej środowiskowej {key}. Dodaj ją do pliku .env.");
        }
    }
}

