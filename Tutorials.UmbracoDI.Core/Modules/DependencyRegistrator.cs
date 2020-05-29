using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorials.UmbracoDI.Core.Services;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Services;
using Umbraco.Core.Services.Implement;

namespace Tutorials.UmbracoDI.Core.Modules
{
    // https://our.umbraco.com/documentation/reference/using-ioc/
    public class DependencyBootstrapper : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<ICommunicationService, CommunicationService>(Lifetime.Request);
        }
    }
}
