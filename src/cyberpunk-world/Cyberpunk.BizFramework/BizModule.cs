namespace Cyberpunk.BizFramework;

/// <summary>
/// 一个业务模块
/// </summary>
public interface IModule
{
    void BeforeInit();

    void Init();

    void AfterInit();

    void Update();
}

public interface ModuleManager
{
    void RegisterModule(IModule module);

    void UnregisterModule(IModule module);

    IModule FindModule(string name);

    void BeforeInit();

    void Init();

    void AfterInit();

    void Update();
}