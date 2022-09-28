using System;

namespace SmartAssembly.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public sealed class DoNotMoveAttribute : Attribute
{
}
