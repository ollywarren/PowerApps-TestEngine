using Microsoft.Extensions.Logging;
using Microsoft.PowerApps.TestEngine.Helpers;
using Microsoft.PowerApps.TestEngine.PowerApps.PowerFxModel;
using Microsoft.PowerFx;
using Microsoft.PowerFx.Types;

namespace Microsoft.PowerApps.TestEngine.PowerFx.Functions
{
    public class NavigateFunction : ReflectionFunction {
        protected readonly string _screenName;
        public NavigateFunction(string screenName) {
            _screenName = screenName;
        }
        
    }
}