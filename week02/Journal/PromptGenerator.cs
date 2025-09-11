using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of your day?",
        "What are you grateful for today?",
        "Describe a challenge you faced recently and how you overcame it.",
        "What is a goal you have for the next month?",
        "Write about a memorable experience from your childhood.",
        "What is something new you learned today?",
        "Describe a person who has had a positive impact on your life.",
        "What is your favorite way to relax and unwind?",
        "Write about a place you would like to visit and why.",
        "What is something you are proud of accomplishing recently?"
    };

    public string GetRandomPrompt()
    {
        Random _random = new Random();
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}