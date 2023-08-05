using MythAndLegends.Data.Entity;

namespace StrangeStories.Services.Interface;

public interface ILegendService
{
    
    public void AddLegend(Legend legend);
    
    public Legend? GetLegendByCode(string code);
}