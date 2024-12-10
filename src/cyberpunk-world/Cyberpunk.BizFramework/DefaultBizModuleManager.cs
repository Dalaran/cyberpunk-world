using Cyberpunk.BizFramework;

namespace Cyberpunk.BizFramework;

public class DefaultBizModuleManager : ModuleManager
{
    private readonly ConcurrentDictionary<string, IModule> name2Modules = new ConcurrentDictionary<string, IModule>();

    
}