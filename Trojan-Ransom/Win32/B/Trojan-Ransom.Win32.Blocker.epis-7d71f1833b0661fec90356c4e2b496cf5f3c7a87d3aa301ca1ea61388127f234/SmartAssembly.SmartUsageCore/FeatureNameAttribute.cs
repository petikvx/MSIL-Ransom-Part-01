using System;

namespace SmartAssembly.SmartUsageCore;

[AttributeUsage(AttributeTargets.Parameter)]
[DoNotObfuscate]
[DoNotPrune]
internal class FeatureNameAttribute : Attribute
{
}
