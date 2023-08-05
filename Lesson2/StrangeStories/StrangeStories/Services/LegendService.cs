using MythAndLegends.Data;
using MythAndLegends.Data.Entity;
using StrangeStories.Services.Interface;

namespace MythAndLegends.Services;

public class LegendService : BaseService, ILegendService
{
    public void AddLegend(Legend legend)
    {
        if (string.IsNullOrEmpty(legend.StoryCode))
        {
            legend.StoryCode = CreateCode(legend.Name);
        }
        
        Storage.Legends.Add(legend);
    }

    public Legend? GetLegendByCode(string code)
    {
        return Storage.Legends.FirstOrDefault(x => x.StoryCode.Equals(code));
    }

}