using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials.UmbracoDI.Core.Services
{
    public class TextDazzler : ITextDazzler
    {
        private readonly IConfigurationSupplier _configurationSupplier;

        public TextDazzler(IConfigurationSupplier configurationSupplier)
        {
            _configurationSupplier = configurationSupplier;
        }

        public string Dazzle(string input)
        {
            var stringBuilder = new StringBuilder();
            // split up text into lines
            var lines = input.Split('\r');

            for (var index = 0; index < lines.Length; index++)
            {
                var line = lines[index];
                // start each line with 3 dazzles
                stringBuilder.Append(_configurationSupplier.DazzleString + _configurationSupplier.DazzleString +
                                     _configurationSupplier.DazzleString + " ");

                // put a dazzle in the center space
                var words = line.Split(' ');
                var left = words.Length / 2;
                for (int i = 0; i < left; i++)
                {
                    stringBuilder.Append(words[i] + " ");
                }

                stringBuilder.Append(_configurationSupplier.DazzleString + " ");

                for (int i = left + 1; i < words.Length; i++)
                {
                    stringBuilder.Append(words[i] + " ");
                }

                // end each line with a dazzle
                stringBuilder.Append(_configurationSupplier.DazzleString + _configurationSupplier.DazzleString +
                                     _configurationSupplier.DazzleString);

                if (index < lines.Length - 1)
                {
                    stringBuilder.AppendLine();
                }
            }

            return stringBuilder.ToString();
        }
    }
}
