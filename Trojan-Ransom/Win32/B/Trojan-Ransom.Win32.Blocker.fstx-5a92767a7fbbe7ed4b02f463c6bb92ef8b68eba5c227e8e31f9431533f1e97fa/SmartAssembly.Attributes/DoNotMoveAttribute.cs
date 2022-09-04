using System;

namespace SmartAssembly.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class DoNotMoveAttribute : Attribute
{
}
