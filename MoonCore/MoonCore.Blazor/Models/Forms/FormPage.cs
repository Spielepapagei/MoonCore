﻿using Microsoft.AspNetCore.Components;

namespace MoonCore.Blazor.Models.Forms;

public class FormPage
{
    public string Name { get; set; } = "";
    public List<FormSection> Sections { get; set; } = new();
    public RenderFragment? CustomContent { get; set; }
}