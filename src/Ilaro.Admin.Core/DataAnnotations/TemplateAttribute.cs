﻿using System;

namespace Ilaro.Admin.Core.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class TemplateAttribute : Attribute
    {
        public string DisplayTemplate { get; set; }

        public string EditorTemplate { get; set; }
    }
}