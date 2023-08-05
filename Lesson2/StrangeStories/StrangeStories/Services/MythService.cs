using MythAndLegends.Data;
using MythAndLegends.Data.Entity;
using StrangeStories.Services.Interface;

namespace MythAndLegends.Services;

public class MythService : BaseService, IMythService
{
    public void AddMyth(Myth myth)
    {
        if (string.IsNullOrEmpty(myth.StoryCode))
        {
            myth.StoryCode = CreateCode(myth.Name);
        }

        Storage.Myths.Add(myth);
    }
    public Myth? GetMythByCode(string code)
    {
        return Storage.Myths.FirstOrDefault(x => x.StoryCode.Equals(code));
    }

}