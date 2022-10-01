using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artemis.Core.Modules;
using Artemis.Core.Services;
using Artemis.Plugins.Misc.DataModelExpansion.DataModels;
using Serilog;

namespace Artemis.Plugins.Misc.DataModelExpansion
{
    public class MiscDataModelExpansion : Module<MiscDataModel>
    {
        public override List<IModuleActivationRequirement> ActivationRequirements => null;

        public override void Disable()
        {
        }

        public override void Enable()
        {
        }

        public override void Update(double deltaTime)
        {
        }
    }
}
