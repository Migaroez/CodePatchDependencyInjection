using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials.UmbracoDI.Core.Services
{
    public class ConfigurationSupplier : IConfigurationSupplier
    {
        public string DazzleString => "🥕";
        public string HostEmailAddress => "info@umbrace.be";
    }
}
