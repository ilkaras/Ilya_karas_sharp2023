using MythAndLegends.Data.Entity;

namespace StrangeStories.Services.Interface;

public interface IStoryService
{
    
    public void AddStory(Story story);

    public Story? GetStoryByCode(string code);
    
}