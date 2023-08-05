using StrangeStories.Services.Interface;

namespace MythAndLegends.Services;

public abstract class BaseService : IBaseService
{
    public string CreateCode(string name)
    {
        var code = $"{name.First()}{name.Last()}-{name.Length}";

        return code;
    }
}