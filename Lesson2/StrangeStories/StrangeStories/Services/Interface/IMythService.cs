using MythAndLegends.Data.Entity;

namespace StrangeStories.Services.Interface;

public interface IMythService
{
    
    public void AddMyth(Myth myth);
    
    public Myth? GetMythByCode(string code);
}