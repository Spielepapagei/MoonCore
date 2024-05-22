﻿namespace MoonCoreUI.Attributes;

public class SectionAttribute : Attribute
{
    public string Name { get; set; }
    public string Icon { get; set; }
    
    public SectionAttribute(string name)
    {
        Name = name;
    }
}