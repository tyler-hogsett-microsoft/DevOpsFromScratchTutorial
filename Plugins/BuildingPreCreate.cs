using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugins
{
    [CrmPluginRegistration(
        MessageNameEnum.Create,
        "cou_building",
        StageEnum.PreOperation,
        ExecutionModeEnum.Synchronous,
        "",
        "cou_building_precreate",
        1,
        IsolationModeEnum.Sandbox)]
    public class BuildingPreCreate : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            var tracer = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            tracer.Trace("Pre-create plugin");
        }
    }
}
