using System;

namespace HtmlAgilityPack;

[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
public sealed class SkipNodeNotFoundAttribute : Attribute
{
}
