﻿using MythAndLegends.Data;
using MythAndLegends.Data.Entity;
using StrangeStories.Services.Interface;

namespace MythAndLegends.Services;


public class CreatorService : IStoryService
{
    public void AddStory()
    {
        Console.WriteLine("Enter story type (myth/legend)");
        var input = Console.ReadLine();
        
        if (input == "legend")
        {
            Console.WriteLine("Enter name of the legend");
            var name = Console.ReadLine();
            Console.WriteLine("Enter object of the legend");
            var storyObject = Console.ReadLine();
            Console.WriteLine("Enter the story");
            var storyText = Console.ReadLine();

            var story = new Legend()
            {
                Name = name,
                Object = storyObject,
                Content = storyText
            };
            
            Storage.Legends.Add(story);
        }
        else if (input == "myth")
        {
            Console.WriteLine("Enter name of the myth");
            var name = Console.ReadLine();
            Console.WriteLine("Enter the story");
            var storyText = Console.ReadLine();
            Console.WriteLine("Enter some fact");
            var fact = Console.ReadLine();

            var story = new Myth()
            {
                Name = name,
                Fact = fact,
                Content = storyText
            };
            
            Storage.Myths.Add(story);
        }
        
        Console.WriteLine("Oops, wrong input");
    }
}